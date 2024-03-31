Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTxtbox.Text = "Username"
        NameTxtbox.ForeColor = Color.DarkGray

        PswdTxtbox.Text = "Password"
        PswdTxtbox.ForeColor = Color.DarkGray
    End Sub

    Private Sub NameTxtbox_GotFocus(sender As Object, e As EventArgs) Handles NameTxtbox.GotFocus
        If NameTxtbox.Text = "Username" Then
            NameTxtbox.Text = ""
            NameTxtbox.ForeColor = Color.Black

        End If
    End Sub

    Private Sub NameTxtbox_LostFocus(sender As Object, e As EventArgs) Handles NameTxtbox.LostFocus
        If NameTxtbox.Text = "" Then
            NameTxtbox.Text = "Username"
            NameTxtbox.ForeColor = Color.DarkGray

        End If
    End Sub

    Private Sub PswdTxtbox_GotFocus(sender As Object, e As EventArgs) Handles PswdTxtbox.GotFocus
        If PswdTxtbox.Text = "Password" Then
            PswdTxtbox.Text = ""
            PswdTxtbox.PasswordChar = "●"
            PswdTxtbox.ForeColor = Color.Black

        End If
    End Sub

    Private Sub PswdTxtbox_LostFocus(sender As Object, e As EventArgs) Handles PswdTxtbox.LostFocus
        If PswdTxtbox.Text = "" Then
            PswdTxtbox.Text = "Password"
            PswdTxtbox.PasswordChar = ""
            PswdTxtbox.ForeColor = Color.DarkGray

        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim username As String = NameTxtbox.Text
        Dim password As String = PswdTxtbox.Text
        If Username = "admin" AndAlso password = "password" Then
            ' Create an instance of the FoodForm
            Dim Form2 As New Form2()

            ' Show the FoodForm
            Form2.Show()


            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub
End Class
