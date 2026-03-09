Imports System
Imports System.Collections.Generic

' ==============================
' KLASSE BUCH
' ==============================
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

' ==============================
' KLASSE BENUTZER
' ==============================
Public Class Benutzer
    Public Property Id As Integer
    Public Property Name As String

    Public Sub New(id As Integer, name As String)
        Me.Id = id
        Me.Name = name
    End Sub
End Class
