<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockOutReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockOutReport))
        Me.txtProdName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnShowAllTransaction = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.StockInDataGrid = New System.Windows.Forms.DataGridView()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.StockInDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProdName
        '
        Me.txtProdName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdName.BackColor = System.Drawing.Color.White
        Me.txtProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProdName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtProdName.FormattingEnabled = True
        Me.txtProdName.Location = New System.Drawing.Point(601, 90)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(170, 22)
        Me.txtProdName.TabIndex = 192
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(392, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 22)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "TRANSACTION NUM:"
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.White
        Me.txtCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCategory.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.Location = New System.Drawing.Point(159, 90)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(200, 22)
        Me.txtCategory.TabIndex = 190
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 22)
        Me.Label4.TabIndex = 189
        Me.Label4.Text = "CATEGORY:"
        '
        'btnShowAllTransaction
        '
        Me.btnShowAllTransaction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnShowAllTransaction.FlatAppearance.BorderSize = 0
        Me.btnShowAllTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAllTransaction.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllTransaction.ForeColor = System.Drawing.Color.White
        Me.btnShowAllTransaction.Location = New System.Drawing.Point(34, 505)
        Me.btnShowAllTransaction.Name = "btnShowAllTransaction"
        Me.btnShowAllTransaction.Size = New System.Drawing.Size(162, 29)
        Me.btnShowAllTransaction.TabIndex = 188
        Me.btnShowAllTransaction.Text = "Show All Transaction"
        Me.btnShowAllTransaction.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(696, 506)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 28)
        Me.btnPrint.TabIndex = 187
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTitle.AutoSize = True
        Me.txtTitle.BackColor = System.Drawing.Color.LightBlue
        Me.txtTitle.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtTitle.Location = New System.Drawing.Point(242, 21)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(352, 41)
        Me.txtTitle.TabIndex = 186
        Me.txtTitle.Text = "STOCK-OUT REPORT"
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
        Me.StockInDataGrid.Location = New System.Drawing.Point(34, 197)
        Me.StockInDataGrid.Name = "StockInDataGrid"
        Me.StockInDataGrid.ReadOnly = True
        Me.StockInDataGrid.Size = New System.Drawing.Size(737, 302)
        Me.StockInDataGrid.TabIndex = 185
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DateTimePickerTo.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.DateTimePickerTo.Location = New System.Drawing.Point(443, 159)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePickerTo.TabIndex = 184
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DateTimePickerFrom.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(235, 159)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePickerFrom.TabIndex = 183
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(392, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 22)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "TO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(155, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 22)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "FROM:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(30, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 23)
        Me.Label1.TabIndex = 180
        Me.Label1.Text = "DATE FILTER"
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
        'StockOutReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnShowAllTransaction)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.StockInDataGrid)
        Me.Controls.Add(Me.DateTimePickerTo)
        Me.Controls.Add(Me.DateTimePickerFrom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockOutReport"
        Me.Text = "StockOutReport"
        CType(Me.StockInDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProdName As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategory As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnShowAllTransaction As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents txtTitle As Label
    Friend WithEvents StockInDataGrid As DataGridView
    Friend WithEvents DateTimePickerTo As DateTimePicker
    Friend WithEvents DateTimePickerFrom As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
