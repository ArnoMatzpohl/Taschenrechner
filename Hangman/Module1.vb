Module Module1

    Sub Main() ''Hauptprogram
        Dim currentDate = DateTime.Now
        Console.Title = "Hangman 1"
        Console.WriteLine("Datum/Uhrzeit: " & currentDate)
        Console.WriteLine("")
        Console.WriteLine("Dieses Spiel ist FSK18!")

        Console.Clear()

        Dim currentDate1 = DateTime.Now
        Console.WriteLine("Datum/Uhrzeit: " & currentDate1)
        Console.WriteLine("")
        Console.WriteLine("Wie alt bist du?")
        Dim Alter As Integer = Console.ReadLine

        Console.Clear()

        Dim currentDate2 = DateTime.Now
        Console.WriteLine("Datum/Uhrzeit: " & currentDate2)
        Console.WriteLine("")
        Console.WriteLine("Wie viele Wörer Möchtest du erraten?")
        Dim AnzahlRatewörter As Integer = Console.ReadLine

        Console.Clear()

        Dim currentDate3 = DateTime.Now
        Console.WriteLine("Datum/Uhrzeit: " & currentDate3)
        Console.WriteLine("")
        Console.WriteLine("Wie ist dein Name?")
        Dim Name As String = Console.ReadLine

        'Console.WriteLine(vbCrLf + "What is your name? ")
        'Dim name = Console.ReadLine()
        'Dim currentDate = DateTime.Now
        'Console.WriteLine($"{vbCrLf}Hello, {Name}, on {currentDate:d} at {currentDate:t}")
        'Console.Write(vbCrLf + "Press any key to exit... ")
        'Console.ReadKey(True)

        
        Console.Clear()



        Console.WriteLine("Datum/Uhrzeit: " & currentDate)

        Console.WriteLine("")

        Console.WriteLine("Hallo " & Name & ", willkommen zurrück!")

        Console.WriteLine("")
        Console.WriteLine("-------------------")
        Console.WriteLine("")
        Console.WriteLine("Gebe ein Wort ein, welches erraten werden soll...")
        Dim Lösungswort = Console.ReadLine

        Console.Clear()

        Dim EingegebeneBuchstaben As String = ""

        Dim Fehlversuche As Integer = 0

b:
        Console.Clear()

        Dim currentDate4 = DateTime.Now
        Console.WriteLine("Datum/Uhrzeit: " & currentDate4)
        Console.WriteLine("")

        Console.WriteLine("Gebe einen Buchstaben ein...")
        Dim GeratendderBuchstabe As String = Console.ReadLine

        EingegebeneBuchstaben = EingegebeneBuchstaben & GeratendderBuchstabe

        Select Case EingegebeneBuchstaben
            Case Lösungswort
                Console.WriteLine("Das Wort Wurde erraten. !!!Epischer Sieg!!!")
        End Select



        ' rein in Textausgabe
        'Textausgabe("Hallo Welt") 'Die Funktion mit Namen "Textausgabe" wird aufgerufen. Ihr wird der Wert "Hallo Welt" als Parameter übergeben.
        ' Programmfluss geht hier weiter, nachdem Textausgabe beendet wurde.



        Console.WriteLine(WortEnthältBuchstabe("Welt", "A")) 'Die Funktion mit Namen "WortEnthältBuchstabe" wird aufgerufen. Ihr wird der Wert "Welt", "A-G" als Parameter übergeben.
        Console.WriteLine(WortEnthältBuchstabe("Welt", "B"))
        Console.WriteLine(WortEnthältBuchstabe("Welt", "C"))
        Console.WriteLine(WortEnthältBuchstabe("Welt", "D"))
        Console.WriteLine(WortEnthältBuchstabe("Welt", "E"))
        Console.WriteLine(WortEnthältBuchstabe("Welt", "F"))
        Console.WriteLine(WortEnthältBuchstabe("Welt", "G"))


        Dim Gurke As String

        Gurke = GeratendderBuchstabe

        Console.WriteLine(WortEnthältBuchstabe("Welt", GeratendderBuchstabe))

        Console.ReadLine()
        GoTo b


a:

        Console.WriteLine("Gib deine Fehlversuche an...")
        Dim Zahl As Integer
        Zahl = Console.ReadLine
        HangmanZeichnen(Zahl) ' zeichnet Hangman

        GoTo a

    End Sub

    Function GeratenderBuchstabe() As String
        Console.WriteLine("Gebe einen buchstaben ein...")
        Dim EigegebenerBuchstabe As String = Console.ReadLine
        Return EigegebenerBuchstabe
    End Function

    Function WortEnthältBuchstabe(Wort As String, Buchstabe As String) As Boolean

        Return Wort.Contains(Buchstabe) 'es gibt den Wert zurück der dabei raus kommt wenn die Funktion Wort.CONTAINS mit dem Parameterwert von Buchstabe aufgerufen wird

    End Function

    Sub HangmanZeichnen(Fehlversuche As Integer)
        Console.Clear()

        Select Case Fehlversuche 'was ist in Fehlversuchen drinne

            Case 0 'Fehversuch = 0 dann den Galgen malen
                Console.WriteLine("                               ")
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 1
                Console.WriteLine("                               ")
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |         (*_*)          ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 2
                Console.WriteLine("                               ")
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |         (*_*)          ")
                Console.WriteLine("      |           |            ")
                Console.WriteLine("      |           |            ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 3
                Console.WriteLine("                               ")
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |         (*_*)          ")
                Console.WriteLine("      |           | /          ")
                Console.WriteLine("      |           |/           ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 4
                Console.WriteLine("                               ")
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |         (*_*)          ")
                Console.WriteLine("      |         \ | /          ")
                Console.WriteLine("      |          \|/           ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 5
                Console.WriteLine("                               ")
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |         (*_*)          ")
                Console.WriteLine("      |         \ | /          ")
                Console.WriteLine("      |          \|/           ")
                Console.WriteLine("      |            \           ")
                Console.WriteLine("      |             \          ")
                Console.WriteLine(" _____|_____                   ")

            Case Else
                Console.WriteLine("                               ")
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |         (*_*)          ")
                Console.WriteLine("      |         \ | /          ")
                Console.WriteLine("      |          \|/           ")
                Console.WriteLine("      |          / \           ")
                Console.WriteLine("      |         /   \          ")
                Console.WriteLine(" _____|_____                   ")






        End Select

        'Select Case Fehlversuche
        '    Case 1
        '        Console.WriteLine("Fehlversuche: 1")
        '    Case 2
        '        Console.WriteLine("Fehlversuche: 2")
        '    Case 3
        '        Console.WriteLine("Fehlverluche: 3")
        '    Case 4
        '        Console.WriteLine("Fehlversuche: 4")
        '    Case 5
        '        Console.WriteLine("Fehlversuche: 5")
        '    Case Else
        '        Console.WriteLine("Fehlversuche:" & Fehlversuche)
        'End Select

    End Sub



End Module
