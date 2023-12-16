<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNoStocks = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlBorrowers = New System.Windows.Forms.Panel()
        Me.txtLowStocks = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LowStocksDataGrid = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlTotalBooks = New System.Windows.Forms.Panel()
        Me.txtTotalProduct = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.pnlBorrowers.SuspendLayout()
        CType(Me.LowStocksDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalBooks.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(59, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "NO STOCKS:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtNoStocks)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(513, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 119
        '
        'txtNoStocks
        '
        Me.txtNoStocks.AutoSize = True
        Me.txtNoStocks.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoStocks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtNoStocks.Location = New System.Drawing.Point(85, 37)
        Me.txtNoStocks.Name = "txtNoStocks"
        Me.txtNoStocks.Size = New System.Drawing.Size(42, 46)
        Me.txtNoStocks.TabIndex = 25
        Me.txtNoStocks.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(54, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "LOW STOCKS:"
        '
        'pnlBorrowers
        '
        Me.pnlBorrowers.BackColor = System.Drawing.Color.White
        Me.pnlBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBorrowers.Controls.Add(Me.txtLowStocks)
        Me.pnlBorrowers.Controls.Add(Me.Label8)
        Me.pnlBorrowers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.pnlBorrowers.Location = New System.Drawing.Point(307, 62)
        Me.pnlBorrowers.Name = "pnlBorrowers"
        Me.pnlBorrowers.Size = New System.Drawing.Size(200, 100)
        Me.pnlBorrowers.TabIndex = 120
        '
        'txtLowStocks
        '
        Me.txtLowStocks.AutoSize = True
        Me.txtLowStocks.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtLowStocks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtLowStocks.Location = New System.Drawing.Point(83, 37)
        Me.txtLowStocks.Name = "txtLowStocks"
        Me.txtLowStocks.Size = New System.Drawing.Size(42, 46)
        Me.txtLowStocks.TabIndex = 24
        Me.txtLowStocks.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "TOTAL PRODUCT:"
        '
        'LowStocksDataGrid
        '
        Me.LowStocksDataGrid.AllowUserToAddRows = False
        Me.LowStocksDataGrid.AllowUserToDeleteRows = False
        Me.LowStocksDataGrid.AllowUserToOrderColumns = True
        Me.LowStocksDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LowStocksDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.LowStocksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LowStocksDataGrid.Location = New System.Drawing.Point(24, 365)
        Me.LowStocksDataGrid.Name = "LowStocksDataGrid"
        Me.LowStocksDataGrid.ReadOnly = True
        Me.LowStocksDataGrid.Size = New System.Drawing.Size(764, 208)
        Me.LowStocksDataGrid.TabIndex = 117
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightBlue
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 16)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "LOW/NO STOCKS:"
        '
        'Chart
        '
        Me.Chart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart.BorderlineColor = System.Drawing.Color.Black
        Me.Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart.Legends.Add(Legend2)
        Me.Chart.Location = New System.Drawing.Point(24, 202)
        Me.Chart.Name = "Chart"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.Legend = "Legend1"
        Series2.Name = "TOTAL NUMBER"
        Me.Chart.Series.Add(Series2)
        Me.Chart.Size = New System.Drawing.Size(764, 131)
        Me.Chart.TabIndex = 115
        Me.Chart.Text = "Chart1"
        '
        'pnlTotalBooks
        '
        Me.pnlTotalBooks.BackColor = System.Drawing.Color.White
        Me.pnlTotalBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotalBooks.Controls.Add(Me.txtTotalProduct)
        Me.pnlTotalBooks.Controls.Add(Me.Label7)
        Me.pnlTotalBooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.pnlTotalBooks.Location = New System.Drawing.Point(101, 62)
        Me.pnlTotalBooks.Name = "pnlTotalBooks"
        Me.pnlTotalBooks.Size = New System.Drawing.Size(200, 100)
        Me.pnlTotalBooks.TabIndex = 118
        '
        'txtTotalProduct
        '
        Me.txtTotalProduct.AutoSize = True
        Me.txtTotalProduct.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtTotalProduct.Location = New System.Drawing.Point(78, 37)
        Me.txtTotalProduct.Name = "txtTotalProduct"
        Me.txtTotalProduct.Size = New System.Drawing.Size(42, 46)
        Me.txtTotalProduct.TabIndex = 23
        Me.txtTotalProduct.Text = "0"
        '
        'ProductsDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 585)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlBorrowers)
        Me.Controls.Add(Me.LowStocksDataGrid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.pnlTotalBooks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductsDashboard"
        Me.Text = "StaffDashboard"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlBorrowers.ResumeLayout(False)
        Me.pnlBorrowers.PerformLayout()
        CType(Me.LowStocksDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalBooks.ResumeLayout(False)
        Me.pnlTotalBooks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlBorrowers As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents LowStocksDataGrid As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Chart As DataVisualization.Charting.Chart
    Friend WithEvents pnlTotalBooks As Panel
    Friend WithEvents txtNoStocks As Label
    Friend WithEvents txtLowStocks As Label
    Friend WithEvents txtTotalProduct As Label
End Class
