Imports System.IO
Module Module1

    Sub Main()
        Dim sr As System.IO.StreamReader
        Dim teamname(9) As String
        Dim count As Integer = 0
        Dim strline As String
        sr = New System.IO.StreamReader("C:\Users\chinghey.lau\Downloads\OneDrive - New Hall School\Projects\task2 team name.txt")
        strline = sr.ReadLine
        Do While Not strline Is Nothing
            teamname(count) = strline
            strline = sr.ReadLine
            count += 1
        Loop
        sr.Close()
        For count = 0 To 9
            Console.Write(teamname(count))
            Console.Write(",")
        Next
        Console.ReadLine()
    End Sub

End Module
