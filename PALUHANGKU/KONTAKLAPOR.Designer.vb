<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contact))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        Label1.Location = New Point(80, 349)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 41)
        Label1.TabIndex = 0
        Label1.Text = "Call Center POLRI : 110"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        Label2.Location = New Point(256, 337)
        Label2.Name = "Label2"
        Label2.Size = New Size(290, 184)
        Label2.TabIndex = 1
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        Label3.Location = New Point(553, 337)
        Label3.Name = "Label3"
        Label3.Size = New Size(182, 150)
        Label3.TabIndex = 2
        Label3.Text = "KPAI Komisi Perlindungan Anak Indonesia (KPAI):" & vbCrLf & "- WhatsApp: 081-1177-2273" & vbCrLf & "- Telepon: (021) 3190 1556"
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        Label4.Location = New Point(728, 337)
        Label4.Name = "Label4"
        Label4.Size = New Size(245, 184)
        Label4.TabIndex = 3
        Label4.Text = "website https://lpai.id/hubungi-kami/" & vbCrLf & "email lpa.indonesia@yahoo.com" & vbCrLf & "telepon ke +62 2123 2038 atau 081775009213 (pusat)" & vbCrLf & "instagram @lpai.id " & vbCrLf & "https://lpai.id/lpai-daerah/" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        Label5.Location = New Point(427, 75)
        Label5.Name = "Label5"
        Label5.Size = New Size(189, 26)
        Label5.TabIndex = 4
        Label5.Text = "Kontak Laporan"
        ' 
        ' Contact
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1039, 599)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Contact"
        Text = "kontak lapopr"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
