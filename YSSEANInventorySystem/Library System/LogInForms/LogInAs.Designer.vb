<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogInAs
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightBlue
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(150, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 75)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "  YSSEAN GENERAL " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     MERCHANDISE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INVENTORY SYSTEM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LOGO
        '
        Me.LOGO.BackColor = System.Drawing.Color.LightBlue
        Me.LOGO.Image = Global.Library_System.My.Resources.Resources.logo__1_
        Me.LOGO.Location = New System.Drawing.Point(73, 51)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(71, 57)
        Me.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LOGO.TabIndex = 38
        Me.LOGO.TabStop = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.LightBlue
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAdmin.Image = Global.Library_System.My.Resources.Resources.user_circle_gear__1_
        Me.btnAdmin.Location = New System.Drawing.Point(212, 156)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(140, 98)
        Me.btnAdmin.TabIndex = 35
        Me.btnAdmin.Text = "ADMIN"
        Me.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.LightBlue
        Me.btnStaff.FlatAppearance.BorderSize = 0
        Me.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaff.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnStaff.Image = Global.Library_System.My.Resources.Resources.user_circle
        Me.btnStaff.Location = New System.Drawing.Point(84, 156)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(122, 98)
        Me.btnStaff.TabIndex = 34
        Me.btnStaff.Text = "STAFF"
        Me.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Library_System.My.Resources.Resources.logo__2_
        Me.PictureBox2.Location = New System.Drawing.Point(23, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(371, 247)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Library_System.My.Resources.Resources.shapedash
        Me.PictureBox1.Location = New System.Drawing.Point(-406, -311)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1127, 911)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'LogInAs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 292)
        Me.Controls.Add(Me.LOGO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LogInAs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LOGO As PictureBox
End Class
