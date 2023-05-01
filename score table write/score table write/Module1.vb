Module Module1

    Sub Main()
        Dim sr As IO.StreamReader
        Dim sw As IO.StreamWriter
        Dim score As Single
        sr = New IO.StreamReader("C:\Users\new\OneDrive - New Hall School\Projects\score.csv")
        Dim done As String
        Dim highest As Single = sr.ReadLine()
        Dim readline As String = sr.ReadLine()
        Dim myIntegerArray() As Integer = (From s As Integer In readline.Split(","c)).ToArray
        Console.WriteLine("highest score: {0}", highest)
        sr.Close()
        sw = New IO.StreamWriter("C:\Users\new\OneDrive - New Hall School\Projects\score.csv")
        Console.WriteLine("What yours score?")
        Do
            Try
                score = Console.ReadLine()
                done = "T"
            Catch ex As InvalidCastException
                Console.WriteLine("wrong input! input again")
                done = "F"
            End Try
        Loop Until done = "T"
        If score > highest Then
            sw.WriteLine(score)
            Console.WriteLine("updated")
        Else
            Console.WriteLine("Well done >_<")
        End If
        sw.Close()
        Console.ReadLine()

    End Sub

End Module
