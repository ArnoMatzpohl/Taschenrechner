Public Class Form1




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

        Dim Schleife As Integer

        Dim RandomZahl1 As New Random()

        Randomize()
        TextBox1.Clear()

        For Hauptschleife As Integer = 1 To 30

            Dim Zahl2 As Integer
            Dim RandomZahl As Integer
            Dim Text As String

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

            Zahl2 = RandomZahl1.Next(0, 10)

            'TextBox1.Text = TextBox1.Text & Zahl2

            'Next

            Dim RandomZahl2 As Integer = RandomZahl1.Next(1, 3)
            'es soll entweder eine Zahl oder ein buchstabe ausgewählt werden und in die texbox eingefügt werden 
            If RandomZahl2 = 1 Then
                TextBox1.Text = TextBox1.Text & Zahl2
            Else
                TextBox1.Text = TextBox1.Text & Text
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

        NeueZeile = vbCrLf

        TextBox2.Text = TextBox2.Text & Verwendungszweck & ": " & TextBox1.Text & NeueZeile



        FileIO.FileSystem.WriteAllText("C:\Users\arnomatz\Documents\GepeichertePasswörter.txt", TextBox2.Text, False)

        ' Next






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ausgelesenerText As String = FileIO.FileSystem.ReadAllText("C:\Users\arnomatz\Documents\GepeichertePasswörter.txt")

        TextBox2.Text = ausgelesenerText

    End Sub

End Class