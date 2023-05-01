Module Module1

    Sub Main()
        Dim colour() As String = {"red", "orange", "yellow", "green"}
        Dim sw As IO.StreamWriter
        sw = New IO.StreamWriter("C:\Users\chinghey.lau\Downloads\OneDrive - New Hall School\Projects\rainbow.csv")
        For count As Integer = 0 To colour.Length - 1
            sw.Write(colour(count))
            sw.WriteLine(",")
        Next
        sw.Close()
    End Sub

End Module
