Imports System

Module Module1
    Class Person
        Protected Name, Address As String
        Public Sub New(ByVal n As String, ByVal a As String)
            Name = n
            Address = a
        End Sub

        Function ShowData()
            Console.WriteLine(Name & " " & Address)
        End Function

        Protected Overrides Sub Finalize()
            Console.WriteLine("Destructor Called")
        End Sub

    End Class



    Sub main()
        Dim per As New Person("Binaya", "Pokhara")
        per.ShowData()

    End Sub
End Module
