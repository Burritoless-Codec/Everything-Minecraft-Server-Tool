Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Close()
        tosagree.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text (*.txt)|*.txt"
        sfd.FileName = "eula"
        If RadioButton1.Checked = True Then
            If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim sw As New System.IO.StreamWriter(sfd.FileName)
                sw.Write("eula=true")
                sw.Close()
            End If
        Else
            If RadioButton2.Checked = True Then
                If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Dim sw As New System.IO.StreamWriter(sfd.FileName)
                    sw.Write("eula=flase")
                    sw.Close()
                End If
            End If
        End If
    End Sub

End Class
