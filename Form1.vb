Imports Oracle.DataAccess.Client
Imports Telerik.WinControls.UI
Public Class Form1
    Dim query As String
    Dim cid, Cname, dob As String
    Dim Mno As String

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim dt As New DataTable
        dbconnection()
        cid = Rgvcus.CurrentRow.Cells("CID").Value
        Cname = Rgvcus.CurrentRow.Cells("NAME").Value
        dob = Rgvcus.CurrentRow.Cells("DOB").Value
        Mno = Rgvcus.CurrentRow.Cells("MOBNO").Value.ToString
        query = "UPDATE CUST_DETAILS SET NAME='" & Cname & "',DOB='" & dob & "',MOBNO=" & Mno & "WHERE CID=" & cid & ""
        Updatequery(query)
        Rgvcus.Update()
        Gridpanel.Update()
        closeconn()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim dt As New DataTable
        dbconnection()
        cid = Rgvcus.CurrentRow.Cells("CID").Value
        query = "DELETE FROM CUST_DETAILS WHERE CID=" & cid & ""
        Delquery(query)
        query = "SELECT * FROM CUST_DETAILS "
        dt = Selectqry(query)
        If dt.Rows.Count = 0 Then
            MsgBox("No records")
        End If
        Rgvcus.DataSource = dt
        Rgvcus.Update()
        Gridpanel.Update()
        closeconn()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim dt, dt1 As New DataTable
        dbconnection()
        query = "SELECT * FROM CUST_DETAILS "
        dt = Selectqry(query)
        cid = Rgvcus.CurrentRow.Cells("CID").Value
        Cname = Rgvcus.CurrentRow.Cells("NAME").Value
        dob = Rgvcus.CurrentRow.Cells("DOB").Value
        Mno = Rgvcus.CurrentRow.Cells("MOBNO").Value.ToString
        'If Len(dob) = 0 Then
        '    Exit Sub
        'ElseIf Len(dob) < 10 Then
        '    MsgBox("INVALID DATE FORMAT")
        '    Rgvcus.Focus()
        'ElseIf IsDate(dob) = False Or Rgvcus.CurrentRow.Cells("DOB").Value(2) Then
        'End If
        If Len(Mno) > 10 Or Len(Mno) < 10 Then
            MsgBox("INVALID MOBILE NUMBER")
            Rgvcus.Focus()
        Else
            If dt.Rows.Count = Rgvcus.Rows.Count Then
                For Each row As DataRow In dt.Rows
                    For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                        If dt.Rows(i)("CID").ToString = cid Then
                            If dt.Rows(i)("NAME").ToString = Cname Then
                                If dt.Rows(i)("DOB").ToString = dob Then
                                    If dt.Rows(i)("MOBNO").ToString = Mno Then
                                        query = "DELETE FROM CUST_DETAILS WHERE CID=" & cid & ""
                                        Delquery(query)
                                        dt.Rows(i).Delete()
                                        query = "SELECT * FROM CUST_DETAILS "
                                        dt = Selectqry(query)
                                        If dt.Rows.Count = 0 Then
                                            MsgBox("No records")
                                        End If
                                        Rgvcus.DataSource = dt
                                        Rgvcus.Update()
                                        Gridpanel.Update()
                                        Exit For
                                    Else
                                        query = "UPDATE CUST_DETAILS SET MOBNO=" & Mno & "WHERE CID=" & cid & ""
                                        Updatequery(query)
                                        Rgvcus.Update()
                                        Gridpanel.Update()
                                        Exit For
                                    End If
                                Else
                                    query = "UPDATE CUST_DETAILS SET DOB='" & dob & "' WHERE CID=" & cid & ""
                                    Updatequery(query)
                                    Rgvcus.Update()
                                    Gridpanel.Update()
                                    Exit For
                                End If
                            Else
                                query = "UPDATE CUST_DETAILS SET NAME='" & Cname & "'WHERE CID=" & cid & ""
                                Updatequery(query)
                                Rgvcus.Update()
                                Gridpanel.Update()
                                Exit For
                            End If
                        Else

                        End If
                    Next
                Next
            Else
                query = "INSERT INTO CUST_DETAILS VALUES (" & cid & ",'" & Cname & "','" & dob & "'," & Mno & ")"
                insert(query)
                Rgvcus.Update()
                Gridpanel.Update()
            End If
        End If
        closeconn()
    End Sub


    Private Sub Rgvcus_Enter(sender As Object, e As EventArgs) Handles Rgvcus.Enter
        'Rgvcus.Rows.NewRow()
    End Sub

    Private Sub Rgvcus_KeyDown(sender As Object, e As KeyEventArgs) Handles Rgvcus.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub Rgvcus_Click(sender As Object, e As EventArgs) Handles Rgvcus.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dbconnection()
        query = "Select * FROM CUST_DETAILS "
        dt = Selectqry(query)
        If dt.Rows.Count = 0 Then
            MsgBox("No records")
        End If
        Rgvcus.DataSource = dt
        Rgvcus.Update()
        Gridpanel.Update()
        closeconn()
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Dim dt As New DataTable
        dbconnection()
        cid = Rgvcus.CurrentRow.Cells("CID").Value
        Cname = Rgvcus.CurrentRow.Cells("NAME").Value
        dob = Rgvcus.CurrentRow.Cells("DOB").Value
        Mno = Rgvcus.CurrentRow.Cells("MOBNO").Value
        query = "INSERT INTO CUST_DETAILS VALUES (" & cid & ",'" & Cname & "','" & dob & "'," & Mno & ")"
        insert(query)
        Rgvcus.Update()
        Gridpanel.Update()
        closeconn()
    End Sub

End Class
