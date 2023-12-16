
Public Class AdminInterface

    Private currentChildForm As Form = Nothing


    Private Sub ShowSubMenu(SubMenu As Panel)
        If SubMenu.Visible = False Then
            SubMenu.Visible = True
        Else
            SubMenu.Visible = False
        End If
    End Sub

    Private Sub ShowChildForm(childForm As Form)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        currentChildForm.TopLevel = False
        currentChildForm.FormBorderStyle = FormBorderStyle.None
        currentChildForm.Dock = DockStyle.Fill

        PanelMain.Controls.Add(currentChildForm)
        PanelMain.Tag = currentChildForm

        currentChildForm.Show()
    End Sub

    Private Sub AdminInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogInAdmin.ShowDialog()
        btnStocksDashboard.PerformClick()
        btnDashboard.PerformClick()
        btnReports.PerformClick()
    End Sub

    Private Sub btnProductManagement_Click(sender As Object, e As EventArgs) Handles btnStocksDashboard.Click
        ShowChildForm(New ProductsDashboard())
    End Sub

    Private Sub btnAccountsDashboard_Click(sender As Object, e As EventArgs) Handles btnAccountsDashboard.Click
        ShowChildForm(New AccountsDashboard())
    End Sub

    Private Sub btnAccountManagement_Click(sender As Object, e As EventArgs) Handles btnAccountManagement.Click
        ShowChildForm(New AccountsManagement())
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowSubMenu(DashboardSubmenu)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPendingRequest.Click
        ShowChildForm(New PendingRequests())
    End Sub

    Private Sub btnLogOut_Click_1(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        loggedInUsername = ""
        AccountTypeLoggedIn = ""
        LogInAs.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnReports.Click
        ShowSubMenu(ReportsSubmenu)
    End Sub

    Private Sub btnAllProductsReport_Click(sender As Object, e As EventArgs) Handles btnAllProductsReport.Click
        ShowChildForm(New AllProductsReport())
    End Sub

    Private Sub btnStockInReport_Click(sender As Object, e As EventArgs) Handles btnStockInReport.Click
        ShowChildForm(New StockInReport())
    End Sub

    Private Sub btnStockOutReport_Click(sender As Object, e As EventArgs) Handles btnStockOutReport.Click
        ShowChildForm(New StockOutReport())
    End Sub
End Class