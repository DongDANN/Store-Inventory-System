<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashArt
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashArt))
        Me.pnlBar = New System.Windows.Forms.Panel()
        Me.pnlLoading = New System.Windows.Forms.Panel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBar
        '
        Me.pnlBar.BackColor = System.Drawing.Color.LightBlue
        Me.pnlBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBar.Controls.Add(Me.pnlLoading)
        Me.pnlBar.Location = New System.Drawing.Point(1, 278)
        Me.pnlBar.Name = "pnlBar"
        Me.pnlBar.Size = New System.Drawing.Size(685, 25)
        Me.pnlBar.TabIndex = 6
        '
        'pnlLoading
        '
        Me.pnlLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.pnlLoading.Location = New System.Drawing.Point(-8, 0)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(35, 25)
        Me.pnlLoading.TabIndex = 7
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(69, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 123)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "  YSSEAN GENERAL " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     MERCHANDISE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INVENTORY SYSTEM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Library_System.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(461, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'SplashArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(683, 303)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SplashArt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashArt"
        Me.pnlBar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlBar As Panel
    Friend WithEvents pnlLoading As Panel
    Friend WithEvents Timer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
