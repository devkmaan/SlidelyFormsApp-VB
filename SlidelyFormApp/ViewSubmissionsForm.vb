Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private totalSubmissions As Integer = 0

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Await FetchTotalSubmissions()
        If totalSubmissions > 0 Then
            Await FetchAndDisplaySubmission(currentIndex)
        End If
    End Sub

    Private Async Function FetchTotalSubmissions() As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/read?index=0")
                If response.IsSuccessStatusCode Then
                    Dim content As String = Await response.Content.ReadAsStringAsync()
                    Dim submission As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(content)
                    If submission IsNot Nothing AndAlso submission.ContainsKey("total_submissions") Then
                        totalSubmissions = Convert.ToInt32(submission("total_submissions"))
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Function

    Private Async Function FetchAndDisplaySubmission(index As Integer) As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                If response.IsSuccessStatusCode Then
                    Dim content As String = Await response.Content.ReadAsStringAsync()
                    Dim submission As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(content)
                    If submission IsNot Nothing Then
                        TextBoxName.Text = submission("name")
                        TextBoxEmail.Text = submission("email")
                        TextBoxPhoneNum.Text = submission("phone")
                        TextBoxGitHub.Text = submission("github_link")
                        TextBoxStopwatch.Text = submission("stopwatch_time")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
        UpdateButtons()
    End Function

    Private Sub UpdateButtons()
        ButtonPrevious.Enabled = currentIndex > 0
        ButtonNext.Enabled = currentIndex < totalSubmissions - 1
        ButtonDelete.Enabled = totalSubmissions > 0
    End Sub

    Private Async Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await FetchAndDisplaySubmission(currentIndex)
        End If
    End Sub

    Private Async Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            Await FetchAndDisplaySubmission(currentIndex)
        End If
    End Sub

    Private Async Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted successfully!")
                    ' Refresh submissions
                    Await FetchTotalSubmissions()
                    If totalSubmissions > 0 Then
                        If currentIndex >= totalSubmissions Then
                            currentIndex = totalSubmissions - 1
                        End If
                        Await FetchAndDisplaySubmission(currentIndex)
                    Else
                        ' Clear form if no submissions left
                        TextBoxName.Clear()
                        TextBoxEmail.Clear()
                        TextBoxPhoneNum.Clear()
                        TextBoxGitHub.Clear()
                        TextBoxStopwatch.Clear()
                        UpdateButtons()
                    End If
                Else
                    MessageBox.Show("Failed to delete submission.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ButtonPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ButtonNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            ButtonDelete.PerformClick()
        End If
    End Sub
End Class
