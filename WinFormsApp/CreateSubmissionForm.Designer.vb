<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        components = New ComponentModel.Container()
        lblHelloWorld = New Label()
        txtGitHubRepo = New TextBox()
        Label5 = New Label()
        txtPhoneNumber = New TextBox()
        Label4 = New Label()
        txtEmail = New TextBox()
        Label2 = New Label()
        txtName = New TextBox()
        Label1 = New Label()
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        lblElapsedTime = New TextBox()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' lblHelloWorld
        ' 
        lblHelloWorld.AutoSize = True
        lblHelloWorld.Font = New Font("Segoe UI", 25F)
        lblHelloWorld.Location = New Point(71, 40)
        lblHelloWorld.Margin = New Padding(4, 0, 4, 0)
        lblHelloWorld.Name = "lblHelloWorld"
        lblHelloWorld.Size = New Size(1024, 67)
        lblHelloWorld.TabIndex = 7
        lblHelloWorld.Text = "John Doe, Slidely Task 2 - Create Submissions"
        ' 
        ' txtGitHubRepo
        ' 
        txtGitHubRepo.Location = New Point(561, 385)
        txtGitHubRepo.Margin = New Padding(4, 5, 4, 5)
        txtGitHubRepo.Name = "txtGitHubRepo"
        txtGitHubRepo.Size = New Size(328, 31)
        txtGitHubRepo.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label5.Location = New Point(279, 385)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(212, 28)
        Label5.TabIndex = 25
        Label5.Text = "Github ink For Task 2"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(561, 308)
        txtPhoneNumber.Margin = New Padding(4, 5, 4, 5)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(328, 31)
        txtPhoneNumber.TabIndex = 24
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.Location = New Point(366, 308)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 28)
        Label4.TabIndex = 23
        Label4.Text = "Phone Num"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(561, 235)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(328, 31)
        txtEmail.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.Location = New Point(426, 235)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 28)
        Label2.TabIndex = 21
        Label2.Text = "Email"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(561, 167)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.Size = New Size(328, 31)
        txtName.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.Location = New Point(420, 168)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 28)
        Label1.TabIndex = 19
        Label1.Text = "Name"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.ActiveCaption
        btnSubmit.FlatAppearance.BorderSize = 5
        btnSubmit.Location = New Point(420, 615)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(200, 58)
        btnSubmit.TabIndex = 30
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Khaki
        btnToggleStopwatch.FlatAppearance.BorderSize = 5
        btnToggleStopwatch.Location = New Point(237, 530)
        btnToggleStopwatch.Margin = New Padding(4, 5, 4, 5)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(257, 58)
        btnToggleStopwatch.TabIndex = 29
        btnToggleStopwatch.Text = "Toggle Stopwatch (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lblElapsedTime
        ' 
        lblElapsedTime.BorderStyle = BorderStyle.FixedSingle
        lblElapsedTime.Font = New Font("Segoe UI", 18F)
        lblElapsedTime.Location = New Point(561, 530)
        lblElapsedTime.Margin = New Padding(4, 5, 4, 5)
        lblElapsedTime.Name = "lblElapsedTime"
        lblElapsedTime.ReadOnly = True
        lblElapsedTime.Size = New Size(136, 55)
        lblElapsedTime.TabIndex = 31
        lblElapsedTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(lblElapsedTime)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtGitHubRepo)
        Controls.Add(Label5)
        Controls.Add(txtPhoneNumber)
        Controls.Add(Label4)
        Controls.Add(txtEmail)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Controls.Add(lblHelloWorld)
        Margin = New Padding(4, 5, 4, 5)
        Name = "CreateSubmissionForm"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHelloWorld As Label
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lblElapsedTime As TextBox
    Friend WithEvents Timer1 As Timer
End Class
