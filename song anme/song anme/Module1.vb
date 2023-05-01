Imports System.IO
Module Module1

    Sub Main()
        Dim sr As StreamReader
        Dim team(9) As String
        sr = New StreamReader("C:\Users\chinghey.lau\Downloads\OneDrive - New Hall School\Projects\task4 teamsname.csv")
        team = sr.ReadLine().Split(",")
        sr.Close()
        For count As Integer = 0 To 9
            Console.WriteLine(team(count))
        Next
        Console.ReadLine()

    End Sub

End Module
