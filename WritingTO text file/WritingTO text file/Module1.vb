Module Module1

    Sub Main()
        Dim name(4) As String
        Dim objStreamWriter As IO.StreamWriter
        objStreamWriter = New IO.StreamWriter("C:\Users\chinghey.lau\Downloads\OneDrive - New Hall School\Projects\name.txt")
        For count As Integer = 0 To 4
            Console.WriteLine("Enter the name {0}", count + 1)
            name(count) = Console.ReadLine()
            objStreamWriter.WriteLine(name(count))
            objStreamWriter.WriteLine()
        Next
        objStreamWriter.Close()
        Console.WriteLine("successfully inputed")
        Console.ReadLine()
    End Sub

End Module
