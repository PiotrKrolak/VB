Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Error: RS232"


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim l_screen
        l_screen = Loading_screen
        l_screen.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim info As String = "Error: 404"
        MessageBox.Show(info)

        Application.Exit()

    End Sub
End Class
