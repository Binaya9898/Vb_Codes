Module Module1
    Public Sub Add(ByVal a As Integer)
        a = a + 1
        Console.WriteLine(a)
    End Sub

    Public Sub Add2(ByRef a As Integer)
        a = a + 5
    End Sub

    Sub main()
        Dim a = 20

        Add(20)
        Add2(a)
        Console.WriteLine("Now original value is changed to " & a)

    End Sub
End Module