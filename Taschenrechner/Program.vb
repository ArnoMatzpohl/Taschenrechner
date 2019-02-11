Module Program

    Sub Main()
        Console.Title = "Taschenrechner"
        Console.WriteLine("Hallo")

        Dim Zahl1 As Integer
        Dim Zahl2 As Integer

        Console.WriteLine("Jetzt die Zahl eingeben!")
        Zahl1 = Console.ReadLine

        Console.WriteLine("Jetzt die zweite Zahl eingeben!")
        Zahl2 = Console.ReadLine

        Console.WriteLine("Ergebnis:" & Zahl1 + Zahl2)

        Console.ReadLine()
    End Sub

End Module
