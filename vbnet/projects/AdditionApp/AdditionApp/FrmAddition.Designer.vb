<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddition
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
        Me.LblAugent = New System.Windows.Forms.Label()
        Me.TxtAugend = New System.Windows.Forms.TextBox()
        Me.TxtAddend = New System.Windows.Forms.TextBox()
        Me.LblAddend = New System.Windows.Forms.Label()
        Me.TxtSum = New System.Windows.Forms.TextBox()
        Me.LblSum = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblAugent
        '
        Me.LblAugent.AutoSize = True
        Me.LblAugent.Location = New System.Drawing.Point(155, 69)
        Me.LblAugent.Name = "LblAugent"
        Me.LblAugent.Size = New System.Drawing.Size(57, 17)
        Me.LblAugent.TabIndex = 0
        Me.LblAugent.Text = "Augend"
        '
        'TxtAugend
        '
        Me.TxtAugend.Location = New System.Drawing.Point(240, 66)
        Me.TxtAugend.Name = "TxtAugend"
        Me.TxtAugend.Size = New System.Drawing.Size(100, 22)
        Me.TxtAugend.TabIndex = 1
        '
        'TxtAddend
        '
        Me.TxtAddend.Location = New System.Drawing.Point(240, 110)
        Me.TxtAddend.Name = "TxtAddend"
        Me.TxtAddend.Size = New System.Drawing.Size(100, 22)
        Me.TxtAddend.TabIndex = 3
        '
        'LblAddend
        '
        Me.LblAddend.AutoSize = True
        Me.LblAddend.Location = New System.Drawing.Point(155, 113)
        Me.LblAddend.Name = "LblAddend"
        Me.LblAddend.Size = New System.Drawing.Size(57, 17)
        Me.LblAddend.TabIndex = 2
        Me.LblAddend.Text = "Addend"
        '
        'TxtSum
        '
        Me.TxtSum.Location = New System.Drawing.Point(240, 152)
        Me.TxtSum.Name = "TxtSum"
        Me.TxtSum.Size = New System.Drawing.Size(100, 22)
        Me.TxtSum.TabIndex = 5
        '
        'LblSum
        '
        Me.LblSum.AutoSize = True
        Me.LblSum.Location = New System.Drawing.Point(155, 155)
        Me.LblSum.Name = "LblSum"
        Me.LblSum.Size = New System.Drawing.Size(36, 17)
        Me.LblSum.TabIndex = 4
        Me.LblSum.Text = "Sum"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(158, 207)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(74, 36)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'FrmAddition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 332)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtSum)
        Me.Controls.Add(Me.LblSum)
        Me.Controls.Add(Me.TxtAddend)
        Me.Controls.Add(Me.LblAddend)
        Me.Controls.Add(Me.TxtAugend)
        Me.Controls.Add(Me.LblAugent)
        Me.Name = "FrmAddition"
        Me.Text = "AdditionApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblAugent As Label
    Friend WithEvents TxtAugend As TextBox
    Friend WithEvents TxtAddend As TextBox
    Friend WithEvents LblAddend As Label
    Friend WithEvents TxtSum As TextBox
    Friend WithEvents LblSum As Label
    Friend WithEvents BtnAdd As Button
End Class
