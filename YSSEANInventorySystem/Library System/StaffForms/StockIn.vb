Imports System.Data.SqlClient
Public Class StockIn
    Private connectionString As String = "Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True"

    Private Sub data()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                cmd = New SqlCommand("Select * from dbo.Products", con)
                sd = New SqlDataAdapter(cmd)
                dt = New DataTable()
                sd.Fill(dt)

                StockInDataGrid.DataSource = dt
                getData()
                AutoID()
                BindStockInDataGrid()
            End Using
        Finally
        End Try
    End Sub

    Private Sub BindStockInDataGrid()
        StockInDataGrid.DataSource = dt
    End Sub

    Private Sub PendingRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()

        For Each col As DataGridViewColumn In StockInDataGrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        btnShowAllProducts.PerformClick()
        HideSensitiveColumns()
    End Sub
    Private Sub HideSensitiveColumns()
        StockInDataGrid.Columns("ProductID").Visible = False
    End Sub

    Private Sub ProductManagenentDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StockInDataGrid.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dt.Rows.Count Then
            productcode = dt.Rows(e.RowIndex)("ProductCode").ToString()

            txtProductCode.Text = productcode
        End If
    End Sub

    Private Sub btnShowAllProducts_Click(sender As Object, e As EventArgs) Handles btnShowAllProducts.Click
        StockInDataGrid.DataSource = dt
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchKeyword As String = txtSearch.Text.Trim()
        If Not String.IsNullOrEmpty(searchKeyword) Then
            Dim filteredRows() As DataRow = dt.Select($"Category LIKE '%{searchKeyword}%' OR ProductCode LIKE '%{searchKeyword}%' OR ProductName LIKE '%{searchKeyword}%'")
            Dim filteredTable As DataTable = dt.Clone()
            For Each row As DataRow In filteredRows
                filteredTable.ImportRow(row)
            Next
            StockInDataGrid.DataSource = filteredTable
        Else
            StockInDataGrid.DataSource = dt
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Dim price As Decimal
        Dim quantity As Integer

        If Decimal.TryParse(txtPrice.Text, price) AndAlso Integer.TryParse(txtQuantity.Text, quantity) Then

            Dim stockedInPrice As Decimal = price * quantity
            txtTotalPrice.Text = stockedInPrice.ToString("0.00")
        Else

            txtTotalPrice.Text = ""
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If Not String.IsNullOrEmpty(txtProductCode.Text) AndAlso IsNumeric(txtQuantity.Text) Then
            Try
                Using con As New SqlConnection(connectionString)
                    con.Open()

                    Dim existingStockQuantity As Integer = GetExistingStockQuantity(txtProductCode.Text)
                    Dim newStockQuantity As Integer = existingStockQuantity + CInt(txtQuantity.Text)
                    UpdateStockQuantity(txtProductCode.Text, newStockQuantity)

                    Transaction()

                    MessageBox.Show("Stock updated successfully.")
                    txtQuantity.Text = ""
                    data()
                End Using
            Finally
            End Try
        Else
            MessageBox.Show("Please enter a valid Product ID and Quantity.")
        End If
    End Sub




    Private Function GetExistingStockQuantity(ProductCode As String) As Integer
        Dim existingStockQuantity As Integer = 0

        Try
            Using con As New SqlConnection(connectionString)
                If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim query As String = "SELECT Stocks FROM Products WHERE ProductCode = @ProductCode"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@ProductCode", ProductCode)

            Dim result As Object = cmd.ExecuteScalar()

                If result IsNot DBNull.Value Then
                    existingStockQuantity = Convert.ToInt32(result)
                End If
            End Using
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        Return existingStockQuantity
    End Function


    Private Sub UpdateStockQuantity(ProductCode As String, newStockQuantity As Integer)
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

            Dim query As String = "UPDATE Products SET Stocks = @NewStockQuantity WHERE ProductCode = @ProductCode"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@NewStockQuantity", newStockQuantity)
            cmd.Parameters.AddWithValue("@ProductCode", ProductCode)

                cmd.ExecuteNonQuery()
            End Using
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub txtProductCode_TextChanged(sender As Object, e As EventArgs) Handles txtProductCode.TextChanged
        Dim matchingRows() As DataRow = dt.Select("ProductCode = '" & txtProductCode.Text & "'")

        If matchingRows.Length > 0 Then
            Dim selectedRow As DataRow = matchingRows(0)
            txtProductID.Text = selectedRow("ProductID").ToString()
            txtProdName.Text = selectedRow("ProductName").ToString()
            txtCategory.Text = selectedRow("Category").ToString()
            txtPrice.Text = selectedRow("Price").ToString()
        Else
        End If
    End Sub

    Sub getData()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()

                cmd1 = New SqlCommand("Select * from dbo.StockIn_Transactions", con)
                sd1 = New SqlDataAdapter(cmd1)
                dt1 = New DataTable()
                Dim ds1 As New DataSet
                sd1.Fill(ds1)
                StockInDataGrid.DataSource = ds1.Tables(0)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End Using
    End Sub


    Sub AutoID()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
            cmd1 = New SqlCommand("SELECT TOP 1 TransactionID, TransactionNum FROM dbo.StockIn_Transactions ORDER BY TransactionID DESC", con)
            sd1 = New SqlDataAdapter(cmd1)
            Dim ds As New DataSet
            sd1.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    Dim TransactionNum As String = ds.Tables(0).Rows(0)("TransactionNum").ToString()

                    If TransactionNum.Length >= 9 Then
                        Dim tmp_id = TransactionNum.Substring(2, 7)
                        Dim new_id As Integer = CInt(tmp_id) + 1
                        txtTransactionNum.Text = "TR" & new_id.ToString("0000000")
                    Else
                        txtTransactionNum.Text = "TR0000001"
                    End If
                Else
                    txtTransactionNum.Text = "TR0000001"
                End If
            End Using
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Sub Transaction()
        Try
            Using con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True")
                con.Open()

                Dim archiveQuery As String = "INSERT INTO dbo.StockIn_Transactions (TransactionNum, ProductCode, Category, ProductName, Quantity, Price, Date) " &
                    "VALUES (@TransactionNum, @ProductCode, @Category, @ProductName, @Quantity, @Price, @Date)"
                cmd = New SqlCommand(archiveQuery, con)
                cmd.Parameters.AddWithValue("@TransactionNum", txtTransactionNum.Text)
                cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text)
                cmd.Parameters.AddWithValue("@Category", txtCategory.Text)
                cmd.Parameters.AddWithValue("@ProductName", txtProdName.Text)
                cmd.Parameters.AddWithValue("@Quantity", CInt(txtQuantity.Text))
                cmd.Parameters.AddWithValue("@Price", txtTotalPrice.Text)
                cmd.Parameters.AddWithValue("@Date", DateTime.Now)

                cmd.ExecuteNonQuery()
            End Using
        Finally
        End Try
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
