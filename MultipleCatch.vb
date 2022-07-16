Module Mmodule1
    Sub main()
        Dim a = 10, b = 0, c As Integer
        Try
            c = a / b
            Console.WriteLine(c)
        Catch ex As OverflowException
            Console.WriteLine(ex.Message)

        Catch ex As DivideByZeroException
            Console.WriteLine(ex.Message)
        Finally
            Console.WriteLine("Enter any key to continue")
            Console.ReadKey()


        End Try


    End Sub
End Module