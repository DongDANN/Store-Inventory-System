
Imports System.Data.SqlClient

Public Class MerchandiseEdit
    Dim con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True")

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

    End Sub

    Public Sub PopulateFields()
        Try
            con.Open()
            Dim query As String = "SELECT ProductName, Category, Price FROM dbo.Products WHERE ProductCode = @ProductCode"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ProductCode", productcode)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    txtProdName.Text = reader("ProductName").ToString()
                    txtCategory.Text = reader("Category").ToString()
                    txtPrice.Text = reader("Price").ToString()
                Else
                    MessageBox.Show("Product not found.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub MerchandiseEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()
        PopulateFields()
        txtProductCode.Text = productcode
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        If Not String.IsNullOrEmpty(txtProdName.Text) AndAlso
            Not String.IsNullOrEmpty(txtCategory.Text) AndAlso
            Not String.IsNullOrEmpty(txtPrice.Text) Then

            Try
                con.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM dbo.Products WHERE ProductCode=@ProductCode"
                cmd = New SqlCommand(checkQuery, con)
                cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text)
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                If AccountTypeLoggedIn = "Admin" Then
                    If count > 0 Then

                        Dim query As String = "UPDATE dbo.Products SET ProductCode=@ProductCode, ProductName=@ProductName, Category=@Category, Price=@Price WHERE ProductCode=@ProductCode"
                        cmd = New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text)
                        cmd.Parameters.AddWithValue("@ProductName", txtProdName.Text)
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text)
                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text)

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Successfully updated.")
                        data()
                        Me.Hide()
                    Else
                        MessageBox.Show("Select a product.")
                    End If
                ElseIf AccountTypeLoggedIn = "Staff" Then
                    EditPendingApproval()
                    Me.Hide()
                ElseIf AccountTypeLoggedIn = "" Then
                    Login.ShowDialog()
                End If

            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("All fields must be filled out.")
        End If
    End Sub
    Private Sub EditPendingApproval()
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
            cmd.Parameters.AddWithValue("@Request", "Edit")
            cmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text)
            cmd.Parameters.AddWithValue("@ProductName", txtProdName.Text)
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text)
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@RequestedBy", AccountName)
            cmd.Parameters.AddWithValue("@Date", DateTime.Now)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Added to pending approvals of admin.")
            data()
        Finally
        End Try
    End Sub

    Private Sub txtProdName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProdName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategory.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class