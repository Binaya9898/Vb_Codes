Imports System

Module Program
    Sub Main(args As String())

        Dim n As Integer
        Dim i As Integer
        Dim j As Integer
        n = Console.ReadLine()

        For i = 1 To n
            For j = 1 To 10
                Console.Write("     " & i * j)

            Next j
            Console.WriteLine()


        Next i

    End Sub
End Module
