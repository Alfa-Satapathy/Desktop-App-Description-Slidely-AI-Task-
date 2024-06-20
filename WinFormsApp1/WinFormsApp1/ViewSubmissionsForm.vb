Imports System.Windows.Forms

Public Class ViewSubmissionsForm
    Public Property S1 As String
    Public Property S2 As String
    Public Property S3 As String
    Public Property S4 As String

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = S1
        Label8.Text = S2
        Label9.Text = S3
        Label10.Text = S4
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle hotkeys here
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Ctrl+P is pressed
            Button1.PerformClick() ' Simulate a click on Button1
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl+N is pressed
            Button2.PerformClick() ' Simulate a click on Button2
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            ' Ctrl+D is pressed
            Button3.PerformClick() ' Simulate a click on Button3
        End If
    End Sub
End Class
