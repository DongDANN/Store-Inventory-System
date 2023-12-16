Imports System.Data.SqlClient

Public Class Services_Print
    Private connectionString As String = "Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True"
    Private Sub data()
        cmd = New SqlCommand("Select * from dbo.Products", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)

        cmd = New SqlCommand("SELECT DISTINCT Category FROM dbo.Products", con)
        sd = New SqlDataAdapter(cmd)
        Dim categoryTable As New DataTable()
        sd.Fill(categoryTable)

        Dim filteredRows() As DataRow = dt.Select("Category LIKE '%Printing Paper%'")
        Dim filteredTable As DataTable = dt.Clone()

        For Each row As DataRow In filteredRows
            filteredTable.ImportRow(row)
        Next

        txtProdName.DataSource = filteredTable
        txtProdName.DisplayMember = "ProductName"
    End Sub

    Private Sub Services_Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Using con As New SqlConnection(connectionString)
            If txtProdName.SelectedItem IsNot Nothing Then
                Dim selectedProduct As DataRowView = DirectCast(txtProdName.SelectedItem, DataRowView)
                Dim productName As String = selectedProduct("ProductName").ToString()

                Dim quantityToDeduct As Integer

                ' Check if the input is a valid integer
                If Integer.TryParse(txtQuantity.Text, quantityToDeduct) Then
                    ' Check if the quantity to deduct is higher than stocks
                    If quantityToDeduct > GetStocks(productName) Then
                        MessageBox.Show($"Cannot deduct more than available stocks for {productName}.")
                        Return
                    End If

                    ' Deduct stocks
                    DeductStocks(productName, quantityToDeduct)

                    MessageBox.Show($"Quantity deducted for {productName}.")
                Else
                    MessageBox.Show("Please enter a valid quantity.")
                End If
            Else
                MessageBox.Show("Please select a product.")
            End If
        End Using
    End Sub

    Private Function GetStocks(productName As String) As Integer
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()

                Dim query As String = "SELECT Stocks FROM Products WHERE ProductName = @ProductName"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ProductName", productName)
                Dim currentStocks As Integer = CInt(cmd.ExecuteScalar())

                Return currentStocks
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
                Return 0
            Finally
                con.Close()
            End Try
        End Using
    End Function

    Private Sub DeductStocks(productName As String, quantityToDeduct As Integer)
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()

                Dim query As String = "SELECT Stocks FROM Products WHERE ProductName = @ProductName"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ProductName", productName)
                Dim currentStocks As Integer = CInt(cmd.ExecuteScalar())

                Dim newStocks As Integer = Math.Max(currentStocks - quantityToDeduct, 0)

                query = "UPDATE Products SET Stocks = @NewStocks WHERE ProductName = @ProductName"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@NewStocks", newStocks)
                cmd.Parameters.AddWithValue("@ProductName", productName)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
