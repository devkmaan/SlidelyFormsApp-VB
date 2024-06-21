<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        LabelName = New Label()
        LabelEmail = New Label()
        LabelPhoneNum = New Label()
        LabelGithub = New Label()
        TextBoxName = New TextBox()
        TextBoxEmail = New TextBox()
        TextBoxPhoneNum = New TextBox()
        TextBoxGithub = New TextBox()
        ButtonStopwatch = New Button()
        TextBoxStopwatch = New TextBox()
        ButtonSubmit = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()

        Label1.AutoSize = True
        Label1.Location = New Point(202, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 25)
        Label1.TabIndex = 0
        Label1.Text = "Dev Kumar Maan, Slidely Task 2 - Create Submission"


        LabelName.AutoSize = True
        LabelName.Location = New Point(202, 98)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(59, 25)
        LabelName.TabIndex = 1
        LabelName.Text = "Name"

        LabelEmail.AutoSize = True
        LabelEmail.Location = New Point(202, 146)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(54, 25)
        LabelEmail.TabIndex = 2
        LabelEmail.Text = "Email"

        LabelPhoneNum.AutoSize = True
        LabelPhoneNum.Location = New Point(202, 195)
        LabelPhoneNum.Name = "LabelPhoneNum"
        LabelPhoneNum.Size = New Size(106, 25)
        LabelPhoneNum.TabIndex = 3
        LabelPhoneNum.Text = "Phone Num"

        LabelGithub.AutoSize = True
        LabelGithub.Location = New Point(202, 245)
        LabelGithub.Name = "LabelGithub"
        LabelGithub.Size = New Size(185, 25)
        LabelGithub.TabIndex = 4
        LabelGithub.Text = "Github Link For Task 2"

        TextBoxName.Location = New Point(433, 92)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(150, 31)
        TextBoxName.TabIndex = 5

        TextBoxEmail.Location = New Point(433, 140)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(150, 31)
        TextBoxEmail.TabIndex = 6

        TextBoxPhoneNum.Location = New Point(433, 189)
        TextBoxPhoneNum.Name = "TextBoxPhoneNum"
        TextBoxPhoneNum.Size = New Size(150, 31)
        TextBoxPhoneNum.TabIndex = 7

        TextBoxGithub.Location = New Point(433, 239)
        TextBoxGithub.Name = "TextBoxGithub"
        TextBoxGithub.Size = New Size(150, 31)
        TextBoxGithub.TabIndex = 8

        ButtonStopwatch.BackColor = Color.Khaki
        ButtonStopwatch.Location = New Point(202, 294)
        ButtonStopwatch.Name = "ButtonStopwatch"
        ButtonStopwatch.Size = New Size(247, 34)
        ButtonStopwatch.TabIndex = 9
        ButtonStopwatch.Text = "Toggle Stopwatch (Ctrl + T)"
        ButtonStopwatch.UseVisualStyleBackColor = False

        TextBoxStopwatch.Location = New Point(461, 297)
        TextBoxStopwatch.Name = "TextBoxStopwatch"
        TextBoxStopwatch.ReadOnly = True
        TextBoxStopwatch.Size = New Size(122, 31)
        TextBoxStopwatch.TabIndex = 10

        ButtonSubmit.BackColor = Color.PaleTurquoise
        ButtonSubmit.Location = New Point(202, 353)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(381, 34)
        ButtonSubmit.TabIndex = 11
        ButtonSubmit.Text = "Submit (Ctrl + S)"
        ButtonSubmit.UseVisualStyleBackColor = False

        Timer1.Enabled = True
        Timer1.Interval = 1000

        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonSubmit)
        Controls.Add(TextBoxStopwatch)
        Controls.Add(ButtonStopwatch)
        Controls.Add(TextBoxGithub)
        Controls.Add(TextBoxPhoneNum)
        Controls.Add(TextBoxEmail)
        Controls.Add(TextBoxName)
        Controls.Add(LabelGithub)
        Controls.Add(LabelPhoneNum)
        Controls.Add(LabelEmail)
        Controls.Add(LabelName)
        Controls.Add(Label1)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPhoneNum As Label
    Friend WithEvents LabelGithub As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPhoneNum As TextBox
    Friend WithEvents TextBoxGithub As TextBox
    Friend WithEvents ButtonStopwatch As Button
    Friend WithEvents TextBoxStopwatch As TextBox
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents Timer1 As Timer
End Class
