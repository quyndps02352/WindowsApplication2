Public Class main
    Dim str As String = "Wellcome !!"
    Dim dodaichuoi As Integer = Str.Length
    Dim khtrang As Integer
    Dim strtam As String = ""
    Dim strtrang As String = ""
    Dim strlb As String
    Dim i As Integer = 0

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label1.Text = str.Substring(0, 1)
    End Sub
    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        frm1.ShowDialog()
        Me.Hide() 'ẩn form chính
    End Sub

    Private Sub ĐóngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐóngToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub ThêmSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmSảnPhẩmToolStripMenuItem.Click
        Frmsanpham.ShowDialog()
    End Sub

    Private Sub XemSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemSảnPhẩmToolStripMenuItem.Click
        quanlykhachhang.ShowDialog()
    End Sub

    Private Sub ThôngTinAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinAdminToolStripMenuItem.Click
        Frmadmin.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        khtrang = 10 - Label1.Text.Length
        If Label1.Text.Length < dodaichuoi Then
            strtam = str.Substring(Label1.Text.Length, 1)
        End If
        strlb = Label1.Text
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = str Then
            If i < 30 Then
                i = i + 1
            Else
                i = 0
                Label1.Text = str.Substring(0, 1)
                Timer2.Enabled = False
                Timer1.Enabled = True
            End If
        Else
            If strtam <> " " Then
                For i As Integer = 1 To khtrang
                    strtrang = strtrang & " "
                Next
                khtrang = khtrang - 1
                Label1.Text = strlb & strtrang & strtam
                If khtrang = 0 Then
                    Label1.Text = strlb & strtam
                    Timer2.Enabled = False
                    Timer1.Enabled = True
                End If
                strtrang = ""
            Else
                Label1.Text = Label1.Text & " "
                Timer2.Enabled = False
                Timer1.Enabled = True
            End If
        End If
    End Sub
End Class