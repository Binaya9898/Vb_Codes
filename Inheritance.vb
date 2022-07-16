Imports System

Module Module1
    Class Person
        Protected Name, Address As String
        Public Sub GetData(ByVal n As String, ByVal a As String)
            Name = n
            Address = a
        End Sub

    End Class

    Class Employee : Inherits Person
        Protected post As String
        Public Sub data(ByVal p As String)
            post = p

        End Sub
        Function showData()
            Console.WriteLine(Name)
        End Function
    End Class


    Sub main()
        Dim per As New Person
        per.GetData("Binaya", "Pokhara")
        Dim emp As New Employee
        emp.data("Programmer")
        emp.showData()




    End Sub
End Module
