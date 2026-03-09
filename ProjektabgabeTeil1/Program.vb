Imports System
Imports System.Collections.Generic

' KLASSE BUCH
Public Class Buch
    Public Property Id As Integer
    Public Property Titel As String
    Public Property Autor As String
    Public Property Verfuegbar As Boolean
    Public Property AusgeliehenVon As Integer

    Public Sub New(id As Integer, titel As String, autor As String)
        Me.Id = id
        Me.Titel = titel
        Me.Autor = autor
        Me.Verfuegbar = True
        Me.AusgeliehenVon = 0
    End Sub
End Class

' KLASSE BENUTZER
Public Class Benutzer
    Public Property Id As Integer
    Public Property Name As String

    Public Sub New(id As Integer, name As String)
        Me.Id = id
        Me.Name = name
    End Sub
End Class

' HAUPTPROGRAMM
Module Program

    Dim buecherListe As New List(Of Buch)
    Dim benutzerListe As New List(Of Benutzer)

    Sub Main()
        LadeTestdaten()
        Menu()
    End Sub

    ' TESTDATEN
    Sub LadeTestdaten()

        buecherListe.Add(New Buch(1, "Informatik 1", "Müller"))
        buecherListe.Add(New Buch(2, "VB.NET Grundlagen", "Schmidt"))
        buecherListe.Add(New Buch(3, "Datenstrukturen", "Klein"))
        buecherListe.Add(New Buch(4, "Softwaretechnik", "Meier"))
        buecherListe.Add(New Buch(5, "Algorithmen einfach erklärt", "Fischer"))
        buecherListe.Add(New Buch(6, "Rechnerarchitektur", "Weber"))
        buecherListe.Add(New Buch(7, "Betriebssysteme", "Hartmann"))
        buecherListe.Add(New Buch(8, "Netzwerktechnik", "Schulz"))

        benutzerListe.Add(New Benutzer(1, "Max Mustermann"))
        benutzerListe.Add(New Benutzer(2, "Erika Musterfrau"))
        benutzerListe.Add(New Benutzer(3, "Hans Meier"))
        benutzerListe.Add(New Benutzer(4, "Laura Schmidt"))
        benutzerListe.Add(New Benutzer(5, "Tim Becker"))
        benutzerListe.Add(New Benutzer(6, "Sophie Wagner"))
        benutzerListe.Add(New Benutzer(7, "Lukas Hoffmann"))
        benutzerListe.Add(New Benutzer(8, "Anna Koch"))

    End Sub

    ' MENÜ
    Sub Menu()

        Dim auswahl As Integer = -1

        Do
            Console.WriteLine("1 - Buch hinzufügen")
            Console.WriteLine("2 - Benutzer hinzufügen")
            Console.WriteLine("3 - Alle Bücher anzeigen")
            Console.WriteLine("4 - Alle Benutzer anzeigen")
            Console.WriteLine("5 - Buch ausleihen")
            Console.WriteLine("6 - Buch zurückgeben")
            Console.WriteLine("0 - Beenden")

            Dim eingabe As String = Console.ReadLine()

            If IsNumeric(eingabe) Then
                auswahl = Convert.ToInt32(eingabe)
            Else
                auswahl = -1
            End If

            Console.WriteLine()

            If auswahl = 1 Then
                BuchHinzufuegen()
            ElseIf auswahl = 2 Then
                BenutzerHinzufuegen()
            ElseIf auswahl = 3 Then
                AlleBuecher()
            ElseIf auswahl = 4 Then
                AlleBenutzer()
            ElseIf auswahl = 5 Then
                BuchAusleihen()
            ElseIf auswahl = 6 Then
                BuchZurueckgeben()
            ElseIf auswahl = 0 Then
                Console.WriteLine("Programm beendet.")
            Else
                Console.WriteLine("Ungültige Eingabe.")
            End If

            Console.WriteLine()

        Loop While auswahl <> 0

    End Sub

    ' BUCH HINZUFÜGEN
    Sub BuchHinzufuegen()

        Console.Write("ID: ")
        Dim id As Integer = Convert.ToInt32(Console.ReadLine())

        Console.Write("Titel: ")
        Dim titel As String = Console.ReadLine()

        Console.Write("Autor: ")
        Dim autor As String = Console.ReadLine()

        buecherListe.Add(New Buch(id, titel, autor))

    End Sub

    ' BENUTZER HINZUFÜGEN
    Sub BenutzerHinzufuegen()

        Console.Write("ID: ")
        Dim id As Integer = Convert.ToInt32(Console.ReadLine())

        Console.Write("Name: ")
        Dim name As String = Console.ReadLine()

        benutzerListe.Add(New Benutzer(id, name))

    End Sub

    ' ALLE BÜCHER ANZEIGEN
    Sub AlleBuecher()

        For i As Integer = 0 To buecherListe.Count - 1

            Dim status As String

            If buecherListe(i).Verfuegbar Then
                status = "Verfügbar"
            Else
                status = "Ausgeliehen von Benutzer " & buecherListe(i).AusgeliehenVon
            End If

            Console.WriteLine("ID: " & buecherListe(i).Id &
                              " | Titel: " & buecherListe(i).Titel &
                              " | Autor: " & buecherListe(i).Autor &
                              " | Status: " & status)

        Next

    End Sub

    '  ALLE BENUTZER ANZEIGEN
    Sub AlleBenutzer()

        For i As Integer = 0 To benutzerListe.Count - 1

            Console.WriteLine("ID: " & benutzerListe(i).Id &
                              " | Name: " & benutzerListe(i).Name)

        Next

    End Sub
