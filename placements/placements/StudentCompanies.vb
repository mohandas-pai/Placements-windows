Imports System.Data.SqlClient
Public Class StudentCompanies

    Dim selectedCid As Integer

    Private Sub StudentCompanies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select C.cname As Name,C.ctype As Type,C.package As Package,C.int_date, C.cid from COMPANY C, STUDENT S, ELIGIBLE_FOR EF where S.username = '" & CurrentSession.UserName & "' and S.dept = EF.dcode and C.cid = EF.cid", con)
        dt = New DataTable
        adp.Fill(dt)
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        For Each row In dt.Rows
            Dim newPanel As FlowLayoutPanel
            Dim cname As Label
            Dim compType As Label
            Dim package As Label
            Dim reg As Button
            newPanel = New FlowLayoutPanel
            newPanel.FlowDirection = FlowDirection.LeftToRight

            cname = New Label
            cname.Text = row.Item(0)
            compType = New Label
            compType.Text = row.Item(1)
            package = New Label
            package.Text = row.Item(2)

            cname.ForeColor = Color.Brown
            compType.ForeColor = Color.Blue
            package.ForeColor = Color.Brown

            reg = New Button
            reg.Text = "REGISTER"
            reg.Tag = row.Item(4)
            reg.BackColor = Color.BlanchedAlmond
            AddHandler reg.MouseClick, AddressOf RegButton_Click

            newPanel.Controls.Add(cname)
            newPanel.Controls.Add(compType)
            newPanel.Controls.Add(package)
            newPanel.Controls.Add(reg)

            newPanel.FlowDirection = FlowDirection.LeftToRight

            FlowLayoutPanel1.Controls.Add(newPanel)

        Next

    End Sub

    Private Sub RegButton_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)

        selectedCid = button.Tag

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        ' First we check if he has been placed
        adp = New SqlDataAdapter("select * from STUDENT S where S.username = '" & CurrentSession.UserName & "' and S.username in ( select S.username from APPLIES_FOR AF, STUDENT S where S.usn = AF.usn and AF.is_placed = 1)", con)
        dt = New DataTable
        adp.Fill(dt)

        If dt.Rows.Count > 0 Then
            MsgBox("You've already been placed in a company!")
        Else
            ' Now we check if he has applied for this company
            adp = New SqlDataAdapter("select * from STUDENT S where S.username = '" & CurrentSession.UserName & "' and S.username in ( select S.username from APPLIES_FOR AF,STUDENT S where AF.usn = S.usn and AF.cid = " & selectedCid & ")", con)
            dt = New DataTable
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("You've already registered for this company!")
            Else
                ' Now we check if he has applied for 3 companies already
                adp = New SqlDataAdapter("select * from STUDENT S where S.username = '" & CurrentSession.UserName & "' and S.username in ( select S.username from COMPANY C, APPLIES_FOR AF, STUDENT S where S.usn = AF.usn and C.cid = AF.cid group by S.username having COUNT(*) >= 2 )", con)
                dt = New DataTable
                adp.Fill(dt)

                If dt.Rows.Count > 0 Then
                    MsgBox("You've already registered for 2 companies!")
                Else
                    ' TODO: Validate Grades with company's requirements
                    Dim dialogResult As MsgBoxResult
                    dialogResult = MsgBox("Are you sure you want to register for this company?", MsgBoxStyle.YesNo)
                    If dialogResult = MsgBoxResult.Yes Then
                        ' insert into db
                        Dim adp1 As SqlDataAdapter
                        Dim adp2 As SqlDataAdapter
                        Dim dt1 As DataTable
                        Dim dt2 As DataTable
                        dt1 = New DataTable
                        dt2 = New DataTable
                        adp1 = New SqlDataAdapter("select C.req_sslc,C.req_puc,C.req_cgpa from COMPANY C where C.cid=" & selectedCid & "", con)
                        adp1.Fill(dt1)
                        adp2 = New SqlDataAdapter("select G.sslc,G.puc,G.cgpa from GRADE G,STUDENT S where  S. username = '" & CurrentSession.UserName & "' and G.usn=S.usn", con)
                        adp2.Fill(dt2)
                        MsgBox("MY CGPA IS " + dt2.Rows(0).Item(2).ToString)
                        If (dt1.Rows(0).Item(0).ToString > dt2.Rows(0).Item(0).ToString) Then
                            MsgBox("Minimum SSLC is " + dt1.Rows(0).Item(0).ToString)
                        ElseIf (dt1.Rows(0).Item(1).ToString > dt2.Rows(0).Item(1).ToString) Then
                            MsgBox("Minimum PUC is " + dt1.Rows(0).Item(1).ToString)
                        ElseIf (dt1.Rows(0).Item(2).ToString > dt2.Rows(0).Item(2).ToString) Then
                            MsgBox("Minimum CGPA is " + dt1.Rows(0).Item(2).ToString)
                        Else
                            Dim sqlcmd As SqlCommand
                            sqlcmd = New SqlCommand("insert into APPLIES_FOR select usn, " & selectedCid & ", GETDATE(),0 from STUDENT where username = '" & CurrentSession.UserName & "'", con)
                            If sqlcmd.ExecuteNonQuery() > 0 Then
                                MsgBox("Sucessfully registered for the company!")
                            Else
                                MsgBox("Error: Contact administrator")
                            End If
                        End If
                End If
                End If

            End If

        End If

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class