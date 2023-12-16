Imports System.Data.SqlClient

Public Class SplashArt

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        pnlLoading.Width += 3

        If pnlLoading.Width >= 699 Then
            Timer.Stop()
            Me.Hide()
            LogInAs.Show()
        End If
    End Sub

    Private Sub pnlBar_Paint(sender As Object, e As PaintEventArgs) Handles pnlBar.Paint

    End Sub
End Class
