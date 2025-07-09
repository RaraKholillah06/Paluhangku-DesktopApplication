<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSignUp))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        tbEmail = New TextBox()
        txtUsername = New TextBox()
        btnSignUp = New Button()
        RadButLaki = New RadioButton()
        RadButPerem = New RadioButton()
        tbPassword = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtKonPass = New TextBox()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(71, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 22)
        Label1.TabIndex = 0
        Label1.Text = "Nama:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(71, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 22)
        Label2.TabIndex = 1
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(71, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 22)
        Label3.TabIndex = 2
        Label3.Text = "Jenis Kelamin:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(71, 234)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 22)
        Label4.TabIndex = 3
        Label4.Text = "Username:"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(248, 53)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 4
        ' 
        ' tbEmail
        ' 
        tbEmail.Location = New Point(248, 94)
        tbEmail.Name = "tbEmail"
        tbEmail.Size = New Size(125, 27)
        tbEmail.TabIndex = 5
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(299, 233)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(125, 27)
        txtUsername.TabIndex = 7
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        btnSignUp.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = Color.White
        btnSignUp.Location = New Point(197, 408)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(110, 38)
        btnSignUp.TabIndex = 8
        btnSignUp.Text = "SIGN UP"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' RadButLaki
        ' 
        RadButLaki.AutoSize = True
        RadButLaki.BackColor = Color.Transparent
        RadButLaki.Font = New Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadButLaki.ForeColor = Color.White
        RadButLaki.Location = New Point(248, 133)
        RadButLaki.Name = "RadButLaki"
        RadButLaki.Size = New Size(96, 26)
        RadButLaki.TabIndex = 9
        RadButLaki.TabStop = True
        RadButLaki.Text = "Laki-Laki"
        RadButLaki.UseVisualStyleBackColor = False
        ' 
        ' RadButPerem
        ' 
        RadButPerem.AutoSize = True
        RadButPerem.BackColor = Color.Transparent
        RadButPerem.Font = New Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RadButPerem.ForeColor = Color.White
        RadButPerem.Location = New Point(248, 163)
        RadButPerem.Name = "RadButPerem"
        RadButPerem.Size = New Size(119, 26)
        RadButPerem.TabIndex = 10
        RadButPerem.TabStop = True
        RadButPerem.Text = "Perempuan"
        RadButPerem.UseVisualStyleBackColor = False
        ' 
        ' tbPassword
        ' 
        tbPassword.Location = New Point(299, 281)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(125, 27)
        tbPassword.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(47, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(71, 286)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 22)
        Label6.TabIndex = 12
        Label6.Text = "Password:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(71, 332)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 22)
        Label7.TabIndex = 13
        Label7.Text = "Konfirmasi:"
        ' 
        ' txtKonPass
        ' 
        txtKonPass.Location = New Point(299, 327)
        txtKonPass.Name = "txtKonPass"
        txtKonPass.Size = New Size(125, 27)
        txtKonPass.TabIndex = 14
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(299, 360)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(128, 24)
        CheckBox1.TabIndex = 15
        CheckBox1.Text = "Lihat Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' formSignUp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(882, 475)
        Controls.Add(CheckBox1)
        Controls.Add(txtKonPass)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(RadButPerem)
        Controls.Add(RadButLaki)
        Controls.Add(btnSignUp)
        Controls.Add(txtUsername)
        Controls.Add(tbPassword)
        Controls.Add(tbEmail)
        Controls.Add(txtNama)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "formSignUp"
        Text = "SIGN_UP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents RadButLaki As RadioButton
    Friend WithEvents RadButPerem As RadioButton
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtKonPass As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
