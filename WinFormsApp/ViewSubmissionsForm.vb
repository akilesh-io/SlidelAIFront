Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submissions As New List(Of Submission)
    Private currentIndex As Integer = 0
    Private ReadOnly httpClient As HttpClient = New HttpClient()

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize submissions list with a known number of placeholders
        InitializeSubmissions(1) ' Adjust the count as needed
        DisplaySubmission()
        Me.KeyPreview = True
    End Sub

    Private Sub InitializeSubmissions(count As Integer)
        For i As Integer = 0 To count - 1
            submissions.Add(Nothing)
        Next
    End Sub

    Private Async Function LoadSubmissionsAsync(index As Integer) As Task
        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync($"http://localhost:3000/read?index={index}")
            response.EnsureSuccessStatusCode()
            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
            Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(jsonResponse)
            If submission IsNot Nothing Then
                If index < submissions.Count Then
                    submissions(index) = submission
                Else
                    submissions.Add(submission)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Error fetching submission at index {index}: {ex.Message}")
        End Try
    End Function

    Private Async Sub DisplaySubmission()
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            If submissions(currentIndex) Is Nothing Then
                Await LoadSubmissionsAsync(currentIndex)
            End If

            If submissions(currentIndex) IsNot Nothing Then
                txtSubmissionName.Text = submissions(currentIndex).Name
                txtSubmissionEmail.Text = submissions(currentIndex).Email
                txtSubmissionPhoneNumber.Text = submissions(currentIndex).Phone
                txtSubmissionGitHubRepo.Text = submissions(currentIndex).github_link
                txtSubmissionElapsedTime.Text = submissions(currentIndex).stopwatch_time
            End If
        End If
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If

        If currentIndex = submissions.Count - 1 Then
            Await LoadSubmissionsAsync(currentIndex + 1)
        End If
        'BtnNext.Enabled = False

    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            BtnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            BtnNext.PerformClick()
        End If
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
