Public Class FrmMultiplicationTable
    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim n As Integer

        n = TxtNumber.Text
        TxtTable.Clear()

        For i As Integer = 1 To 10
            TxtTable.Text = TxtTable.Text & n & " × " & i & " = " & n * i & vbCrLf
        Next

        TxtMessage.Text = "After learning the table of " & n & ", learn the table of " & n + 1 & "."
    End Sub
End Class
