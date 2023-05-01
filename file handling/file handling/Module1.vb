Module Module1

    Sub Main()
        Dim objStreamReader As IO.StreamReader
        Dim strLine As String
        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New IO.StreamReader("C:\Users\chinghey.lau\Downloads\OneDrive - New Hall School\9.1.1NewTable.csv")
        'Read the first line of text.
        strLine = objStreamReader.ReadLine
        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            'Write the line to the Console window.
            Console.WriteLine(strLine)
            'Read the next line.
            strLine = objStreamReader.ReadLine
        Loop
        'Close the file.
        objStreamReader.Close()
        Console.ReadLine()

    End Sub

End Module
