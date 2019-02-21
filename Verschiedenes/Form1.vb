Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Benutzername As String
        Dim Passwort As String
        Dim Program As String



        Benutzername = TextBox1.Text
        Passwort = TextBox2.Text

        If Benutzername = "A" Then
            Benutzername = 1
        End If

        If Passwort = "B" Then
            Passwort = 1
        End If

        If Benutzername = Passwort Then
            Shell("C:\Users\arnomatz\Documents\Login Passwort-Generator\test2.exe")
        End If


    End Sub
End Class
