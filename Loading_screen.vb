Public Class Loading_screen
    Private Sub Loading_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        If ToolStripProgressBar1.Value <= ToolStripProgressBar1.Maximum + 1 Then
            ToolStripProgressBar1.Value += 1
        Else
            Timer1.Enabled = False
            Me.Hide()

        End If
    End Sub
End Class