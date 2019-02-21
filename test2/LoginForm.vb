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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function IstLoginGülit(Benutzername As String, Passwort As String) As Boolean

        Select Case Benutzername
            Case "A"
                If Passwort = "B" Then

                    Return True
                End If

            Case "B"
                If Passwort = "C" Then

                    Return True

                End If

            Case "C"
                If Passwort = "D" Then

                    Return True

                End If

        End Select
    End Function




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Benutzername As String
        Dim Passwort As String
        Dim Program As String



        Benutzername = TextBox1.Text
        Passwort = TextBox2.Text

        CurrentData.UserName = Benutzername
        CurrentData.Password = Passwort

        Select Case Benutzername
            Case "A"
                If Passwort = "B" Then
                    PasswortForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Der Benutzernahme oder das Passwort ist falsch!")
                End If



            Case "B"
                If Passwort = "C" Then
                    PasswortForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Der Benutzernahme oder das Passwort ist falsch!")
                End If

            Case "C"
                If Passwort = "D" Then
                    PasswortForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Der Benutzernahme oder das Passwort ist falsch!")
                End If

            Case Else
                MessageBox.Show("Der Benutzernahme oder das Passwort ist falsch!")

        End Select



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
