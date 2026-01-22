<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewBook
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
        Me.BtnTestDatabase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnTestDatabase
        '
        Me.BtnTestDatabase.Location = New System.Drawing.Point(294, 173)
        Me.BtnTestDatabase.Name = "BtnTestDatabase"
        Me.BtnTestDatabase.Size = New System.Drawing.Size(155, 88)
        Me.BtnTestDatabase.TabIndex = 0
        Me.BtnTestDatabase.Text = "Test Database"
        Me.BtnTestDatabase.UseVisualStyleBackColor = True
        '
        'FrmNewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTestDatabase)
        Me.Name = "FrmNewBook"
        Me.Text = "LMS - New Book"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnTestDatabase As Button
End Class
