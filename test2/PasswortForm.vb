Public Class PasswortForm

    Sub AssertAreEqual(actual As Integer, expected As Integer)
        If actual <> expected Then
            Throw New InvalidOperationException("actual does not equal expected")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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
        TextBox1.Clear()

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
                TextBox1.Text = TextBox1.Text & Zahl2 & Symbol1
            Else
                TextBox1.Text = TextBox1.Text & Text & Symbol2
            End If

        Next

    End Sub

    ''' <summary>
    ''' Generiert ein Passwort der Länge des übergebenen Parameters Länge.
    ''' </summary>
    ''' <param name="Länge">Die Länge des Passworts.</param>
    Function GenerierePasswort(Länge As Integer) As String

        Dim Passwort As String = TextBox1.Text

        Return Passwort
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Texbox 3 zum Verwendungszweck und Textbox4 die Speicherliste
        Dim NeueZeile As String 'vb "vbCrLf"
        Dim Verwendungszweck As String = TextBox3.Text

        'For SchleifeSpeichern As Integer = 0 To 10

        'TextBox2.Text = TextBox3.Text & ": " & TextBox1.Text

        If TextBox3.Text = "" Then
            MessageBox.Show("Gebe einen Verwendungszweck ein!")
        Else

            NeueZeile = vbCrLf

            TextBox2.Text = TextBox2.Text & Verwendungszweck & ": " & TextBox1.Text & NeueZeile

            FileIO.FileSystem.WriteAllText("Testdatei.txt", vbCrLf, True)

            Dim benutzer As String = CurrentData.UserName
            Dim passwort As String = CurrentData.Password
            Dim encrypted As Byte() = CurrentData.Encrypt(TextBox2.Text, passwort)

            'FileIO.FileSystem.WriteAllText("Neu", vbCrLf, True)

            'FileIO.FileSystem.WriteAllBytes(IO.Path.Combine("Neu", benutzer & ".pwd"), encrypted, False)
        End If

    End Sub

    Sub BeispielFürVerschlüsselung()
        Dim Dateiname As String = "Testdatei.txt"
        Dim Passwort As String = FileIO.FileSystem.ReadAllText("Testdatei.txt")
        Dim VerschlüsselteBytes As Byte()
        Dim Entschlüsselt As String
        Dim WiederVerschlüsselteBytes As Byte()

        'datei einlesen
        If FileIO.FileSystem.FileExists(Dateiname) Then
            VerschlüsselteBytes = FileIO.FileSystem.ReadAllBytes(Dateiname)

            'inhalt entschlüsseln
            Entschlüsselt = CurrentData.Decrypt(VerschlüsselteBytes, Passwort)
        Else
            Entschlüsselt = "Textdatei.txt"  'erstmal steht kein inhalt drin
        End If

        'neuen inhalt zuweisen (alter inhalt + neue zeile + neuen inhalt)
        Entschlüsselt = Entschlüsselt & vbCrLf & TextBox2.Text

        'inhalt verschlüsseln
        WiederVerschlüsselteBytes = CurrentData.Encrypt(Entschlüsselt, Passwort)

        'neuen verschlüsselten inhalt wieder schreiben (kein append = true, sondern False, da wir den Inhalt komplett neu schreibne wollen)
        FileIO.FileSystem.WriteAllBytes(Dateiname, WiederVerschlüsselteBytes, False)

        TextBox2.Text = Entschlüsselt

    End Sub
    'FileIO.FileSystem.WriteAllText("C:\Users\arnomatz\Documents\GepeichertePasswörter.txt", TextBox2.Text, False)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BeispielFürVerschlüsselung()



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
        Dim filePath As String = IO.Path.Combine("Neu", benutzer & ".pwd")
        Dim ausgelesenerText As String
        Dim encryptedBytes As Byte()

        Debug.WriteLine(filePath)

        If FileIO.FileSystem.FileExists(filePath) Then
            encryptedBytes = FileIO.FileSystem.ReadAllBytes(filePath)
            Debug.WriteLine("Datei existiert")

            Try
                ausgelesenerText = CurrentData.Decrypt(encryptedBytes, passwort)
                TextBox2.Text = ausgelesenerText
            Catch ex As Exception
                MessageBox.Show("Falsches Passwort oder Datei beschädigt!")
                Environment.Exit(0)
            End Try
        Else
            Debug.WriteLine("Datei existiert nict!!!")
        End If



    End Sub

    Private Sub PasswortForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Environment.Exit(0)
    End Sub
End Class