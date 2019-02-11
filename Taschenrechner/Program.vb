Module Program

    Sub Main()
        Console.Title = "Taschenrechner"
        Console.WriteLine("Willkommen beim Taschenrechner.")
        Console.WriteLine("Bestätige die Schritte mit Enter")

        Console.WriteLine("")
a:

        Dim Zahl1 As Integer
        Dim Zahl2 As Integer
        Dim Rechenoperation As String

        Console.WriteLine("")

        Console.WriteLine("erste Zahl eingeben...")

        Zahl1 = Console.ReadLine

        Console.WriteLine("")

        Console.WriteLine("zweite Zahl eingeben...")
        Zahl2 = Console.ReadLine

        Console.WriteLine("")

        Console.WriteLine("Addition=+")
        Console.WriteLine("Subtraktion=-")
        Console.WriteLine("Multiplikation=*")
        Console.WriteLine("Division=/")

        Console.WriteLine("")

        Console.WriteLine("Rechenoperation eingeben:")

        Console.WriteLine("")

        Rechenoperation = Console.ReadLine

        'If Rechenoperation = "+" Then
        '    Console.WriteLine("Ergebnis:" & Zahl1 + Zahl2)

        'ElseIf Rechenoperation = "-" Then
        '    Console.WriteLine("Ergebnis:" & Zahl1 - Zahl2)

        'ElseIf Rechenoperation = "*" Then
        '    Console.WriteLine("Ergebnis:" & Zahl1 * Zahl2)

        'ElseIf Rechenoperation = "/" Then
        '    Console.WriteLine("Ergebnis:" & Zahl1 / Zahl2)
        'End If

        Select Case Rechenoperation
            Case "+", "Plus", "plus", "PLUS"
                Console.WriteLine("Ergebnis:" & Zahl1 + Zahl2)
            Case "-", "Minus", "minus", "MINUS"
                Console.WriteLine("Ergebnis:" & Zahl1 - Zahl2)
            Case "*", "Multiplikation", "multiplikation", "MULTIPLIKATION"
                Console.WriteLine("Ergebnis:" & Zahl1 * Zahl2)
            Case "/", "Division", "division", "DIVISON"
                Console.WriteLine("Ergebnis:" & Zahl1 / Zahl2)
        End Select

        Console.WriteLine("")

        Console.WriteLine("Weiter oder Beenden?")
        Dim Antwort = Console.ReadLine

        Select Case Antwort
            Case "Weiter", "weiter", "WEITER"
                GoTo a

        End Select







    End Sub

End Module
