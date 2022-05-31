Imports System

Module Program
    Sub Main(args As String())
        Dim a As String
        Dim b As String
        Console.WriteLine("Enter a string")
        a = Console.ReadLine()
        Console.WriteLine(" Ucase Function =>   " & UCase(a))
        Console.WriteLine(" Lcase Function =>   " & LCase(a))
        Console.WriteLine(" Substring      =>   " & a.Substring(0, 5))
        b = a
        Console.WriteLine(" Clone          =>   " & b)


        '  The string function Substring is used to extract the letters from the string'
        'Substring takes the starting index and ending index as argument

        ' Clone is a function that can make a copy of value of a previously used or defined variable.

    End Sub
End Module
