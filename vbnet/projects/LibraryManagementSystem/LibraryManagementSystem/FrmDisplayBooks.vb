Imports System.Data.SqlClient
Public Class FrmDisplayBooks
    Private Sub FrmDisplayBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain

        Dim con As New SqlConnection("Server=(localdb)\csist242702; Database=lms_242702")
        Dim cmd As New SqlCommand("SELECT * FROM book", con)
        con.Open()
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()

        da.Fill(ds)

        DgvBooks.DataSource = ds

        con.Close()
    End Sub

End Class