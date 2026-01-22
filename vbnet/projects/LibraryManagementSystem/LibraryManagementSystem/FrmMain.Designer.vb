<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CirculationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookToolStripMenuItem, Me.MemberToolStripMenuItem, Me.CirculationToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.BookToolStripMenuItem.Text = "&Book"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.EditToolStripMenuItem1})
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.MemberToolStripMenuItem.Text = "&Member"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.NewToolStripMenuItem1.Text = "&New"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(122, 26)
        Me.EditToolStripMenuItem1.Text = "&Edit"
        '
        'CirculationToolStripMenuItem
        '
        Me.CirculationToolStripMenuItem.Name = "CirculationToolStripMenuItem"
        Me.CirculationToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.CirculationToolStripMenuItem.Text = "&Circulation"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.UserToolStripMenuItem.Text = "&User"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Library Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CirculationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
End Class
