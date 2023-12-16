Imports System.Data.SqlClient

Public Class ProductManagement
    Dim con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True")

    Private Sub data()
        cmd = New SqlCommand("Select * from dbo.Products", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        ProductManagenentDataGrid.DataSource = dt

    End Sub
    Private Sub SetupDataGridView()
        ' Add "Edit" and "Delete" buttons to the DataGridView
        Dim editButtonColumn As New DataGridViewButtonColumn()
        editButtonColumn.Name = "Edit"
        editButtonColumn.Text = "Edit"
        editButtonColumn.UseColumnTextForButtonValue = True
        ProductManagenentDataGrid.Columns.Add(editButtonColumn)

        Dim deleteButtonColumn As New DataGridViewButtonColumn()
        deleteButtonColumn.Name = "Delete"
        deleteButtonColumn.Text = "Delete"
        deleteButtonColumn.UseColumnTextForButtonValue = True
        ProductManagenentDataGrid.Columns.Add(deleteButtonColumn)
    End Sub
    Private Sub ProductManagenentDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductManagenentDataGrid.CellContentClick
        If e.ColumnIndex = ProductManagenentDataGrid.Columns("Edit").Index Then
            MerchandiseEdit.ShowDialog()
        ElseIf e.ColumnIndex = ProductManagenentDataGrid.Columns("Delete").Index Then
            btnDelete_Click(sender, e)
        End If
    End Sub

    Private Sub PendingRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        data()
        SetupDataGridView()
        AddHandler ProductManagenentDataGrid.CellClick, AddressOf ProductManagenentDataGrid_CellClick

        For Each col As DataGridViewColumn In ProductManagenentDataGrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
        HideSensitiveColumns()
    End Sub
    Private Sub HideSensitiveColumns()
        ProductManagenentDataGrid.Columns("ProductID").Visible = False
        ProductManagenentDataGrid.Columns("Stocks").Visible = False
    End Sub


    Private Sub ProductManagenentDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductManagenentDataGrid.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dt.Rows.Count Then
            productcode = dt.Rows(e.RowIndex)("ProductCode").ToString()

            txtProductCode.Text = productcode
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        MerchandiseNew.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtProductCode.Text = "" Then
            MessageBox.Show("Select a product.")
        Else
            MerchandiseEdit.ShowDialog()
        End If

    End Sub

    Private Sub btnShowAllProducts_Click(sender As Object, e As EventArgs) Handles btnShowAllProducts.Click
        data()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtProductCode.Text <> "" Then
            If AccountTypeLoggedIn = "Admin" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete and archive this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Try
                        con.Open()

                        Dim archiveQuery As String = "INSERT INTO dbo.Products_Archive (ProductID, ProductCode, Category, ProductName, Price) " &
                                            "VALUES (@ProductID, @ProductCode, @Category, @ProductName, @Price)"
                        cmd = New SqlCommand(archiveQuery, con)
                        cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text)
                        cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text)
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text)
                        cmd.Parameters.AddWithValue("@ProductName", txtProdName.Text)
                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text)

                        cmd.ExecuteNonQuery()

                        Dim deleteQuery As String = "DELETE FROM dbo.Products WHERE ProductID=@ProductID"
                        cmd = New SqlCommand(deleteQuery, con)
                        cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text)
                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Successfully Deleted and Archived.")
                    Finally
                        con.Close()
                    End Try
                End If
            ElseIf AccountTypeLoggedIn = "Staff" Then
                con.Open()
                DeletePendingApproval()
            ElseIf AccountTypeLoggedIn = "" Then
                Login.Show()
            End If
            con.Close()
        End If
    End Sub

    Private Sub DeletePendingApproval()
        Try
            Dim AccountName As String = String.Empty

            Dim accountQuery As String = "SELECT Name FROM dbo.Accounts WHERE Username = @Username"
            Using accountCmd As New SqlCommand(accountQuery, con)
                accountCmd.Parameters.AddWithValue("@Username", loggedInUsername)

                Using myRead As SqlDataReader = accountCmd.ExecuteReader()
                    If myRead.Read() Then
                        AccountName = myRead("Name").ToString()
                    End If
                End Using
            End Using

            Dim query As String = "INSERT INTO dbo.Pending_Approval (Request, ProductID, ProductCode, ProductName, Category, Price, RequestedBy, Date) VALUES (@Request,@ProductID, @ProductCode, @ProductName, @Category, @Price, @RequestedBy, @Date)"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Request", "Delete")
            cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text)
            cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text)
            cmd.Parameters.AddWithValue("@ProductName", txtProdName.Text)
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text)
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@RequestedBy", AccountName)
            cmd.Parameters.AddWithValue("@Date", DateTime.Now)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Added to pending approvals of admin.")
        Catch Ex As Exception
            MessageBox.Show("There is an existing request for item: " + txtProdName.Text)
        Finally
            con.Close()
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
End Class