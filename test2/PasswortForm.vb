Public Class PasswortForm

    Sub AssertAreEqual(actual As Integer, expected As Integer)
        If actual <> expected Then
            Throw New InvalidOperationException("actual does not equal expected")
        End If
    End Sub

    Private Sub NeuesPasswortGenerierenButton_Click(sender As Object, e As EventArgs) Handles NeuesPasswortGenerierenButton.Click

        ' AssertAreEqual(GenerierePasswort(10).Length, 10)
        ' AssertAreEqual(GenerierePasswort(15).Length, 15)

        Dim Haus As String
        Dim Baum As String
        Dim Auto As String

        Haus = "Hallo"
        Baum = "Welt"

        Auto = Haus & "!" & Baum
        Auto = Auto & "!"

        Dim RandomZahl1 As New Random()

        Randomize()
        PasswortBox.Clear()

        For Hauptschleife As Integer = 1 To 20

            Dim Zahl2 As Integer
            Dim RandomZahl As Integer
            Dim Text As String
            Dim Symbol1 As String
            Dim Symbol2 As String
            'For Schleife2 As Long = 1 To Long.MaxValue
            Dim Zahl1 As Integer = RandomZahl1.Next(65, 91)

            Text = Chr(Zahl1)

            RandomZahl = RandomZahl1.Next(1, 3)

            If RandomZahl = 1 Then
                Text = Text.ToLower
            End If

            'TextBox1.Text = TextBox1.Text & Text

            'Next

            ' For SchleifeZahlen As Integer = 0 To 15

            Dim SymboleRandom As Integer = RandomZahl1.Next(36, 39)

            Symbol1 = Chr(SymboleRandom)

            Dim SymboleRandom2 As Integer = RandomZahl1.Next(40, 44)

            Symbol2 = Chr(SymboleRandom)

            'TextBox1.Text = TextBox1.Text & Zahl2

            'Next

            ' Select Case RandomZahl2 = RandomZahl1.Next(1, 4)
            'Case = 1
            '
            'Case = 2
            '
            ' Case Else
            ' TextBox1.Text = TextBox1.Text & Symbol

            'End Select

            Dim RandomZahl2 As Integer = RandomZahl1.Next(1, 3)
            'es soll entweder eine Zahl oder ein buchstabe ausgewählt werden und in die texbox eingefügt werden 
            If RandomZahl2 = 1 Then
                PasswortBox.Text = PasswortBox.Text & Zahl2 & Symbol1
            Else
                PasswortBox.Text = PasswortBox.Text & Text & Symbol2
            End If

        Next

    End Sub

    ''' <summary>
    ''' Generiert ein Passwort der Länge des übergebenen Parameters Länge.
    ''' </summary>
    ''' <param name="Länge">Die Länge des Passworts.</param>
    Function GenerierePasswort(Länge As Integer) As String

        Dim Passwort As String = PasswortBox.Text

        Return Passwort
    End Function

    Private Sub SpeichernButton_Click(sender As Object, e As EventArgs) Handles SpeichernButton.Click

        'Texbox 3 zum Verwendungszweck und Textbox4 die Speicherliste
        Dim NeueZeile As String 'vb "vbCrLf"
        Dim Verwendungszweck As String = VerwendungsBox.Text
        Dim DateiPfadFürBenutzer As String

        'For SchleifeSpeichern As Integer = 0 To 10

        'TextBox2.Text = TextBox3.Text & ": " & TextBox1.Text

        If VerwendungsBox.Text = "" Then
            MessageBox.Show("Gebe einen Verwendungszweck ein!")

        Else
            NeueZeile = vbCrLf
            GepeichertePasswörterBox.Text = GepeichertePasswörterBox.Text & Verwendungszweck & ": " & PasswortBox.Text & NeueZeile

            Dim benutzer As String = CurrentData.UserName
            Dim passwort As String = CurrentData.Password

            'in encrypted steht der verschlüsselte Inhalt der "GepeichertePasswörterBox" 
            Dim encrypted As Byte() = CurrentData.Encrypt(GepeichertePasswörterBox.Text, passwort) 'die funkion Encrypt wird aufgerufen mit 2 parametern und anhand es passworts des benutzers verschlüsselt

            DateiPfadFürBenutzer = GibDateiPfadFürBenutzerZurück(benutzer)

            FileIO.FileSystem.WriteAllBytes(DateiPfadFürBenutzer, encrypted, True)
        End If

    End Sub

    Sub BeispielFürVerschlüsselung()
        Dim Dateiname As String = "Testdatei.txt"
        Dim Passwort As String = "mein geheimes Passwort"
        Dim VerschlüsselteBytes As Byte()
        Dim Entschlüsselt As String
        Dim WiederVerschlüsselteBytes As Byte()

        'datei einlesen
        If FileIO.FileSystem.FileExists(Dateiname) Then
            VerschlüsselteBytes = FileIO.FileSystem.ReadAllBytes(Dateiname)

            'inhalt entschlüsseln
            Entschlüsselt = CurrentData.Decrypt(VerschlüsselteBytes, Passwort)
        Else
            Entschlüsselt = ""  'erstmal steht kein inhalt drin
        End If

        'neuen inhalt zuweisen (alter inhalt + neue zeile + neuen inhalt)
        Entschlüsselt = Entschlüsselt & vbCrLf & GepeichertePasswörterBox.Text

        'inhalt verschlüsseln
        WiederVerschlüsselteBytes = CurrentData.Encrypt(Entschlüsselt, Passwort)

        'neuen verschlüsselten inhalt wieder schreiben (kein append = true, sondern False, da wir den Inhalt komplett neu schreibne wollen)
        FileIO.FileSystem.WriteAllBytes(Dateiname, WiederVerschlüsselteBytes, False)

        GepeichertePasswörterBox.Text = Entschlüsselt

    End Sub
    'FileIO.FileSystem.WriteAllText("C:\Users\arnomatz\Documents\GepeichertePasswörter.txt", TextBox2.Text, False)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' BeispielFürVerschlüsselung()

        'Dim eingebenesPasswort As String

        'Do

        ' eingebenesPasswort = InputBox("Bitte gib dein Passwort ein: ", "Passwort-Generator-SECURITY", "", 0, 0)

        ' If eingebenesPasswort = "a" Then
        ' Exit Do
        '  Else
        '         Environment.Exit(0)
        ' End If
        ' Loop

        ''Do

        ''    eingebenesPasswort = InputBox("Bitte gib dein Passwort ein: ", "Passwort-Generator-SECURITY", "", 0, 0)

        ''Loop Until eingebenesPasswort = "Hallo"

        'Do
        '    eingebenesPasswort = InputBox("Bitte gib dein Passwort ein", "SECURITY", "password", 0, 0)

        'Loop While eingebenesPasswort <> "Hallo" '<> = Ungleich

        'Do While eingebenesPasswort <> "Hallo"
        '    eingebenesPasswort = InputBox("Bitte gib dein Passwort ein", "SECURITY", "password", 0, 0)
        'Loop

        ' Dim ausgelesenerText As String = FileIO.FileSystem.ReadAllText("C:\Users\arnomatz\Documents\GepeichertePasswörter.txt")

        'TextBox2.Text = FileIO.FileSystem.ReadAllText("Neu")

        Dim benutzer As String = CurrentData.UserName
        Dim passwort As String = CurrentData.Password
        Dim DateiPfadFürBenutzer As String = GibDateiPfadFürBenutzerZurück(benutzer)
        Dim ausgelesenerText As String
        Dim encryptedBytes As Byte()

        Debug.WriteLine(DateiPfadFürBenutzer)

        If FileIO.FileSystem.FileExists(DateiPfadFürBenutzer) Then
            'auslesen der verschlüsselten Datei des Benutzers
            encryptedBytes = FileIO.FileSystem.ReadAllBytes(DateiPfadFürBenutzer)
            Debug.WriteLine("Datei existiert")

            Try
                ausgelesenerText = CurrentData.Decrypt(encryptedBytes, passwort)
                GepeichertePasswörterBox.Text = ausgelesenerText
            Catch ex As Exception
                MessageBox.Show("Falsches Passwort oder Datei beschädigt!")
                Environment.Exit(0)
            End Try
        Else
            Debug.WriteLine("Datei existiert nicht!!!")
        End If

    End Sub

    Function GibDateiPfadFürBenutzerZurück(Benutzernamen As String) As String
        'wenn das verzeichnis NICHT existiert
        If FileIO.FileSystem.DirectoryExists("Passwortdateien") = False Then
            'erzeuge Verzeichnis
            FileIO.FileSystem.CreateDirectory("Passwortdateien")
        End If

        'das ist der Ordner "Passwortdateien" und die Datei mit Namen der Variablen "Benutzername" und ".pwd" als Dateiendung
        Return IO.Path.Combine("Passwortdateien", Benutzernamen & ".pwd")
    End Function

    Private Sub PasswortForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Environment.Exit(0)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("http://www.enmanosdenadie.com.ar/wp-content/uploads/2009/11/ie-trash.png")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://www.upguard.com/hs-fs/hubfs/UpGuard/blogimages/flashisbad.png?width=691&name=flashisbad.png")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("https://techboomers.com/wp-content/uploads/2018/07/facebook-in-trash-1.png")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("https://www.tagesspiegel.de/images/neuland4_nerdcore/8376588/3-format3001.jpg")
    End Sub
End Class