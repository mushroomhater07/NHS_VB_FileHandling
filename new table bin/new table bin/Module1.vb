Imports System.IO
Module Module1

    Sub Main()
        Dim path As String = "C:\Users\chinghey.lau\Downloads\OneDrive - New Hall School\Projects\newtable.bin"
        Dim sr As StreamReader = New StreamReader("C:\Users\chinghey.lau\Downloads\OneDrive - New Hall School\Projects\9.1.1 NewTable.csv")
        Dim fs As FileStream
        Try
            fs = New FileStream(path, FileMode.CreateNew)
        Catch ex As Exception
            Console.WriteLine("file exist! overwrited!")
            fs = New FileStream(path, FileMode.Create)
        End Try
        Dim bw As BinaryWriter = New BinaryWriter(fs)
        Dim word() As String = Split(sr.ReadLine(), ",")
        bw.Write(word.Length())
        For count As Integer = 0 To word.Length() - 1
            Console.WriteLine("input: {0}", word(count))
            bw.Write(word(count))
        Next
        bw.Close()
        fs.Close()
        Console.ReadLine()
        Dim fs1 As FileStream = New FileStream(path, FileMode.Open)
        Dim br As BinaryReader = New BinaryReader(fs1)
        Dim length As Integer = br.ReadInt32()
        For coun As Integer = 0 To length - 1
            Console.WriteLine("binary read: {0}", br.ReadString())
        Next
        br.Close()
        fs1.Close()
        Console.ReadLine()

    End Sub

End Module
