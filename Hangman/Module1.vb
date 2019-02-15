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

        Console.Clear()

        Console.WriteLine("Datum/Uhrzeit: " & currentDate)

        Console.WriteLine("")

        Console.WriteLine("Hallo " & Name & ", willkommen zurrück!")

        Console.WriteLine("")
        Console.WriteLine("-------------------")
        Console.WriteLine("")
        'Console.WriteLine("Gebe ein Wort ein, welches erraten werden soll...")
        'Dim Lösungswort = Console.ReadLine


        Console.WriteLine("Gebe einen Text ein welcher erraten werden soll...") 'Es wird in die Konsole geschrieben "Gebe einen Text ein..."
        Dim EingegebenerText As String = Console.ReadLine 'Die Variable "EingegebenerText" wird Definirt. Sie hat den Datentyp String. EingegebenerText übernimmt den Wert von Console.ReadLine
        Dim WortlängeVonEingegebenerText As Integer ' Die Variable WortlängeVonEingegebenerText wird definirt und hat den Datentyp Integer
        WortlängeVonEingegebenerText = EingegebenerText.Length 'Die länge von "EingegebenerText" wird WortlängeVonEingegebenerText übergeben
        'Console.WriteLine(WortlängeVonEingegebenerText)

        'For A As Integer = 0 To WortlängeVonEingegebenerText - 1
        '    Console.WriteLine(EingegebenerText(A))
        'Next

        'For C As Integer = 2 To WortlängeVonEingegebenerText - 1
        '    Console.WriteLine(EingegebenerText(C))
        'Next

        Dim B As String 'Dei Variable "B" wird definiert und hat den Dtatentyp String
        B = EingegebenerText(0) ' B enthält das  erste Zeichen von EingegebenerText



        'Console.WriteLine(WortEnthältBuchstabe("Welt", "F"))

        Dim RichtigGeratendeBuchstaben As String 'Dei Variable "RichtigGeratendeBuchstaben" wird Definirt und hat den Datantyp String

        RichtigGeratendeBuchstaben = "" '

        Dim Fehlversuche As Integer 'Dei Variable "Fehlversuche" wird Definirt und hat den Datantyp String

        Dim RichtigGeratendeBuchstabenAnzahl As Integer 'Dei Variable "RichtigGeratendeBuchstabenAnzahl" wird Definirt und hat den Datantyp String




        For T As Integer = 1 To 26 ' Dei Schleife "T" Geht von 1 bis 26
            RichtigGeratendeBuchstabenAnzahl = 0 'RichtigGeratendeBuchstabenAnzahl enthählt 0
            Console.Clear() 'Die Konsole wird gelöscht
            HangmanZeichnen(Fehlversuche) 'Es wird die Funktion Hangman Zeichnen aufgerufen und ihr wird Fehlversuche übergeben
            Console.WriteLine("Gebe einen Buchstaben ein...") 'Es wird in die Konsole geschrieben: "Gebe einen Buchstaben ein..."
            Dim BuchstabeGeraten As String = Console.ReadLine 'Die Variable BuchstabeGeraten wird Definiert, hat den Datentypen String und übernimmt den Wert von Console.Readline
            Console.WriteLine(WortEnthältBuchstabe(EingegebenerText, BuchstabeGeraten)) 'Es wird überprüft ob der eingegebene Buchstabe in dem Eingegebenen test Enthalten ist.




            If WortEnthältBuchstabe(EingegebenerText, BuchstabeGeraten) Then 'Das Wort enthält den geratenden Buchstaben dann:
                RichtigGeratendeBuchstaben = RichtigGeratendeBuchstaben & BuchstabeGeraten 'Der Wert von RichtigGeratendeBuchstaben & BuchstabeGeraten Wird RichtigGeratendeBuchstaben zugewiesen
                Console.WriteLine(RichtigGeratendeBuchstaben) 'In die Konsole wird das was In RichtigGeratendeBuchstaben steht geschrieben
                For R As Integer = 0 To EingegebenerText.Length - 1 'Die schleife geht von 0 bis zu der Länge vom eingegebenen Text -1



                    Dim EnthältBuchstabe As Boolean

                    EnthältBuchstabe = WortEnthältBuchstabe(RichtigGeratendeBuchstaben, EingegebenerText(R))
                    EnthältBuchstabe = RichtigGeratendeBuchstaben.Contains(EingegebenerText(R))

                    If EnthältBuchstabe = True Then
                        RichtigGeratendeBuchstabenAnzahl += 1 'zu RichtigGeratendeBuchstabenAnzahl wird einer dazu gezählt 
                    End If

                    'Das unter diesem satzt ist das gleiche wie über diesem Satz
                    'If WortEnthältBuchstabe(RichtigGeratendeBuchstaben, EingegebenerText(R)) = True Then 'Es wird überprüft ob in RichtigGeratendeBuchstaben der  EingegebenerText(R)(R.ter Buchstabe von EingegebenerText) enthalten ist
                    '    RichtigGeratendeBuchstabenAnzahl += 1 'zu RichtigGeratendeBuchstabenAnzahl wird einer dazu gezählt 
                    'End If

                Next

                If RichtigGeratendeBuchstabenAnzahl = EingegebenerText.Length Then
                    Console.WriteLine("Herzlichen Glückwunsch! Das Wort ist: " & EingegebenerText) 'In die Konsole wird geschrieben: "Herzlichen Glückwunsch! Das Wort ist: " & EingegebenerText
                    Console.ReadLine()
                End If
            Else 'Das Wort enthält nicht den Buchstaben
                Fehlversuche = Fehlversuche + 1 'Zu Fehversuchen wird 1 (Fehlversuch) hinzugefügt

            End If
        Next




        'Console.WriteLine(EingegebenerText("Welt", EingegebenerText))


        Console.ReadLine()

        'For Z As Integer = 2 To 20 Step 2 'Die SChleife aus Zahlen(zählen) hat den Startwert 2 und zählt bis 20 mit der Schrittweite 2
        '    Console.WriteLine(Z)

        'Next

        'For I As Integer = 5 To 10

        'Next

        Dim Text As String
        Text = "Hallo Welt"

        Dim Wortlänge As Integer
        Wortlänge = Text.Length

        Console.WriteLine(Wortlänge)





        Console.ReadLine()






        Dim EingegebeneBuchstaben As String = ""

        'b:
        '        Console.Clear()

        '        Dim currentDate4 = DateTime.Now
        '        Console.WriteLine("Datum/Uhrzeit: " & currentDate4)
        '        Console.WriteLine("")

        '        Console.WriteLine("Gebe einen Buchstaben ein...")
        '        Dim GeratendderBuchstabe As String = Console.ReadLine

        '        EingegebeneBuchstaben = EingegebeneBuchstaben & GeratendderBuchstabe

        '        Select Case EingegebeneBuchstaben
        '            Case Lösungswort
        '                Console.WriteLine("Das Wort Wurde erraten. !!!Epischer Sieg!!!")
        '        End Select



        ' rein in Textausgabe
        'Textausgabe("Hallo Welt") 'Die Funktion mit Namen "Textausgabe" wird aufgerufen. Ihr wird der Wert "Hallo Welt" als Parameter übergeben.
        ' Programmfluss geht hier weiter, nachdem Textausgabe beendet wurde.



        'Console.WriteLine(WortEnthältBuchstabe("Welt", "A")) 'Die Funktion mit Namen "WortEnthältBuchstabe" wird aufgerufen. Ihr wird der Wert "Welt", "A-G" als Parameter übergeben.
        'Console.WriteLine(WortEnthältBuchstabe("Welt", "B"))
        'Console.WriteLine(WortEnthältBuchstabe("Welt", "C"))
        'Console.WriteLine(WortEnthältBuchstabe("Welt", "D"))
        'Console.WriteLine(WortEnthältBuchstabe("Welt", "E"))
        'Console.WriteLine(WortEnthältBuchstabe("Welt", "F"))
        'Console.WriteLine(WortEnthältBuchstabe("Welt", "G"))


        'Dim Gurke As String

        'Gurke = GeratendderBuchstabe

        'Console.WriteLine(WortEnthältBuchstabe("Welt", GeratendderBuchstabe))

        'Console.ReadLine()
        'GoTo b


a:

        Console.WriteLine("Gib deine Fehlversuche an...")
        Dim Zahl As Integer
        Zahl = Console.ReadLine
        HangmanZeichnen(Zahl) ' zeichnet Hangman

        GoTo a

    End Sub


    Function WortEnthältBuchstabe(Wort As String, Buchstabe As String) As Boolean

        Return Wort.Contains(Buchstabe) 'es gibt den Wert zurück der dabei raus kommt wenn die Funktion Wort.CONTAINS mit dem Parameterwert von Buchstabe aufgerufen wird

    End Function








    Function GeratenderBuchstabe() As String
        Console.WriteLine("Gebe einen buchstaben ein...")
        Dim EigegebenerBuchstabe As String = Console.ReadLine
        Return EigegebenerBuchstabe
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
