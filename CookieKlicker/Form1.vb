Public Class Form1




    Function Belohnung1() As Integer
        If SpielStatus.Instanz.InsgesamtesGeld > 100 Then
            Nachichtlabel.Text = "Du hast insgesamt über 100$ Verdient, hier ist
deine Belohnung:

25$ Von John erhalten!"
            SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler + 25
            SpielStatus.Instanz.InsgesamtesGeld = SpielStatus.Instanz.InsgesamtesGeld + 25

        ElseIf SpielStatus.Instanz.InsgesamtesGeld > 1000 Then
            Nachichtlabel.Text = "Du hast insgesamt über 100$ Verdient, hier ist
deine Belohnung:

100$ Von John erhalten!"
            SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler + 100
            SpielStatus.Instanz.InsgesamtesGeld = SpielStatus.Instanz.InsgesamtesGeld + 100
        ElseIf SpielStatus.Instanz.InsgesamtesGeld > 100000 Then
            Nachichtlabel.Text = "Du hast insgesamt über 100$ Verdient, hier ist
deine Belohnung:

15.000$ Von John erhalten!"
            SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler + 15000
            SpielStatus.Instanz.InsgesamtesGeld = SpielStatus.Instanz.InsgesamtesGeld + 15000
        End If





    End Function


    'Erste Fabrik
    Private Sub Fabrik1Button_Click(sender As Object, e As EventArgs) Handles Fabrik1Button.MouseUp
        Fabrik1Button.Text = "Upgrade"

        If SpielStatus.Instanz.Zähler >= SpielStatus.Instanz.Fabrik1Preis Then
            SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler - SpielStatus.Instanz.Fabrik1Preis
            SpielStatus.Instanz.Fabrik1Upgrade = SpielStatus.Instanz.Fabrik1Upgrade + 1
            Zählerbox.Text = SpielStatus.Instanz.Zähler
            SpielStatus.Instanz.Fabrik1Preis = SpielStatus.Instanz.Fabrik1Preis * 1.1
            KastenFabrik1Label.Text = "- Kosten: " & SpielStatus.Instanz.Fabrik1Preis & "$"
            BeschreibungFabrik1Label.Text = "- Generiert automatisch " & SpielStatus.Instanz.Fabrik1Upgrade + 1.15 & "$ pro sek. automatisch!"
            Fabrik1LevelLabel.Text = "Level: " & SpielStatus.Instanz.Fabrik1Upgrade
            Nachichtlabel.Text = "Glückwunsch!
Du hast deine Fabrik1 auf ein neues Level
gebrach!"
            SpielStatus.Instanz.Counter = 0
            NachichtTimer.Interval = 500
            NachichtTimer.Start()
            NachichtPictureBox.Show()
            WahrscheinlichkeitKapputBox.Text = Aktuellezerstörungswahrscheinlichkeit() * 100
            GeldProSekundebox.Text = GeldProSekunde()
        End If

    End Sub

    Private Sub KaufenFabrik2Button_Click(sender As Object, e As EventArgs) Handles KaufenFabrik2Button.MouseUp

        If SpielStatus.Instanz.Fabrik2Preis < SpielStatus.Instanz.Zähler Then
            SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler - SpielStatus.Instanz.Fabrik2Preis
            Zählerbox.Text = SpielStatus.Instanz.Zähler
            SpielStatus.Instanz.Fabrik2Preis = SpielStatus.Instanz.Fabrik2Preis * 1.2
            SpielStatus.Instanz.Fabrik2Upgrade = SpielStatus.Instanz.Fabrik2Upgrade + 1
            Fabrik2LevelLabel.Text = "- Level: " & SpielStatus.Instanz.Fabrik2Upgrade
            BeschreibungFabrik2Label.Text = "- Generiert" & SpielStatus.Instanz.Fabrik2Upgrade * 1.3 & "$ pro sek. automatisch!"
            KaufenFabrik2Button.Text = "Upgrade"
            KosenFabrik2Label.Text = "- Kostet: " & SpielStatus.Instanz.Fabrik2Preis & "$"
            Nachichtlabel.Text = "Glückwunsch!
