<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        HOMEToolStripMenuItem = New ToolStripMenuItem()
        BERITAToolStripMenuItem = New ToolStripMenuItem()
        KasusBullyingToolStripMenuItem = New ToolStripMenuItem()
        PenangananBullyingToolStripMenuItem = New ToolStripMenuItem()
        EDUKASIToolStripMenuItem = New ToolStripMenuItem()
        PengertianBullyingToolStripMenuItem = New ToolStripMenuItem()
        JenisjenisBullyingToolStripMenuItem = New ToolStripMenuItem()
        DampakBullyingToolStripMenuItem = New ToolStripMenuItem()
        HakSebagaiKorbanToolStripMenuItem = New ToolStripMenuItem()
        CaraMencegahBullyingToolStripMenuItem = New ToolStripMenuItem()
        WhatShouldIDoToolStripMenuItem = New ToolStripMenuItem()
        SaatMengalamiBullyingToolStripMenuItem = New ToolStripMenuItem()
        SaatMelihatBullyingToolStripMenuItem = New ToolStripMenuItem()
        KontakPelaporanToolStripMenuItem = New ToolStripMenuItem()
        FORUMToolStripMenuItem = New ToolStripMenuItem()
        KONSULTASIToolStripMenuItem = New ToolStripMenuItem()
        RekomendasiPsikologToolStripMenuItem = New ToolStripMenuItem()
        ABOUTToolStripMenuItem = New ToolStripMenuItem()
        SiapaKitaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        btnJoinUs = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        btnLogin = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Khaki
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HOMEToolStripMenuItem, BERITAToolStripMenuItem, EDUKASIToolStripMenuItem, FORUMToolStripMenuItem, KONSULTASIToolStripMenuItem, ABOUTToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1319, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HOMEToolStripMenuItem
        ' 
        HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        HOMEToolStripMenuItem.Size = New Size(66, 24)
        HOMEToolStripMenuItem.Text = "HOME"
        ' 
        ' BERITAToolStripMenuItem
        ' 
        BERITAToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {KasusBullyingToolStripMenuItem, PenangananBullyingToolStripMenuItem})
        BERITAToolStripMenuItem.Name = "BERITAToolStripMenuItem"
        BERITAToolStripMenuItem.Size = New Size(70, 24)
        BERITAToolStripMenuItem.Text = "BERITA"
        ' 
        ' KasusBullyingToolStripMenuItem
        ' 
        KasusBullyingToolStripMenuItem.Name = "KasusBullyingToolStripMenuItem"
        KasusBullyingToolStripMenuItem.Size = New Size(229, 26)
        KasusBullyingToolStripMenuItem.Text = "Kasus Bullying"
        ' 
        ' PenangananBullyingToolStripMenuItem
        ' 
        PenangananBullyingToolStripMenuItem.Name = "PenangananBullyingToolStripMenuItem"
        PenangananBullyingToolStripMenuItem.Size = New Size(229, 26)
        PenangananBullyingToolStripMenuItem.Text = "Penanganan Bullying"
        ' 
        ' EDUKASIToolStripMenuItem
        ' 
        EDUKASIToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PengertianBullyingToolStripMenuItem, JenisjenisBullyingToolStripMenuItem, DampakBullyingToolStripMenuItem, HakSebagaiKorbanToolStripMenuItem, CaraMencegahBullyingToolStripMenuItem, WhatShouldIDoToolStripMenuItem, KontakPelaporanToolStripMenuItem})
        EDUKASIToolStripMenuItem.Name = "EDUKASIToolStripMenuItem"
        EDUKASIToolStripMenuItem.Size = New Size(83, 24)
        EDUKASIToolStripMenuItem.Text = "EDUKASI"
        ' 
        ' PengertianBullyingToolStripMenuItem
        ' 
        PengertianBullyingToolStripMenuItem.Name = "PengertianBullyingToolStripMenuItem"
        PengertianBullyingToolStripMenuItem.Size = New Size(252, 26)
        PengertianBullyingToolStripMenuItem.Text = "Pengertian Bullying"
        ' 
        ' JenisjenisBullyingToolStripMenuItem
        ' 
        JenisjenisBullyingToolStripMenuItem.Name = "JenisjenisBullyingToolStripMenuItem"
        JenisjenisBullyingToolStripMenuItem.Size = New Size(252, 26)
        JenisjenisBullyingToolStripMenuItem.Text = "Jenis-jenis Bullying"
        ' 
        ' DampakBullyingToolStripMenuItem
        ' 
        DampakBullyingToolStripMenuItem.Name = "DampakBullyingToolStripMenuItem"
        DampakBullyingToolStripMenuItem.Size = New Size(252, 26)
        DampakBullyingToolStripMenuItem.Text = "Dampak Bullying"
        ' 
        ' HakSebagaiKorbanToolStripMenuItem
        ' 
        HakSebagaiKorbanToolStripMenuItem.Name = "HakSebagaiKorbanToolStripMenuItem"
        HakSebagaiKorbanToolStripMenuItem.Size = New Size(252, 26)
        HakSebagaiKorbanToolStripMenuItem.Text = "Hak Sebagai Korban"
        ' 
        ' CaraMencegahBullyingToolStripMenuItem
        ' 
        CaraMencegahBullyingToolStripMenuItem.Name = "CaraMencegahBullyingToolStripMenuItem"
        CaraMencegahBullyingToolStripMenuItem.Size = New Size(252, 26)
        CaraMencegahBullyingToolStripMenuItem.Text = "Cara Mencegah Bullying"
        ' 
        ' WhatShouldIDoToolStripMenuItem
        ' 
        WhatShouldIDoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SaatMengalamiBullyingToolStripMenuItem, SaatMelihatBullyingToolStripMenuItem})
        WhatShouldIDoToolStripMenuItem.Name = "WhatShouldIDoToolStripMenuItem"
        WhatShouldIDoToolStripMenuItem.Size = New Size(252, 26)
        WhatShouldIDoToolStripMenuItem.Text = "What Should I do?"
        ' 
        ' SaatMengalamiBullyingToolStripMenuItem
        ' 
        SaatMengalamiBullyingToolStripMenuItem.Name = "SaatMengalamiBullyingToolStripMenuItem"
        SaatMengalamiBullyingToolStripMenuItem.Size = New Size(257, 26)
        SaatMengalamiBullyingToolStripMenuItem.Text = "Saat Mengalami Bullying"
        ' 
        ' SaatMelihatBullyingToolStripMenuItem
        ' 
        SaatMelihatBullyingToolStripMenuItem.Name = "SaatMelihatBullyingToolStripMenuItem"
        SaatMelihatBullyingToolStripMenuItem.Size = New Size(257, 26)
        SaatMelihatBullyingToolStripMenuItem.Text = "Saat Melihat Bullying"
        ' 
        ' KontakPelaporanToolStripMenuItem
        ' 
        KontakPelaporanToolStripMenuItem.Name = "KontakPelaporanToolStripMenuItem"
        KontakPelaporanToolStripMenuItem.Size = New Size(252, 26)
        KontakPelaporanToolStripMenuItem.Text = "Kontak Pelaporan"
        ' 
        ' FORUMToolStripMenuItem
        ' 
        FORUMToolStripMenuItem.Name = "FORUMToolStripMenuItem"
        FORUMToolStripMenuItem.Size = New Size(73, 24)
        FORUMToolStripMenuItem.Text = "FORUM"
        ' 
        ' KONSULTASIToolStripMenuItem
        ' 
        KONSULTASIToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RekomendasiPsikologToolStripMenuItem})
        KONSULTASIToolStripMenuItem.Name = "KONSULTASIToolStripMenuItem"
        KONSULTASIToolStripMenuItem.Size = New Size(106, 24)
        KONSULTASIToolStripMenuItem.Text = "KONSULTASI"
        ' 
        ' RekomendasiPsikologToolStripMenuItem
        ' 
        RekomendasiPsikologToolStripMenuItem.Name = "RekomendasiPsikologToolStripMenuItem"
        RekomendasiPsikologToolStripMenuItem.Size = New Size(241, 26)
        RekomendasiPsikologToolStripMenuItem.Text = "Rekomendasi Psikolog"
        ' 
        ' ABOUTToolStripMenuItem
        ' 
        ABOUTToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SiapaKitaToolStripMenuItem, ToolStripMenuItem2})
        ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        ABOUTToolStripMenuItem.Size = New Size(71, 24)
        ABOUTToolStripMenuItem.Text = "ABOUT"
        ' 
        ' SiapaKitaToolStripMenuItem
        ' 
        SiapaKitaToolStripMenuItem.Name = "SiapaKitaToolStripMenuItem"
        SiapaKitaToolStripMenuItem.Size = New Size(227, 26)
        SiapaKitaToolStripMenuItem.Text = "Siapa Kita"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(227, 26)
        ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        ' 
        ' btnJoinUs
        ' 
        btnJoinUs.AutoSize = True
        btnJoinUs.BackColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        btnJoinUs.BackgroundImageLayout = ImageLayout.None
        btnJoinUs.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnJoinUs.ForeColor = Color.WhiteSmoke
        btnJoinUs.Location = New Point(110, 623)
        btnJoinUs.Name = "btnJoinUs"
        btnJoinUs.Size = New Size(151, 48)
        btnJoinUs.TabIndex = 1
        btnJoinUs.Text = "Join US"
        btnJoinUs.UseVisualStyleBackColor = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(79), CByte(111), CByte(82))
        btnLogin.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(355, 623)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(171, 48)
        btnLogin.TabIndex = 19
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkCyan
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1319, 724)
        Controls.Add(btnLogin)
        Controls.Add(btnJoinUs)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Paluhangku"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnJoinUs As Button
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BERITAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDUKASIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FORUMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KONSULTASIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents KasusBullyingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenangananBullyingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengertianBullyingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JenisjenisBullyingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DampakBullyingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HakSebagaiKorbanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CaraMencegahBullyingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhatShouldIDoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaatMengalamiBullyingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaatMelihatBullyingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KontakPelaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RekomendasiPsikologToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiapaKitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLogin As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem

End Class
