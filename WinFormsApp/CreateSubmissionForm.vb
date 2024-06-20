Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private ReadOnly httpClient As HttpClient = New HttpClient()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblElapsedTime.Text = "00:00:00"
        Timer1.Interval = 1000 ' Timer ticks every second
        Timer1.Enabled = False ' Timer is initially disabled
        Me.KeyPreview = True
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            Timer1.Enabled = False
            btnToggleStopwatch.Text = "Start Stopwatch"
        Else
            stopwatch.Start()
            Timer1.Enabled = True
            btnToggleStopwatch.Text = "Pause Stopwatch"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblElapsedTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim newSubmission As New Submis() With { ' Use the corrected class name
        .Name = txtName.Text,
        .Email = txtEmail.Text,
        .Phone = txtPhoneNumber.Text,
        .github_link = txtGitHubRepo.Text, ' Corrected property name
        .stopwatch_time = lblElapsedTime.Text ' Corrected property name
    }


        Dim json As String = JsonConvert.SerializeObject(newSubmission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await httpClient.PostAsync("http://localhost:3000/submit", content)
            response.EnsureSuccessStatusCode()
            MessageBox.Show("Submission successful!")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Error submitting data: {ex.Message}")
        End Try
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class

Public Class Submis
    <JsonProperty("name")>
    Public Property Name As String

    <JsonProperty("email")>
    Public Property Email As String

    <JsonProperty("phone")>
    Public Property Phone As String

    <JsonProperty("github_link")>
    Public Property github_link As String

    <JsonProperty("stopwatch_time")>
    Public Property stopwatch_time As String
End Class