Imports System.Net.Http

Public Class CreateSubmissionForm

    Dim ss, tt, vv As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        vv = 0
        tt = 0
        ss = 0
        TextBox5.Text = "00:00:00"
        Timer1.Enabled = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox5.Text = Format(ss, "00:") & Format(tt, "00:") & Format(vv, "00")
        vv = vv + 1
        If vv > 59 Then
            vv = 0
            tt = tt + 1
        End If
        If tt = 2 Then
            vv = 0
            tt = 0
            TextBox5.Text = "00:00:00"
            Timer1.Enabled = False
            MessageBox.Show("Time Ended")
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1, s2, s3, s4 As String
        s1 = TextBox1.Text
        s2 = TextBox2.Text
        s3 = TextBox3.Text
        s4 = TextBox4.Text
        MsgBox("Name: " + s1 + vbCrLf + "Email id: " + s2 + vbCrLf + "Phone Number: " + s3 + vbCrLf + "Github Link: " + s4)
        Dim OBJ As New ViewSubmissionsForm
        OBJ.S1 = TextBox1.Text
        OBJ.S2 = TextBox2.Text
        OBJ.S3 = TextBox3.Text
        OBJ.S4 = TextBox4.Text
        OBJ.Show()
        Me.Hide()
    End Sub
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        ' Other initialization code if needed
    End Sub
    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle hotkeys here
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Button1.PerformClick() ' Simulate a click on Button1
        ElseIf e.Control AndAlso e.KeyCode = Keys.Q Then
            Button2.PerformClick() ' Simulate a click on Button2
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            Button3.PerformClick() ' Simulate a click on Button3
        ElseIf e.Control AndAlso e.KeyCode = Keys.R Then
            Button4.PerformClick() ' Simulate a click on Button4
        End If
    End Sub


End Class
