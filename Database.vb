'Wap to insert Name address phn age of a student to a stdnt-tabla And display data in datagried view.

Imports System.Data.OleDb

Module Module1
    Sub main()

        Dim connectionString As String = "Provider=Microsoft.JET.OLEDB.4.0;Data Source= myfile.accdb"
        Dim Cn As OleDbConnection
        Cn = New OleDbConnection(connectionString)
        Dim oledbd As New OleDbDataAdapter
        Dim cmd As OleDbCommand
        Dim sql As String
        Dim dt As New DataTable
        Dim ds As New DataSet


        Dim choice As Integer
        Console.WriteLine("Enter choice")
        choice = Console.ReadLine()
        Select Case choice
            Case 1
                Dim name, address As String
                Dim age, phn As Integer
                Try
                    Cn.Open()

                    sql = "insert into stdnt-table values('" & name & "','" & address & "'," & phn & "," & age & ")"
                    cmd = New OleDbCommand(sql, Cn)
                    cmd.ExecuteNonQuery()
                    Cn.Close()
                Catch ex As Exception
                    Console.WriteLine("Error")

                End Try
            Case 2

                Cn.Open()
                sql = "select * from stdnt-table"
                oledbd = New OleDbDataAdapter(sql, Cn)
                oledbd.Fill(dt)
                DataGriedView.DataSource = dt.defaultView
                Cn.Close()


        End Select
    End Sub




End Module
