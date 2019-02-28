Public Class Form1

    Private Zähler As Integer = 9999999
    Private FabrikUpgrade As Integer = 0
    Dim PreisFabrik As Integer = 1000
    Dim Money As Integer
    Dim PreisBob As Integer = 10000
    Dim BobUpgrade As Integer = 0
    Dim ZerstörungFabrikWahrscheinlichkeit As Double = 0.00001
    Dim Preisreparieren As String = 200
    Dim InsgesamtesGeld As Integer = 0
    Dim GestopptFabrik As Boolean
    Dim Drücker As Integer = 1
    Dim PreisDrücker As Integer = 5
    Dim PreisFabrik1 As Integer = 100
    Dim FabrikUpgrade1 As Integer = 0
    Dim DrückerLevel As Integer = 1
    Dim Preisfabrik3 As Integer = 500
    Dim Fabrik3Upgrade As Integer = 0
    Dim Fabrik3Level As Integer = 0
    Dim Fabrik3Geld As Integer = 0





    'Erste Fabrik
    Private Sub Fabrik1Button_Click(sender As Object, e As EventArgs) Handles Fabrik1Button.Click

        Fabrik1Button.Text = "Upgrade"

        If Zähler >= PreisFabrik1 Then
            Zähler = Zähler - PreisFabrik1
            FabrikUpgrade1 = FabrikUpgrade1 + 1
            Zählerbox.Text = Zähler
            PreisFabrik1 = PreisFabrik1 * 1.1
            KastenFabrik1Label.Text = "- Kosten: " & PreisFabrik1 & "$"
            BeschreibungFabrik1Label.Text = "- Generiert automatisch " & FabrikUpgrade1 + 1 & "$ pro sek. automatisch!"
            Fabrik1LevelLabel.Text = "Level: " & FabrikUpgrade1
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If FabrikUpgrade1 > 0 Then 'mindestens ein upgrade
            Zähler = Zähler + FabrikUpgrade1 * 1
            InsgesamtesGeld = InsgesamtesGeld + FabrikUpgrade1 * 1 '<-- Das Bringt 1 $ mehr
        End If

        Zählerbox.Text = Zähler
        Fabrik1Button.Enabled = PreisFabrik1 <= Zähler

        'reparierenButton.Enabled = BobUpgrade > 0 And Zähler > Preisreparieren And GestopptFabrik = True
        'KaufenBobButton.Enabled = FabrikUpgrade2 > 0 And Zähler > PreisBob
    End Sub

    'Spezial Fabrik

    Private Sub PictureBox1_MouseDown(sender As Object, e As EventArgs) Handles PictureBox1.MouseDown
        PictureBox1.Height = 412
        PictureBox1.Width = 406
        PictureBox1.Top = 125
        PictureBox1.Left = 137
    End Sub

    Private Sub PictureBox1_Mouseup(sender As Object, e As EventArgs) Handles PictureBox1.MouseUp
        PictureBox1.Height = 426
        PictureBox1.Width = 432
        PictureBox1.Top = 115
        PictureBox1.Left = 127
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.MouseDown

        InsgesamtesGeld = InsgesamtesGeld + Drücker
        Zähler = Zähler + Drücker

        Zählerbox.Text = Zähler

    End Sub

    Private Sub KaufenFabrikBobButton_Click(sender As Object, e As EventArgs) Handles KaufenFabrikBobButton.Click

        KaufenFabrikBobButton.Text = "Upgrade"

        If Zähler >= PreisFabrik Then
            Zähler = Zähler - PreisFabrik
            FabrikUpgrade = FabrikUpgrade + 1
            Zählerbox.Text = Zähler
            PreisFabrik = PreisFabrik * 1.3
            KostenChormeLabel.Text = "- Kosten: " & PreisFabrik & "$"
            levelFabrik2Label.Text = "Level: " & FabrikUpgrade
            Label2.Text = "- Generiert automatisch " & FabrikUpgrade * 2 & "$"
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If FabrikUpgrade > 0 Then
            If Rnd() < ZerstörungFabrikWahrscheinlichkeit Then
                GestopptFabrik = True
            End If
        End If
        If GestopptFabrik = True Then
            Nachichtlabel.Text = "Deine Fabrik ist beschädigt!
Benutze Bob um die Fabrik zu reparieren."
        Else
            If FabrikUpgrade > 0 Then 'mindestens ein chrome upgrade
                Zähler = Zähler + FabrikUpgrade * 2
                InsgesamtesGeld = InsgesamtesGeld + FabrikUpgrade * 2 '<-- Das Bringt 1 $ mehr
            End If
        End If
        Zählerbox.Text = Zähler
        KaufenFabrikBobButton.Enabled = PreisFabrik <= Zähler

        reparierenButton.Enabled = BobUpgrade > 0 And Zähler > Preisreparieren And GestopptFabrik = True
        KaufenBobButton.Enabled = FabrikUpgrade > 0 And Zähler > PreisBob
        KaufenFabrik3Button.Enabled = Zähler > Preisfabrik3
        DrückerKaufenButton.Enabled = PreisDrücker < Zähler
    End Sub

    Private Sub KaufenBobButton_Click(sender As Object, e As EventArgs) Handles KaufenBobButton.Click



        KaufenBobButton.Hide()

        If Zähler < PreisBob Then
            MessageBox.Show("Du benötigst: " & PreisBob & "$!")
        End If

        If Zähler >= PreisBob Then
            Zähler = Zähler - PreisBob
            BobUpgrade = BobUpgrade + 1
            PreisBob = PreisBob * 1.8
            BobPreisLabel.Text = "- Kosten: " & PreisBob & "$"
            BobLevelLabel.Text = "Level: " & BobUpgrade

            KaufenBobButton.Enabled = PreisBob <= Zähler

            If reparierenButton.Enabled Then
                GestopptFabrik = False
            End If

        End If

    End Sub

    Private Sub reparierenButton_Click(sender As Object, e As EventArgs) Handles reparierenButton.Click
        GestopptFabrik = False
        Nachichtlabel.Text = "Die Fabrik wurde von Bob Repariert."
    End Sub

    Private Sub DrückerKaufenButton_Click(sender As Object, e As EventArgs) Handles DrückerKaufenButton.Click



        If Zähler > PreisDrücker Then

            Zähler = Zähler - PreisDrücker
            Drücker = Drücker + 1
            PreisDrücker = PreisDrücker * 1.4
            DrückerKostenLabel.Text = "- Kostet: " & PreisDrücker & "$"
            DrückerLevel = DrückerLevel + 1
            DrückerLevelLabel.Text = "Level: " & DrückerLevel
            DrückerBeschreibungLabel.Text = "- Baim nächsen Upgrade: " & DrückerLevel + 1 & "$ pro Klick"
        End If

    End Sub

    Private Sub KaufenFabrik3Button_Click(sender As Object, e As EventArgs) Handles KaufenFabrik3Button.Click

        If KaufenFabrik3Button.Enabled Then
            Zähler = Zähler - Preisfabrik3
            Zählerbox.Text = Zähler
            Preisfabrik3 = Preisfabrik3 * 1.2
            Fabrik3Upgrade = Fabrik3Upgrade + 1
            Fabrik3Level = Fabrik3Level + 1
            LevelFabrik3Label.Text = "- Level: " & Fabrik3Level
            Fabrik3Geld = Fabrik3Level * 1.3
            KosenFabrik3Label.Text = "- Generiert" & Fabrik3Geld & "$ pro sek. automatisch!"
            KaufenFabrik3Button.Text = "Upgrade"
        End If

    End Sub
End Class
