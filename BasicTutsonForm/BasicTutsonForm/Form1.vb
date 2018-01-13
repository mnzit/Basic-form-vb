Public Class LoginForm
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If (UsernameTb.Text = "admin" And PasswordTb.Text = "admin" And UsertypeCb.Text = "Admin") Then
            Dim frm As New MainForm()
            frm.Show()
            Me.Hide()
            frm.UsernameLbl.Text = "Welcome: " & UsernameTb.Text()
        Else
            MessageBox.Show("Please enter valid username, password and usertype!!")
        End If

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsertypeCb.SelectedIndex = 0
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Application.Exit()
    End Sub
End Class
