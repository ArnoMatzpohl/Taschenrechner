Module Module1

    Sub Main() ''Hauptprogram

        Console.Title = "Hangman 1"

        Console.WriteLine("Dieses Spiel ist FSK18!")

        Console.WriteLine("")

        Console.WriteLine("Wie alt bist du?")
        Dim Alter As Integer = Console.ReadLine

        Console.WriteLine("Wie viele Wörer Möchtest du erraten?")
        Dim AnzahlRatewörter As Integer = Console.ReadLine

        Console.WriteLine("Wie ist dein Name?")
        Dim Name As String = Console.ReadLine



        Console.Clear()

        Console.WriteLine("Hallo " & Name & ", willkommen zurrück!")

        Console.WriteLine("")

        Console.WriteLine("Gebe ein Wort ein, welches erraten werden soll...")
        Dim Lösungswort = Console.ReadLine

        Console.Clear()

        Dim EingegebeneBuchstaben As String = ""

        Dim Fehlversuche As Integer = 0

b:
        Console.WriteLine("Gebe einen Buchstaben ein...")
        Dim GeratendderBuchstabe As String = Console.ReadLine

        EingegebeneBuchstaben = EingegebeneBuchstaben & GeratendderBuchstabe

        Select Case EingegebeneBuchstaben
            Case Lösungswort
                Console.WriteLine("Das Wort Wurde erraten. !!!Epischer Sieg!!!")
        End Select

        GoTo b


a:

        Console.WriteLine("Gib deine Fehlversuche an...")
        Dim Zahl As Integer
        Zahl = Console.ReadLine
        HangmanZeichnen(Zahl) ' zeichnet Hangman

        GoTo a

    End Sub

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
