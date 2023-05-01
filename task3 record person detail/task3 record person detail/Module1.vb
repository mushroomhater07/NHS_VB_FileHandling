Imports System.IO
Module Module1
    Structure Bookdetail
        Dim title As String
        Dim isbn As Long
        Dim price As Single
        Dim year As Integer
    End Structure
    Sub Main()
        Write()
        Read()
    End Sub
    Sub Write()
        Dim path As String = "C:\Users\new\OneDrive - New Hall School\Projects\book.bin"
        Dim fs As FileStream
        Dim book As New Bookdetail()
        Dim again As String
        Try
            fs = New FileStream(path, FileMode.CreateNew)
        Catch ex As Exception
            Console.WriteLine("File exist! overwrite mode")
            fs = New FileStream(path, FileMode.Create)
        End Try
        Dim bw As New BinaryWriter(fs)
        Do
            Console.WriteLine("Enter title")
            book.title = Console.ReadLine()
            Console.WriteLine("Enter ISBN code")
            book.isbn = Console.ReadLine()
            Console.WriteLine("Enter the price")
            book.price = Console.ReadLine()
            Console.WriteLine("Enter the year of publish")
            book.year = Console.ReadLine()
            bw.Write(book.title)
            bw.Write(book.isbn)
            bw.Write(book.price)
            bw.Write(book.year)
            Console.Write("Another Entry(Y/N)?: ")
            again = Console.ReadLine.ToUpper()
        Loop Until again = "N"
        bw.Close()
        fs.Close()
        Console.WriteLine("Data entry complete")
        Console.ReadLine()
    End Sub
    Sub Read()
        Dim path As String = "C:\Users\new\OneDrive - New Hall School\Projects\book.bin"
        Dim fs1 As FileStream = New FileStream(path, FileMode.Open)
        Dim br As BinaryReader = New BinaryReader(fs1)
        Dim book1 As New Bookdetail()
        Dim coun As Integer = 0
        Console.WriteLine("Print book detail")
        Try
            Do
                coun += 1
                book1.title = br.ReadString()
                book1.isbn = br.ReadInt64()
                book1.price = br.ReadSingle()
                book1.year = br.ReadInt32()
                Console.WriteLine("book detail [{0}]:", coun)
                Console.WriteLine("book title: {0}", book1.title)
                Console.WriteLine("book isbn: {0}", book1.isbn)
                Console.WriteLine("book price: {0}", book1.price)
                Console.WriteLine("book year: {0}", book1.year)
            Loop While fs1.Position < fs1.Length
        Catch ex As Exception
            Console.WriteLine("All Data Read.")
        End Try
        br.Close()
        fs1.Close()
        Console.ReadLine()
    End Sub

End Module
