<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMultiplicationTable
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
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.TxtTable = New System.Windows.Forms.TextBox()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.TxtMessage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(175, 516)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number"
        '
        'TxtNumber
        '
        Me.TxtNumber.BackColor = System.Drawing.Color.Black
        Me.TxtNumber.Font = New System.Drawing.Font("Segoe Print", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumber.ForeColor = System.Drawing.Color.White
        Me.TxtNumber.Location = New System.Drawing.Point(292, 513)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(107, 48)
        Me.TxtNumber.TabIndex = 1
        Me.TxtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTable
        '
        Me.TxtTable.BackColor = System.Drawing.Color.Black
        Me.TxtTable.Font = New System.Drawing.Font("Segoe Print", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTable.ForeColor = System.Drawing.Color.White
        Me.TxtTable.Location = New System.Drawing.Point(41, 44)
        Me.TxtTable.Multiline = True
        Me.TxtTable.Name = "TxtTable"
        Me.TxtTable.Size = New System.Drawing.Size(332, 418)
        Me.TxtTable.TabIndex = 2
        '
        'BtnShow
        '
        Me.BtnShow.BackColor = System.Drawing.Color.Black
        Me.BtnShow.Font = New System.Drawing.Font("Segoe Print", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.ForeColor = System.Drawing.Color.White
        Me.BtnShow.Location = New System.Drawing.Point(429, 509)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(108, 54)
        Me.BtnShow.TabIndex = 3
        Me.BtnShow.Text = "&Show"
        Me.BtnShow.UseVisualStyleBackColor = False
        '
        'TxtMessage
        '
        Me.TxtMessage.BackColor = System.Drawing.Color.Black
        Me.TxtMessage.Font = New System.Drawing.Font("Segoe Print", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMessage.ForeColor = System.Drawing.Color.White
        Me.TxtMessage.Location = New System.Drawing.Point(379, 44)
        Me.TxtMessage.Multiline = True
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.Size = New System.Drawing.Size(332, 418)
        Me.TxtMessage.TabIndex = 4
        '
        'FrmMultiplicationTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(765, 641)
        Me.Controls.Add(Me.TxtMessage)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.TxtTable)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMultiplicationTable"
        Me.Text = "Multiplication Table v1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents TxtTable As TextBox
    Friend WithEvents BtnShow As Button
    Friend WithEvents TxtMessage As TextBox
End Class
