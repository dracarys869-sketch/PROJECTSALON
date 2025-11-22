
Public Class LOGIN

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TXTPASSWORD.UseSystemPasswordChar = True
        Me.AcceptButton = Button1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user = TXTUSER.Text.Trim()
        Dim pass = TXTPASSWORD.Text.Trim()

        If String.Equals(user, "ADMIN", StringComparison.OrdinalIgnoreCase) AndAlso pass = "ADMIN1234" Then
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is Form1 Then
                    frm.Hide()
                    Exit For
                End If
            Next

            Dim f As New Form5()
            f.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TXTPASSWORD.Clear()
            TXTUSER.Focus()
        End If
    End Sub

End Class