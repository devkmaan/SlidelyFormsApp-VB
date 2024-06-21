<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        LabelName = New Label()
        LabelEmail = New Label()
        LabelPhoneNum = New Label()
        LabelGithub = New Label()
        LabelStopwatch = New Label()
        TextBoxName = New TextBox()
        TextBoxEmail = New TextBox()
        TextBoxPhoneNum = New TextBox()
        TextBoxGitHub = New TextBox()
        TextBoxStopwatch = New TextBox()
        ButtonPrevious = New Button()
        ButtonNext = New Button()
        ButtonDelete = New Button()
        SuspendLayout()



        Label1.AutoSize = True
        Label1.Location = New Point(188, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(376, 25)
        Label1.TabIndex = 0
        Label1.Text = "Dev Kumar Maan, Slidely Task 2 - View Submissions"


        LabelName.AutoSize = True
        LabelName.Location = New Point(203, 96)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(59, 25)
        LabelName.TabIndex = 1
        LabelName.Text = "Name"


        LabelEmail.AutoSize = True
        LabelEmail.Location = New Point(203, 145)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(54, 25)
        LabelEmail.TabIndex = 2
        LabelEmail.Text = "Email"


        LabelPhoneNum.AutoSize = True
        LabelPhoneNum.Location = New Point(203, 197)
        LabelPhoneNum.Name = "LabelPhoneNum"
        LabelPhoneNum.Size = New Size(106, 25)
        LabelPhoneNum.TabIndex = 3
        LabelPhoneNum.Text = "Phone Num"


        LabelGithub.AutoSize = True
        LabelGithub.Location = New Point(203, 251)
        LabelGithub.Name = "LabelGithub"
        LabelGithub.Size = New Size(185, 25)
        LabelGithub.TabIndex = 4
        LabelGithub.Text = "Github Link For Task 2"


        LabelStopwatch.AutoSize = True
        LabelStopwatch.Location = New Point(203, 304)
        LabelStopwatch.Name = "LabelStopwatch"
        LabelStopwatch.Size = New Size(138, 25)
        LabelStopwatch.TabIndex = 5
        LabelStopwatch.Text = "Stopwatch Time"


        TextBoxName.Location = New Point(389, 93)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.ReadOnly = True
        TextBoxName.Size = New Size(150, 31)
        TextBoxName.TabIndex = 6


        TextBoxEmail.Location = New Point(389, 139)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.ReadOnly = True
        TextBoxEmail.Size = New Size(150, 31)
        TextBoxEmail.TabIndex = 7


        TextBoxPhoneNum.Location = New Point(389, 191)
        TextBoxPhoneNum.Name = "TextBoxPhoneNum"
        TextBoxPhoneNum.ReadOnly = True
        TextBoxPhoneNum.Size = New Size(150, 31)
        TextBoxPhoneNum.TabIndex = 8


        TextBoxGitHub.Location = New Point(389, 245)
        TextBoxGitHub.Name = "TextBoxGitHub"
        TextBoxGitHub.ReadOnly = True
        TextBoxGitHub.Size = New Size(150, 31)
        TextBoxGitHub.TabIndex = 9


        TextBoxStopwatch.Location = New Point(389, 298)
        TextBoxStopwatch.Name = "TextBoxStopwatch"
        TextBoxStopwatch.ReadOnly = True
        TextBoxStopwatch.Size = New Size(150, 31)
        TextBoxStopwatch.TabIndex = 10


        ButtonPrevious.BackColor = Color.Khaki
        ButtonPrevious.Location = New Point(203, 348)
        ButtonPrevious.Name = "ButtonPrevious"
        ButtonPrevious.Size = New Size(163, 30)
        ButtonPrevious.TabIndex = 11
        ButtonPrevious.Text = "Previous (Ctrl + P)"
        ButtonPrevious.UseVisualStyleBackColor = False


        ButtonNext.BackColor = Color.PaleTurquoise
        ButtonNext.Location = New Point(389, 348)
        ButtonNext.Name = "ButtonNext"
        ButtonNext.Size = New Size(150, 30)
        ButtonNext.TabIndex = 12
        ButtonNext.Text = "Next (Ctrl + N)"
        ButtonNext.UseVisualStyleBackColor = False


        ButtonDelete.BackColor = Color.Chocolate
        ButtonDelete.Location = New Point(288, 384)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(165, 34)
        ButtonDelete.TabIndex = 13
        ButtonDelete.Text = "Delete (Ctrl + D)"
        ButtonDelete.UseVisualStyleBackColor = False


        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonNext)
        Controls.Add(ButtonPrevious)
        Controls.Add(TextBoxStopwatch)
        Controls.Add(TextBoxGitHub)
        Controls.Add(TextBoxPhoneNum)
        Controls.Add(TextBoxEmail)
        Controls.Add(TextBoxName)
        Controls.Add(LabelStopwatch)
        Controls.Add(LabelGithub)
        Controls.Add(LabelPhoneNum)
        Controls.Add(LabelEmail)
        Controls.Add(LabelName)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPhoneNum As Label
    Friend WithEvents LabelGithub As Label
    Friend WithEvents LabelStopwatch As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPhoneNum As TextBox
    Friend WithEvents TextBoxGitHub As TextBox
    Friend WithEvents TextBoxStopwatch As TextBox
    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonDelete As Button
End Class
