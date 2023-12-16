<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductManagement
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
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.a = New System.Windows.Forms.Label()
        Me.ProductManagenentDataGrid = New System.Windows.Forms.DataGridView()
        Me.btnShowAllProducts = New System.Windows.Forms.Button()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ProductManagenentDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProductCode
        '
        Me.txtProductCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductCode.Enabled = False
        Me.txtProductCode.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProductCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProductCode.Location = New System.Drawing.Point(563, 33)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(200, 20)
        Me.txtProductCode.TabIndex = 106
        '
        'a
        '
        Me.a.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.a.AutoSize = True
        Me.a.BackColor = System.Drawing.Color.LightBlue
        Me.a.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.ForeColor = System.Drawing.Color.White
        Me.a.Location = New System.Drawing.Point(337, 33)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(220, 22)
        Me.a.TabIndex = 105
        Me.a.Text = "SELECTED PRODUCT:"
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
        Me.ProductManagenentDataGrid.Location = New System.Drawing.Point(46, 58)
        Me.ProductManagenentDataGrid.Name = "ProductManagenentDataGrid"
        Me.ProductManagenentDataGrid.ReadOnly = True
        Me.ProductManagenentDataGrid.Size = New System.Drawing.Size(717, 397)
        Me.ProductManagenentDataGrid.TabIndex = 14
        '
        'btnShowAllProducts
        '
        Me.btnShowAllProducts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowAllProducts.FlatAppearance.BorderSize = 0
        Me.btnShowAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAllProducts.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllProducts.ForeColor = System.Drawing.Color.White
        Me.btnShowAllProducts.Location = New System.Drawing.Point(622, 461)
        Me.btnShowAllProducts.Name = "btnShowAllProducts"
        Me.btnShowAllProducts.Size = New System.Drawing.Size(141, 28)
        Me.btnShowAllProducts.TabIndex = 174
        Me.btnShowAllProducts.Text = "Show All Products"
        Me.btnShowAllProducts.UseVisualStyleBackColor = True
        '
        'txtProdName
        '
        Me.txtProdName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProdName.Location = New System.Drawing.Point(560, 152)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 20)
        Me.txtProdName.TabIndex = 180
        Me.txtProdName.Visible = False
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(560, 189)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 20)
        Me.txtPrice.TabIndex = 178
        Me.txtPrice.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightBlue
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(381, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 22)
        Me.Label11.TabIndex = 177
        Me.Label11.Text = "PRICE:"
        Me.Label11.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(381, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 22)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "CATEGORY:"
        Me.Label4.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(381, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 22)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "PRODUCT NAME:"
        Me.Label2.Visible = False
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCategory.Location = New System.Drawing.Point(560, 109)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(200, 20)
        Me.txtCategory.TabIndex = 181
        Me.txtCategory.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.Library_System.My.Resources.Resources.trash
        Me.btnDelete.Location = New System.Drawing.Point(150, 482)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(139, 50)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "REMOVE AND ARCHIVE"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.Library_System.My.Resources.Resources.pencil_simple
        Me.btnEdit.Location = New System.Drawing.Point(-3, 538)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(104, 25)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnEdit.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnNew.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.Library_System.My.Resources.Resources.file_plus
        Me.btnNew.Location = New System.Drawing.Point(46, 482)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(98, 50)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "NEW"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'txtProductID
        '
        Me.txtProductID.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProductID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProductID.Location = New System.Drawing.Point(560, 72)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(200, 20)
        Me.txtProductID.TabIndex = 183
        Me.txtProductID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(381, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 22)
        Me.Label1.TabIndex = 182
        Me.Label1.Text = "PRODUCT ID:"
        Me.Label1.Visible = False
        '
        'ProductManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnShowAllProducts)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.ProductManagenentDataGrid)
        Me.Controls.Add(Me.btnNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductManagement"
        CType(Me.ProductManagenentDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents a As Label
    Friend WithEvents ProductManagenentDataGrid As DataGridView
    Friend WithEvents btnShowAllProducts As Button
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label1 As Label
End Class
