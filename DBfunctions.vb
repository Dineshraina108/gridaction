Imports Oracle.DataAccess.Client
Module DBfunctions
    Public con As New OracleConnection
    Dim ora_ada As New OracleDataAdapter
    Public Sub dbconnection()
        con.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        con.Open()
    End Sub
    Public Sub closeconn()
        con.Close()
    End Sub
    Public Sub insert(ByRef qry As String)
        Dim Tval As Long = 0
        Using Cmd As New OracleCommand(qry, con)
            Tval = Cmd.ExecuteNonQuery()
        End Using
        If Tval > 0 Then
            MsgBox("inserted Successful....!")
        Else
            MsgBox("Failed to insert ....!")
        End If
    End Sub
    Public Sub Updatequery(ByRef qry As String)
        Dim dt As New DataTable
        Dim Tval As Long = 0
        Using Cmd As New OracleCommand(qry, con)
            Tval = Cmd.ExecuteNonQuery()
        End Using
        If Tval > 0 Then
            MsgBox("updated Successful....!")
        Else
            MsgBox("Failed to update ....!")
        End If
    End Sub
    Public Sub Delquery(ByRef qry As String)
        Dim Tval As Long = 0
        Using Cmd As New OracleCommand(qry, con)
            Tval = Cmd.ExecuteNonQuery()
        End Using
        If Tval > 0 Then
            MsgBox("Deleted Successful....!")
        Else
            MsgBox("Failed to Delete ....!")
        End If
    End Sub
    Public Function Selectqry(ByRef qry As String)
        Dim dt As New DataTable
        Using cmd As New OracleCommand(qry, con)
            Using ora_ada As New OracleDataAdapter(cmd)
                ora_ada.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
End Module
