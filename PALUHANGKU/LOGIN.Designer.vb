<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        btnLogin = New Button()
        btnCancel = New Button()
        txtUsername = New TextBox()
        tbPassword = New TextBox()
        cbLihat = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(253), CByte(232), CByte(200))
        btnLogin.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        btnLogin.Location = New Point(263, 297)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(87, 29)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(253), CByte(232), CByte(200))
        btnCancel.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        btnCancel.Location = New Point(388, 297)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(253), CByte(232), CByte(200))
        txtUsername.Location = New Point(294, 146)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(188, 27)
        txtUsername.TabIndex = 4
        ' 
        ' tbPassword
        ' 
        tbPassword.BackColor = Color.FromArgb(CByte(253), CByte(232), CByte(200))
        tbPassword.Location = New Point(294, 215)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(188, 27)
        tbPassword.TabIndex = 5
        ' 
        ' cbLihat
        ' 
        cbLihat.AutoSize = True
        cbLihat.BackColor = Color.Transparent
        cbLihat.Font = New Font("Javanese Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbLihat.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        cbLihat.Location = New Point(294, 252)
        cbLihat.Name = "cbLihat"
        cbLihat.Size = New Size(159, 45)
        cbLihat.TabIndex = 6
        cbLihat.Text = "Lihat Password"
        cbLihat.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Javanese Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        Label1.Location = New Point(306, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 25)
        Label1.TabIndex = 7
        Label1.Text = "Masukkan Email"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Javanese Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        Label2.Location = New Point(306, 187)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 25)
        Label2.TabIndex = 8
        Label2.Text = "Masukkan Password"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(739, 354)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cbLihat)
        Controls.Add(tbPassword)
        Controls.Add(txtUsername)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        DoubleBuffered = True
        ForeColor = SystemColors.ActiveCaptionText
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN ANGGOTA"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents cbLihat As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
