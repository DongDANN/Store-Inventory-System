Public Class StaffsInterface
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

    Private Sub btnManagements_Click(sender As Object, e As EventArgs) Handles btnManagements.Click
        ShowSubMenu(ManagementPanelSubMenu)
    End Sub

    Private Sub btnProductManagement_Click(sender As Object, e As EventArgs) Handles btnProductManagement.Click
        ShowChildForm(New ProductManagement())
    End Sub

    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        ShowChildForm(New ServiceManagement())
    End Sub

    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        ShowSubMenu(StocksPanelSubMenu)
    End Sub

    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        ProductManagement.Close()
        ShowChildForm(New StockIn())
    End Sub

    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        ShowChildForm(New StockOut())
    End Sub


    Private Sub btnAllProductsReport_Click(sender As Object, e As EventArgs)
        ShowChildForm(New AllProductsReport())
    End Sub

    Private Sub btnStockInReport_Click(sender As Object, e As EventArgs)
        ShowChildForm(New StockInReport())
    End Sub

    Private Sub btnStockOutReport_Click(sender As Object, e As EventArgs)
        ShowChildForm(New StockOutReport())
    End Sub

    Private Sub btnMyAccount_Click(sender As Object, e As EventArgs)
        ShowChildForm(New PendingRequests())
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        loggedInUsername = ""
        AccountTypeLoggedIn = ""
        LogInAs.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub StaffsInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnManagements.PerformClick()
        btnProductManagement.PerformClick()
        btnManagements.PerformClick()
    End Sub
End Class
