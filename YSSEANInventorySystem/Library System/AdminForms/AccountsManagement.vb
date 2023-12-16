Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class AccountsManagement
    Public con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True")
    Private Sub data()
        cmd = New SqlCommand("Select * from dbo.Accounts", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        AccountManagementDataGrid.DataSource = dt

        txtName.DataSource = dt
        txtName.DisplayMember = "Name"
    End Sub

    Private Sub HideSensitiveColumns()

        AccountManagementDataGrid.Columns("Password").Visible = False
        AccountManagementDataGrid.Columns("AccountID").Visible = False
    End Sub

    Private Function IsUsernameExists(username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM dbo.Accounts WHERE Username = @Username"

        Try
            con.Open()

            Using cmdCheckUsername As New SqlCommand(query, con)
                cmdCheckUsername.Parameters.AddWithValue("@Username", username)
                Dim count As Integer = Convert.ToInt32(cmdCheckUsername.ExecuteScalar())
                Return count > 0
            End Using
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPassword.Text = txtConfirmPassword.Text Then
            Try
                con.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM dbo.Accounts WHERE Name=@Name"
                cmd = New SqlCommand(checkQuery, con)
                cmd.Parameters.AddWithValue("@Name", txtName.Text)
                Dim count As Integer = CInt(cmd.ExecuteScalar())

                If count > 0 Then
                    Dim query As String = "UPDATE dbo.Accounts SET Username=@Username, Password=@Password, AccountType=@AccountType, Status=@Status WHERE Name=@Name"
                    cmd = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@AccountType", txtAccountType.Text)
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text)
                    cmd.Parameters.AddWithValue("@Name", txtName.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Successfully updated.")
                    data()
                Else
                    MessageBox.Show("Account with Name: " + txtName.Text + " does not exist.")
                End If
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Make sure the Passwords Matched.")
        End If
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If txtPassword.Text = txtConfirmPassword.Text Then
            If Not IsUsernameExists(txtUsername.Text) Then
                Try
                    con.Open()
                    Dim query As String = "INSERT INTO dbo.Accounts (Name, Username, Password, AccountType, Status) VALUES (@Name, @Username, @Password, @AccountType, @Status)"
                    cmd = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Name", txtName.Text)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@AccountType", txtAccountType.Text)
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Successfully added.")
                    data()
                Finally
                    con.Close()
                End Try
            Else
                MessageBox.Show("Username already exists. Please choose a different username.")
            End If
        Else
            MessageBox.Show("Make sure the Passwords Matched.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtName.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete and archive this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    con.Open()


                    Dim archiveQuery As String = "INSERT INTO dbo.Accounts_Archive (Name, Username, Password, AccountType, Status) " &
                                         "SELECT Name, Username, Password, AccountType, Status FROM dbo.Accounts WHERE Name=@Name"

                    cmd = New SqlCommand(archiveQuery, con)
                    cmd.Parameters.AddWithValue("@Name", txtName.Text)
                    cmd.ExecuteNonQuery()


                    Dim deleteQuery As String = "DELETE FROM dbo.Accounts WHERE Name=@Name"
                    cmd = New SqlCommand(deleteQuery, con)
                    cmd.Parameters.AddWithValue("@Name", txtName.Text)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Successfully Deleted and Archived.")
                    data()
                Finally
                    con.Close()
                End Try
            End If
        Else
            MessageBox.Show("Enter Name of the Account Above.")
        End If
    End Sub





    Private Sub txtName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtName.SelectedIndexChanged
        If txtName.SelectedIndex <> -1 Then
            Dim selectedRow As DataRow = dt.Rows(txtName.SelectedIndex)
            txtUsername.Text = selectedRow("Username").ToString()
            txtPassword.Text = selectedRow("Password").ToString()
            txtAccountType.Text = selectedRow("AccountType").ToString()
            txtStatus.Text = selectedRow("Status").ToString()
        End If
    End Sub

    Private Sub AccountsManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()
        HideSensitiveColumns()
        For Each col As DataGridViewColumn In AccountManagementDataGrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LibrarySystemDatabaseDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        con.Open()
        cmd = New SqlCommand("Select * from dbo.Accounts where Name='" + txtName.Text + "'", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        AccountManagementDataGrid.DataSource = dt
        con.Close()
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If txtName.Text.Length > 50 Then
            MessageBox.Show("Name cannot exceed 50 characters.")
            txtName.Text = txtName.Text.Substring(0, 50)
            txtName.SelectionStart = txtName.Text.Length
        End If
    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        Dim currentText As String = txtUsername.Text

        If currentText.Length > 20 Then
            MessageBox.Show("Username cannot exceed 20 characters.")
            txtUsername.Text = currentText.Substring(0, 20)
            txtUsername.SelectionStart = txtUsername.TextLength
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        Dim currentText As String = txtPassword.Text

        If currentText.Length > 20 Then
            MessageBox.Show("Password cannot exceed 20 characters.")
            txtPassword.Text = currentText.Substring(0, 20)
            txtPassword.SelectionStart = txtPassword.TextLength
        End If
    End Sub

    Private Sub txtConfirmPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmPassword.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        Dim currentText As String = txtConfirmPassword.Text

        If currentText.Length > 20 Then
            MessageBox.Show("Password cannot exceed 20 characters.")
            txtConfirmPassword.Text = currentText.Substring(0, 20)
            txtConfirmPassword.SelectionStart = txtConfirmPassword.TextLength
        End If

    End Sub

    Private Sub AccountManagementDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AccountManagementDataGrid.CellContentClick

    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub

    Private Sub btnEye_Click(sender As Object, e As EventArgs) Handles btnEye.Click
        If txtPassword.UseSystemPasswordChar Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnEye2_Click(sender As Object, e As EventArgs) Handles btnEye2.Click
        If txtConfirmPassword.UseSystemPasswordChar Then
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class