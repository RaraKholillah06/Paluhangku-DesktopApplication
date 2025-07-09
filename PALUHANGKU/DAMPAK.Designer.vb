<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DampakBullying
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DampakBullying))
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        Label1.Location = New Point(307, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 33)
        Label1.TabIndex = 0
        Label1.Text = "DAMPAK BULLYING"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        Label2.Location = New Point(217, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(400, 212)
        Label2.TabIndex = 1
        Label2.Text = "1. Kekerasan fisik" & vbCrLf & "2. Masalah kesehatan mental" & vbCrLf & "3. Kesulitan belajar" & vbCrLf & "4. Penurunan rasa percaya diri" & vbCrLf & "5. Perilaku bunuh diri" & vbCrLf & "6. Penurunan prestasi" & vbCrLf & "7. Gangguan emosional"
        ' 
        ' DampakBullying
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(810, 484)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "DampakBullying"
        Text = "Dampak"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
