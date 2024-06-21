Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchTime As TimeSpan = TimeSpan.Zero

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub ButtonStopwatch_Click(sender As Object, e As EventArgs) Handles ButtonStopwatch.Click
        ToggleStopwatch()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1))
        TextBoxStopwatch.Text = stopwatchTime.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Await SubmitFormAsync()
    End Sub

    Private Async Function SubmitFormAsync() As Task
        Dim name As String = TextBoxName.Text
        Dim email As String = TextBoxEmail.Text
        Dim phone As String = TextBoxPhoneNum.Text
        Dim githubLink As String = TextBoxGithub.Text
        Dim stopwatchTimeStr As String = stopwatchTime.ToString("hh\:mm\:ss")

        Dim submission As New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phone", phone},
            {"github_link", githubLink},
            {"stopwatch_time", stopwatchTimeStr}
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Try
                Console.WriteLine("Submitting data to the backend")
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful!")
                    Me.Close()  ' Close the form after successful submission
                Else
                    Dim errorMsg As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show("Submission failed. " & errorMsg)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub ToggleStopwatch()
        If stopwatchRunning Then
            Timer1.Stop()
            stopwatchRunning = False
        Else
            Timer1.Start()
            stopwatchRunning = True
        End If
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ButtonSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch()
        End If
    End Sub

    Private Sub CreateSubmissionForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim mainForm As Form1 = DirectCast(Application.OpenForms("Form1"), Form1)
        If mainForm IsNot Nothing Then
            mainForm.Show()
        End If
    End Sub
End Class
