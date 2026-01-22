Public Class FrmMain
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        FrmNewBook.Show()
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.ShowDialog()
    End Sub
End Class
