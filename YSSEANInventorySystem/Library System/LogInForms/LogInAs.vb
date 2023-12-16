Public Class LogInAs
    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Me.Hide()
        StaffsInterface.Show()

    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        AdminInterface.Show()
    End Sub
End Class