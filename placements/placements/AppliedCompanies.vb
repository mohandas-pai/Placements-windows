Imports System.Data.SqlClient
Public Class AppliedCompanies

    Private Sub AppliedCompanies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adp As SqlDataAdapter
        Dim dt As DataTable
        'Dim dr As SqlDataReader
        'Dim sql As SqlCommand
        'Dim cNameLabel, cTypeLabel, cPackageLabel, cIntDateLabel As Label


        adp = New SqlDataAdapter("select C.cname As Name,C.ctype As Type,C.package As Package,C.int_date,AF.regdate as registered_on from COMPANY C, APPLIES_FOR AF, STUDENT S where S.username = '" & CurrentSession.UserName & "' and S.usn = AF.usn and C.cid = AF.cid", con)
        dt = New DataTable
        adp.Fill(dt)
        DataGridView1.DataSource = dt

        'dr = sql.ExecuteReader

        'While dr.Read
        '    cNameLabel = New Label
        '    cTypeLabel = New Label
        '    cPackageLabel = New Label
        '    cIntDateLabel = New Label


        '    cNameLabel.Text = dr("cname")
        '    cTypeLabel.Text = dr("ctype")
        '    cPackageLabel.Text = dr("package").ToString
        '    cIntDateLabel.Text = dr("int_date").ToString
        '    cNameLabel.Location.X = 
        '    Me.Controls.
        '    'Me.Controls.Add(cNameLabel)
        '    Me.Controls.Add(cTypeLabel)
        '    Me.Controls.Add(cPackageLabel)
        '    Me.Controls.Add(cIntDateLabel)
        'End While

    End Sub
End Class