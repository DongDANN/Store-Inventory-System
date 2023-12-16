<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MerchandiseEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MerchandiseEdit))
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.a = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(210, 140)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 20)
        Me.txtPrice.TabIndex = 108
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightBlue
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(31, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 22)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "PRICE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 22)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "CATEGORY:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 22)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "PRODUCT NAME:"
        '
        'txtProdName
        '
        Me.txtProdName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProdName.Location = New System.Drawing.Point(210, 66)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 20)
        Me.txtProdName.TabIndex = 120
        '
        'txtProductCode
        '
        Me.txtProductCode.Enabled = False
        Me.txtProductCode.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProductCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProductCode.Location = New System.Drawing.Point(210, 34)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(200, 20)
        Me.txtProductCode.TabIndex = 123
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.BackColor = System.Drawing.Color.LightBlue
        Me.a.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.ForeColor = System.Drawing.Color.White
        Me.a.Location = New System.Drawing.Point(31, 30)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(173, 22)
        Me.a.TabIndex = 122
        Me.a.Text = "PRODUCT CODE:"
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Location = New System.Drawing.Point(210, 103)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(200, 22)
        Me.txtCategory.TabIndex = 124
        '
        'btnSAVE
        '
        Me.btnSAVE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSAVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSAVE.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSAVE.ForeColor = System.Drawing.Color.White
        Me.btnSAVE.Image = Global.Library_System.My.Resources.Resources.file_plus
        Me.btnSAVE.Location = New System.Drawing.Point(35, 176)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(98, 50)
        Me.btnSAVE.TabIndex = 119
        Me.btnSAVE.Text = "SAVE"
        Me.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'MerchandiseEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(460, 272)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.btnSAVE)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MerchandiseEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSAVE As Button
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents a As Label
    Friend WithEvents txtCategory As ComboBox
End Class
