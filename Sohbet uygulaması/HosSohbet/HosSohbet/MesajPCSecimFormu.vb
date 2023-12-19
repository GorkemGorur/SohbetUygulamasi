Imports System.Net

Public Class MesajPCSecimFormu
    Public TaramaYap As Boolean = True
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If IpAdresimCBox.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen IP Adresi Seçimi Yapınız.", "Eksik Veri Girişi")
            Exit Sub
        End If
        Dim IPAdresimiz, BilgisayarAdimiz, TakmaAdimiz, KarsiPC, KarsiPCIPAdres As String
        IPAdresimiz = IpAdresimCBox.SelectedItem.ToString
        BilgisayarAdimiz = BilgisayarAdiTBox.Text
        TakmaAdimiz = TakmaAdTBox.Text.Trim
        If TakmaAdimiz.Length < 3 Then
            MessageBox.Show("Lütfen En Az 3 Karakterlik Bir Takma Ad Belirleyiniz.", "Eksik Veri Girişi")
            TakmaAdTBox.Select()
            Exit Sub
        End If

        KarsiPC = MesajlasilacakPCCBox.Text.Trim
        If KarsiPC.Length < 1 Then
            MessageBox.Show("Lütfen Mesajlaşmak istediğiniz PC'yi seçiniz veya yazınız.", "Eksik Veri Girişi")
            MesajlasilacakPCCBox.Select()
            Exit Sub
        End If
        Try
            Dim KPCAdresleri() As IPAddress = Dns.GetHostByName(KarsiPC).AddressList
            Dim UcBlok As String = IPAdresimiz.Substring(0, IPAdresimiz.LastIndexOf(".") + 1)

            For Each Adres As IPAddress In KPCAdresleri
                If Adres.ToString.StartsWith(UcBlok) Then
                    KarsiPCIPAdres = Adres.ToString
                    Exit For
                End If
            Next
            If Not String.IsNullOrEmpty(KarsiPCIPAdres) Then
                AnaForm.IPAdresimiz = IPAdresimiz
                AnaForm.BilgisayarAdimiz = BilgisayarAdimiz
                AnaForm.TakmaAdimiz = TakmaAdimiz
                AnaForm.KarsiPC = KarsiPC
                AnaForm.KarsiPCIPAdres = KarsiPCIPAdres
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub MesajPCSecimFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IpAdresimCBox.Items.Clear()
        IpAdresimCBox.Items.AddRange(ipAdreslerimiGetir)
        If IpAdresimCBox.Items.Count > 0 Then
            IpAdresimCBox.SelectedIndex = 0
        End If
        BilgisayarAdiTBox.Text = Dns.GetHostName
        Cursor.Current = Cursors.WaitCursor
        MesajlasilacakPCleriGetir()
        Cursor.Current = Cursors.Default
        Me.Activate()
    End Sub
    Private Function ipAdreslerimiGetir()
        Dim BilgisayarAdim As String = Dns.GetHostName
        'Dns.GetHostAddresses(BilgisayarAdim)'İP V6 adresinide getirir
        Dim ipAdreslerim() As IPAddress = Dns.GetHostByName(BilgisayarAdim).AddressList
        Return ipAdreslerim
    End Function
    Private Sub MesajlasilacakPCleriGetir()
        If TaramaYap Then
            Dim Bilgisayarlar() As AgBilgisayari = AgBilgisayari.YerelAgiGetir()
            MesajlasilacakPCCBox.Items.Clear()
            For Each Bilgisayar As AgBilgisayari In Bilgisayarlar
                MesajlasilacakPCCBox.Items.Add(Bilgisayar.PCAd)
            Next
        End If
    End Sub

    Private Sub YenileBtn_Click(sender As Object, e As EventArgs) Handles YenileBtn.Click
        Cursor.Current = Cursors.WaitCursor
        MesajlasilacakPCleriGetir()
        Cursor.Current = Cursors.Default
    End Sub
End Class
