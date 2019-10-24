Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim info_rs232 As String = "Error: RS232"
        MessageBox.Show(info_rs232)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim l_screen
        l_screen = Loading_screen
        l_screen.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim info_exit As String = "Error: 404"
        MessageBox.Show(info_exit)
        End 'zamyka aplikacje
        'Application.Exit() ' zamyka aplikacje inaczej niz wyzej

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub RS232ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RS232ToolStripMenuItem.Click
        Rs_settings.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Aplikacja stworzona w przyspieszenia przejść pomiędzy testerami wykorzystującymi jeden komputer.")
    End Sub
End Class
