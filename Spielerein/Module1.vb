Module Module1

    Sub Main()
        Dim Franz As String = Kleinbuchstaben1("BAUM")
        Dim Heidi As String = Kleinbuchstaben2("au")
        zeichneBisherGerateneBuchstaben(Franz, Heidi)
    End Sub

    Function Kleinbuchstaben1(BAUM As String) As String
        Return BAUM.ToLower
    End Function
    Function Kleinbuchstaben2(au As String) As String
        Return au.ToLower
    End Function

    Sub zeichneBisherGerateneBuchstaben(Wort As String, richtigeBuchstaben As String)

        For Zähler As Integer = 0 To Wort.Length - 1

            If richtigeBuchstaben.Contains(Wort(Zähler)) Then
                Console.Write(Wort(Zähler) & " ")

            Else
                Console.Write("_ ")
            End If

        Next
        Console.WriteLine()
    End Sub

    'schreibe eine funktion die nichts zurückgibt mit namen "zeichneBisherGerateneBuchstaben"
    'diese funktion enthält 2 Parameter
    'der erste heißt "Wort"
    'der zweite heißt "richtigeBuchstaben"
    'beide haben den Datentyp String
    'gibt im falle von Wort enthält buchstabe den Buchstaben aus,
    'ansonsten ein "_"




End Module
