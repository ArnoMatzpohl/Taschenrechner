
'Die "Class" Mit den Namen Loginform wird Definiert
Public Class LoginForm

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

    End Sub

    'Die Fuktion mit den NAmen "IstLoginGültig" wird Definiert
    'Aufgabe Dieser Funktion Ist eizig und allein, ausschließlich zu überprüfen ob der Login gültig ist
    Function istLoginGültig(Benutzername As String, Passwort As String) As Boolean

        Dim HashPasswort As String
        HashPasswort = BitConverter.ToString(CurrentData.HmacSha512(Passwort))

        'Dim rainbowTable As New Dictionary(Of String, String)

        'For i As Integer = 65 To 90
        '    rainbowTable(Chr(i)) = BitConverter.ToString(CurrentData.HmacSha512(Chr(i)))
        'Next


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

        Dim AlleLogins As String
        Dim LoginListe As List(Of String)
        Dim KobinierterBenutzrnameUndPasswort As String
        Dim ListeEnthältLogin As Boolean

        AlleLogins = FileIO.FileSystem.ReadAllText("login.txt")

        LoginListe = AlleLogins.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries).ToList

        KobinierterBenutzrnameUndPasswort = Benutzername & ":" & Passwort

        ListeEnthältLogin = LoginListe.Contains(KobinierterBenutzrnameUndPasswort)

        Return ListeEnthältLogin

        'AlleWörter = FileIO.FileSystem.ReadAllText("Wortliste.txt")
        ' Wörter = AlleWörter.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries).ToList

    End Function

    'PasswortForm.Show()
    'Me.Hide()
    'MessageBox.Show("Der Benutzernahme oder das Passwort ist falsch!")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Benutzername As String
        Dim Passwort As String
        Dim Program As String

        Benutzername = TextBox1.Text
        Passwort = TextBox2.Text

        CurrentData.UserName = Benutzername
        CurrentData.Password = Passwort

        'Die Funktion IstLoginGültigVonLoginDatei Wird Aufgerufen mit den Parametern Benutzername und Passwort
        'Der Rückgabewert wird überprüft ob er Wahr ist.
        'wenn das zutrifft Wird die Funktion PasswortForm.Show aufgerufen und Me.Hide()

        If istLoginGültig(Benutzername, Passwort) = True Then
            PasswortForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Der Benutzernahme oder das Passwort ist falsch!")
        End If

        Exit Sub

        'das drunter ist alles müll und kann weg (kapier eh keiner)

        Dim PasswortFürBenutzerA As String
        Dim PasswortFürBenutzerB As String
        Dim PasswortFürBenutzerC As String
        Dim BenutzernameFürBenutzerA As String
        Dim BenutzernameFürBenutzerB As String
        Dim BenutzernameFürBenutzerC As String

        If TextBox1.Text = "A" Then
            PasswortFürBenutzerA = "B"
            BenutzernameFürBenutzerA = "A"
        End If

        If TextBox1.Text = "B" Then
            PasswortFürBenutzerB = "C"
            BenutzernameFürBenutzerB = "B"
        End If

        If TextBox1.Text = "C" Then
            PasswortFürBenutzerC = "D"
            BenutzernameFürBenutzerC = "C"
        End If

        If BenutzernameFürBenutzerA = "A" Or BenutzernameFürBenutzerB = "B" Or BenutzernameFürBenutzerC = "C" Then
            BenutzernameFürBenutzerA = 1 Or BenutzernameFürBenutzerB = 1 Or BenutzernameFürBenutzerC = 1
        Else
            BenutzernameFürBenutzerA = 2 Or BenutzernameFürBenutzerB = 2 Or BenutzernameFürBenutzerC = 2

        End If

        If PasswortFürBenutzerA = TextBox2.Text Or PasswortFürBenutzerB = TextBox2.Text Or PasswortFürBenutzerC = TextBox2.Text Then
            PasswortFürBenutzerA = 1 Or PasswortFürBenutzerB = 1 Or PasswortFürBenutzerC = 1
        Else
            PasswortFürBenutzerA = 2 Or PasswortFürBenutzerB = 2 Or PasswortFürBenutzerC = 2

        End If

        If BenutzernameFürBenutzerA = 1 And PasswortFürBenutzerA = 1 Or BenutzernameFürBenutzerB = 1 And PasswortFürBenutzerB = 1 Or BenutzernameFürBenutzerC = 1 And PasswortFürBenutzerC = 1 Then
            PasswortForm.Show()
            Me.Hide()
        ElseIf BenutzernameFürBenutzerA = 2 And PasswortFürBenutzerA = 2 Or BenutzernameFürBenutzerB = 2 And PasswortFürBenutzerB = 2 Or BenutzernameFürBenutzerC = 2 And PasswortFürBenutzerC = 2 Then

            MessageBox.Show("Der Benutzernahme oder das Passwort ist falsch!")
            ' Shell("C:\Users\arnomatz\Documents\Login Passwort-Generator\test2.exe")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Environment.Exit(0)
    End Sub

End Class
