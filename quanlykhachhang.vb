Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class quanlykhachhang
    Dim table As New DataTable
    Dim laydl As String = "workstation id=QUYNDPS02352.mssql.somee.com;packet size=4096;user id=quyndps0_SQLLogin_1;pwd=57dil29dn4;data source=QUYNDPS02352.mssql.somee.com;persist security info=False;initial catalog=QUYNDPS02352"
    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        Dim tai As New SqlConnection(laydl)
        Dim them As New SqlDataAdapter("insert into KHACH_HANG values ('" & txtmakh.Text & "','" & txtten.Text & "', '" & txtdiachi.Text & "', '" & txtdt.Text & "')", tai)
        Try
            tai.Open()
            them.Fill(table)

        Catch ex As Exception
            MessageBox.Show("nhập thành công !")
        End Try
        dt1.DataSource = table
        tai.Close()
    End Sub

    Private Sub quanlykhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim load As New SqlConnection(laydl)
        Dim dulieu As New SqlDataAdapter("select * From KHACH_HANG", load)
        Try
            dulieu.Fill(table)
        Catch ex As Exception

        End Try
        dt1.DataSource = table
        Load.Close()
    End Sub

    Private Sub btntim_Click(sender As Object, e As EventArgs) Handles btntim.Click
        Dim some As New SqlConnection(laydl)
        some.Open()
        Dim TimKiem As New SqlDataAdapter("SELECT * FROM KhachHang WHERE MA_KH Like '" & txt1.Text & "' AND TEN_KH LIKE '" & txt2.Text & "' AND DIACHI LIKE '" & txt3.Text & "' AND SDT LIKE '" & txt4.Text & "' ", some)
        Dim bangTimKiem As New DataTable
        Try

            TimKiem.Fill(bangTimKiem)


        Catch ex As Exception
            MessageBox.Show("thông tin đã được cập nhật!")
        End Try
        dt2.DataSource = table
        some.Close()
    End Sub

    Private Sub dt1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt1.CellContentClick

    End Sub
End Class