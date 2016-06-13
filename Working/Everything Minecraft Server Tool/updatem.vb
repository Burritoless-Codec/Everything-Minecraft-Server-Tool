Imports System.IO
Imports System.Net
Imports System.Web

Public Class updatem
    Public Sub cfu()

    End Sub
    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Application.ProductVersion
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cfu()
    End Sub
End Class