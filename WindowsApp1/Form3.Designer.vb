<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxConf2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxConf1 = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AccessibleDescription = "Username"
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 30.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(244, -5)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(254, 74)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Admin"
        '
        'TextBoxConf2
        '
        Me.TextBoxConf2.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxConf2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBoxConf2.Location = New System.Drawing.Point(382, 192)
        Me.TextBoxConf2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxConf2.Name = "TextBoxConf2"
        Me.TextBoxConf2.Size = New System.Drawing.Size(260, 42)
        Me.TextBoxConf2.TabIndex = 2
        Me.TextBoxConf2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxConf2.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = "Password"
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 16.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(148, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 41)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Password:"
        '
        'TextBoxConf1
        '
        Me.TextBoxConf1.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxConf1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBoxConf1.Location = New System.Drawing.Point(382, 118)
        Me.TextBoxConf1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxConf1.Name = "TextBoxConf1"
        Me.TextBoxConf1.Size = New System.Drawing.Size(260, 42)
        Me.TextBoxConf1.TabIndex = 2
        Me.TextBoxConf1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Username
        '
        Me.Username.AccessibleDescription = "Username"
        Me.Username.AutoSize = True
        Me.Username.BackColor = System.Drawing.Color.Transparent
        Me.Username.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Username.Location = New System.Drawing.Point(148, 118)
        Me.Username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(211, 38)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username:"
        '
        'PreviousButton
        '
        Me.PreviousButton.AccessibleDescription = "PreviousButton"
        Me.PreviousButton.Font = New System.Drawing.Font("Verdana", 16.25!, System.Drawing.FontStyle.Bold)
        Me.PreviousButton.Location = New System.Drawing.Point(48, 337)
        Me.PreviousButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(308, 68)
        Me.PreviousButton.TabIndex = 0
        Me.PreviousButton.Text = "Back"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'ConfirmButton
        '
        Me.ConfirmButton.AccessibleDescription = "ConfirmButton"
        Me.ConfirmButton.Font = New System.Drawing.Font("Verdana", 16.25!, System.Drawing.FontStyle.Bold)
        Me.ConfirmButton.Location = New System.Drawing.Point(382, 337)
        Me.ConfirmButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(308, 68)
        Me.ConfirmButton.TabIndex = 0
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(82, 71)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(723, 71)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxConf2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBoxConf1)
        Me.Panel1.Controls.Add(Me.Username)
        Me.Panel1.Controls.Add(Me.PreviousButton)
        Me.Panel1.Controls.Add(Me.ConfirmButton)
        Me.Panel1.Location = New System.Drawing.Point(82, 168)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 512)
        Me.Panel1.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(886, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(886, 750)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxConf2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxConf1 As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents PreviousButton As Button
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
