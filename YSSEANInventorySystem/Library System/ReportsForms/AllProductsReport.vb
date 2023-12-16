Imports System.Data.SqlClient
Public Class AllProductsReport
    Public con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True")
    Private Sub data()
        cmd = New SqlCommand("Select * from dbo.Products", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        AllProductsDataGrid.DataSource = dt

        txtProdName.DataSource = dt
        txtProdName.DisplayMember = "ProductName"

        cmd = New SqlCommand("SELECT DISTINCT Category FROM dbo.Products", con)
        sd = New SqlDataAdapter(cmd)
        Dim CategoryTable As New DataTable()
        sd.Fill(CategoryTable)
        txtCategory.DataSource = CategoryTable
        txtCategory.DisplayMember = "Category"
    End Sub

    Private Sub PendingRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()

        For Each col As DataGridViewColumn In AllProductsDataGrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        btnShowAllProducts.PerformClick()

        HideSensitiveColumns()
    End Sub
    Private Sub HideSensitiveColumns()
        AllProductsDataGrid.Columns("ProductID").Visible = False
    End Sub

    Private Sub txtCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtCategory.SelectedIndexChanged

        Dim selectedCategory As String = txtCategory.Text
        Dim filteredProducts As DataView = New DataView(dt)
        filteredProducts.RowFilter = $"Category = '{selectedCategory}'"

        txtProdName.DataSource = filteredProducts
        txtProdName.DisplayMember = "ProductName"
    End Sub

    Private Sub txtProdName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProdName.SelectedIndexChanged
        Dim selectedProductName As String = txtProdName.Text
        Dim filteredRows() As DataRow = dt.Select($"ProductName = '{selectedProductName}'")

        Dim filteredDataTable As DataTable = dt.Clone()
        For Each row As DataRow In filteredRows
            filteredDataTable.ImportRow(row)
        Next

        AllProductsDataGrid.DataSource = filteredDataTable
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.AllProductsDataGrid.Width, Me.AllProductsDataGrid.Height)
        AllProductsDataGrid.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.AllProductsDataGrid.Width, Me.AllProductsDataGrid.Height))
        e.Graphics.DrawImage(imagebmp, 50, 0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnShowAllProducts.Click
        AllProductsDataGrid.DataSource = dt
    End Sub
End Class