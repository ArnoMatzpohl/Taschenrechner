Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class