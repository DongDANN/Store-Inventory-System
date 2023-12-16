<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Services_Print
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtProdName = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.ProductManagenentDataGrid = New System.Windows.Forms.DataGridView()
        CType(Me.ProductManagenentDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 22)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "PAPER:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 22)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "QUANTITY:"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnNew.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.Library_System.My.Resources.Resources.file_plus
        Me.btnNew.Location = New System.Drawing.Point(47, 132)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(90, 50)
        Me.btnNew.TabIndex = 123
        Me.btnNew.Text = "ADD"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'txtProdName
        '
        Me.txtProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProdName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProdName.FormattingEnabled = True
        Me.txtProdName.Location = New System.Drawing.Point(185, 34)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 22)
        Me.txtProdName.TabIndex = 124
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtQuantity.Location = New System.Drawing.Point(185, 82)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(200, 20)
        Me.txtQuantity.TabIndex = 125
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
        Me.ProductManagenentDataGrid.Location = New System.Drawing.Point(336, 242)
        Me.ProductManagenentDataGrid.Name = "ProductManagenentDataGrid"
        Me.ProductManagenentDataGrid.ReadOnly = True
        Me.ProductManagenentDataGrid.Size = New System.Drawing.Size(717, 161)
        Me.ProductManagenentDataGrid.TabIndex = 127
        Me.ProductManagenentDataGrid.Visible = False
        '
        'Services_Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(459, 194)
        Me.Controls.Add(Me.ProductManagenentDataGrid)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Services_Print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ProductManagenentDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents txtProdName As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents ProductManagenentDataGrid As DataGridView
End Class
