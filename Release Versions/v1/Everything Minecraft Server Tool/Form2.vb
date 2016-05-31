Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)

        If ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 0
        End If
        Label1.Text = "Checking Settings"
        Timer1.Enabled = False
        Form1.Show()
    End Sub
End Class