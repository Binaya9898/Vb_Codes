Imports System

Module Program
    Sub Main(args As String())
        Dim ch As Integer
        Console.WriteLine("1. Add")
        Console.WriteLine("2. Sub")
        Console.WriteLine("3. Product")
        Console.WriteLine("4. Division")
        Console.WriteLine("Enter a choice")
        ch = Console.ReadLine()

        Select Case ch
            Case 1
                Dim a, b As Integer
                Console.WriteLine("Enter any two numbers")
                a = Console.ReadLine()
                b = Console.ReadLine()
                Console.WriteLine("The sum is " & a + b)


            Case 2
                Dim a, b As Integer
                Console.WriteLine("Enter any two numbers")
                a = Console.ReadLine()
                b = Console.ReadLine()
                Console.WriteLine("The division is " & a - b)

            Case 3
                Dim a, b As Integer
                Console.WriteLine("Enter any two numbers")
                a = Console.ReadLine()
                b = Console.ReadLine()
                Console.WriteLine("The sum is " & a * b)


            Case 4
                Dim a, b As Integer
                Console.WriteLine("Enter any two numbers")
                a = Console.ReadLine()
                b = Console.ReadLine()
                Console.WriteLine("The sum is " & a / b)

            Case Else
                Console.WriteLine("Invalid Choice")
        End Select








    End Sub
End Module
