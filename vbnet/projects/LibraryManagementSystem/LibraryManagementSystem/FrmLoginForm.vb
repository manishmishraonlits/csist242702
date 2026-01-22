Imports System.Data.SqlClient
Public Class FrmLoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Dim con As New SqlConnection("Server=(localdb)\csist242702; Database=lms_242702")
        Dim cmd As New SqlCommand("SELECT * FROM users WHERE user_id='" & TxtUsername.Text & "' AND password='" & TxtPassword.Text & "'", con)
        Dim dr As SqlDataReader
        con.Open()
        dr = cmd.ExecuteReader()
        If (dr.Read) Then
            FrmMain.Show()
            Me.Close()
        Else
            MessageBox.Show("User id/Password invalid!")
        End If
        con.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

End Class
