Module program
    Sub main()
        Dim a As Integer
        Dim b As Integer
        Console.WriteLine("Enter divisor and divider respectively")
        a = Console.ReadLine()
        b = Console.ReadLine()
        Try
            Dim c As Integer
            c = a / b
            Console.WriteLine(c)
        Catch ex As Exception
            Console.WriteLine("Attemp to divide by zero")
        Finally
            Console.WriteLine("Press any key to terminate")
            Console.ReadKey()

        End Try
    End Sub
End Module