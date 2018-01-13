<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UsertypeCb = New System.Windows.Forms.ComboBox()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.UsertypeLbl = New System.Windows.Forms.Label()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.UsernameTb = New System.Windows.Forms.TextBox()
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UsertypeCb)
        Me.GroupBox1.Controls.Add(Me.PasswordTb)
        Me.GroupBox1.Controls.Add(Me.UsertypeLbl)
        Me.GroupBox1.Controls.Add(Me.PasswordLbl)
        Me.GroupBox1.Controls.Add(Me.UsernameTb)
        Me.GroupBox1.Controls.Add(Me.UsernameLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'UsertypeCb
        '
        Me.UsertypeCb.FormattingEnabled = True
        Me.UsertypeCb.Items.AddRange(New Object() {"Select User", "Admin", "User"})
        Me.UsertypeCb.Location = New System.Drawing.Point(105, 88)
        Me.UsertypeCb.Name = "UsertypeCb"
        Me.UsertypeCb.Size = New System.Drawing.Size(99, 21)
        Me.UsertypeCb.TabIndex = 2
        '
        'PasswordTb
        '
        Me.PasswordTb.Location = New System.Drawing.Point(105, 59)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTb.Size = New System.Drawing.Size(148, 20)
        Me.PasswordTb.TabIndex = 1
        '
        'UsertypeLbl
        '
        Me.UsertypeLbl.AutoSize = True
        Me.UsertypeLbl.Location = New System.Drawing.Point(27, 91)
        Me.UsertypeLbl.Name = "UsertypeLbl"
        Me.UsertypeLbl.Size = New System.Drawing.Size(49, 13)
        Me.UsertypeLbl.TabIndex = 0
        Me.UsertypeLbl.Text = "Usertype"
        '
        'PasswordLbl
        '
        Me.PasswordLbl.AutoSize = True
        Me.PasswordLbl.Location = New System.Drawing.Point(27, 62)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLbl.TabIndex = 0
        Me.PasswordLbl.Text = "Password"
        '
        'UsernameTb
        '
        Me.UsernameTb.Location = New System.Drawing.Point(105, 33)
        Me.UsernameTb.Name = "UsernameTb"
        Me.UsernameTb.Size = New System.Drawing.Size(148, 20)
        Me.UsernameTb.TabIndex = 1
        '
        'UsernameLbl
        '
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.Location = New System.Drawing.Point(27, 36)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(55, 13)
        Me.UsernameLbl.TabIndex = 0
        Me.UsernameLbl.Text = "Username"
        '
        'LoginBtn
        '
        Me.LoginBtn.Location = New System.Drawing.Point(43, 151)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(101, 23)
        Me.LoginBtn.TabIndex = 1
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(165, 151)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(101, 23)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AcceptButton = Me.LoginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(284, 188)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UsertypeCb As ComboBox
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents UsertypeLbl As Label
    Friend WithEvents PasswordLbl As Label
    Friend WithEvents UsernameTb As TextBox
    Friend WithEvents UsernameLbl As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
