<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffsInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffsInterface))
        Me.PanelSideBar = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.StocksPanelSubMenu = New System.Windows.Forms.Panel()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.btnStockIn = New System.Windows.Forms.Button()
        Me.btnStocks = New System.Windows.Forms.Button()
        Me.ManagementPanelSubMenu = New System.Windows.Forms.Panel()
        Me.btnServices = New System.Windows.Forms.Button()
        Me.btnProductManagement = New System.Windows.Forms.Button()
        Me.btnManagements = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelSideBar.SuspendLayout()
        Me.StocksPanelSubMenu.SuspendLayout()
        Me.ManagementPanelSubMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSideBar
        '
        Me.PanelSideBar.AutoScroll = True
        Me.PanelSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PanelSideBar.Controls.Add(Me.btnLogOut)
        Me.PanelSideBar.Controls.Add(Me.StocksPanelSubMenu)
        Me.PanelSideBar.Controls.Add(Me.btnStocks)
        Me.PanelSideBar.Controls.Add(Me.ManagementPanelSubMenu)
        Me.PanelSideBar.Controls.Add(Me.btnManagements)
        Me.PanelSideBar.Controls.Add(Me.PanelLogo)
        Me.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideBar.Name = "PanelSideBar"
        Me.PanelSideBar.Size = New System.Drawing.Size(200, 520)
        Me.PanelSideBar.TabIndex = 0
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(0, 381)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogOut.Size = New System.Drawing.Size(200, 40)
        Me.btnLogOut.TabIndex = 11
        Me.btnLogOut.Text = "LOGOUT"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'StocksPanelSubMenu
        '
        Me.StocksPanelSubMenu.Controls.Add(Me.btnStockOut)
        Me.StocksPanelSubMenu.Controls.Add(Me.btnStockIn)
        Me.StocksPanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.StocksPanelSubMenu.Location = New System.Drawing.Point(0, 301)
        Me.StocksPanelSubMenu.Name = "StocksPanelSubMenu"
        Me.StocksPanelSubMenu.Size = New System.Drawing.Size(200, 80)
        Me.StocksPanelSubMenu.TabIndex = 7
        Me.StocksPanelSubMenu.Visible = False
        '
        'btnStockOut
        '
        Me.btnStockOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnStockOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStockOut.FlatAppearance.BorderSize = 0
        Me.btnStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockOut.ForeColor = System.Drawing.Color.White
        Me.btnStockOut.Location = New System.Drawing.Point(0, 41)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnStockOut.Size = New System.Drawing.Size(200, 40)
        Me.btnStockOut.TabIndex = 9
        Me.btnStockOut.Text = "STOCK-OUT"
        Me.btnStockOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockOut.UseVisualStyleBackColor = False
        '
        'btnStockIn
        '
        Me.btnStockIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnStockIn.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStockIn.FlatAppearance.BorderSize = 0
        Me.btnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockIn.ForeColor = System.Drawing.Color.White
        Me.btnStockIn.Location = New System.Drawing.Point(0, 0)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnStockIn.Size = New System.Drawing.Size(200, 41)
        Me.btnStockIn.TabIndex = 8
        Me.btnStockIn.Text = "STOCK-IN"
        Me.btnStockIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockIn.UseVisualStyleBackColor = False
        '
        'btnStocks
        '
        Me.btnStocks.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnStocks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStocks.FlatAppearance.BorderSize = 0
        Me.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStocks.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnStocks.ForeColor = System.Drawing.Color.White
        Me.btnStocks.Location = New System.Drawing.Point(0, 261)
        Me.btnStocks.Name = "btnStocks"
        Me.btnStocks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnStocks.Size = New System.Drawing.Size(200, 40)
        Me.btnStocks.TabIndex = 6
        Me.btnStocks.Text = "STOCKS"
        Me.btnStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStocks.UseVisualStyleBackColor = False
        '
        'ManagementPanelSubMenu
        '
        Me.ManagementPanelSubMenu.Controls.Add(Me.btnServices)
        Me.ManagementPanelSubMenu.Controls.Add(Me.btnProductManagement)
        Me.ManagementPanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.ManagementPanelSubMenu.Location = New System.Drawing.Point(0, 181)
        Me.ManagementPanelSubMenu.Name = "ManagementPanelSubMenu"
        Me.ManagementPanelSubMenu.Size = New System.Drawing.Size(200, 80)
        Me.ManagementPanelSubMenu.TabIndex = 5
        Me.ManagementPanelSubMenu.Visible = False
        '
        'btnServices
        '
        Me.btnServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnServices.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnServices.FlatAppearance.BorderSize = 0
        Me.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServices.ForeColor = System.Drawing.Color.White
        Me.btnServices.Location = New System.Drawing.Point(0, 40)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnServices.Size = New System.Drawing.Size(200, 40)
        Me.btnServices.TabIndex = 7
        Me.btnServices.Text = "SERVICES"
        Me.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServices.UseVisualStyleBackColor = False
        '
        'btnProductManagement
        '
        Me.btnProductManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnProductManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductManagement.FlatAppearance.BorderSize = 0
        Me.btnProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductManagement.ForeColor = System.Drawing.Color.White
        Me.btnProductManagement.Location = New System.Drawing.Point(0, 0)
        Me.btnProductManagement.Name = "btnProductManagement"
        Me.btnProductManagement.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnProductManagement.Size = New System.Drawing.Size(200, 40)
        Me.btnProductManagement.TabIndex = 6
        Me.btnProductManagement.Text = "PRODUCTS"
        Me.btnProductManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductManagement.UseVisualStyleBackColor = False
        '
        'btnManagements
        '
        Me.btnManagements.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnManagements.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManagements.FlatAppearance.BorderSize = 0
        Me.btnManagements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManagements.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnManagements.ForeColor = System.Drawing.Color.White
        Me.btnManagements.Location = New System.Drawing.Point(0, 141)
        Me.btnManagements.Name = "btnManagements"
        Me.btnManagements.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnManagements.Size = New System.Drawing.Size(200, 40)
        Me.btnManagements.TabIndex = 4
        Me.btnManagements.Text = "MERCHANDISE"
        Me.btnManagements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManagements.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(200, 141)
        Me.PanelLogo.TabIndex = 2
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
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.White
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(200, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(768, 520)
        Me.PanelMain.TabIndex = 2
        '
        'StaffsInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 520)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelSideBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(984, 559)
        Me.Name = "StaffsInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffsInterface"
        Me.PanelSideBar.ResumeLayout(False)
        Me.StocksPanelSubMenu.ResumeLayout(False)
        Me.ManagementPanelSubMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSideBar As Panel
    Friend WithEvents StocksPanelSubMenu As Panel
    Public WithEvents btnStockOut As Button
    Public WithEvents btnStockIn As Button
    Public WithEvents btnStocks As Button
    Friend WithEvents ManagementPanelSubMenu As Panel
    Public WithEvents btnServices As Button
    Public WithEvents btnProductManagement As Button
    Public WithEvents btnManagements As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelMain As Panel
    Public WithEvents btnLogOut As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
