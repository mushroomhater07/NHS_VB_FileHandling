Imports System.IO
Module Module1

    Sub Main()
        Dim sr As StreamReader
        sr = New StreamReader("C:\Users\chinghey.lau\Downloads\OneDrive - New Hall School\Projects\task1 text.txt")
        Dim line As Integer
        Dim character As Integer
        Dim noofline As String
        Dim wholetext As String
        Do
            noofline = sr.ReadLine()
            character += Len(noofline)
            line += 1
            wholetext = wholetext & noofline
        Loop Until noofline Is Nothing
        Dim words() As String = Split(wholetext, " ")
        Console.WriteLine("number of line: {0}", line)
        Console.WriteLine("number of character: {0}", character)
        Console.WriteLine("number of word: {0}", words.Length)
        Console.ReadLine()

    End Sub

End Module
