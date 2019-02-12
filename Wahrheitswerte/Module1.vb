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


    End Sub

End Module
