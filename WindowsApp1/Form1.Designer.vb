<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PAssword = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.AdminButton = New System.Windows.Forms.Button()
        Me.SigninButton = New System.Windows.Forms.Button()
        Me.SignupButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.PAssword)
        Me.Panel1.Controls.Add(Me.Username)
        Me.Panel1.Controls.Add(Me.AdminButton)
        Me.Panel1.Controls.Add(Me.SigninButton)
        Me.Panel1.Controls.Add(Me.SignupButton)
        Me.Panel1.Location = New System.Drawing.Point(55, 149)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 594)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(268, 31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox2.Location = New System.Drawing.Point(292, 298)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(308, 42)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(292, 225)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(308, 42)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PAssword
        '
        Me.PAssword.AccessibleDescription = "Password"
        Me.PAssword.AutoSize = True
        Me.PAssword.BackColor = System.Drawing.Color.Transparent
        Me.PAssword.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAssword.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PAssword.Location = New System.Drawing.Point(76, 300)
        Me.PAssword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PAssword.Name = "PAssword"
        Me.PAssword.Size = New System.Drawing.Size(203, 38)
        Me.PAssword.TabIndex = 1
        Me.PAssword.Text = "Password:"
        '
        'Username
        '
        Me.Username.AccessibleDescription = "Username"
        Me.Username.AutoSize = True
        Me.Username.BackColor = System.Drawing.Color.Transparent
        Me.Username.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Username.Location = New System.Drawing.Point(76, 225)
        Me.Username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(211, 38)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username:"
        '
        'AdminButton
        '
        Me.AdminButton.AccessibleDescription = "AdminButton"
        Me.AdminButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminButton.Font = New System.Drawing.Font("Verdana", 16.25!, System.Drawing.FontStyle.Bold)
        Me.AdminButton.Location = New System.Drawing.Point(472, 446)
        Me.AdminButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Size = New System.Drawing.Size(184, 68)
        Me.AdminButton.TabIndex = 0
        Me.AdminButton.Text = "Admin"
        Me.AdminButton.UseVisualStyleBackColor = True
        '
        'SigninButton
        '
        Me.SigninButton.AccessibleDescription = "SigninButton"
        Me.SigninButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SigninButton.Font = New System.Drawing.Font("Verdana", 16.25!, System.Drawing.FontStyle.Bold)
        Me.SigninButton.Location = New System.Drawing.Point(230, 436)
        Me.SigninButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SigninButton.Name = "SigninButton"
        Me.SigninButton.Size = New System.Drawing.Size(244, 89)
        Me.SigninButton.TabIndex = 0
        Me.SigninButton.Text = "Sign In"
        Me.SigninButton.UseVisualStyleBackColor = True
        '
        'SignupButton
        '
        Me.SignupButton.AccessibleName = "SignupButton"
        Me.SignupButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SignupButton.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignupButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SignupButton.Location = New System.Drawing.Point(47, 447)
        Me.SignupButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SignupButton.Name = "SignupButton"
        Me.SignupButton.Size = New System.Drawing.Size(187, 68)
        Me.SignupButton.TabIndex = 0
        Me.SignupButton.Text = "Sign Up"
        Me.SignupButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CloseButton)
        Me.Panel2.Location = New System.Drawing.Point(55, 44)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(702, 68)
        Me.Panel2.TabIndex = 4
        '
        'CloseButton
        '
        Me.CloseButton.AccessibleDescription = "CloseButton"
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(638, 5)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(60, 57)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "x"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 818)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PAssword As Label
    Friend WithEvents Username As Label
    Friend WithEvents AdminButton As Button
    Friend WithEvents SigninButton As Button
    Friend WithEvents SignupButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CloseButton As Button
End Class
