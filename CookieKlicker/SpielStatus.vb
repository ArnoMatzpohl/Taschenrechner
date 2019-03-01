Public Class SpielStatus

    Public Zähler As Long = 0
    Public Money As Integer
    Public PreisBob As Integer = 10000
    Public BobUpgrade As Integer = 0
    Public ZerstörungFabrikWahrscheinlichkeit As Double = 0.001
    Public Preisreparieren As String = 200
    Public InsgesamtesGeld As Integer = 0
    Public GestopptFabrik As Boolean

    Public Fabrik1Preis As Integer = 100
    Public Fabrik1Upgrade As Integer = 0

    Public Fabrik2Preis As Integer = 500
    Public Fabrik2Upgrade As Integer = 0

    Public Fabrik3Preis As Integer = 1000
    Public Fabrik3Upgrade As Integer = 0

    Public DrückerPreis As Integer = 5
    Public DrückerUpgrade As Integer = 1

    Public ReperateurPreis As Integer = 6
    Public ReperateurUpgrades As Integer = 0
    Public ReperateurAbzug As Double = 0.0
    Public Counter As Integer = 0

    Private Shared Status As New SpielStatus

    Public Shared Property Instanz() As SpielStatus
        Get
            Return Status
        End Get
        Private Set(value As SpielStatus)
            Status = value
        End Set
    End Property

    Public Shared Sub NeuAnfangen()
        Instanz = New SpielStatus
    End Sub

    Public Shared Sub Speichern()
        Dim data As String = Newtonsoft.Json.JsonConvert.SerializeObject(SpielStatus.Instanz, Newtonsoft.Json.Formatting.Indented)

        FileIO.FileSystem.WriteAllText("savegame.json", data, False, New Text.UTF8Encoding(False))
    End Sub

    Public Shared Sub Laden()
        Dim data As String

        If FileIO.FileSystem.FileExists("savegame.json") Then
            data = FileIO.FileSystem.ReadAllText("savegame.json")

            Instanz = Newtonsoft.Json.JsonConvert.DeserializeObject(Of SpielStatus)(data)
        End If
    End Sub


End Class
