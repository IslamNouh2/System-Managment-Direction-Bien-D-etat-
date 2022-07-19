<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SING_UP
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
        Dim Full_nameLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Me.Show_userBTN = New System.Windows.Forms.Button()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.cancelBTN = New System.Windows.Forms.Button()
        Me.singBTN = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Full_nameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Full_nameLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.ForeColor = System.Drawing.Color.White
        UsernameLabel.Location = New System.Drawing.Point(105, 166)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(85, 23)
        UsernameLabel.TabIndex = 21
        UsernameLabel.Text = "username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.Color.White
        PasswordLabel.Location = New System.Drawing.Point(105, 241)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(82, 23)
        PasswordLabel.TabIndex = 23
        PasswordLabel.Text = "password:"
        '
        'Full_nameLabel
        '
        Full_nameLabel.AutoSize = True
        Full_nameLabel.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_nameLabel.ForeColor = System.Drawing.Color.White
        Full_nameLabel.Location = New System.Drawing.Point(553, 166)
        Full_nameLabel.Name = "Full_nameLabel"
        Full_nameLabel.Size = New System.Drawing.Size(82, 23)
        Full_nameLabel.TabIndex = 25
        Full_nameLabel.Text = "full name:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeLabel.ForeColor = System.Drawing.Color.White
        TypeLabel.Location = New System.Drawing.Point(105, 325)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(46, 23)
        TypeLabel.TabIndex = 27
        TypeLabel.Text = "type:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.ForeColor = System.Drawing.Color.White
        PhoneLabel.Location = New System.Drawing.Point(553, 241)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(60, 23)
        PhoneLabel.TabIndex = 28
        PhoneLabel.Text = "phone:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.ForeColor = System.Drawing.Color.White
        AddressLabel.Location = New System.Drawing.Point(553, 325)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(70, 23)
        AddressLabel.TabIndex = 30
        AddressLabel.Text = "address:"
        '
        'Show_userBTN
        '
        Me.Show_userBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Show_userBTN.FlatAppearance.BorderSize = 0
        Me.Show_userBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Show_userBTN.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_userBTN.ForeColor = System.Drawing.Color.White
        Me.Show_userBTN.Location = New System.Drawing.Point(442, 425)
        Me.Show_userBTN.Name = "Show_userBTN"
        Me.Show_userBTN.Size = New System.Drawing.Size(141, 43)
        Me.Show_userBTN.TabIndex = 35
        Me.Show_userBTN.Text = "عرض المستخدمين"
        Me.Show_userBTN.UseVisualStyleBackColor = False
        '
        'TypeComboBox
        '
        Me.TypeComboBox.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"مسـؤول", "عـون معاينة"})
        Me.TypeComboBox.Location = New System.Drawing.Point(223, 322)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(205, 31)
        Me.TypeComboBox.TabIndex = 34
        '
        'cancelBTN
        '
        Me.cancelBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cancelBTN.FlatAppearance.BorderSize = 0
        Me.cancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBTN.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBTN.ForeColor = System.Drawing.Color.White
        Me.cancelBTN.Location = New System.Drawing.Point(635, 425)
        Me.cancelBTN.Name = "cancelBTN"
        Me.cancelBTN.Size = New System.Drawing.Size(141, 43)
        Me.cancelBTN.TabIndex = 33
        Me.cancelBTN.Text = "إغلاق"
        Me.cancelBTN.UseVisualStyleBackColor = False
        '
        'singBTN
        '
        Me.singBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.singBTN.FlatAppearance.BorderSize = 0
        Me.singBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.singBTN.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.singBTN.ForeColor = System.Drawing.Color.White
        Me.singBTN.Location = New System.Drawing.Point(257, 425)
        Me.singBTN.Name = "singBTN"
        Me.singBTN.Size = New System.Drawing.Size(141, 43)
        Me.singBTN.TabIndex = 32
        Me.singBTN.Text = "تسجيل"
        Me.singBTN.UseVisualStyleBackColor = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(223, 163)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(205, 30)
        Me.UsernameTextBox.TabIndex = 22
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(223, 238)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(205, 30)
        Me.PasswordTextBox.TabIndex = 24
        '
        'Full_nameTextBox
        '
        Me.Full_nameTextBox.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_nameTextBox.Location = New System.Drawing.Point(665, 163)
        Me.Full_nameTextBox.Name = "Full_nameTextBox"
        Me.Full_nameTextBox.Size = New System.Drawing.Size(205, 30)
        Me.Full_nameTextBox.TabIndex = 26
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(665, 238)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(205, 30)
        Me.PhoneTextBox.TabIndex = 29
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Font = New System.Drawing.Font("Nina", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(665, 322)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(205, 30)
        Me.AddressTextBox.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 106)
        Me.Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(354, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "إنشاء المستخدمين"
        '
        'Form_SING_UP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 506)
        Me.Controls.Add(Me.Show_userBTN)
        Me.Controls.Add(Me.TypeComboBox)
        Me.Controls.Add(Me.cancelBTN)
        Me.Controls.Add(Me.singBTN)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Full_nameLabel)
        Me.Controls.Add(Me.Full_nameTextBox)
        Me.Controls.Add(TypeLabel)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_SING_UP"
        Me.Text = "تسجيل المستخدمين"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Show_userBTN As Button
    Friend WithEvents TypeComboBox As ComboBox
    Friend WithEvents cancelBTN As Button
    Friend WithEvents singBTN As Button
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Full_nameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
