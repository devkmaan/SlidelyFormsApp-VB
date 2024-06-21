Public Class Form1
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ButtonViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ButtonNewSubmissions.PerformClick()
        End If
    End Sub

    Private Sub ButtonViewSubmissions_Click(sender As Object, e As EventArgs) Handles ButtonViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        AddHandler viewForm.FormClosed, AddressOf ChildFormClosed
        viewForm.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonNewSubmissions_Click(sender As Object, e As EventArgs) Handles ButtonNewSubmissions.Click
        Dim createForm As New CreateSubmissionForm()
        AddHandler createForm.FormClosed, AddressOf ChildFormClosed
        createForm.Show()
        Me.Hide()
    End Sub

    Private Sub ChildFormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Show()
    End Sub
End Class
