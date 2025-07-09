<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForumForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForumForm))
        Label1 = New Label()
        ListBoxDiskusiUmum = New ListBox()
        TextBoxPesanBaru = New TextBox()
        btnKirim = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        Label1.Location = New Point(338, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(399, 29)
        Label1.TabIndex = 0
        Label1.Text = "CERITAKAN PENGALAMAN MU DISINI"
        ' 
        ' ListBoxDiskusiUmum
        ' 
        ListBoxDiskusiUmum.FormattingEnabled = True
        ListBoxDiskusiUmum.Location = New Point(186, 161)
        ListBoxDiskusiUmum.Name = "ListBoxDiskusiUmum"
        ListBoxDiskusiUmum.Size = New Size(710, 264)
        ListBoxDiskusiUmum.TabIndex = 0
        ' 
        ' TextBoxPesanBaru
        ' 
        TextBoxPesanBaru.Location = New Point(186, 118)
        TextBoxPesanBaru.Name = "TextBoxPesanBaru"
        TextBoxPesanBaru.Size = New Size(627, 27)
        TextBoxPesanBaru.TabIndex = 1
        ' 
        ' btnKirim
        ' 
        btnKirim.BackColor = Color.FromArgb(CByte(253), CByte(232), CByte(200))
        btnKirim.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKirim.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        btnKirim.Location = New Point(870, 439)
        btnKirim.Name = "btnKirim"
        btnKirim.Size = New Size(134, 53)
        btnKirim.TabIndex = 2
        btnKirim.Text = "KIRIM"
        btnKirim.UseVisualStyleBackColor = False
        ' 
        ' ForumForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1027, 504)
        Controls.Add(btnKirim)
        Controls.Add(ListBoxDiskusiUmum)
        Controls.Add(TextBoxPesanBaru)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "ForumForm"
        Text = "1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxDiskusiUmum As ListBox
    Friend WithEvents TextBoxPesanBaru As TextBox
    Friend WithEvents btnKirim As Button
End Class
