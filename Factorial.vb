Module Program
    Function factorial(ByVal a As Integer)
        Dim i As Integer
        Dim fact As Integer

        For i = 1 To a
            fact = fact * i
            i = i + 1
        Next
        Return fact
    End Function

    Sub main()
        Dim x As Integer
        Dim y As Integer
        Console.WriteLine("Enter a number to find a factorial")
        x = Console.ReadLine()
        y = factorial(x)
        Console.WriteLine(y)


    End Sub
End Module