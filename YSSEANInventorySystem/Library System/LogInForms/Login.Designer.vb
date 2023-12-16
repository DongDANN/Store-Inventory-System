<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtLogIn = New System.Windows.Forms.Label()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEye = New System.Windows.Forms.Button()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(184, 213)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ShortcutsEnabled = False
        Me.txtPassword.Size = New System.Drawing.Size(229, 29)
        Me.txtPassword.TabIndex = 15
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(184, 161)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(229, 29)
        Me.txtUsername.TabIndex = 14
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.LightBlue
        Me.lblPass.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblPass.ForeColor = System.Drawing.Color.White
        Me.lblPass.Location = New System.Drawing.Point(72, 220)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(105, 22)
        Me.lblPass.TabIndex = 13
        Me.lblPass.Text = "Password  :"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.LightBlue
        Me.lblUser.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(67, 164)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(110, 22)
        Me.lblUser.TabIndex = 12
        Me.lblUser.Text = "Username  :"
        '
        'txtLogIn
        '
        Me.txtLogIn.AutoSize = True
        Me.txtLogIn.BackColor = System.Drawing.Color.Transparent
        Me.txtLogIn.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.txtLogIn.Location = New System.Drawing.Point(228, 55)
        Me.txtLogIn.Name = "txtLogIn"
        Me.txtLogIn.Size = New System.Drawing.Size(145, 50)
        Me.txtLogIn.TabIndex = 11
        Me.txtLogIn.Text = "LOGIN"
        '
        'LOGO
        '
        Me.LOGO.BackColor = System.Drawing.Color.Transparent
        Me.LOGO.Image = Global.Library_System.My.Resources.Resources.logo__1_
        Me.LOGO.Location = New System.Drawing.Point(166, 50)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(71, 63)
        Me.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LOGO.TabIndex = 18
        Me.LOGO.TabStop = False
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLogIn.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.White
        Me.btnLogIn.Image = Global.Library_System.My.Resources.Resources.sign_in__1_
        Me.btnLogIn.Location = New System.Drawing.Point(289, 248)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnLogIn.Size = New System.Drawing.Size(124, 46)
        Me.btnLogIn.TabIndex = 16
        Me.btnLogIn.Text = "LOGIN"
        Me.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Library_System.My.Resources.Resources.logo__2_
        Me.PictureBox2.Location = New System.Drawing.Point(52, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(434, 274)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Library_System.My.Resources.Resources.shapedash
        Me.PictureBox1.Location = New System.Drawing.Point(-29, -212)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(684, 615)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'btnEye
        '
        Me.btnEye.BackColor = System.Drawing.Color.White
        Me.btnEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEye.Image = Global.Library_System.My.Resources.Resources.eye
        Me.btnEye.Location = New System.Drawing.Point(419, 213)
        Me.btnEye.Name = "btnEye"
        Me.btnEye.Size = New System.Drawing.Size(37, 29)
        Me.btnEye.TabIndex = 132
        Me.btnEye.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(525, 378)
        Me.Controls.Add(Me.btnEye)
        Me.Controls.Add(Me.txtLogIn)
        Me.Controls.Add(Me.LOGO)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogIn As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents txtLogIn As Label
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnEye As Button
End Class
