Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class Frmsanpham
    Dim bang As New DataTable
    Dim ketnoi As String = "workstation id=QUYNDPS02352.mssql.somee.com;packet size=4096;user id=quyndps0_SQLLogin_1;pwd=57dil29dn4;data source=QUYNDPS02352.mssql.somee.com;persist security info=False;initial catalog=QUYNDPS02352"
    Public Sub loaddulieu()
        Dim load As New SqlConnection(ketnoi)
        Dim dulieu As New SqlDataAdapter("select * From SAN_PHAM", load)
        Try
            dulieu.Fill(bang)
        Catch ex As Exception

        End Try
        dt1.DataSource = bang
        load.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles xem.Click
        Dim load As New SqlConnection(ketnoi)
        Dim dulieu As New SqlDataAdapter("select * From SAN_PHAM", load)
        Try
            load.Open()
            dulieu.Fill(bang)
        Catch ex As Exception
        End Try
        dt1.DataSource = bang
        load.Close()

    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim load As New SqlConnection(ketnoi)
        Dim them As New SqlDataAdapter("insert into SAN_PHAM values ('" & txtmsp.Text & "','" & txttensp.Text & "', '" & txtloai.Text & "', '" & txtmavach.Text & "')", load)
        Try
            load.Open()
            them.Fill(bang)

        Catch ex As Exception
            MessageBox.Show("nhập thành công !")
        End Try
        dt1.DataSource = bang
        load.Close()
    End Sub

    Private Sub dt1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt1.CellContentClick
        Dim thongtin As Integer = dt1.CurrentCell.RowIndex
        txtmsp.Text = dt1.Item(0, thongtin).Value
        txttensp.Text = dt1.Item(1, thongtin).Value
        txtloai.Text = dt1.Item(2, thongtin).Value
        txtmavach.Text = dt1.Item(3, thongtin).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim load As New SqlConnection(ketnoi)
        load.Open()
        Dim sua As String = " UPDATE SAN_PHAM SET MA_SP=@MA_SP, TEN_SP=@TEN_SP , LOAI_SP=@LOAI_SP, MA_VACH=@MA_VACH"
        Dim com As New SqlCommand(sua, load)
        Try
            com.Parameters.AddWithValue("@MA_SP", txtmsp.Text)
            com.Parameters.AddWithValue("@TEN_SP", txttensp.Text)
            com.Parameters.AddWithValue("@LOAI_SP", txtloai.Text)
            com.Parameters.AddWithValue("@MA_VACH", txtmavach.Text)
            com.ExecuteNonQuery()
            load.Close()
        Catch ex As Exception
            MessageBox.Show("sửa thành công")
        End Try
        bang.Clear()
        dt1.DataSource = bang
        dt1.DataSource = Nothing
        loaddulieu()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim xoa As New SqlConnection(ketnoi)
        xoa.Open()
        Dim thucthi As String = "delete from SAN_PHAM where TEN_SP=@TEN_SP"
        Dim com As New SqlCommand(thucthi, xoa)
        Try
            com.Parameters.AddWithValue("TEN_SP", txttensp.Text)
            com.ExecuteNonQuery()
            xoa.Close()
        Catch ex As Exception
            MessageBox.Show("xóa thành công !")

        End Try
        bang.Clear()
        dt1.DataSource = bang
        dt1.DataSource = Nothing
        loaddulieu()
    End Sub
End Class