Imports System.IO
Module Module1


    Function WriteTo()
        Dim fs As New FileStream("D:\Exam\ConsoleApp1\bin.txt", FileMode.Create)
        Dim fw As New BinaryWriter(fs)
        fw.Write("Hello I am Binaya")
        fs.Close()
    End Function
    Function ReadFrom()
        Dim p As String
        Dim fd As New FileStream("D:\Exam\ConsoleApp1\bin.txt", FileMode.Open)
        Dim fr As New BinaryReader(fd)
        p = fr.ReadString()
        Return p
    End Function

    Sub main()
        Console.WriteLine(WriteTo())
        Console.WriteLine(ReadFrom())


    End Sub
End Module
