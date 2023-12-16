<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PendingRequests
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBookManagement = New System.Windows.Forms.Label()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.PendingDatagrid = New System.Windows.Forms.DataGridView()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.a = New System.Windows.Forms.Label()
        Me.btnApproveAll = New System.Windows.Forms.Button()
        Me.btnDeclineAll = New System.Windows.Forms.Button()
        CType(Me.PendingDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBookManagement
        '
        Me.txtBookManagement.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBookManagement.AutoSize = True
        Me.txtBookManagement.BackColor = System.Drawing.Color.LightBlue
        Me.txtBookManagement.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookManagement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtBookManagement.Location = New System.Drawing.Point(233, 9)
        Me.txtBookManagement.Name = "txtBookManagement"
        Me.txtBookManagement.Size = New System.Drawing.Size(352, 41)
        Me.txtBookManagement.TabIndex = 137
        Me.txtBookManagement.Text = "PENDING REQUESTS"
        '
        'btnApprove
        '
        Me.btnApprove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApprove.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnApprove.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(26, 489)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnApprove.Size = New System.Drawing.Size(93, 49)
        Me.btnApprove.TabIndex = 135
        Me.btnApprove.Text = "APPROVE"
        Me.btnApprove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'btnDecline
        '
        Me.btnDecline.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDecline.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDecline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDecline.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDecline.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecline.ForeColor = System.Drawing.Color.White
        Me.btnDecline.Location = New System.Drawing.Point(125, 489)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnDecline.Size = New System.Drawing.Size(93, 49)
        Me.btnDecline.TabIndex = 139
        Me.btnDecline.Text = "DECLINE"
        Me.btnDecline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDecline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDecline.UseVisualStyleBackColor = False
        '
        'PendingDatagrid
        '
        Me.PendingDatagrid.AllowUserToAddRows = False
        Me.PendingDatagrid.AllowUserToDeleteRows = False
        Me.PendingDatagrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PendingDatagrid.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PendingDatagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PendingDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PendingDatagrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.PendingDatagrid.GridColor = System.Drawing.Color.White
        Me.PendingDatagrid.Location = New System.Drawing.Point(26, 79)
        Me.PendingDatagrid.Name = "PendingDatagrid"
        Me.PendingDatagrid.ReadOnly = True
        Me.PendingDatagrid.Size = New System.Drawing.Size(751, 404)
        Me.PendingDatagrid.TabIndex = 170
        '
        'txtProductID
        '
        Me.txtProductID.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProductID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProductID.Location = New System.Drawing.Point(576, 93)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(200, 20)
        Me.txtProductID.TabIndex = 193
        Me.txtProductID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(397, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 22)
        Me.Label1.TabIndex = 192
        Me.Label1.Text = "PRODUCT ID:"
        Me.Label1.Visible = False
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCategory.Location = New System.Drawing.Point(576, 130)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(200, 20)
        Me.txtCategory.TabIndex = 191
        Me.txtCategory.Visible = False
        '
        'txtProdName
        '
        Me.txtProdName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProdName.Location = New System.Drawing.Point(576, 173)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 20)
        Me.txtProdName.TabIndex = 190
        Me.txtProdName.Visible = False
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(576, 210)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 20)
        Me.txtPrice.TabIndex = 189
        Me.txtPrice.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightBlue
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(397, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 22)
        Me.Label11.TabIndex = 188
        Me.Label11.Text = "PRICE:"
        Me.Label11.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(397, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 22)
        Me.Label4.TabIndex = 187
        Me.Label4.Text = "CATEGORY:"
        Me.Label4.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(397, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 22)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "PRODUCT NAME:"
        Me.Label2.Visible = False
        '
        'txtProductCode
        '
        Me.txtProductCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductCode.Enabled = False
        Me.txtProductCode.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProductCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProductCode.Location = New System.Drawing.Point(579, 54)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(200, 20)
        Me.txtProductCode.TabIndex = 185
        '
        'a
        '
        Me.a.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.a.AutoSize = True
        Me.a.BackColor = System.Drawing.Color.LightBlue
        Me.a.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.ForeColor = System.Drawing.Color.White
        Me.a.Location = New System.Drawing.Point(353, 54)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(220, 22)
        Me.a.TabIndex = 184
        Me.a.Text = "SELECTED PRODUCT:"
        '
        'btnApproveAll
        '
        Me.btnApproveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApproveAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnApproveAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApproveAll.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnApproveAll.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApproveAll.ForeColor = System.Drawing.Color.White
        Me.btnApproveAll.Location = New System.Drawing.Point(524, 489)
        Me.btnApproveAll.Name = "btnApproveAll"
        Me.btnApproveAll.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnApproveAll.Size = New System.Drawing.Size(123, 49)
        Me.btnApproveAll.TabIndex = 194
        Me.btnApproveAll.Text = "APPROVE ALL"
        Me.btnApproveAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApproveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApproveAll.UseVisualStyleBackColor = False
        '
        'btnDeclineAll
        '
        Me.btnDeclineAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeclineAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDeclineAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeclineAll.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDeclineAll.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeclineAll.ForeColor = System.Drawing.Color.White
        Me.btnDeclineAll.Location = New System.Drawing.Point(656, 489)
        Me.btnDeclineAll.Name = "btnDeclineAll"
        Me.btnDeclineAll.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnDeclineAll.Size = New System.Drawing.Size(123, 49)
        Me.btnDeclineAll.TabIndex = 195
        Me.btnDeclineAll.Text = "DECLINE ALL"
        Me.btnDeclineAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeclineAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeclineAll.UseVisualStyleBackColor = False
        '
        'PendingRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.Controls.Add(Me.btnDeclineAll)
        Me.Controls.Add(Me.btnApproveAll)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.PendingDatagrid)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.txtBookManagement)
        Me.Controls.Add(Me.btnApprove)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PendingRequests"
        Me.Text = "Pending Request"
        CType(Me.PendingDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBookManagement As Label
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnDecline As Button
    Friend WithEvents PendingDatagrid As DataGridView
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents a As Label
    Friend WithEvents btnApproveAll As Button
    Friend WithEvents btnDeclineAll As Button
End Class
