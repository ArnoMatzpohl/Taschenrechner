Module Module1

    Sub Main()

        Dim Zahl1 As Integer
        Dim Zahl2 As Integer
        Dim IstZahl1GrößerAlsZahl2 As Boolean

        'Zahl1 = 5 '5 ist der Wert von Zahl1 
        'Zahl2 = 6 '6 ist der Wert von Zahl2
        IstZahl1GrößerAlsZahl2 = False 'IstZahl1GrößerAlsZahl2 ist falsch
        IstZahl1GrößerAlsZahl2 = True 'IstZahl1GrößerAlsZahl2 ist richtig
        IstZahl1GrößerAlsZahl2 = Zahl1 > Zahl2 'IstZahl1GrößerAlsZahl2 wird erstezt durch Zahl1 ist größer als Zahl2

        'Console.WriteLine(IstZahl1GrößerAlsZahl2) ' schreibt ob es whr oder falsch ist
        Console.WriteLine("Schreibe die erste Zahl...") 'Frage nach einer Zahl an den Benutzer
        Dim GefragteZahl1 As Integer = Console.ReadLine ' Die grefragte Zahl wird GefragteZahl1 genannt 


        'IstZahl1GrößerAlsZahl2 = Zahl1 > Zahl2
        'Console.WriteLine(IstZahl1GrößerAlsZahl2)

        Console.WriteLine("Schreibe die zweite Zahl...") 'Frage nach der zweiten Zahl
        Dim GefragteZahl2 As Integer = Console.ReadLine 'Die eingegebene Zahl heißt Gefragte Zahl2



        IstZahl1GrößerAlsZahl2 = GefragteZahl1 > GefragteZahl2 'IstZahl1GrößerAlsZahl2 übernimmt das Ergebnis von Zahl1 > Zahl2
        Console.WriteLine(IstZahl1GrößerAlsZahl2) 'es würd True für Wahr oder FALSE für falsch

        Select Case GefragteZahl1
            Case > GefragteZahl2
                Console.WriteLine(GefragteZahl1)
            Case < GefragteZahl2
                Console.WriteLine(GefragteZahl2)
        End Select


        Select Case IstZahl1GrößerAlsZahl2
            Case True
                Console.WriteLine(GefragteZahl1)
            Case False
                Console.WriteLine(GefragteZahl2)
        End Select

        If IstZahl1GrößerAlsZahl2 Then
            Console.WriteLine(GefragteZahl1)
        Else
            Console.WriteLine(GefragteZahl2)
        End If

        Console.ReadLine()


        Dim Zahl5 As Integer
        Dim Zahl6 As Integer
        Dim Zahl7 As Integer
        Dim Wahrheitswert As Boolean
        Dim Wahrheitswert1 As Boolean
        Dim Wahrheitswert2 As Boolean

        Zahl7 = 3
        Zahl5 = 1
        Zahl6 = 2


        Wahrheitswert = 5 > 3
        Wahrheitswert1 = 5 > 4
        Wahrheitswert2 = Wahrheitswert And Wahrheitswert1
        Wahrheitswert2 = Wahrheitswert Or Wahrheitswert1
        Wahrheitswert2 = Wahrheitswert Or Not Wahrheitswert1


    End Sub

End Module
