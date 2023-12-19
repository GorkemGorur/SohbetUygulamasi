Imports System.Net
Imports System.DirectoryServices
'System.DirectoryServices için Project Menüsünden Add Reference dedikten sonra açılan ekrandan
'Assemblies Altındaki Framework içinden bu NameSpace'i bulduk ve ekledik
Public Class AgBilgisayari
    Private ElemanDomain As String
    Private ElemanAdi As String
    Private ElemanipAdresleri As IPAddress() = Nothing

    Public ReadOnly Property Domain As String
        Get
            Return ElemanDomain
        End Get
    End Property
    Public ReadOnly Property PCAd As String
        Get
            Return ElemanAdi
        End Get
    End Property
    Public ReadOnly Property ipAdresleri As IPAddress()
        Get
            Return ElemanipAdresleri
        End Get
    End Property
    Private Sub New(Domain As String, Ad As String)
        ElemanDomain = Domain
        ElemanAdi = Ad
        Try
            ElemanipAdresleri = Dns.GetHostAddresses(Ad)
        Catch
        End Try
    End Sub
    Public Shared Function YerelAgiGetir() As AgBilgisayari()
        Dim Liste = New List(Of AgBilgisayari)()
        Using Root = New DirectoryEntry("WinNT:")
            For Each Eleman As DirectoryEntry In Root.Children.OfType(Of DirectoryEntry)()
                Select Case Eleman.SchemaClassName
                    Case "Computer"
                        Liste.Add(New AgBilgisayari("", Eleman.Name))
                    Case "Domain"
                        Liste.AddRange(Eleman.Children.OfType(Of DirectoryEntry)().
                        Where(Function(ElemanEleman) (ElemanEleman.SchemaClassName = "Computer")).
                        Select(Function(ElemanEleman) New AgBilgisayari(Eleman.Name, ElemanEleman.Name)))
                End Select
            Next
        End Using
        Return Liste.OrderBy(Function(Eleman) Eleman.Domain).ThenBy(Function(Eleman) Eleman.ElemanAdi).ToArray
    End Function
End Class
