
'Die "Class" Mit den Namen Loginform wird Definiert
Public Class LoginForm

    Sub Testkrempel()
        'schritt 1: Datei Login.txt einlesen und der Variable "LoginInhalt" zuweisen
        'schritt 2: Benutzerdatei für Benutzer "A" schreiben mit dem Inhalt "VerwendungszweckA Passwort"
        'schritt 3: benutzerdatei für Benutzer "A" laden und der Variable "BenutzerDateiA" zuweisen
        'schritt 4: Benutzerdatei für Benutzer "B" schreiben mit dem Inhalt "VerwendungszweckB Passwort"
        'schritt 5: benutzerdatei für Benutzer "B" laden und der Variable "BenutzerDateiB" zuweisen

        Dim LoginInhalt As String = FileIO.FileSystem.ReadAllText("Login.txt")
        Dim BenutzerDateiA As String
        Dim BenutzerDateiB As String

        FileIO.FileSystem.WriteAllText("DateiFürBenutzerA", "VerwendungszweckA Passwort", True)
        BenutzerDateiA = FileIO.FileSystem.ReadAllText("DateiFürBenutzerA")

        FileIO.FileSystem.WriteAllText("DateiFürBenutzerB", "VerwendungszweckB Passwort", True)
        BenutzerDateiB = FileIO.FileSystem.ReadAllText("DateiFürBenutzerB")



    End Sub

    Sub BeispielFürVerschlüsselung()
        Dim Dateiname As String = "Testdatei.txt"
        Dim Passwort As String = "mein geheimes PAsswort"
        Dim VerschlüsselteBytes As Byte()
        Dim Entschlüsselt As String
        Dim WiederVerschlüsselteBytes As Byte()

        'datei einlesen
        If FileIO.FileSystem.FileExists(Dateiname) Then
            VerschlüsselteBytes = FileIO.FileSystem.ReadAllBytes(Dateiname)

            'inhalt entschlüsseln
            Entschlüsselt = CurrentData.Decrypt(VerschlüsselteBytes, Passwort)
        Else
            Entschlüsselt = "" 'erstmal steht kein inhalt drin
        End If

        'neuen inhalt zuweisen (alter inhalt + neue zeile + neuen inhalt)
        Entschlüsselt = Entschlüsselt & vbCrLf & "neues: Passwort"

        'inhalt verschlüsseln
        WiederVerschlüsselteBytes = CurrentData.Encrypt(Entschlüsselt, Passwort)

        'neuen verschlüsselten inhalt wieder schreiben (kein append = true, sondern False, da wir den Inhalt komplett neu schreibne wollen)
        FileIO.FileSystem.WriteAllBytes(Dateiname, WiederVerschlüsselteBytes, False)

    End Sub

    Sub TestKrempel2()
        'schritt 1: Datei Login.txt einlesen und der Variable "LoginInhalt" zuweisen
        'schritt 2: Benutzerdatei für Benutzer "A" schreiben mit dem Inhalt "VerwendungszweckA Passwort"
        'schritt 3: benutzerdatei für Benutzer "A" laden und der Variable "BenutzerDateiA" zuweisen
        'schritt 4: Benutzerdatei für Benutzer "B" schreiben mit dem Inhalt "VerwendungszweckB Passwort"
        'schritt 5: benutzerdatei für Benutzer "B" laden und der Variable "BenutzerDateiB" zuweisen

        Dim LoginInhalt As String = FileIO.FileSystem.ReadAllText("Login.txt")
        Dim DteiVorzeichenFürBenutzerDatei As String = "DateiFürBenutzer"
        Dim BenutzerNameA As String = "A"
        Dim BenutzerNameB As String = "B"
        Dim BenutzerDateiA As String
        Dim BenutzerDateiB As String
        'Dim Dateiname As String = DteiVorzeichenFürBenutzerDatei & BenutzerNameA
        'DateiFürBenutzerA
        FileIO.FileSystem.WriteAllText(DteiVorzeichenFürBenutzerDatei & BenutzerNameA & ".verschlüsselt", LoginInhalt, True)
        BenutzerDateiA = FileIO.FileSystem.ReadAllText(BenutzerNameA)

        'DateiFürBenutzerB
        FileIO.FileSystem.WriteAllText(DteiVorzeichenFürBenutzerDatei & BenutzerNameB & ".verschlüsselt", LoginInhalt, True)
        BenutzerDateiB = FileIO.FileSystem.ReadAllText(BenutzerNameB)

    End Sub

    Public Sub TextVerschlüsselung()
        Dim password As String = "password"
        Dim secretText As String = "Das darfst net lesen"
        Dim encryptedText As String
        Dim decryptedText As String

        Dim encrypted As Byte() = CurrentData.Encrypt(secretText, password)
        encryptedText = System.Text.Encoding.Unicode.GetString(encrypted)
        decryptedText = CurrentData.Decrypt(encrypted, "password")

    End Sub


    'Die Funktion mit den Namen "Form1_Loader" Wird Difiniert 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BeispielFürVerschlüsselung()
        'Testkrempel()
    End Sub

    'Die Fuktion mit den NAmen "IstLoginGültig" wird Definiert
    'Aufgabe Dieser Funktion Ist eizig und allein, ausschließlich zu überprüfen ob der Login gültig ist
    Function istLoginGültig(Benutzername As String, Passwort As String) As Boolean

        Dim HashPasswort As String
        HashPasswort = BitConverter.ToString(CurrentData.HmacSha512(Passwort))
        'HashPasswort = BitConverter.ToString(CurrentData.HmacSha512("3"))

        Select Case Benutzername
            Case "A"
                If HashPasswort = "94-9C-B9-F0-B6-13-A4-CD-32-8F-72-31-FF-46-77-95-C4-57-D1-56-81-37-F9-A9-EB-08-7E-8C-AC-8F-7F-BB-75-6B-21-A5-F5-91-12-FC-3E-60-B7-DE-78-08-16-4D-40-75-56-11-CD-44-DB-45-DC-ED-63-57-87-FE-74-90" Then
                    Return True
                End If

            Case "B"
                If HashPasswort = "AB-C1-62-E3-CB-30-84-A1-8F-B1-A7-44-A8-53-80-33-11-5C-8A-CD-56-06-FC-49-FF-CE-2F-B5-6B-7C-1E-12-2B-78-F2-1E-AB-2F-C2-5C-EA-EC-B2-4B-8B-10-8E-16-22-F3-73-10-43-21-57-64-E3-74-77-3B-27-1B-61-4E" Then
                    Return True
                End If

            Case "C"
                If HashPasswort = "46-5D-0A-C3-AC-F7-27-8E-05-E1-C5-16-6F-57-64-E3-95-45-D1-45-DD-F5-75-69-EF-56-74-A3-B3-7C-B9-CA-D4-88-A9-5A-A9-77-A3-C8-C8-D5-00-FB-9F-4A-63-39-13-8C-A7-16-67-FF-C7-DC-31-24-53-07-F0-E4-94-44" Then
                    Return True
                End If

        End Select
    End Function



    'Aufgabe Dieser Funktion Ist eizig und allein, ausschließlich zu überprüfen ob der Login gültig ist
    Function IstLoginGültigVonLoginDatei(Benutzername As String, Passwort As String) As Boolean '<--- Das Ist die Funktions Definition

        Dim HashPasswort As String
        HashPasswort = BitConverter.ToString(CurrentData.HmacSha512(Passwort))

        Dim AlleLogins As String
        Dim LoginListe As List(Of String)
        Dim KobinierterBenutzrnameUndPasswort As String
        Dim ListeEnthältLogin As Boolean

        AlleLogins = FileIO.FileSystem.ReadAllText("login.txt")

        LoginListe = AlleLogins.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries).ToList

        KobinierterBenutzrnameUndPasswort = Benutzername & ":" & HashPasswort

        ListeEnthältLogin = LoginListe.Contains(KobinierterBenutzrnameUndPasswort)

        Return ListeEnthältLogin

        'AlleWörter = FileIO.FileSystem.ReadAllText("Wortliste.txt")
        ' Wörter = AlleWörter.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries).ToList


    End Function

    'PasswortForm.Show()
    'Me.Hide()
    'MessageBox.Show("Der Benutzernahme oder das Passwort ist falsch!")


    'Aufgabe Dieser Funktion Ist eizig und allein, ausschließlich: das  sie überprüft ob der Benutzernam bereits vergeben ist :D. sonst nischts  



    Shared Function BenutzerExistiertSchon(Benutzername As String) As Boolean

        Dim Text As String
        Text = FileIO.FileSystem.ReadAllText("login.txt")

        Return Text.Contains(Benutzername & ":")

    End Function

    Private Sub LoginButtonClick(sender As Object, e As EventArgs) Handles LoginButton.Click



        'Mein Ziel:  Wenn die Check box ausgewählt ist dann soll das program ein Neues konto Anlegen. Ansonsten Soll es so sein wie vorher 

        Dim Benutzername As String
        Dim Passwort As String

        If BenutzerBox.Text = "" Or PasswortBox.Text = "" Then
            MessageBox.Show("Gebe einen Benutzername und ein Passwort ein!")
        Else
            If CheckBox1.Checked Then

                If BenutzerExistiertSchon(BenutzerBox.Text) = True Then
                    MessageBox.Show("Dieser Benutzername ist bereits vergebn!")
                    Exit Sub
                Else
                    Dim HashPasswort As String
                    HashPasswort = BitConverter.ToString(CurrentData.HmacSha512(PasswortBox.Text))
                    FileIO.FileSystem.WriteAllText("Login.txt", vbCrLf & BenutzerBox.Text & ":" & HashPasswort, True)
                End If


            End If



            Benutzername = BenutzerBox.Text
            Passwort = PasswortBox.Text
            CurrentData.UserName = Benutzername
            CurrentData.Password = Passwort



            'Die Funktion IstLoginGültigVonLoginDatei Wird Aufgerufen mit den Parametern Benutzername und Passwort
            'Der Rückgabewert wird überprüft ob er Wahr ist.
            'wenn das zutrifft Wird die Funktion PasswortForm.Show aufgerufen und Me.Hide()

            If IstLoginGültigVonLoginDatei(Benutzername, Passwort) = True Then
                PasswortForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Der Benutzernahme oder das Passwort ist falsch!")
            End If
        End If











        'Exit Sub

        ''das drunter ist alles müll und kann weg (kapier eh keiner)

        'Dim PasswortFürBenutzerA As String
        'Dim PasswortFürBenutzerB As String
        'Dim PasswortFürBenutzerC As String
        'Dim BenutzernameFürBenutzerA As String
        'Dim BenutzernameFürBenutzerB As String
        'Dim BenutzernameFürBenutzerC As String

        'If TextBox1.Text = "A" Then
        '    PasswortFürBenutzerA = "B"
        '    BenutzernameFürBenutzerA = "A"
        'End If

        'If TextBox1.Text = "B" Then
        '    PasswortFürBenutzerB = "C"
        '    BenutzernameFürBenutzerB = "B"
        'End If

        'If TextBox1.Text = "C" Then
        '    PasswortFürBenutzerC = "D"
        '    BenutzernameFürBenutzerC = "C"
        'End If

        'If BenutzernameFürBenutzerA = "A" Or BenutzernameFürBenutzerB = "B" Or BenutzernameFürBenutzerC = "C" Then
        '    BenutzernameFürBenutzerA = 1 Or BenutzernameFürBenutzerB = 1 Or BenutzernameFürBenutzerC = 1
        'Else
        '    BenutzernameFürBenutzerA = 2 Or BenutzernameFürBenutzerB = 2 Or BenutzernameFürBenutzerC = 2

        'End If

        'If PasswortFürBenutzerA = TextBox2.Text Or PasswortFürBenutzerB = TextBox2.Text Or PasswortFürBenutzerC = TextBox2.Text Then
        '    PasswortFürBenutzerA = 1 Or PasswortFürBenutzerB = 1 Or PasswortFürBenutzerC = 1
        'Else
        '    PasswortFürBenutzerA = 2 Or PasswortFürBenutzerB = 2 Or PasswortFürBenutzerC = 2

        'End If

        'If BenutzernameFürBenutzerA = 1 And PasswortFürBenutzerA = 1 Or BenutzernameFürBenutzerB = 1 And PasswortFürBenutzerB = 1 Or BenutzernameFürBenutzerC = 1 And PasswortFürBenutzerC = 1 Then
        '    PasswortForm.Show()
        '    Me.Hide()
        'ElseIf BenutzernameFürBenutzerA = 2 And PasswortFürBenutzerA = 2 Or BenutzernameFürBenutzerB = 2 And PasswortFürBenutzerB = 2 Or BenutzernameFürBenutzerC = 2 And PasswortFürBenutzerC = 2 Then

        '    MessageBox.Show("Der Benutzernahme oder das Passwort ist falsch!")
        '    ' Shell("C:\Users\arnomatz\Documents\Login Passwort-Generator\test2.exe")
        'End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Environment.Exit(0)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        'wenn ein der Haken gesetzt ist soll er einen neuen Benutzer anlegen wenn nicht soll er es einfach ignorieren


        Dim Check As String




        Check = CheckBox1.Checked




        'FileIO.FileSystem.WriteAllText("C:\Users\arnomatz\source\repos\Taschenrechner\test2\bin\Debug\Login.txt", vbCrLf & TextBox1.Text & ":" & TextBox2.Text, True)

        'PasswortForm.Show()
        'Me.Hide()



        'FileIO.FileSystem.WriteAllBytes(IO.Path.Combine("C:\Users\arnomatz\Documents", benutzer & ".pwd"), encrypted, False)
        'FileIO.FileSystem.WriteAllText("C:\Users\arnomatz\Documents\GepeichertePasswörter.txt", TextBox2.Text, False)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        MessageBox.Show("Der BESTE Browser den es gibt <3")
    End Sub

    '    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    '        MessageBox.Show("bestätigen Sie mit OK oder klicken sie auf das x")


    '        MessageBox.Show("
    'Herzlichen Glückwunsch, sie haben ein treffen mit dem GANZEN Schalke-Team gewonnen.
    'Sie erhalten weitere E-Mails von uns bezüglich des treffens.
    'Das Team freut sich auf das treffen mit ihnen.
    '_______________

    '-Kauf bestätigt-

    'Vielen Dank für ihren einkauf bei store.schalke04.de!
    'Ihr Fanartikel (SCHALKE SCHAL AUS BAUMWOLLE MIT ECHTGOLD PUNKTEN/ 
    'Preis 150,00,-)
    'wird so schnell wie möglich geliefert.
    'Da sie Haben den Premium Versand gewählt haben mussten wir ihnen die kosten
    'auf die Rechnung schreiben.
    'Der Kerosin Preis Beträgt zur zeit den Versands: 1.57,- pro Liter.
    'Es Werden 24.274 Liter Kerosin für den Flug benötigt.
    'Der Premiumversand kostet 38.110,18,- .
    'Vielen Dank für Ihr Verständnis.

    'Rechnung:

    '       (SCHALKE SCHAL MIT PUNKTEN                    150,00,-
    '        Premiumversand                                          38.110,18,-

    '        Endpreis:                                                        38.260,18,-


    'Mit Sportlichen Grüßen, ihr:

    'store.schalke04.de Team")




    '    End Sub
End Class