Du hast deine Fabrik2 auf ein neues Level
gebrach!"
            SpielStatus.Instanz.Counter = 0
            NachichtTimer.Interval = 500
            NachichtTimer.Start()
            NachichtPictureBox.Show()
            WahrscheinlichkeitKapputBox.Text = Aktuellezerstörungswahrscheinlichkeit() * 100
            GeldProSekundebox.Text = GeldProSekunde()
        End If

    End Sub

    Private Sub Fabrik3KaufenButton_Click(sender As Object, e As EventArgs) Handles Fabrik3KaufenButton.MouseUp

        Fabrik3KaufenButton.Text = "Upgrade"

        If SpielStatus.Instanz.Zähler >= SpielStatus.Instanz.Fabrik3Preis Then
            SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler - SpielStatus.Instanz.Fabrik3Preis
            SpielStatus.Instanz.Fabrik3Upgrade = SpielStatus.Instanz.Fabrik3Upgrade + 1
            Zählerbox.Text = SpielStatus.Instanz.Zähler
            SpielStatus.Instanz.Fabrik3Preis = SpielStatus.Instanz.Fabrik3Preis * 1.3
            KostenFabrik3Label.Text = "- Kosten: " & SpielStatus.Instanz.Fabrik3Preis & "$"
            Fabrik3LevelLabel.Text = "Level: " & SpielStatus.Instanz.Fabrik3Upgrade
            BeschreibungFabrik3Label.Text = "- Generiert automatisch " & SpielStatus.Instanz.Fabrik3Upgrade * 2 & "$"
            WahrscheinlichkeitKapputBox.Text = Aktuellezerstörungswahrscheinlichkeit() * 100
            GeldProSekundebox.Text = GeldProSekunde()
            Nachichtlabel.Text = "Glückwunsch!
Du hast deine Fabrik3 auf ein neues Level
gebrach!"
            SpielStatus.Instanz.Counter = 0
            NachichtTimer.Interval = 500
            NachichtTimer.Start()
            NachichtPictureBox.Show()

        End If

    End Sub

    Private Sub DrückerKaufenButton_Click(sender As Object, e As EventArgs) Handles DrückerKaufenButton.MouseUp
        If SpielStatus.Instanz.Zähler > SpielStatus.Instanz.DrückerPreis Then

            SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler - SpielStatus.Instanz.DrückerPreis
            SpielStatus.Instanz.DrückerPreis = SpielStatus.Instanz.DrückerPreis * 1.4
            DrückerKostenLabel.Text = "- Kostet: " & SpielStatus.Instanz.DrückerPreis & "$"
            SpielStatus.Instanz.DrückerUpgrade = SpielStatus.Instanz.DrückerUpgrade + 1
            DrückerLevelLabel.Text = "Level: " & SpielStatus.Instanz.DrückerUpgrade
            DrückerBeschreibungLabel.Text = "- Baim nächsen Upgrade: " & SpielStatus.Instanz.DrückerUpgrade + 1 & "$ pro Klick"

            Nachichtlabel.Text = "Cursor Upgrade auf Level: " & SpielStatus.Instanz.DrückerUpgrade
            SpielStatus.Instanz.Counter = 0
            NachichtTimer.Interval = 500
            NachichtTimer.Start()
            NachichtPictureBox.Show()
        End If

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

        Belohnung1()

        SpielStatus.Instanz.InsgesamtesGeld = SpielStatus.Instanz.InsgesamtesGeld + SpielStatus.Instanz.DrückerUpgrade
        SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler + SpielStatus.Instanz.DrückerUpgrade

        Zählerbox.Text = SpielStatus.Instanz.Zähler

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If SpielStatus.Instanz.Fabrik1Upgrade > 0 Or SpielStatus.Instanz.Fabrik2Upgrade > 0 Or SpielStatus.Instanz.Fabrik3Upgrade > 0 Then
            If Rnd() < Aktuellezerstörungswahrscheinlichkeit() Then
                SpielStatus.Instanz.GestopptFabrik = True
            End If
        End If

        If SpielStatus.Instanz.GestopptFabrik = True Then
            Nachichtlabel.Text = "Deine Fabrik ist beschädigt!
