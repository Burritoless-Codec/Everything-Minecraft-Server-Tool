Public Class tosagree
    Private Sub tosagree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.TOS = 1
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class