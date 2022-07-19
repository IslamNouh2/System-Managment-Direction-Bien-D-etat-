<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ADD_USER_login
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ADD_USER_login))
        Me.UsernameTXT = New System.Windows.Forms.TextBox()
        Me.Passwordtxt = New System.Windows.Forms.TextBox()
        Me.cancelBTN = New System.Windows.Forms.Button()
        Me.loginBTN = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.ForeColor = System.Drawing.Color.White
        UsernameLabel.Location = New System.Drawing.Point(321, 100)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(87, 23)
        UsernameLabel.TabIndex = 26
        UsernameLabel.Text = "Username:"
        '
        'UsernameTXT
        '
        Me.UsernameTXT.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTXT.Location = New System.Drawing.Point(439, 97)
        Me.UsernameTXT.Name = "UsernameTXT"
        Me.UsernameTXT.Size = New System.Drawing.Size(205, 30)
        Me.UsernameTXT.TabIndex = 27
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.Color.White
        PasswordLabel.Location = New System.Drawing.Point(321, 175)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(82, 23)
        PasswordLabel.TabIndex = 28
        PasswordLabel.Text = "Password:"
        '
        'Passwordtxt
        '
        Me.Passwordtxt.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passwordtxt.Location = New System.Drawing.Point(439, 172)
        Me.Passwordtxt.Name = "Passwordtxt"
        Me.Passwordtxt.Size = New System.Drawing.Size(205, 30)
        Me.Passwordtxt.TabIndex = 29
        '
        'cancelBTN
        '
        Me.cancelBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cancelBTN.FlatAppearance.BorderSize = 0
        Me.cancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBTN.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBTN.ForeColor = System.Drawing.Color.White
        Me.cancelBTN.Location = New System.Drawing.Point(411, 321)
        Me.cancelBTN.Name = "cancelBTN"
        Me.cancelBTN.Size = New System.Drawing.Size(141, 43)
        Me.cancelBTN.TabIndex = 25
        Me.cancelBTN.Text = "Cancel"
        Me.cancelBTN.UseVisualStyleBackColor = False
        '
        'loginBTN
        '
        Me.loginBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.loginBTN.FlatAppearance.BorderSize = 0
        Me.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBTN.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBTN.ForeColor = System.Drawing.Color.White
        Me.loginBTN.Location = New System.Drawing.Point(198, 321)
        Me.loginBTN.Name = "loginBTN"
        Me.loginBTN.Size = New System.Drawing.Size(141, 43)
        Me.loginBTN.TabIndex = 24
        Me.loginBTN.Text = "Login"
        Me.loginBTN.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(66, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Form_ADD_USER_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(755, 442)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTXT)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.Passwordtxt)
        Me.Controls.Add(Me.cancelBTN)
        Me.Controls.Add(Me.loginBTN)
        Me.Name = "Form_ADD_USER_login"
        Me.Text = "Form_ADD_USER_login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UsernameTXT As TextBox
    Friend WithEvents Passwordtxt As TextBox
    Friend WithEvents cancelBTN As Button
    Friend WithEvents loginBTN As Button
End Class
