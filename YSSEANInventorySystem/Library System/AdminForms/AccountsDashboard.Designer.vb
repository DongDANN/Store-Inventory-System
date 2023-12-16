<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountsDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlBorrowers = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RecentLoginsDataGrid = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlTotalBooks = New System.Windows.Forms.Panel()
        Me.txtTotalAccounts = New System.Windows.Forms.Label()
        Me.txtActiveAccounts = New System.Windows.Forms.Label()
        Me.txtDisabledAccounts = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.pnlBorrowers.SuspendLayout()
        CType(Me.RecentLoginsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalBooks.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(26, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "DISABLED ACCOUNTS:"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtDisabledAccounts)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(526, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 111
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(34, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "ACTIVE ACCOUNTS:"
        '
        'pnlBorrowers
        '
        Me.pnlBorrowers.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlBorrowers.BackColor = System.Drawing.Color.White
        Me.pnlBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBorrowers.Controls.Add(Me.txtActiveAccounts)
        Me.pnlBorrowers.Controls.Add(Me.Label8)
        Me.pnlBorrowers.Location = New System.Drawing.Point(320, 12)
        Me.pnlBorrowers.Name = "pnlBorrowers"
        Me.pnlBorrowers.Size = New System.Drawing.Size(200, 100)
        Me.pnlBorrowers.TabIndex = 112
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(34, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "TOTAL ACCOUNTS:"
        '
        'RecentLoginsDataGrid
        '
        Me.RecentLoginsDataGrid.AllowUserToAddRows = False
        Me.RecentLoginsDataGrid.AllowUserToDeleteRows = False
        Me.RecentLoginsDataGrid.AllowUserToOrderColumns = True
        Me.RecentLoginsDataGrid.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RecentLoginsDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.RecentLoginsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecentLoginsDataGrid.Location = New System.Drawing.Point(28, 345)
        Me.RecentLoginsDataGrid.Name = "RecentLoginsDataGrid"
        Me.RecentLoginsDataGrid.ReadOnly = True
        Me.RecentLoginsDataGrid.Size = New System.Drawing.Size(776, 171)
        Me.RecentLoginsDataGrid.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightBlue
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(25, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "RECENT LOGINS:"
        '
        'Chart
        '
        Me.Chart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Chart.BorderlineColor = System.Drawing.Color.Black
        Me.Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart.Legends.Add(Legend2)
        Me.Chart.Location = New System.Drawing.Point(28, 118)
        Me.Chart.Name = "Chart"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.Legend = "Legend1"
        Series2.Name = "TOTAL NUMBER"
        Me.Chart.Series.Add(Series2)
        Me.Chart.Size = New System.Drawing.Size(776, 178)
        Me.Chart.TabIndex = 104
        Me.Chart.Text = "Chart1"
        '
        'pnlTotalBooks
        '
        Me.pnlTotalBooks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlTotalBooks.BackColor = System.Drawing.Color.White
        Me.pnlTotalBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotalBooks.Controls.Add(Me.txtTotalAccounts)
        Me.pnlTotalBooks.Controls.Add(Me.Label7)
        Me.pnlTotalBooks.Location = New System.Drawing.Point(114, 12)
        Me.pnlTotalBooks.Name = "pnlTotalBooks"
        Me.pnlTotalBooks.Size = New System.Drawing.Size(200, 100)
        Me.pnlTotalBooks.TabIndex = 109
        '
        'txtTotalAccounts
        '
        Me.txtTotalAccounts.AutoSize = True
        Me.txtTotalAccounts.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalAccounts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtTotalAccounts.Location = New System.Drawing.Point(80, 34)
        Me.txtTotalAccounts.Name = "txtTotalAccounts"
        Me.txtTotalAccounts.Size = New System.Drawing.Size(42, 46)
        Me.txtTotalAccounts.TabIndex = 19
        Me.txtTotalAccounts.Text = "0"
        '
        'txtActiveAccounts
        '
        Me.txtActiveAccounts.AutoSize = True
        Me.txtActiveAccounts.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtActiveAccounts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtActiveAccounts.Location = New System.Drawing.Point(80, 34)
        Me.txtActiveAccounts.Name = "txtActiveAccounts"
        Me.txtActiveAccounts.Size = New System.Drawing.Size(42, 46)
        Me.txtActiveAccounts.TabIndex = 20
        Me.txtActiveAccounts.Text = "0"
        '
        'txtDisabledAccounts
        '
        Me.txtDisabledAccounts.AutoSize = True
        Me.txtDisabledAccounts.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtDisabledAccounts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtDisabledAccounts.Location = New System.Drawing.Point(77, 34)
        Me.txtDisabledAccounts.Name = "txtDisabledAccounts"
        Me.txtDisabledAccounts.Size = New System.Drawing.Size(42, 46)
        Me.txtDisabledAccounts.TabIndex = 23
        Me.txtDisabledAccounts.Text = "0"
        '
        'AccountsDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(839, 528)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlBorrowers)
        Me.Controls.Add(Me.RecentLoginsDataGrid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.pnlTotalBooks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountsDashboard"
        Me.Text = "ITDashboard"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlBorrowers.ResumeLayout(False)
        Me.pnlBorrowers.PerformLayout()
        CType(Me.RecentLoginsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RecentLoginsDataGrid As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Chart As DataVisualization.Charting.Chart
    Friend WithEvents pnlTotalBooks As Panel
    Friend WithEvents txtTotalAccounts As Label
    Friend WithEvents txtActiveAccounts As Label
    Friend WithEvents txtDisabledAccounts As Label
End Class
