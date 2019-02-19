'Option Strict On

Module Hangman

    Sub Main() ''Hauptprogrm





        ''Dim Zahln As List(Of Integer)
        'Dim AlleWörter As String
        'Dim Wörter As List(Of String)
        'Dim i As Integer

        'AlleWörter = FileIO.FileSystem.ReadAllText("Wortliste.txt")
        'Wörter = AlleWörter.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries).ToList

        ''Console.WriteLine(Wörter(1))

        'For i = 0 To Wörter.Count - 1
        '    ' Console.WriteLine(Wörter(i))
        'Next

        'Dim LetzeWort As String = Wörter(Wörter.Count - 1)
        'Dim VorLetzeWort As String = Wörter(Wörter.Count - 2)

        '''Console.WriteLine("Die Wortliste enthält: " & Wörter.Count)

        ''weise der Variable "ZufälligesWort" ein zufälliges Wort aus der Wörterliste zu

        'Dim ZufälligesWort As String


        'Dim RandomZahl1 As New Random()

        'Randomize()

        'Dim Zahl1 As Integer = RandomZahl1.Next(0, Wörter.Count)

        'Select Case Zahl1
        '    Case Zahl1
        '        ZufälligesWort = Wörter(Zahl1)
        'End Select

        'Dim Zählschleife As Integer



        'For Zählschleife = 30 To 32000 Step 100
        '    Console.Beep()

        'Next


        'Dim Zählschleife As Integer
        'Dim Schleife As String


        'For Zählschleife = 40 To 45 Step 100
        '    Console.Beep() '(Zählschleife, 10)

        'Next






        'Dim Gurke As String
        'Dim Wurst As String
        'Dim Baum As String
        'Dim JaNein As Boolean

        'Gurke = "GURKE"
        'Wurst = "gurke"
        'Wurst = Gurke.ToLower
        'JaNein = Gurke.Equals(Wurst, StringComparison.InvariantCultureIgnoreCase)
        'Console.WriteLine(JaNein)

        'Wurst = "Diese Wurst ist lecker"
        'Gurke = "Diese Gurke ist grün"
        'JaNein = Gurke.Contains("A") 'c

        'JaNein = Wurst.Contains(Gurke(0))
        'JaNein = Gurke.Contains(Wurst(3))
        'JaNein = Wurst.Length > Gurke.Length
        'JaNein = Wurst.ToLower = Gurke.ToLower
        'JaNein = Wurst.ToUpper = Gurke.ToUpper
        'JaNein = Gurke.Length > Wurst.Length - 3
        'JaNein = Gurke.Length > 7
        'JaNein = Gurke.Trim.Length > 7
        'Baum = Gurke(7)
        'JaNein = Baum(0) = "B"
        'Baum = Gurke
        'JaNein = Baum.Contains(Gurke)
        'JaNein = (Baum > Gurke)
        'JaNein = (Baum = Gurke)
        'JaNein = Baum.Equals(Gurke, StringComparison.InvariantCultureIgnoreCase)


a:


        Console.Clear()
        Dim Zählschleife As Integer
        Dim Schleife As String


        Dim currentDate = DateTime.Now
        Console.Title = "Hangman 1 (V 1.3)"
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Datum/Uhrzeit: " & currentDate)
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Dieses Spiel ist FSK18!")
        Console.ForegroundColor = ConsoleColor.White
        For Zählschleife = 40 To 41 Step 1
            'Console.Beep() '(Zählschleife, 10)

        Next
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("--------------")
        Console.WriteLine("Gebe dein Passwort ein:")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.White
        Dim OK As String = Console.ReadLine()
        Dim OKif As String

        Select Case OK
            Case "Bistro Öz Tadim", "Arno", "a"
                ' Console.Beep()
                GoTo R
                'Case Else
                '    GoTo a
        End Select
        GoTo a

R:

        Console.Clear()

        Dim currentDate1 = DateTime.Now
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Datum/Uhrzeit: " & currentDate1)
        Console.WriteLine("")
        Console.WriteLine("Wie alt bist du?")
        Console.ForegroundColor = ConsoleColor.White
        Dim Alter As Integer = Console.ReadLine
        Dim FSK18 As Integer = 18

        If Alter > FSK18 Then
            GoTo c
        ElseIf Alter < FSK18 Then
            GoTo a
        End If

c:
        Console.Clear()

        'Dim currentDate2 = DateTime.Now
        'Console.WriteLine("Datum/Uhrzeit: " & currentDate2)
        'Console.WriteLine("")
        'Console.WriteLine("Wie viele Wörer Möchtest du erraten?")
        'Dim AnzahlRatewörter As Integer = Console.ReadLine

        'Console.Clear()

        Dim currentDate3 = DateTime.Now
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Datum/Uhrzeit: " & currentDate3)
        Console.WriteLine("")
        Console.WriteLine("Wie ist dein Name?")
        Console.ForegroundColor = ConsoleColor.White
        Dim Name As String = Console.ReadLine

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Datum/Uhrzeit: " & currentDate)

        Console.WriteLine("")

        Console.WriteLine("Hallo " & Name & ", willkommen zurrück!")
        For Zählschleife = 40 To 41 Step 1
            'Console.Beep() '(Zählschleife, 10)

        Next
        Console.WriteLine("")
        Console.WriteLine("-------------------")
        Console.WriteLine("")
        'Console.WriteLine("Gebe ein Wort ein, welches erraten werden soll...")
        'Dim Lösungswort = Console.ReadLine


        'Console.WriteLine("Gebe einen Text ein welcher erraten werden soll...") 'Es wird in die Konsole geschrieben "Gebe einen Text ein..."
        'Dim ZufälligesWort As String
        'Die Variable "EingegebenerText" wird Definirt. Sie hat den Datentyp String. EingegebenerText übernimmt den Wert von Console.ReadLine
        'Dim RandomZahl As New Random()

        'Randomize()

        'Dim Zahl As Integer = RandomZahl.Next(0, 20)



        'Select Case Zahl
        '    Case 0
        '        EingegebenerText = "Spiel"
        '    Case 1
        '        EingegebenerText = "Baum"
        '    Case 2
        '        EingegebenerText = "Haus"
        '    Case 3
        '        EingegebenerText = "Lellek"
        '    Case 4
        '        EingegebenerText = "Familie"
        '    Case 5
        '        EingegebenerText = "Computer"
        '    Case 6
        '        EingegebenerText = "Schnee"
        '    Case 7
        '        EingegebenerText = "Steak"
        '    Case 8
        '        EingegebenerText = "Nashorn"
        '    Case 9
        '        EingegebenerText = "Tier"
        '    Case 10
        '        EingegebenerText = "Telefon"
        '    Case 11
        '        EingegebenerText = "Kabel"
        '    Case 12
        '        EingegebenerText = "Schule"
        '    Case 13
        '        EingegebenerText = "Apfel"
        '    Case 14
        '        EingegebenerText = "Figur"
        '    Case 15
        '        EingegebenerText = "Nudel"
        '    Case 16
        '        EingegebenerText = "Amerika"
        '    Case 17
        '        EingegebenerText = "Müsli"
        '    Case 18
        '        EingegebenerText = "Arbeitsplatz"
        '    Case 19
        '        EingegebenerText = "Versicherung"
        '    Case 20
        '        EingegebenerText = "Sport"
        'End Select
ö:
        'Dim Zahln As List(Of Integer)
        Dim AlleWörter As String
        Dim Wörter As List(Of String)
        Dim i As Integer

        AlleWörter = FileIO.FileSystem.ReadAllText("Wortliste.txt")
        Wörter = AlleWörter.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries).ToList

        'Console.WriteLine(Wörter(1))

        For i = 0 To Wörter.Count - 1
            ' Console.WriteLine(Wörter(i))
        Next

        Dim LetzeWort As String = Wörter(Wörter.Count - 1)
        Dim VorLetzeWort As String = Wörter(Wörter.Count - 2)

        ''Console.WriteLine("Die Wortliste enthält: " & Wörter.Count)

        'weise der Variable "ZufälligesWort" ein zufälliges Wort aus der Wörterliste zu

        Dim ZufälligesWort As String


        Dim RandomZahl1 As New Random()

        Randomize()

        Dim Zahl1 As Integer = RandomZahl1.Next(0, Wörter.Count)

        Select Case Zahl1
            Case Zahl1
                ZufälligesWort = Wörter(Zahl1)
        End Select

        Dim Fehlversuche As Integer
        Fehlversuche = 0


        Dim WortlängeVonEingegebenerText As Integer ' Die Variable WortlängeVonEingegebenerText wird definirt und hat den Datentyp Integer
        WortlängeVonEingegebenerText = ZufälligesWort.Length 'Die länge von "EingegebenerText" wird WortlängeVonEingegebenerText übergeben
        'Console.WriteLine(WortlängeVonEingegebenerText)

        'For A As Integer = 0 To WortlängeVonEingegebenerText - 1
        '    Console.WriteLine(EingegebenerText(A))
        'Next

        'For C As Integer = 2 To WortlängeVonEingegebenerText - 1
        '    Console.WriteLine(EingegebenerText(C))
        'Next

        Dim B As String 'Dei Variable "B" wird definiert und hat den Dtatentyp String
        B = ZufälligesWort(0) ' B enthält das  erste Zeichen von EingegebenerText

        'Console.WriteLine(WortEnthältBuchstabe("Welt", "F"))

        Dim RichtigGeratendeBuchstaben As String 'Dei Variable "RichtigGeratendeBuchstaben" wird Definirt und hat den Datantyp String



        RichtigGeratendeBuchstaben = ""

        'Dei Variable "Fehlversuche" wird Definirt und hat den Datantyp String

        Dim RichtigGeratendeBuchstabenAnzahl As Integer 'Dei Variable "RichtigGeratendeBuchstabenAnzahl" wird Definirt und hat den Datantyp String

        For T As Integer = 1 To 26 ' Dei Schleife "T" Geht von 1 bis 26
            RichtigGeratendeBuchstabenAnzahl = 0 'RichtigGeratendeBuchstabenAnzahl enthählt 0
            Console.Clear() 'Die Konsole wird gelöscht
            HangmanZeichnen(Fehlversuche) 'Es wird die Funktion Hangman Zeichnen aufgerufen und ihr wird Fehlversuche übergeben
            Dim Franz As String = Kleinbuchstaben1(ZufälligesWort)
            Dim Heidi As String = Kleinbuchstaben2(RichtigGeratendeBuchstaben)
            zeichneBisherGerateneBuchstaben(Franz, Heidi)
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Gebe einen Buchstaben ein...")
            Console.ForegroundColor = ConsoleColor.White 'Es wird in die Konsole geschrieben: "Gebe einen Buchstaben ein..."
            Dim BuchstabeGeraten As String = Console.ReadLine 'Die Variable BuchstabeGeraten wird Definiert, hat den Datentypen String und übernimmt den Wert von Console.Readline
            'Console.WriteLine(WortEnthältBuchstabe(EingegebenerText, BuchstabeGeraten)) 'Es wird überprüft ob der eingegebene Buchstabe in dem Eingegebenen test Enthalten ist.

            'Console.ReadLine()
            Dim EnthältBuchstabe1 As Boolean

            EnthältBuchstabe1 = ZufälligesWort.ToLower.Contains(BuchstabeGeraten.ToLower)

            If EnthältBuchstabe1 = True Then 'Das Wort enthält den geratenden Buchstaben dann:
                RichtigGeratendeBuchstaben = RichtigGeratendeBuchstaben & BuchstabeGeraten 'Der Wert von RichtigGeratendeBuchstaben & BuchstabeGeraten Wird RichtigGeratendeBuchstaben zugewiesen
                'Console.WriteLine(RichtigGeratendeBuchstaben) 'In die Konsole wird das was In RichtigGeratendeBuchstaben steht geschrieben
                For R As Integer = 0 To ZufälligesWort.Length - 1 'Die schleife geht von 0 bis zu der Länge vom eingegebenen Text -1

                    Dim EnthältBuchstabe As Boolean

                    '  EnthältBuchstabe = WortEnthältBuchstabe(RichtigGeratendeBuchstaben, EingegebenerText(R))
                    EnthältBuchstabe = RichtigGeratendeBuchstaben.ToLower.Contains(ZufälligesWort.ToLower()(R))

                    If EnthältBuchstabe = True Then
                        RichtigGeratendeBuchstabenAnzahl += 1 'zu RichtigGeratendeBuchstabenAnzahl wird einer dazu gezählt 
                    End If

                    'Das unter diesem satzt ist das gleiche wie über diesem Satz
                    'If WortEnthältBuchstabe(RichtigGeratendeBuchstaben, EingegebenerText(R)) = True Then 'Es wird überprüft ob in RichtigGeratendeBuchstaben der  EingegebenerText(R)(R.ter Buchstabe von EingegebenerText) enthalten ist
                    '    RichtigGeratendeBuchstabenAnzahl += 1 'zu RichtigGeratendeBuchstabenAnzahl wird einer dazu gezählt 
                    'End If

                Next

                If RichtigGeratendeBuchstabenAnzahl = ZufälligesWort.Length Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Herzlichen Glückwunsch " & Name & "! Das Wort ist: " & ZufälligesWort) 'In die Konsole wird geschrieben: "Herzlichen Glückwunsch! Das Wort ist: " & EingegebenerText


                    Console.WriteLine("Möchtest du noch eine Runde Spielen?")
                    Console.ForegroundColor = ConsoleColor.White
                    Dim AntwortRunde As String = Console.ReadLine
                    Console.Clear()
                    Select Case AntwortRunde
                        Case "Ja", "ja", "jA", "Weiter", "weiter", "JA"
                            GoTo ö
                        Case Else
                            Environment.Exit(0)
                    End Select


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




        'Console.WriteLine("Gib deine Fehlversuche an...")
        'Dim Zahl As Integer
        'Zahl = Console.ReadLine
        'HangmanZeichnen(Zahl) ' zeichnet Hangman



    End Sub

    Function WortEnthältBuchstabe(Wort As String, Buchstabe As String) As Boolean

        Return Wort.Contains(Buchstabe) 'es gibt den Wert zurück der dabei raus kommt wenn die Funktion Wort.CONTAINS mit dem Parameterwert von Buchstabe aufgerufen wird

    End Function

    Sub AnzeigeGeratenerBuchstaben(EingegebenerText, RichtigGeratendeBuchstaben)
        Console.WriteLine(RichtigGeratendeBuchstaben)
    End Sub

    Function GeratenderBuchstabe() As String
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Gebe einen buchstaben ein...")
        Console.ForegroundColor = ConsoleColor.White
        Dim EigegebenerBuchstabe As String = Console.ReadLine
        Return EigegebenerBuchstabe
    End Function

    Function Kleinbuchstaben1(EingegebenerText As String) As String
        Return EingegebenerText.ToLower
    End Function

    Function Kleinbuchstaben2(RichtigGeratendeBuchstaben As String) As String
        Return RichtigGeratendeBuchstaben.ToLower
    End Function

    Sub zeichneBisherGerateneBuchstaben(Wort As String, richtigeBuchstaben As String)

        For Zähler As Integer = 0 To Wort.Length - 1

            If richtigeBuchstaben.Contains(Wort(Zähler)) Then
                Console.ForegroundColor = ConsoleColor.White
                Console.Write(Wort(Zähler) & " ")

            Else
                Console.ForegroundColor = ConsoleColor.Gray
                Console.Write("_ ")
            End If

        Next
        Console.WriteLine()
    End Sub

    Sub HangmanZeichnen(Fehlversuche As Integer) 'Diese Funktion ist Fertig!!!
        Console.Clear()

        Select Case Fehlversuche 'was ist in Fehlversuchen drinne

            Case 0 'Fehversuch = 0 dann den Galgen malen  
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Fehlversuche: " & Fehlversuche)
                Console.WriteLine("                               ")
                Console.WriteLine("                               ")
                Console.WriteLine("                               ")
                Console.WriteLine("                               ")
                Console.WriteLine("                               ")
                Console.WriteLine("                               ")
                Console.WriteLine("                               ")
                Console.WriteLine("                               ")
                Console.WriteLine(" ___________                   ")

            Case 1
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Fehlversuche: " & Fehlversuche)
                Console.WriteLine("                               ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 2
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Fehlversuche: " & Fehlversuche)
                Console.WriteLine("                               ")
                Console.WriteLine("      | /                      ")
                Console.WriteLine("      |/                       ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 3
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Fehlversuche: " & Fehlversuche)
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /                      ")
                Console.WriteLine("      |/                       ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 4
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Fehlversuche: " & Fehlversuche)
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 5
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Fehlversuche: " & Fehlversuche)
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |         (>_<)          ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 6
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Fehlversuche: " & Fehlversuche)
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |         (>_<)          ")
                Console.WriteLine("      |           |            ")
                Console.WriteLine("      |           |            ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 7
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Fehlversuche: " & Fehlversuche)
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |         (>_<)          ")
                Console.WriteLine("      |           | /          ")
                Console.WriteLine("      |           |/           ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 8
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Fehlversuche: " & Fehlversuche)
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |         (>_<)          ")
                Console.WriteLine("      |         \ | /          ")
                Console.WriteLine("      |          \|/           ")
                Console.WriteLine("      |                        ")
                Console.WriteLine("      |                        ")
                Console.WriteLine(" _____|_____                   ")

            Case 9
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Fehlversuche: " & Fehlversuche)
                Console.WriteLine("       ___________             ")
                Console.WriteLine("      | /         |            ")
                Console.WriteLine("      |/          |            ")
                Console.WriteLine("      |         (>_<)          ")
                Console.WriteLine("      |         \ | /          ")
                Console.WriteLine("      |          \|/           ")
                Console.WriteLine("      |            \           ")
                Console.WriteLine("      |             \          ")
                Console.WriteLine(" _____|_____                   ")

            Case Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Fehlversuche: " & Fehlversuche)
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
