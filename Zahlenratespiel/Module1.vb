Module Module1

    Sub Main()

        Console.Title = "Zahlenratespiel"
        Console.WriteLine("Gebe Zahlen ein")
        Console.WriteLine("Bestätige die Schritte mit Enter")

        Dim Zähler As Integer
        Dim Zahl As Integer
        Dim Geraten As Integer
        Dim r As New Random()

        Randomize()

        Zahl = r.Next(0, 1000)

a:
        Zähler = Zähler + 1
        'Console.WriteLine(Zahl)
        Geraten = Console.ReadLine

        Select Case Zahl
            Case < Geraten
                Console.WriteLine("Kleiner")
            Case > Geraten
                Console.WriteLine("größer")
            Case = Geraten
                Console.WriteLine("!!!WIN!!!")
                Console.WriteLine("Du hast" & Zähler & "Runden gebraucht")

        End Select



        GoTo a





        'If Zahl > 0 Then
        '    Console.WriteLine("Größer")
        'End If

        'ElseIf Zahl < 1000 Then
        'Console.WriteLine("Kleiner")
        'End If







    End Sub



End Module
