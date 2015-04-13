<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanlykhachhang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txtdt = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtten = New System.Windows.Forms.TextBox()
        Me.dt1 = New System.Windows.Forms.DataGridView()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btntim = New System.Windows.Forms.Button()
        Me.dt2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "mã khách hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "tên khách hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "địa chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "số điện thoại"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(137, 21)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(154, 20)
        Me.txtmakh.TabIndex = 0
        '
        'txtdt
        '
        Me.txtdt.Location = New System.Drawing.Point(137, 130)
        Me.txtdt.Name = "txtdt"
        Me.txtdt.Size = New System.Drawing.Size(154, 20)
        Me.txtdt.TabIndex = 1
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(137, 93)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(154, 20)
        Me.txtdiachi.TabIndex = 2
        '
        'txtten
        '
        Me.txtten.Location = New System.Drawing.Point(137, 58)
        Me.txtten.Name = "txtten"
        Me.txtten.Size = New System.Drawing.Size(154, 20)
        Me.txtten.TabIndex = 3
        '
        'dt1
        '
        Me.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt1.Location = New System.Drawing.Point(24, 168)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(267, 129)
        Me.dt1.TabIndex = 8
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(137, 311)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(120, 23)
        Me.btnthem.TabIndex = 9
        Me.btnthem.Text = "thêm khách hàng"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btntim
        '
        Me.btntim.Location = New System.Drawing.Point(432, 311)
        Me.btntim.Name = "btntim"
        Me.btntim.Size = New System.Drawing.Size(75, 23)
        Me.btntim.TabIndex = 10
        Me.btntim.Text = "tìm kiếm"
        Me.btntim.UseVisualStyleBackColor = True
        '
        'dt2
        '
        Me.dt2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt2.Location = New System.Drawing.Point(342, 168)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(353, 129)
        Me.dt2.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt4)
        Me.GroupBox1.Controls.Add(Me.txt3)
        Me.GroupBox1.Controls.Add(Me.txt2)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Location = New System.Drawing.Point(342, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 141)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "tìm kiếm"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(159, 20)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(149, 20)
        Me.txt1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(159, 48)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(149, 20)
        Me.txt2.TabIndex = 1
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(159, 79)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(149, 20)
        Me.txt3.TabIndex = 2
        '
        'txt4
        '
        Me.txt4.Location = New System.Drawing.Point(159, 109)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(149, 20)
        Me.txt4.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "mã khách hàng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "tên khách hàng"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "địa chỉ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "số điện thoại"
        '
        'quanlykhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(782, 346)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dt2)
        Me.Controls.Add(Me.btntim)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtten)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtdt)
        Me.Controls.Add(Me.txtmakh)
        Me.Name = "quanlykhachhang"
        Me.Text = "khách hàng"
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txtdt As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtten As System.Windows.Forms.TextBox
    Friend WithEvents dt1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btntim As System.Windows.Forms.Button
    Friend WithEvents dt2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt4 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
End Class
