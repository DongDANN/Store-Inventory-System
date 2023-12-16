<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MerchandiseNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MerchandiseNew))
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.a = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.ProductManagenentDataGrid = New System.Windows.Forms.DataGridView()
        Me.btnSAVE = New System.Windows.Forms.Button()
        CType(Me.ProductManagenentDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProductCode
        '
        Me.txtProductCode.Enabled = False
        Me.txtProductCode.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProductCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProductCode.Location = New System.Drawing.Point(211, 41)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(200, 20)
        Me.txtProductCode.TabIndex = 116
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.BackColor = System.Drawing.Color.LightBlue
        Me.a.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.ForeColor = System.Drawing.Color.White
        Me.a.Location = New System.Drawing.Point(32, 37)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(173, 22)
        Me.a.TabIndex = 115
        Me.a.Text = "PRODUCT CODE:"
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Location = New System.Drawing.Point(211, 77)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(200, 22)
        Me.txtCategory.TabIndex = 112
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(211, 157)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 20)
        Me.txtPrice.TabIndex = 111
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightBlue
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(32, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 22)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "PRICE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(32, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 22)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "CATEGORY:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 22)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "PRODUCT NAME:"
        '
        'txtProdName
        '
        Me.txtProdName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProdName.Location = New System.Drawing.Point(211, 120)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 20)
        Me.txtProdName.TabIndex = 117
        '
        'ProductManagenentDataGrid
        '
        Me.ProductManagenentDataGrid.AllowUserToAddRows = False
        Me.ProductManagenentDataGrid.AllowUserToDeleteRows = False
        Me.ProductManagenentDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductManagenentDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.ProductManagenentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductManagenentDataGrid.Location = New System.Drawing.Point(330, 231)
        Me.ProductManagenentDataGrid.Name = "ProductManagenentDataGrid"
        Me.ProductManagenentDataGrid.ReadOnly = True
        Me.ProductManagenentDataGrid.Size = New System.Drawing.Size(717, 259)
        Me.ProductManagenentDataGrid.TabIndex = 119
        Me.ProductManagenentDataGrid.Visible = False
        '
        'btnSAVE
        '
        Me.btnSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSAVE.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSAVE.ForeColor = System.Drawing.Color.White
        Me.btnSAVE.Image = Global.Library_System.My.Resources.Resources.file_plus
        Me.btnSAVE.Location = New System.Drawing.Point(36, 199)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(98, 50)
        Me.btnSAVE.TabIndex = 118
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'MerchandiseNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(460, 272)
        Me.Controls.Add(Me.ProductManagenentDataGrid)
        Me.Controls.Add(Me.btnSAVE)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MerchandiseNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.ProductManagenentDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents a As Label
    Friend WithEvents txtCategory As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents btnSAVE As Button
    Friend WithEvents ProductManagenentDataGrid As DataGridView
End Class
