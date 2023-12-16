Imports System.Data.SqlClient

Public Class ProductsDashboard
    Public con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=YSSEAN;Integrated Security=True")

    Dim TotalProducts As Integer
    Dim LowStocks As Integer
    Dim NoStocks As Integer
    Private Sub data()
        Dim query As String = "SELECT * FROM dbo.Products WHERE Stocks < 5"
        cmd = New SqlCommand(query, con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        LowStocksDataGrid.DataSource = dt
    End Sub
    Private Sub LoadProductStatistics()
        Try
            con.Open()

            ' Total Products
            Using cmdTotal As New SqlCommand("SELECT COUNT(*) FROM dbo.Products", con)
                TotalProducts = Convert.ToInt32(cmdTotal.ExecuteScalar())
            End Using

            ' Low Stocks (below 5)
            Using cmdLowStocks As New SqlCommand("SELECT COUNT(*) FROM dbo.Products WHERE Stocks < 5", con)
                LowStocks = Convert.ToInt32(cmdLowStocks.ExecuteScalar())
            End Using

            ' No Stocks (null or 0)
            Using cmdNoStocks As New SqlCommand("SELECT COUNT(*) FROM dbo.Products WHERE (Stocks IS NULL OR Stocks = 0)", con)
                NoStocks = Convert.ToInt32(cmdNoStocks.ExecuteScalar())
            End Using
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DisplayAccountStatistics()

        txtTotalProduct.Text = TotalProducts.ToString()
        txtLowStocks.Text = LowStocks.ToString()
        txtNoStocks.Text = NoStocks.ToString()


        Me.Chart.Series("TOTAL NUMBER").Points.AddXY("TOTAL PRODUCTS", TotalProducts)
        Me.Chart.Series("TOTAL NUMBER").Points.AddXY("LOW STOCKS", LowStocks)
        Me.Chart.Series("TOTAL NUMBER").Points.AddXY("NO STOCKS", NoStocks)
    End Sub

    Private Sub ProductsDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductStatistics()
        DisplayAccountStatistics()
        data()
    End Sub

End Class