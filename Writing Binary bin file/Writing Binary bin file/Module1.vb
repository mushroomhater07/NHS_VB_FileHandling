Imports System.IO
Module Module1

    Sub Main()
        Dim path As String = "C:\Users\chinghey.lau\Downloads\OneDrive - New Hall School\Projects\save.bin"
        Dim fs As FileStream
        Try
            fs = New FileStream(path, FileMode.CreateNew)
        Catch ex As Exception
            Console.WriteLine("File founded! Overwriting")
            fs = New FileStream(path, FileMode.Create)
        End Try
        Dim bw As BinaryWriter = New BinaryWriter(fs)
        Dim initial, sur As String
        Dim age As Integer
        Console.WriteLine("data entry")
        Console.WriteLine()
        Console.WriteLine("Enter the initial: ")
        initial = Console.ReadLine()
        Console.WriteLine("Enter surname:")
        sur = Console.ReadLine()
        Console.WriteLine("Enter your age:")
        age = Console.ReadLine()

        bw.Write(initial)
        bw.Write(sur)
        bw.Write(age)
        bw.Close()
        fs.Close()
        Console.WriteLine()
        Console.WriteLine("Data Entry Complete. Press Enter to continue")
        Console.ReadLine()
        ' reading 
        Dim fs1 As FileStream = New FileStream(path, FileMode.Open)

        Dim br As BinaryReader = New BinaryReader(fs1)
        Console.Clear()
        Console.WriteLine("Reading File")
        Console.WriteLine()
        initial = br.ReadString()
        Console.WriteLine("Initial: {0}", initial)

        sur = br.ReadString()
        Console.WriteLine("Surname: {0}", sur)

        age = br.ReadInt32()            'ReadInt32() reads a 4-byte signed integer
        Console.WriteLine("Age: {0}", age)
        br.Close()
        fs.Close()
        Console.WriteLine("All Data Read.")
        Console.ReadLine()


    End Sub

End Module
