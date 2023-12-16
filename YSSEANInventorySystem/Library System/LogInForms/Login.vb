Imports System.Data.SqlClient

Public Class Login
    Private connectionString As String = "Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True"
    Private Sub UpdateLastLoginDateTime(con As SqlConnection, username As String)
        Try
            Dim loginDateTime As DateTime = DateTime.Now

            Dim updateLoginQuery As String = "UPDATE dbo.Accounts SET LastLoginDateTime = @LastLoginDateTime WHERE Username = @Username"

            Using cmdUpdate As New SqlCommand(updateLoginQuery, con)
                cmdUpdate.Parameters.AddWithValue("@LastLoginDateTime", loginDateTime)
                cmdUpdate.Parameters.AddWithValue("@Username", username)
                cmdUpdate.ExecuteNonQuery()
            End Using
        Finally
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Try

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "SELECT * FROM dbo.Accounts WHERE Username = @Username AND Password = @Password"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

                    Dim myread As SqlDataReader = cmd.ExecuteReader()

                    If myread.Read() Then
                        Dim accountType As String = myread("AccountType").ToString()
                        Dim accountStatus As String = myread("Status").ToString()

                        If String.Equals(accountStatus, "Active", StringComparison.OrdinalIgnoreCase) Then
                            If String.Equals(accountType, "Admin", StringComparison.Ordinal) OrElse
                           String.Equals(accountType, "Staff", StringComparison.Ordinal) Then

                                Dim username As String = myread("Username").ToString()
                                myread.Close()

                                UpdateLastLoginDateTime(con, username)
                                loggedInUsername = username

                                If String.Equals(accountType, "Admin", StringComparison.Ordinal) Then
                                    Me.Hide()
                                    AccountTypeLoggedIn = "Admin"
                                ElseIf String.Equals(accountType, "Staff", StringComparison.Ordinal) Then
                                    Me.Hide()
                                    AccountTypeLoggedIn = "Staff"
                                End If

                                txtUsername.Text = ""
                                txtPassword.Text = ""

                            End If
                        Else
                            MsgBox("Account is disabled.")
                            txtUsername.Text = ""
                            txtPassword.Text = ""
                        End If
                    Else
                        MsgBox("Invalid Username or Password")
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                    End If
                End Using
            End Using
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnEye_Click(sender As Object, e As EventArgs) Handles btnEye.Click
        If txtPassword.UseSystemPasswordChar Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
