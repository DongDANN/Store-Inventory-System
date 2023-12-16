Imports System.Data.SqlClient
Public Class StockOutReport
    Public con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True")

    Dim cmd As SqlCommand
    Dim sd As SqlDataAdapter
    Dim dt As DataTable

    Private Sub data()
        Dim query As String = "SELECT * FROM dbo.StockOut_Transactions WHERE Date BETWEEN @FromDate AND @ToDate"
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@FromDate", DateTimePickerFrom.Value.Date)
        cmd.Parameters.AddWithValue("@ToDate", DateTimePickerTo.Value.Date.AddDays(1))
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        StockInDataGrid.DataSource = dt

        txtProdName.DataSource = dt
        txtProdName.DisplayMember = "TransactionNum"

        cmd = New SqlCommand("SELECT DISTINCT Category FROM dbo.StockOut_Transactions", con)
        sd = New SqlDataAdapter(cmd)
        Dim CategoryTable As New DataTable()
        sd.Fill(CategoryTable)
        txtCategory.DataSource = CategoryTable
        txtCategory.DisplayMember = "Category"
    End Sub
    Private Sub PendingRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()

        For Each col As DataGridViewColumn In StockInDataGrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        btnShowAllTransaction.PerformClick()

    End Sub

    Private Sub txtCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtCategory.SelectedIndexChanged

        Dim selectedCategory As String = txtCategory.Text
        Dim filteredProducts As DataView = New DataView(dt)
        filteredProducts.RowFilter = $"Category = '{selectedCategory}'"

        txtProdName.DataSource = filteredProducts
        txtProdName.DisplayMember = "TransactionNum"
    End Sub

    Private Sub txtProdName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProdName.SelectedIndexChanged
        Dim selectedProductName As String = txtProdName.Text
        Dim filteredRows() As DataRow = dt.Select($"TransactionNum = '{selectedProductName}'")

        Dim filteredDataTable As DataTable = dt.Clone()
        For Each row As DataRow In filteredRows
            filteredDataTable.ImportRow(row)
        Next

        StockInDataGrid.DataSource = filteredDataTable
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.StockInDataGrid.Width, Me.StockInDataGrid.Height)
        StockInDataGrid.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.StockInDataGrid.Width, Me.StockInDataGrid.Height))
        e.Graphics.DrawImage(imagebmp, 50, 0)
    End Sub

    Private Sub btnShowAllTransaction_Click(sender As Object, e As EventArgs) Handles btnShowAllTransaction.Click
        StockInDataGrid.DataSource = dt
    End Sub

    Private Sub DateTimePickerFrom_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFrom.ValueChanged
        data()
    End Sub

    Private Sub DateTimePickerTo_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerTo.ValueChanged
        data()
    End Sub
End Class