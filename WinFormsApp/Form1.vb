Public Class Form1
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnView.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnSub.PerformClick()
        End If
    End Sub

End Class
