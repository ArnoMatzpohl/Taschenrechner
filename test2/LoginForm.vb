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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Benutzername As String
        Dim Passwort As String
        Dim Program As String



        Benutzername = TextBox1.Text
        Passwort = TextBox2.Text

        CurrentData.UserName = Benutzername
        CurrentData.Password = Passwort
        Dim PasswortFürBenutzerA As String
        Dim PasswortFürBenutzerB As String
        Dim PasswortFürBenutzerC As String


        If Benutzername = "A" Then
            PasswortFürBenutzerA = "B"
        End If

        If Benutzername = "B" Then
            PasswortFürBenutzerB = "C"
        End If

        If Benutzername = "C" Then
            PasswortFürBenutzerC = "D"
        End If



        If Benutzername = "A" Or Benutzername = "B" Or Benutzername = "C" Then
            Benutzername = 1
        Else
            Benutzername = 2

        End If

        If PasswortFürBenutzerA = PasswortFürBenutzerA Or PasswortFürBenutzerB = PasswortFürBenutzerB Or PasswortFürBenutzerC = PasswortFürBenutzerC Then
            Passwort = 1
        Else
            Passwort = 2


        End If

        If Benutzername = 1 And Passwort = 1 Then
            PasswortForm.Show()
            Me.Hide()
        ElseIf Benutzername = 2 And Passwort = 2 Then

            MessageBox.Show("Der Benutzernahme oder das Passwort ist falsch!")
            ' Shell("C:\Users\arnomatz\Documents\Login Passwort-Generator\test2.exe")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Environment.Exit(0)
    End Sub


End Class
