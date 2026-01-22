Public Class FrmAddition
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim a, b As Integer
        a = TxtAugend.Text
        b = TxtAddend.Text
        TxtSum.Text = a + b
    End Sub
End Class
