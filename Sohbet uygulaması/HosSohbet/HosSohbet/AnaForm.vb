Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Public Class AnaForm
    Public IPAdresimiz, BilgisayarAdimiz, TakmaAdimiz, KarsiPC, KarsiPCIPAdres As String
    Private Dinleyici As TcpListener
    Private Kanal As Thread
    Private Sub AnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MesajPCSecimFormu.ShowDialog = DialogResult.OK Then
            IPAdresLbl.Text = String.Format("IP Adresiniz: {0}", IPAdresimiz)
            TakmaAdLbl.Text = String.Format("Takma Adınız: {0}", TakmaAdimiz)
            'Sunucu Tarafı*********************
            Kanal = New Thread(AddressOf Dinle)
            Kanal.Priority = ThreadPriority.Normal
            Kanal.Start()
            '**********************************
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TakmaAdıVeyaMesajlaşılacakPCyiDeğiştirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TakmaAdıVeyaMesajlaşılacakPCyiDeğiştirToolStripMenuItem.Click
        MesajPCSecimFormu.TaramaYap = False
        MesajPCSecimFormu.ShowDialog(Me)
    End Sub
    'İstemci Tarafı*********************
    Private Sub GonderBtn_Click(sender As Object, e As EventArgs) Handles GonderBtn.Click
        Try
            Dim Mesaj As String = BenimMesajHEC.InnerHtml.Trim
            Mesaj = String.Format("<strong>{0}:</strong> {1}", TakmaAdimiz, Mesaj)
            Dim ByteMesaj() As Byte = Encoding.UTF8.GetBytes(Mesaj)
            Dim TCPistemci As New TcpClient(KarsiPCIPAdres, 15000)
            Dim Akar As NetworkStream = TCPistemci.GetStream
            If Akar.CanWrite Then
                Akar.Write(ByteMesaj, 0, ByteMesaj.Count)
                Mesaj = String.Format("<p><strong>Ben_</strong>{0}</p>", Mesaj)
                MesajlarHEC.InnerHtml &= Mesaj
                BenimMesajHEC.InnerHtml = String.Empty
                BenimMesajHEC.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Hata oluştur, Hata: " & ex.Message, "Hata")
        End Try
    End Sub
    '**********************************

    'Sunucu Tarafı*********************
    Private Sub Dinle()
        Try
            Dim IP_Adresim As IPAddress = IPAddress.Parse(IPAdresimiz)
            Dinleyici = New TcpListener(IP_Adresim, 15000)
            Dinleyici.Start()
            Dim TCPistemci As TcpClient
            Dim GelenMesaj As String = String.Empty
            While True
                TCPistemci = Dinleyici.AcceptTcpClient
                Dim Akar As NetworkStream = TCPistemci.GetStream
                If Akar.CanRead Then
                    Dim Okunan(TCPistemci.ReceiveBufferSize) As Byte
                    Akar.Read(Okunan, 0, Okunan.Count)
                    GelenMesaj = Encoding.UTF8.GetString(Okunan)
                    SetText(GelenMesaj)
                End If
            End While
        Catch
        End Try
    End Sub
    Delegate Sub SetTextCallBack([Text] As String)
    Private Sub SetText(Text As String)
        If MesajlarHEC.InvokeRequired Then
            Dim D As New SetTextCallBack(AddressOf SetText)
            Me.Invoke(D, New Object() {[Text]})
        Else
            MesajlarHEC.InnerHtml &= String.Format("<p>{0}</p>", [Text])
        End If
    End Sub

    Private Sub AnaForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dinleyici.Stop()
        Kanal.Abort()
    End Sub

    '**********************************
End Class
