Module Module1

    Sub Main()

        'Das Ergebnis ist der Rest nach der number1 wird geteilt durch number2. Beispiel: der Ausdruck 14 Mod 4 2 ergibt.

        Dim Schleife As Integer


        For Schleife = 1 To 100

            'Console.WriteLine(Schleife & " " & Schleife Mod 3)




            'If Schleife Mod 5 = 0 And Schleife Mod 3 = 0 Then
            '    Console.WriteLine(" - " & Schleife & " " & "FizzBuzz")

            'Else
            '    If Schleife Mod 3 = 0 Then
            '        Console.WriteLine(" - " & Schleife & " " & "Fizz")
            '    End If

            '    If Schleife Mod 5 = 0 Then
            '        Console.WriteLine(" - " & Schleife & " " & "Buzz")

            '    End If

            'End If



            Select Case True
                Case Schleife Mod 3 = 0 And Schleife Mod 5 = 0

                    Console.ForegroundColor = ConsoleColor.Gray

                    Console.WriteLine(Schleife & " " & "FizzBuzz")

                Case Schleife Mod 3 = 0

                    Console.ForegroundColor = ConsoleColor.Gray

                    Console.WriteLine(Schleife & " " & "Fizz")

                Case Schleife Mod 5 = 0

                    Console.ForegroundColor = ConsoleColor.White

                    Console.WriteLine(Schleife & " " & "Buzz")

            End Select



            'If Schleife Mod 3 Then
            '    Console.WriteLine(Schleife & "Fizz")
            'End If

            'If Schleife Mod 5 Then
            '    Console.WriteLine(Schleife & "Buzz")
            'End If











        Next

        Console.ReadLine()


    End Sub

End Module
