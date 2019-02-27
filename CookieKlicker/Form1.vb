Public Class Form1

    Private Zähler As Integer = 0
    Private ChromeUpdgrades As Integer = 0
    Dim PreisChrome As Integer = 10
    Dim Money As Integer
    Dim PreisCleanMaster As Integer = 1
    Dim CleanMasterUpgrades As Integer = 0
    Dim WahrscheinlichkeitVirus As Double = 0.5
    Dim InsgesamtesGeld As Integer = 0


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.MouseDown

        InsgesamtesGeld = InsgesamtesGeld + 1
        Zähler = Zähler + 1

        Zählerbox.Text = Zähler

    End Sub

    Private Sub KaufenChormeButton_Click(sender As Object, e As EventArgs) Handles KaufenChormeButton.Click

        If Zähler >= PreisChrome Then
            Zähler = Zähler - PreisChrome
            ChromeUpdgrades = ChromeUpdgrades + 1
            Zählerbox.Text = Zähler
            PreisChrome = PreisChrome * 1.5
            KostenChormeLabel.Text = "- Kosten: " & PreisChrome & "$"
            ChromeLevelLabel.Text = "Level: " & ChromeUpdgrades
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ChromeUpdgrades > 0 Then 'mindestens ein chrome upgrade
            Zähler = Zähler + ChromeUpdgrades * 1
            InsgesamtesGeld = InsgesamtesGeld + ChromeUpdgrades * 1
        End If
        Zählerbox.Text = Zähler

        KaufenChormeButton.Enabled = PreisChrome <= Zähler

    End Sub

    Private Sub KaufenCleanMasterButton_Click(sender As Object, e As EventArgs) Handles KaufenCleanMasterButton.Click

        If Zähler < PreisCleanMaster Then
            MessageBox.Show("Du benötigst: " & PreisCleanMaster & "$!")
        End If

        If Zähler >= PreisCleanMaster Then
            Zähler = Zähler - PreisCleanMaster
            CleanMasterUpgrades = CleanMasterUpgrades + 1
            PreisCleanMaster = PreisCleanMaster * 1.5
            CleanmasterPreisLabel.Text = "- Kosten: " & PreisCleanMaster & "$"
            CleanMasterLevelLabel.Text = "Level: " & CleanMasterUpgrades



        End If

    End Sub

End Class
