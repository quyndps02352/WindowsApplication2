<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TrangChủToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐóngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChứcNăngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XemSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrangChủToolStripMenuItem, Me.ChứcNăngToolStripMenuItem, Me.TrợGiúpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(503, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TrangChủToolStripMenuItem
        '
        Me.TrangChủToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngXuấtToolStripMenuItem, Me.ĐóngToolStripMenuItem})
        Me.TrangChủToolStripMenuItem.Name = "TrangChủToolStripMenuItem"
        Me.TrangChủToolStripMenuItem.Size = New System.Drawing.Size(83, 23)
        Me.TrangChủToolStripMenuItem.Text = "trang chủ"
        '
        'ĐăngXuấtToolStripMenuItem
        '
        Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
        Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(143, 24)
        Me.ĐăngXuấtToolStripMenuItem.Text = "đăng xuất"
        '
        'ĐóngToolStripMenuItem
        '
        Me.ĐóngToolStripMenuItem.Name = "ĐóngToolStripMenuItem"
        Me.ĐóngToolStripMenuItem.Size = New System.Drawing.Size(143, 24)
        Me.ĐóngToolStripMenuItem.Text = "đóng"
        '
        'ChứcNăngToolStripMenuItem
        '
        Me.ChứcNăngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmSảnPhẩmToolStripMenuItem, Me.XemSảnPhẩmToolStripMenuItem})
        Me.ChứcNăngToolStripMenuItem.Name = "ChứcNăngToolStripMenuItem"
        Me.ChứcNăngToolStripMenuItem.Size = New System.Drawing.Size(89, 23)
        Me.ChứcNăngToolStripMenuItem.Text = "chức năng"
        '
        'ThêmSảnPhẩmToolStripMenuItem
        '
        Me.ThêmSảnPhẩmToolStripMenuItem.Name = "ThêmSảnPhẩmToolStripMenuItem"
        Me.ThêmSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(206, 24)
        Me.ThêmSảnPhẩmToolStripMenuItem.Text = "thêm sản phẩm"
        '
        'XemSảnPhẩmToolStripMenuItem
        '
        Me.XemSảnPhẩmToolStripMenuItem.Name = "XemSảnPhẩmToolStripMenuItem"
        Me.XemSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(206, 24)
        Me.XemSảnPhẩmToolStripMenuItem.Text = "quản lý khách hàng"
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinAdminToolStripMenuItem})
        Me.TrợGiúpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(74, 23)
        Me.TrợGiúpToolStripMenuItem.Text = "trợ giúp"
        '
        'ThôngTinAdminToolStripMenuItem
        '
        Me.ThôngTinAdminToolStripMenuItem.Name = "ThôngTinAdminToolStripMenuItem"
        Me.ThôngTinAdminToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ThôngTinAdminToolStripMenuItem.Text = "thông tin admin"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources._551347_1397969510460159_1467450255_n
        Me.PictureBox1.Location = New System.Drawing.Point(127, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(269, 199)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 4
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(503, 284)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "main"
        Me.Text = "main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TrangChủToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngXuấtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐóngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChứcNăngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThêmSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XemSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrợGiúpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
