<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminInterface))
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelSideBar = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.ReportsSubmenu = New System.Windows.Forms.Panel()
        Me.btnStockOutReport = New System.Windows.Forms.Button()
        Me.btnStockInReport = New System.Windows.Forms.Button()
        Me.btnAllProductsReport = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnPendingRequest = New System.Windows.Forms.Button()
        Me.btnAccountManagement = New System.Windows.Forms.Button()
        Me.DashboardSubmenu = New System.Windows.Forms.Panel()
        Me.btnAccountsDashboard = New System.Windows.Forms.Button()
        Me.btnStocksDashboard = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSideBar.SuspendLayout()
        Me.ReportsSubmenu.SuspendLayout()
        Me.DashboardSubmenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(200, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(826, 543)
        Me.PanelMain.TabIndex = 5
        '
        'PanelSideBar
        '
        Me.PanelSideBar.AutoScroll = True
        Me.PanelSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PanelSideBar.Controls.Add(Me.btnLogOut)
        Me.PanelSideBar.Controls.Add(Me.ReportsSubmenu)
        Me.PanelSideBar.Controls.Add(Me.btnReports)
        Me.PanelSideBar.Controls.Add(Me.btnPendingRequest)
        Me.PanelSideBar.Controls.Add(Me.btnAccountManagement)
        Me.PanelSideBar.Controls.Add(Me.DashboardSubmenu)
        Me.PanelSideBar.Controls.Add(Me.btnDashboard)
        Me.PanelSideBar.Controls.Add(Me.PanelLogo)
        Me.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideBar.Name = "PanelSideBar"
        Me.PanelSideBar.Size = New System.Drawing.Size(200, 543)
        Me.PanelSideBar.TabIndex = 3
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(0, 501)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(200, 40)
        Me.btnLogOut.TabIndex = 12
        Me.btnLogOut.Text = "LOG OUT"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'ReportsSubmenu
        '
        Me.ReportsSubmenu.Controls.Add(Me.btnStockOutReport)
        Me.ReportsSubmenu.Controls.Add(Me.btnStockInReport)
        Me.ReportsSubmenu.Controls.Add(Me.btnAllProductsReport)
        Me.ReportsSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.ReportsSubmenu.Location = New System.Drawing.Point(0, 381)
        Me.ReportsSubmenu.Name = "ReportsSubmenu"
        Me.ReportsSubmenu.Size = New System.Drawing.Size(200, 120)
        Me.ReportsSubmenu.TabIndex = 0
        '
        'btnStockOutReport
        '
        Me.btnStockOutReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnStockOutReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStockOutReport.FlatAppearance.BorderSize = 0
        Me.btnStockOutReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockOutReport.ForeColor = System.Drawing.Color.White
        Me.btnStockOutReport.Location = New System.Drawing.Point(0, 80)
        Me.btnStockOutReport.Name = "btnStockOutReport"
        Me.btnStockOutReport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnStockOutReport.Size = New System.Drawing.Size(200, 40)
        Me.btnStockOutReport.TabIndex = 15
        Me.btnStockOutReport.Text = "STOCK-OUT"
        Me.btnStockOutReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockOutReport.UseVisualStyleBackColor = False
        '
        'btnStockInReport
        '
        Me.btnStockInReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnStockInReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStockInReport.FlatAppearance.BorderSize = 0
        Me.btnStockInReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockInReport.ForeColor = System.Drawing.Color.White
        Me.btnStockInReport.Location = New System.Drawing.Point(0, 40)
        Me.btnStockInReport.Name = "btnStockInReport"
        Me.btnStockInReport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnStockInReport.Size = New System.Drawing.Size(200, 40)
        Me.btnStockInReport.TabIndex = 14
        Me.btnStockInReport.Text = "STOCK-IN"
        Me.btnStockInReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockInReport.UseVisualStyleBackColor = False
        '
        'btnAllProductsReport
        '
        Me.btnAllProductsReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnAllProductsReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAllProductsReport.FlatAppearance.BorderSize = 0
        Me.btnAllProductsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllProductsReport.ForeColor = System.Drawing.Color.White
        Me.btnAllProductsReport.Location = New System.Drawing.Point(0, 0)
        Me.btnAllProductsReport.Name = "btnAllProductsReport"
        Me.btnAllProductsReport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAllProductsReport.Size = New System.Drawing.Size(200, 40)
        Me.btnAllProductsReport.TabIndex = 13
        Me.btnAllProductsReport.Text = "ALL PRODUCTS"
        Me.btnAllProductsReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAllProductsReport.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Location = New System.Drawing.Point(0, 341)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnReports.Size = New System.Drawing.Size(200, 40)
        Me.btnReports.TabIndex = 7
        Me.btnReports.Text = "REPORTS"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnPendingRequest
        '
        Me.btnPendingRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnPendingRequest.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPendingRequest.FlatAppearance.BorderSize = 0
        Me.btnPendingRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPendingRequest.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendingRequest.ForeColor = System.Drawing.Color.White
        Me.btnPendingRequest.Location = New System.Drawing.Point(0, 301)
        Me.btnPendingRequest.Name = "btnPendingRequest"
        Me.btnPendingRequest.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnPendingRequest.Size = New System.Drawing.Size(200, 40)
        Me.btnPendingRequest.TabIndex = 6
        Me.btnPendingRequest.Text = "PENDING REQUEST"
        Me.btnPendingRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPendingRequest.UseVisualStyleBackColor = False
        '
        'btnAccountManagement
        '
        Me.btnAccountManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnAccountManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccountManagement.FlatAppearance.BorderSize = 0
        Me.btnAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountManagement.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountManagement.ForeColor = System.Drawing.Color.White
        Me.btnAccountManagement.Location = New System.Drawing.Point(0, 261)
        Me.btnAccountManagement.Name = "btnAccountManagement"
        Me.btnAccountManagement.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAccountManagement.Size = New System.Drawing.Size(200, 40)
        Me.btnAccountManagement.TabIndex = 5
        Me.btnAccountManagement.Text = "ACCOUNT MANAGEMENTS"
        Me.btnAccountManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccountManagement.UseVisualStyleBackColor = False
        '
        'DashboardSubmenu
        '
        Me.DashboardSubmenu.Controls.Add(Me.btnAccountsDashboard)
        Me.DashboardSubmenu.Controls.Add(Me.btnStocksDashboard)
        Me.DashboardSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.DashboardSubmenu.Location = New System.Drawing.Point(0, 181)
        Me.DashboardSubmenu.Name = "DashboardSubmenu"
        Me.DashboardSubmenu.Size = New System.Drawing.Size(200, 80)
        Me.DashboardSubmenu.TabIndex = 0
        '
        'btnAccountsDashboard
        '
        Me.btnAccountsDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnAccountsDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccountsDashboard.FlatAppearance.BorderSize = 0
        Me.btnAccountsDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountsDashboard.ForeColor = System.Drawing.Color.White
        Me.btnAccountsDashboard.Location = New System.Drawing.Point(0, 40)
        Me.btnAccountsDashboard.Name = "btnAccountsDashboard"
        Me.btnAccountsDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAccountsDashboard.Size = New System.Drawing.Size(200, 40)
        Me.btnAccountsDashboard.TabIndex = 9
        Me.btnAccountsDashboard.Text = "ACCOUNTS"
        Me.btnAccountsDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccountsDashboard.UseVisualStyleBackColor = False
        '
        'btnStocksDashboard
        '
        Me.btnStocksDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnStocksDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStocksDashboard.FlatAppearance.BorderSize = 0
        Me.btnStocksDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStocksDashboard.ForeColor = System.Drawing.Color.White
        Me.btnStocksDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnStocksDashboard.Name = "btnStocksDashboard"
        Me.btnStocksDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnStocksDashboard.Size = New System.Drawing.Size(200, 40)
        Me.btnStocksDashboard.TabIndex = 8
        Me.btnStocksDashboard.Text = "STOCKS"
        Me.btnStocksDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStocksDashboard.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 141)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(200, 40)
        Me.btnDashboard.TabIndex = 4
        Me.btnDashboard.Text = "DASHBOARD"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(200, 141)
        Me.PanelLogo.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Library_System.My.Resources.Resources.image2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'AdminInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 543)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelSideBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminInterface"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelSideBar.ResumeLayout(False)
        Me.ReportsSubmenu.ResumeLayout(False)
        Me.DashboardSubmenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelSideBar As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DashboardSubmenu As Panel
    Public WithEvents btnAccountsDashboard As Button
    Public WithEvents btnStocksDashboard As Button
    Public WithEvents btnAccountManagement As Button
    Public WithEvents btnPendingRequest As Button
    Public WithEvents btnReports As Button
    Friend WithEvents ReportsSubmenu As Panel
    Public WithEvents btnStockOutReport As Button
    Public WithEvents btnStockInReport As Button
    Public WithEvents btnAllProductsReport As Button
    Public WithEvents btnLogOut As Button
End Class
