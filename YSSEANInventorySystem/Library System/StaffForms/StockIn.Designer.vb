<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockIn
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
        Me.StockInDataGrid = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnShowAllProducts = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.a = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTransactionNum = New System.Windows.Forms.TextBox()
        CType(Me.StockInDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StockInDataGrid
        '
        Me.StockInDataGrid.AllowUserToAddRows = False
        Me.StockInDataGrid.AllowUserToDeleteRows = False
        Me.StockInDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StockInDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.StockInDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockInDataGrid.Location = New System.Drawing.Point(38, 92)
        Me.StockInDataGrid.Name = "StockInDataGrid"
        Me.StockInDataGrid.ReadOnly = True
        Me.StockInDataGrid.Size = New System.Drawing.Size(737, 301)
        Me.StockInDataGrid.TabIndex = 113
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(34, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 23)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "ADD NEW STOCKS"
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQuantity.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtQuantity.Location = New System.Drawing.Point(159, 449)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(145, 20)
        Me.txtQuantity.TabIndex = 121
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtTotalPrice.Location = New System.Drawing.Point(477, 453)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(145, 20)
        Me.txtTotalPrice.TabIndex = 119
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightBlue
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(326, 449)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 22)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "TOTAL PRICE:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(34, 447)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 22)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "QUANTITY: "
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnNew.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.Library_System.My.Resources.Resources.file_plus
        Me.btnNew.Location = New System.Drawing.Point(38, 484)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(86, 52)
        Me.btnNew.TabIndex = 122
        Me.btnNew.Text = "ADD"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnShowAllProducts
        '
        Me.btnShowAllProducts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowAllProducts.FlatAppearance.BorderSize = 0
        Me.btnShowAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAllProducts.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllProducts.ForeColor = System.Drawing.Color.White
        Me.btnShowAllProducts.Location = New System.Drawing.Point(634, 399)
        Me.btnShowAllProducts.Name = "btnShowAllProducts"
        Me.btnShowAllProducts.Size = New System.Drawing.Size(141, 28)
        Me.btnShowAllProducts.TabIndex = 174
        Me.btnShowAllProducts.Text = "Show All Products"
        Me.btnShowAllProducts.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(136, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(486, 20)
        Me.txtSearch.TabIndex = 175
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "SEARCH:"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(681, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(94, 22)
        Me.btnSearch.TabIndex = 177
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtProductCode
        '
        Me.txtProductCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductCode.Enabled = False
        Me.txtProductCode.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProductCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProductCode.Location = New System.Drawing.Point(629, 66)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(146, 20)
        Me.txtProductCode.TabIndex = 179
        '
        'a
        '
        Me.a.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.a.AutoSize = True
        Me.a.BackColor = System.Drawing.Color.LightBlue
        Me.a.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.ForeColor = System.Drawing.Color.White
        Me.a.Location = New System.Drawing.Point(402, 64)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(220, 22)
        Me.a.TabIndex = 178
        Me.a.Text = "SELECTED PRODUCT:"
        '
        'txtProductID
        '
        Me.txtProductID.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProductID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProductID.Location = New System.Drawing.Point(563, 103)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(200, 20)
        Me.txtProductID.TabIndex = 191
        Me.txtProductID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(384, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 22)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "PRODUCT ID:"
        Me.Label2.Visible = False
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCategory.Location = New System.Drawing.Point(563, 140)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(200, 20)
        Me.txtCategory.TabIndex = 189
        Me.txtCategory.Visible = False
        '
        'txtProdName
        '
        Me.txtProdName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProdName.Location = New System.Drawing.Point(563, 183)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 20)
        Me.txtProdName.TabIndex = 188
        Me.txtProdName.Visible = False
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(563, 220)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 20)
        Me.txtPrice.TabIndex = 187
        Me.txtPrice.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightBlue
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(384, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 22)
        Me.Label11.TabIndex = 186
        Me.Label11.Text = "PRICE:"
        Me.Label11.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(384, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 22)
        Me.Label4.TabIndex = 185
        Me.Label4.Text = "CATEGORY:"
        Me.Label4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(384, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 22)
        Me.Label6.TabIndex = 184
        Me.Label6.Text = "PRODUCT NAME:"
        Me.Label6.Visible = False
        '
        'txtTransactionNum
        '
        Me.txtTransactionNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTransactionNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtTransactionNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtTransactionNum.Location = New System.Drawing.Point(575, 514)
        Me.txtTransactionNum.Name = "txtTransactionNum"
        Me.txtTransactionNum.Size = New System.Drawing.Size(200, 20)
        Me.txtTransactionNum.TabIndex = 193
        Me.txtTransactionNum.Visible = False
        '
        'StockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.Controls.Add(Me.txtTransactionNum)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnShowAllProducts)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StockInDataGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockIn"
        Me.Text = "StockIn"
        CType(Me.StockInDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StockInDataGrid As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnShowAllProducts As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents a As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTransactionNum As TextBox
End Class
