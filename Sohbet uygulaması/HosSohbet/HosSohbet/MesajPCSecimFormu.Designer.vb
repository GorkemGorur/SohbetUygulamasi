<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MesajPCSecimFormu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IpAdresimCBox = New System.Windows.Forms.ComboBox()
        Me.BilgisayarAdiTBox = New System.Windows.Forms.TextBox()
        Me.TakmaAdTBox = New System.Windows.Forms.TextBox()
        Me.MesajlasilacakPCCBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.YenileBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(118, 131)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(215, 50)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(101, 44)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Tamam"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(110, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(102, 44)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Vazgeç"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "İP Adresiniz:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bilgisayar Adınız:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Takma Adınız:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mesajlaşılacak PC:"
        '
        'IpAdresimCBox
        '
        Me.IpAdresimCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IpAdresimCBox.FormattingEnabled = True
        Me.IpAdresimCBox.Location = New System.Drawing.Point(114, 17)
        Me.IpAdresimCBox.Name = "IpAdresimCBox"
        Me.IpAdresimCBox.Size = New System.Drawing.Size(186, 21)
        Me.IpAdresimCBox.TabIndex = 5
        '
        'BilgisayarAdiTBox
        '
        Me.BilgisayarAdiTBox.Location = New System.Drawing.Point(114, 44)
        Me.BilgisayarAdiTBox.Name = "BilgisayarAdiTBox"
        Me.BilgisayarAdiTBox.ReadOnly = True
        Me.BilgisayarAdiTBox.Size = New System.Drawing.Size(186, 20)
        Me.BilgisayarAdiTBox.TabIndex = 6
        '
        'TakmaAdTBox
        '
        Me.TakmaAdTBox.Location = New System.Drawing.Point(114, 70)
        Me.TakmaAdTBox.Name = "TakmaAdTBox"
        Me.TakmaAdTBox.Size = New System.Drawing.Size(186, 20)
        Me.TakmaAdTBox.TabIndex = 7
        '
        'MesajlasilacakPCCBox
        '
        Me.MesajlasilacakPCCBox.FormattingEnabled = True
        Me.MesajlasilacakPCCBox.Location = New System.Drawing.Point(114, 96)
        Me.MesajlasilacakPCCBox.Name = "MesajlasilacakPCCBox"
        Me.MesajlasilacakPCCBox.Size = New System.Drawing.Size(186, 21)
        Me.MesajlasilacakPCCBox.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HosSohbet.My.Resources.Resources.HosSohbetResim
        Me.PictureBox1.Location = New System.Drawing.Point(12, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'YenileBtn
        '
        Me.YenileBtn.Image = Global.HosSohbet.My.Resources.Resources.yenile
        Me.YenileBtn.Location = New System.Drawing.Point(300, 94)
        Me.YenileBtn.Name = "YenileBtn"
        Me.YenileBtn.Size = New System.Drawing.Size(27, 23)
        Me.YenileBtn.TabIndex = 9
        Me.YenileBtn.UseVisualStyleBackColor = True
        '
        'MesajPCSecimFormu
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(345, 193)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.YenileBtn)
        Me.Controls.Add(Me.MesajlasilacakPCCBox)
        Me.Controls.Add(Me.TakmaAdTBox)
        Me.Controls.Add(Me.BilgisayarAdiTBox)
        Me.Controls.Add(Me.IpAdresimCBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MesajPCSecimFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mesajlaşılacak PC Seçimi"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IpAdresimCBox As ComboBox
    Friend WithEvents BilgisayarAdiTBox As TextBox
    Friend WithEvents TakmaAdTBox As TextBox
    Friend WithEvents MesajlasilacakPCCBox As ComboBox
    Friend WithEvents YenileBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
