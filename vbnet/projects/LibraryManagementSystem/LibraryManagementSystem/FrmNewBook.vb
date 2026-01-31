Imports System.Data.SqlClient
Public Class FrmNewBook
    Private Sub FrmNewBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMain


    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim con As New SqlConnection("Server=(localdb)\csist242702; Database=lms_242702")
        Dim cmd As New SqlCommand("SELECT * FROM book", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dr As DataRow
        Dim cb As New SqlCommandBuilder(da)

        Dim ds As New DataSet()
        con.Open()
        da.Fill(ds)
        dr = ds.Tables(0).NewRow()
        dr(1) = TxtTitle.Text
        ds.Tables(0).Rows.Add(dr)
        da.Update(ds)
        MessageBox.Show("Aal is Well!")
        con.Close()
        TxtTitle.Clear()
        TxtAuthor.Clear()
        TxtEdition.Clear()
    End Sub
End Class