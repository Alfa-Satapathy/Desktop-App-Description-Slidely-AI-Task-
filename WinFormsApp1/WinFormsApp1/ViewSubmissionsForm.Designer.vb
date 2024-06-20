<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(223, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(344, 23)
        Label1.TabIndex = 0
        Label1.Text = "Piyush, Slidely Task 2-View Submission Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(38, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 23)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(38, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 23)
        Label3.TabIndex = 2
        Label3.Text = "Email id"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(38, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 23)
        Label4.TabIndex = 3
        Label4.Text = "Phone Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(38, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 23)
        Label5.TabIndex = 4
        Label5.Text = "Github Link"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(38, 310)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 23)
        Label6.TabIndex = 9
        Label6.Text = "Stopwatch Timer"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(91, 388)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 29)
        Button1.TabIndex = 11
        Button1.Text = "Previous (Ctrl+P)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(291, 388)
        Button2.Name = "Button2"
        Button2.Size = New Size(157, 29)
        Button2.TabIndex = 12
        Button2.Text = "Next (Ctrl + N)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(490, 388)
        Button3.Name = "Button3"
        Button3.Size = New Size(157, 29)
        Button3.TabIndex = 13
        Button3.Text = "Get Data (CTRL+ D)"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(223, 81)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 20)
        Label7.TabIndex = 14
        Label7.Text = "*Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(223, 135)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 20)
        Label8.TabIndex = 15
        Label8.Text = "*Email Id"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(223, 199)
        Label9.Name = "Label9"
        Label9.Size = New Size(114, 20)
        Label9.TabIndex = 16
        Label9.Text = "*Phone Number"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(223, 259)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 20)
        Label10.TabIndex = 17
        Label10.Text = "*Github Link"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(223, 313)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 20)
        Label11.TabIndex = 18
        Label11.Text = "00:00:00"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
