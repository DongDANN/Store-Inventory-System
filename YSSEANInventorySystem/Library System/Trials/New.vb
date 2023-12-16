Imports System.Data.SqlClient

Public Class MerchandiseNew
    Dim con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True")
    Private connectionString As String = "Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True"

    Private Sub data()
        cmd = New SqlCommand("Select * from dbo.Products", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)

        cmd = New SqlCommand("SELECT DISTINCT Category FROM dbo.Products", con)
        sd = New SqlDataAdapter(cmd)
        Dim CategoryTable As New DataTable()
        sd.Fill(CategoryTable)
        txtCategory.DataSource = CategoryTable
        txtCategory.DisplayMember = "Category"

        getData()
        AutoID()
    End Sub
    Private Sub PendingRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()
        txtPrice.Text = ""
        txtProdName.Text = ""
    End Sub

    Sub getData()
        Using con As New SqlConnection(connectionString)
            Try
                con.Open()
                cmd = New SqlCommand("Select * from dbo.Products", con)
                sd = New SqlDataAdapter(cmd)
                dt = New DataTable()
                Dim ds As New DataSet
                sd.Fill(ds)
                ProductManagenentDataGrid.DataSource = ds.Tables(0)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub


    Sub AutoID()
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Check if there is an existing product code in Pending_Approval with "New" request
                Dim pendingQuery As String = "SELECT TOP 1 ProductCode FROM dbo.Pending_Approval WHERE Request = 'New' ORDER BY ProductCode DESC"
                cmd = New SqlCommand(pendingQuery, con)
                Dim pendingProductCode As Object = cmd.ExecuteScalar()

                If pendingProductCode IsNot Nothing AndAlso Not DBNull.Value.Equals(pendingProductCode) Then
                    ' If there is, increment it
                    Dim highestPendingProductCode As String = pendingProductCode.ToString()
                    Dim tmp_id As Integer = CInt(highestPendingProductCode.Substring(2))
                    Dim new_id As Integer = tmp_id + 1
                    txtProductCode.Text = "PR" & new_id.ToString("0000000")
                Else
                    ' If none in Pending_Approval, get the highest product code from the Products table
                    Dim productsQuery As String = "SELECT TOP 1 ProductCode FROM dbo.Products ORDER BY ProductCode DESC"
                    cmd = New SqlCommand(productsQuery, con)
                    Dim productsProductCode As Object = cmd.ExecuteScalar()

                    If productsProductCode IsNot Nothing AndAlso Not DBNull.Value.Equals(productsProductCode) Then
                        ' If there is, increment it
                        Dim highestProductsProductCode As String = productsProductCode.ToString()
                        Dim tmp_id As Integer = CInt(highestProductsProductCode.Substring(2))
                        Dim new_id As Integer = tmp_id + 1
                        txtProductCode.Text = "PR" & new_id.ToString("0000000")
                    Else
                        ' If none in both tables, use the default PR0000001
                        txtProductCode.Text = "PR0000001"
                    End If
                End If

            End Using
        Finally
            con.Close()
        End Try
    End Sub


    Private Function IsProductExists(productName As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM dbo.Products WHERE ProductName = @ProductName"
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@ProductName", productName)

        Dim count As Integer = CInt(cmd.ExecuteScalar())
        Return count > 0
    End Function


    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        If Not String.IsNullOrEmpty(txtProdName.Text) AndAlso
        Not String.IsNullOrEmpty(txtCategory.Text) AndAlso
        Not String.IsNullOrEmpty(txtPrice.Text) Then

            Try
                con.Open()

                If AccountTypeLoggedIn = "Admin" Then
                    If Not IsProductExists(txtProdName.Text) Then
                        Dim query As String = "INSERT INTO dbo.Products (ProductCode, ProductName, Category, Price) VALUES (@ProductCode, @ProductName, @Category, @Price)"
                        cmd = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text)
                        cmd.Parameters.AddWithValue("@ProductName", txtProdName.Text)
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text)
                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text)

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Successfully added.")
                        data()
                        Me.Hide()
                    Else
                        MessageBox.Show("Product already exists or there is a pending 'New' request. Please choose a different Product.")
                    End If
                ElseIf AccountTypeLoggedIn = "Staff" Then
                    InsertPendingApproval()
                    Me.Hide()
                ElseIf AccountTypeLoggedIn = "" Then
                    Login.ShowDialog()
                End If
            Finally
                con.Close()
            End Try

        Else
            MessageBox.Show("Fields cannot be empty.")
        End If
    End Sub


    Private Sub InsertPendingApproval()
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

            Dim query As String = "INSERT INTO dbo.Pending_Approval (Request, ProductCode, ProductName, Category, Price, RequestedBy, Date) VALUES (@Request, @ProductCode, @ProductName, @Category, @Price, @RequestedBy, @Date)"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Request", "New")
            cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text)
            cmd.Parameters.AddWithValue("@ProductName", txtProdName.Text)
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text)
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@RequestedBy", AccountName)
            cmd.Parameters.AddWithValue("@Date", DateTime.Now)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Added to pending approvals of admin.")
            data()
        Catch Ex As Exception
            MessageBox.Show("There is an existing request, contact the admin.")
        End Try
    End Sub

    Private Sub txtCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategory.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtProdName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProdName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

End Class