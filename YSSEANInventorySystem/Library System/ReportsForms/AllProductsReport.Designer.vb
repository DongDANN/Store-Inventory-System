<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllProductsReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllProductsReport))
        Me.AllProductsDataGrid = New System.Windows.Forms.DataGridView()
        Me.txtProdName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnShowAllProducts = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.Label()
        CType(Me.AllProductsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AllProductsDataGrid
        '
        Me.AllProductsDataGrid.AllowUserToAddRows = False
        Me.AllProductsDataGrid.AllowUserToDeleteRows = False
        Me.AllProductsDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllProductsDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.AllProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllProductsDataGrid.GridColor = System.Drawing.Color.White
        Me.AllProductsDataGrid.Location = New System.Drawing.Point(34, 100)
        Me.AllProductsDataGrid.Name = "AllProductsDataGrid"
        Me.AllProductsDataGrid.ReadOnly = True
        Me.AllProductsDataGrid.Size = New System.Drawing.Size(737, 384)
        Me.AllProductsDataGrid.TabIndex = 169
        '
        'txtProdName
        '
        Me.txtProdName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdName.BackColor = System.Drawing.Color.White
        Me.txtProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProdName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProdName.FormattingEnabled = True
        Me.txtProdName.Location = New System.Drawing.Point(571, 72)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 22)
        Me.txtProdName.TabIndex = 163
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(392, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 22)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "PRODUCT NAME:"
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.White
        Me.txtCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Location = New System.Drawing.Point(159, 72)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(200, 22)
        Me.txtCategory.TabIndex = 161
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 22)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "CATEGORY:"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(696, 490)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 28)
        Me.btnPrint.TabIndex = 172
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'btnShowAllProducts
        '
        Me.btnShowAllProducts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnShowAllProducts.FlatAppearance.BorderSize = 0
        Me.btnShowAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAllProducts.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllProducts.ForeColor = System.Drawing.Color.White
        Me.btnShowAllProducts.Location = New System.Drawing.Point(34, 489)
        Me.btnShowAllProducts.Name = "btnShowAllProducts"
        Me.btnShowAllProducts.Size = New System.Drawing.Size(141, 28)
        Me.btnShowAllProducts.TabIndex = 173
        Me.btnShowAllProducts.Text = "Show All Products"
        Me.btnShowAllProducts.UseVisualStyleBackColor = True
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTitle.AutoSize = True
        Me.txtTitle.BackColor = System.Drawing.Color.LightBlue
        Me.txtTitle.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtTitle.Location = New System.Drawing.Point(271, 9)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(269, 41)
        Me.txtTitle.TabIndex = 174
        Me.txtTitle.Text = "ALL PRODUCTS"
        '
        'AllProductsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.btnShowAllProducts)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.AllProductsDataGrid)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AllProductsReport"
        CType(Me.AllProductsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AllProductsDataGrid As DataGridView
    Friend WithEvents txtProdName As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategory As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnShowAllProducts As Button
    Friend WithEvents txtTitle As Label
End Class
