Module program
    Class sum
        Protected a, b As Integer
        Public Sub New(ByVal p As Integer, ByVal q As Integer)
            a = p
            b = q
        End Sub

        Function showData()
            Return a + b
        End Function
        Protected Overrides Sub Finalize()
            Console.WriteLine("Destructor called")

        End Sub

    End Class
    Sub main()
        Dim N As sum = New sum(20, 20)
        Console.WriteLine(N.showData())

    End Sub
End Module