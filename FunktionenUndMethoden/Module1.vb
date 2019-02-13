Module Module1

    Sub Main()

        Rest()

        Console.ReadLine() 'Die Funktion Readline, welche auf Console definiert ist, wird mit dem Parameter "garnichts" aufgerufen (wird ohne Parameterübergabe aufgerufen).
    End Sub

    Function Kabel(SSD As String) As Integer

    End Function

    Function Case3(Knopf As String, Stift As String) As String

    End Function

    Function Hülle(Blau As String, Rot As String, Lila As String) As String
        Console.WriteLine("Wert von Blau: " & Blau & "Wert von Rot: " & Rot & "Wert von Lila: " & Lila)
    End Function

    Sub Grün(Schwarz As String, Black As String)
        Console.WriteLine(Schwarz & Black)
    End Sub



    Sub Rest()

        Dim Eingabetext As String 'Die Variable mit Namen "Eingabetext" wird definiert und hat den Datentyp "String"
        Dim AlsGroßbuchstabe As String 'Die Variable "AlsGroßbuchstabe" wird mit dem Datentyp "String" definiert
        Dim Text1 As String
        Dim Text2 As String
        Dim Zahl1 As Integer
        Dim Zahl2 As Integer
        Dim Wahr As Boolean

        ' rein in Textausgabe
        Textausgabe("Hallo Welt") 'Die Funktion mit Namen "Textausgabe" wird aufgerufen. Ihr wird der Wert "Hallo Welt" als Parameter übergeben.
        ' Programmfluss geht hier weiter, nachdem Textausgabe beendet wurde.
        TextausgabenAlsGroßbuchstaben("Hallo Welt")


        TextausgabeOhneLeerzeichen(" Hallo Welt ")

        TextausgabeInKleinbuchstaben("Hallo Welt")

        Textausgabe(TextEnthältA("hallo welt"))

        Wahr = TextEnthältA("Hallo Welt") 'der Variable wahr wird der Wert zugewiesen der bei aufruf von "TextenthältA" zurückgegeben wird

        Text1 = Kleinbuchstaben("Hallo Welt")

        Text2 = Großbuchstaben("Hallo Welt")



        Textausgabe(Kleinbuchstaben("Guten Morgen"))

        Wiederholung()
    End Sub

    Sub Wiederholung()
        Console.WriteLine("Gebe deinen Text ein...")
        Dim Antwort As String = Console.ReadLine
        Console.WriteLine("Dein Text: " & Antwort)
    End Sub



    Function TextEnthältA(Tastatur As String) As Boolean
        Return Tastatur.Contains("A") 'es gibt den Wert zurück der dabei raus kommt wenn die Funktion Tastatur.CONTAINS mit dem Parameterwert A aufgerufen wird
    End Function

    Sub TextausgabeInKleinbuchstaben(Eingabeparameter As String)
        Dim China As String
        China = Kleinbuchstaben(Eingabeparameter) 'China wird der Wert zugewiesen den die Funktion Kleinbuchstaben zurück gibt
        Textausgabe(China)
    End Sub

    Sub TextausgabenAlsGroßbuchstaben(Eingabeparameter As String)
        Dim China As String
        China = Großbuchstaben(Eingabeparameter) 'China wird der Wert zugewiesen den die Funktion Großbuchstaben zurück gibt
        Textausgabe(China)
    End Sub

    Sub TextausgabeOhneLeerzeichen(Eingabeparameter As String)
        Dim China As String
        China = KeineLeerzeichenAmAnfangUndAmEnde(Eingabeparameter) 'China wird der Wert zugewiesen den die Funktion KeineLeerzeichenAmAnfangUndAmEnde zurück gibt
        Textausgabe(China) ' der Wert von China wird der Textausgaben Übertragen
    End Sub



    Sub Textausgabe(Hallo As String) 'Die Funktion heißt "Textausgabe". Sie hat einen Parameter. Dieser Parameter heißt "Hallo" und hat den Datentyp "String"

        'Es wird das was in "Hallo" steht geschrieben. => Die Funktion "WriteLine" welche auf "Console" definiert ist wird mit dem Parameter "Hallo" als Wert aufgerufen.
        Console.WriteLine(Hallo)

    End Sub 'Die Funktion ist hier zu Ende. => raus aus Textausgabe


    Function KeineLeerzeichenAmAnfangUndAmEnde(Boom As String) As String
        Return Boom.Trim
    End Function

    Function Kleinbuchstaben(Wert As String) As String
        Return Wert.ToLower
    End Function

    Function Großbuchstaben(Maus As String) As String
        Return Maus.ToUpper
    End Function
End Module
