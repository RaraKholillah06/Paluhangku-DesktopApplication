<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        tbUser = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' tbUser
        ' 
        tbUser.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        tbUser.BorderStyle = BorderStyle.FixedSingle
        tbUser.ForeColor = Color.Green
        tbUser.Location = New Point(313, 200)
        tbUser.Name = "tbUser"
        tbUser.Size = New Size(245, 27)
        tbUser.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.ForeColor = Color.Green
        txtPassword.Location = New Point(313, 282)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(245, 27)
        txtPassword.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Label1.Location = New Point(363, 379)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 31)
        Label1.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(253), CByte(232), CByte(200))
        btnLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        btnLogin.Location = New Point(334, 383)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 4
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' AdminLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(780, 451)
        Controls.Add(btnLogin)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(tbUser)
        DoubleBuffered = True
        Name = "AdminLogin"
        Text = "AdminLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
End Class
