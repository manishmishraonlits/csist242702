Imports System.Data.SqlClient
Public Class FrmNewBook
    Private Sub FrmNewBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain


    End Sub

    Private Sub BtnTestDatabase_Click(sender As Object, e As EventArgs) Handles BtnTestDatabase.Click
        Dim con As New SqlConnection("server=(localdb)\csist232603; database=lms")
        Dim cmd As New SqlCommand("SELECT * FROM book", con)
        con.Open()
        cmd.ExecuteReader()
        MessageBox.Show("Aal is well!")
        con.Close()
    End Sub
End Class