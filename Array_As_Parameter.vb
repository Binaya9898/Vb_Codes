Module Module1
    Public Function Sum(ByVal arr As Integer())
        Dim p As Integer() = arr
        Dim i As Integer
        Dim total As Integer
        For i = 0 To 3
            total = total + p(i)

        Next i

        Return total
    End Function

    Sub main()
        Dim data As Integer() = {10, 20, 30}
        Sum(data)


    End Sub
End Module
