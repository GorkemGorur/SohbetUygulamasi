<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TakmaAdLbl = New System.Windows.Forms.Label()
        Me.IPAdresLbl = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MesajlarHEC = New MSDN.Html.Editor.HtmlEditorControl()
        Me.BenimMesajHEC = New MSDN.Html.Editor.HtmlEditorControl()
        Me.GonderBtn = New System.Windows.Forms.Button()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TakmaAdıVeyaMesajlaşılacakPCyiDeğiştirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(490, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÇıkışToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 490)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(490, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TakmaAdLbl)
        Me.Panel1.Controls.Add(Me.IPAdresLbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 55)
        Me.Panel1.TabIndex = 2
        '
        'TakmaAdLbl
        '
        Me.TakmaAdLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.TakmaAdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TakmaAdLbl.Location = New System.Drawing.Point(0, 23)
        Me.TakmaAdLbl.Name = "TakmaAdLbl"
        Me.TakmaAdLbl.Size = New System.Drawing.Size(490, 23)
        Me.TakmaAdLbl.TabIndex = 1
        Me.TakmaAdLbl.Text = "Takma Adınız:"
        Me.TakmaAdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IPAdresLbl
        '
        Me.IPAdresLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.IPAdresLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.IPAdresLbl.Location = New System.Drawing.Point(0, 0)
        Me.IPAdresLbl.Name = "IPAdresLbl"
        Me.IPAdresLbl.Size = New System.Drawing.Size(490, 23)
        Me.IPAdresLbl.TabIndex = 0
        Me.IPAdresLbl.Text = "IP Adresiniz:"
        Me.IPAdresLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 79)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MesajlarHEC)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.BenimMesajHEC)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GonderBtn)
        Me.SplitContainer1.Size = New System.Drawing.Size(490, 411)
        Me.SplitContainer1.SplitterDistance = 311
        Me.SplitContainer1.TabIndex = 3
        '
        'MesajlarHEC
        '
        Me.MesajlarHEC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MesajlarHEC.InnerText = Nothing
        Me.MesajlarHEC.Location = New System.Drawing.Point(0, 0)
        Me.MesajlarHEC.Name = "MesajlarHEC"
        Me.MesajlarHEC.Size = New System.Drawing.Size(490, 311)
        Me.MesajlarHEC.TabIndex = 0
        Me.MesajlarHEC.ToolbarVisible = False
        '
        'BenimMesajHEC
        '
        Me.BenimMesajHEC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BenimMesajHEC.InnerText = Nothing
        Me.BenimMesajHEC.Location = New System.Drawing.Point(0, 0)
        Me.BenimMesajHEC.Name = "BenimMesajHEC"
        Me.BenimMesajHEC.Size = New System.Drawing.Size(421, 96)
        Me.BenimMesajHEC.TabIndex = 1
        '
        'GonderBtn
        '
        Me.GonderBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.GonderBtn.Image = Global.HosSohbet.My.Resources.Resources.MesajGonder
        Me.GonderBtn.Location = New System.Drawing.Point(421, 0)
        Me.GonderBtn.Name = "GonderBtn"
        Me.GonderBtn.Size = New System.Drawing.Size(69, 96)
        Me.GonderBtn.TabIndex = 0
        Me.GonderBtn.Text = "Gönder"
        Me.GonderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.GonderBtn.UseVisualStyleBackColor = True
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TakmaAdıVeyaMesajlaşılacakPCyiDeğiştirToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.HosSohbet.My.Resources.Resources.Degistir
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'TakmaAdıVeyaMesajlaşılacakPCyiDeğiştirToolStripMenuItem
        '
        Me.TakmaAdıVeyaMesajlaşılacakPCyiDeğiştirToolStripMenuItem.Name = "TakmaAdıVeyaMesajlaşılacakPCyiDeğiştirToolStripMenuItem"
        Me.TakmaAdıVeyaMesajlaşılacakPCyiDeğiştirToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.TakmaAdıVeyaMesajlaşılacakPCyiDeğiştirToolStripMenuItem.Text = "Takma Adı veya Mesajlaşılacak PC'yi Değiştir"
        '
        'AnaForm
        '
        Me.AcceptButton = Me.GonderBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 512)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AnaForm"
        Me.Text = "Hoş Sohbet"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TakmaAdLbl As Label
    Friend WithEvents IPAdresLbl As Label
    Friend WithEvents GonderBtn As Button
    Friend WithEvents MesajlarHEC As MSDN.Html.Editor.HtmlEditorControl
    Friend WithEvents BenimMesajHEC As MSDN.Html.Editor.HtmlEditorControl
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents TakmaAdıVeyaMesajlaşılacakPCyiDeğiştirToolStripMenuItem As ToolStripMenuItem
End Class