Benutze Bob um die Fabrik zu reparieren."
        Else
            If SpielStatus.Instanz.Fabrik3Upgrade > 0 Then 'mindestens ein chrome upgrade
                SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler + SpielStatus.Instanz.Fabrik3Upgrade * 2
                SpielStatus.Instanz.InsgesamtesGeld = SpielStatus.Instanz.InsgesamtesGeld + SpielStatus.Instanz.Fabrik3Upgrade * 2 '<-- Das Bringt 1 $ mehr
            End If
        End If



        If SpielStatus.Instanz.GestopptFabrik = True Then
            Nachichtlabel.Text = "Deine Fabrik ist beschädigt!
Benutze Bob um die Fabrik zu reparieren."
        Else
            If SpielStatus.Instanz.Fabrik2Upgrade > 0 Then 'mindestens ein chrome upgrade
                SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler + SpielStatus.Instanz.Fabrik2Upgrade * 2
                SpielStatus.Instanz.InsgesamtesGeld = SpielStatus.Instanz.InsgesamtesGeld + SpielStatus.Instanz.Fabrik2Upgrade * 2 '<-- Das Bringt 1 $ mehr
            End If
        End If


        If SpielStatus.Instanz.GestopptFabrik = True Then
            Nachichtlabel.Text = "Deine Fabrik ist beschädigt!
