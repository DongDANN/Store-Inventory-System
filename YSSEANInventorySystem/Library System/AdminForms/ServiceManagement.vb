Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ServiceManagement
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Services_Print.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Services_Xerox.ShowDialog()
    End Sub

    Private Sub ServiceManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class