Imports System.Data.SqlClient
'yêu cầu sửa lại lỗi chính tả trong ghi chú ghi sai chính tả đọc càng khó hiểu hơn
' tôi đã thêm chỗ này :)
Public Class frm1
    'xử lý dụe kiện nút buttom'
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim chuoiketnoi As String = "workstation id=QUYNDPS02352.mssql.somee.com;packet size=4096;user id=quyndps0_SQLLogin_1;pwd=57dil29dn4;data source=QUYNDPS02352.mssql.somee.com;persist security info=False;initial catalog=QUYNDPS02352"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NHAN_VIEN where ID_NV='" & txt1.Text & "' and PASS='" & txt2.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            'nhập chính xác'
            If tb.Rows.Count > 0 Then
                MessageBox.Show("kết nối thành công dữ liệu")
                main.Show()
                Me.Hide()
            Else
                'nhạp sai user và pass'
                MessageBox.Show("sai user hoặc pass ! vui long kiểm tra lại")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Me.Close()
    End Sub
End Class