Benutze Bob um die Fabrik zu reparieren."
        Else
            If SpielStatus.Instanz.Fabrik1Upgrade > 0 Then 'mindestens ein chrome upgrade
                SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler + SpielStatus.Instanz.Fabrik1Upgrade * 2
                SpielStatus.Instanz.InsgesamtesGeld = SpielStatus.Instanz.InsgesamtesGeld + SpielStatus.Instanz.Fabrik1Upgrade * 2 '<-- Das Bringt 1 $ mehr
            End If
        End If


        Zählerbox.Text = SpielStatus.Instanz.Zähler
        Fabrik3KaufenButton.Enabled = SpielStatus.Instanz.Fabrik3Preis <= SpielStatus.Instanz.Zähler

        reparierenButton.Enabled = SpielStatus.Instanz.BobUpgrade > 0 And SpielStatus.Instanz.Zähler > SpielStatus.Instanz.Preisreparieren And SpielStatus.Instanz.GestopptFabrik = True

        KaufenFabrik2Button.Enabled = SpielStatus.Instanz.Fabrik2Preis < SpielStatus.Instanz.Zähler
        DrückerKaufenButton.Enabled = SpielStatus.Instanz.DrückerPreis < SpielStatus.Instanz.Zähler
        KaufenBobButton.Enabled = SpielStatus.Instanz.Fabrik3Upgrade > 0 And SpielStatus.Instanz.Zähler > SpielStatus.Instanz.PreisBob Or SpielStatus.Instanz.Fabrik1Upgrade > 0 And SpielStatus.Instanz.Zähler > SpielStatus.Instanz.PreisBob Or SpielStatus.Instanz.Fabrik2Upgrade And SpielStatus.Instanz.Zähler > SpielStatus.Instanz.PreisBob
    End Sub

    Private Sub KaufenBobButton_Click(sender As Object, e As EventArgs) Handles KaufenBobButton.MouseUp



        KaufenBobButton.Hide()

        If SpielStatus.Instanz.Zähler < SpielStatus.Instanz.PreisBob Then
            Nachichtlabel.Text = "Du benötigst: " & SpielStatus.Instanz.PreisBob & "$!"
            SpielStatus.Instanz.Counter = 0
            NachichtTimer.Interval = 500
            NachichtTimer.Start()
            NachichtPictureBox.Show()
        End If

        If SpielStatus.Instanz.Zähler >= SpielStatus.Instanz.PreisBob Then
            SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler - SpielStatus.Instanz.PreisBob
            SpielStatus.Instanz.BobUpgrade = SpielStatus.Instanz.BobUpgrade + 1
            SpielStatus.Instanz.Counter = 0
            NachichtTimer.Interval = 500
            NachichtTimer.Start()
            NachichtPictureBox.Show()
            SpielStatus.Instanz.PreisBob = SpielStatus.Instanz.PreisBob * 1.8
            BobPreisLabel.Text = "- Kosten: " & SpielStatus.Instanz.PreisBob & "$"
            BobLevelLabel.Text = "Level: " & SpielStatus.Instanz.BobUpgrade

            Nachichtlabel.Text = "Bob wurde Gekauft!"
            SpielStatus.Instanz.Counter = 0
            NachichtTimer.Interval = 500
            NachichtTimer.Start()
            NachichtPictureBox.Show()

            KaufenBobButton.Enabled = SpielStatus.Instanz.PreisBob <= SpielStatus.Instanz.Zähler

            If reparierenButton.Enabled Then
                SpielStatus.Instanz.GestopptFabrik = False
            End If

        End If

    End Sub

    Private Sub reparierenButton_Click(sender As Object, e As EventArgs) Handles reparierenButton.Click
        SpielStatus.Instanz.GestopptFabrik = False
        Nachichtlabel.Text = "Die Fabrik wurde von Bob Repariert."
        SpielStatus.Instanz.Counter = 0
        NachichtTimer.Interval = 500
        NachichtTimer.Start()
        NachichtPictureBox.Show()
    End Sub

    Function GeldProSekunde() As Integer
        Dim GeldProSekundeInsgesamt As Integer


        GeldProSekundeInsgesamt = GeldProSekundeInsgesamt + SpielStatus.Instanz.Fabrik1Upgrade + 1.15
        GeldProSekundeInsgesamt = GeldProSekundeInsgesamt + SpielStatus.Instanz.Fabrik2Upgrade * 1.3
        GeldProSekundeInsgesamt = GeldProSekundeInsgesamt + SpielStatus.Instanz.Fabrik3Upgrade * 2

        Return GeldProSekundeInsgesamt + 1
    End Function

    Function Aktuellezerstörungswahrscheinlichkeit() As Double
        Dim Rückgabe As Double = SpielStatus.Instanz.ZerstörungFabrikWahrscheinlichkeit

        Rückgabe = Rückgabe + SpielStatus.Instanz.Fabrik1Upgrade * 0.01
        Rückgabe = Rückgabe + SpielStatus.Instanz.Fabrik2Upgrade * 0.03
        Rückgabe = Rückgabe + SpielStatus.Instanz.Fabrik3Upgrade * 0.06

        If Rückgabe > 0.8 Then
            Rückgabe = 0.8
        End If

        '0.01
        '0.03
        '0.06

        Rückgabe = Rückgabe - SpielStatus.Instanz.ReperateurAbzug

        Return Rückgabe
    End Function

    Private Sub UpgradeReperateurButton_Click(sender As Object, e As EventArgs) Handles UpgradeReperateurButton.Click

        If SpielStatus.Instanz.ReperateurPreis < SpielStatus.Instanz.Zähler Then
            SpielStatus.Instanz.ReperateurUpgrades = SpielStatus.Instanz.ReperateurUpgrades + 1
            SpielStatus.Instanz.Zähler = SpielStatus.Instanz.Zähler - SpielStatus.Instanz.ReperateurPreis
            SpielStatus.Instanz.ReperateurAbzug = SpielStatus.Instanz.ReperateurAbzug + 0.1
            SpielStatus.Instanz.ReperateurPreis = SpielStatus.Instanz.ReperateurPreis * 0.05
            WahrscheinlichkeitKapputBox.Text = Aktuellezerstörungswahrscheinlichkeit() * 100
            KostenReperateurLabel.Text = "- Kostet: " & SpielStatus.Instanz.ReperateurPreis & "$"

        End If

    End Sub

    Private Sub NachichtTimer_Tick(sender As Object, e As EventArgs) Handles NachichtTimer.Tick


        NachichtPictureBox.Visible = Not NachichtPictureBox.Visible


        SpielStatus.Instanz.Counter += 1

        If SpielStatus.Instanz.Counter > 3 Then
            NachichtTimer.Stop()
            'NachichtPictureBox.Hide()
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NachichtPictureBox.Hide()

        SpielStatus.Laden()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SpielStatus.Speichern()
    End Sub

    Private Sub SpielNeuStartenButton_Click(sender As Object, e As EventArgs) Handles SpielNeuStartenButton.Click
        SpielStatus.NeuAnfangen()
    End Sub
End Class
