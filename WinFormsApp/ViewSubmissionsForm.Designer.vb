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
        lblHelloWorld = New Label()
        BtnPrevious = New Button()
        BtnNext = New Button()
        Label1 = New Label()
        txtSubmissionName = New TextBox()
        txtSubmissionEmail = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        txtSubmissionPhoneNumber = New TextBox()
        txtSubmissionGitHubRepo = New TextBox()
        Label5 = New Label()
        txtSubmissionElapsedTime = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' lblHelloWorld
        ' 
        lblHelloWorld.AutoSize = True
        lblHelloWorld.Font = New Font("Segoe UI", 30F)
        lblHelloWorld.Location = New Point(9, 52)
        lblHelloWorld.Margin = New Padding(4, 0, 4, 0)
        lblHelloWorld.Name = "lblHelloWorld"
        lblHelloWorld.Size = New Size(1183, 81)
        lblHelloWorld.TabIndex = 6
        lblHelloWorld.Text = "John Doe, Slidely Task 2 - View Submissions"
        ' 
        ' BtnPrevious
        ' 
        BtnPrevious.BackColor = Color.Khaki
        BtnPrevious.Location = New Point(376, 633)
        BtnPrevious.Margin = New Padding(4, 5, 4, 5)
        BtnPrevious.Name = "BtnPrevious"
        BtnPrevious.Size = New Size(200, 58)
        BtnPrevious.TabIndex = 7
        BtnPrevious.Text = "Previous (CTRL + P)"
        BtnPrevious.UseVisualStyleBackColor = False
        ' 
        ' BtnNext
        ' 
        BtnNext.BackColor = SystemColors.ActiveCaption
        BtnNext.Location = New Point(607, 633)
        BtnNext.Margin = New Padding(4, 5, 4, 5)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(200, 58)
        BtnNext.TabIndex = 8
        BtnNext.Text = "Next (CTRL + N)"
        BtnNext.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.Location = New Point(364, 205)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 28)
        Label1.TabIndex = 9
        Label1.Text = "Name"
        ' 
        ' txtSubmissionName
        ' 
        txtSubmissionName.Enabled = False
        txtSubmissionName.Location = New Point(506, 203)
        txtSubmissionName.Margin = New Padding(4, 5, 4, 5)
        txtSubmissionName.Name = "txtSubmissionName"
        txtSubmissionName.Size = New Size(328, 31)
        txtSubmissionName.TabIndex = 10
        ' 
        ' txtSubmissionEmail
        ' 
        txtSubmissionEmail.Enabled = False
        txtSubmissionEmail.Location = New Point(506, 272)
        txtSubmissionEmail.Margin = New Padding(4, 5, 4, 5)
        txtSubmissionEmail.Name = "txtSubmissionEmail"
        txtSubmissionEmail.Size = New Size(328, 31)
        txtSubmissionEmail.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.Location = New Point(370, 272)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 28)
        Label2.TabIndex = 11
        Label2.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.Location = New Point(310, 345)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 28)
        Label4.TabIndex = 13
        Label4.Text = "Phone Num"
        ' 
        ' txtSubmissionPhoneNumber
        ' 
        txtSubmissionPhoneNumber.Enabled = False
        txtSubmissionPhoneNumber.Location = New Point(506, 345)
        txtSubmissionPhoneNumber.Margin = New Padding(4, 5, 4, 5)
        txtSubmissionPhoneNumber.Name = "txtSubmissionPhoneNumber"
        txtSubmissionPhoneNumber.Size = New Size(328, 31)
        txtSubmissionPhoneNumber.TabIndex = 14
        ' 
        ' txtSubmissionGitHubRepo
        ' 
        txtSubmissionGitHubRepo.Enabled = False
        txtSubmissionGitHubRepo.Location = New Point(506, 422)
        txtSubmissionGitHubRepo.Margin = New Padding(4, 5, 4, 5)
        txtSubmissionGitHubRepo.Name = "txtSubmissionGitHubRepo"
        txtSubmissionGitHubRepo.Size = New Size(328, 31)
        txtSubmissionGitHubRepo.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label5.Location = New Point(223, 422)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(212, 28)
        Label5.TabIndex = 15
        Label5.Text = "Github ink For Task 2"
        ' 
        ' txtSubmissionElapsedTime
        ' 
        txtSubmissionElapsedTime.Enabled = False
        txtSubmissionElapsedTime.Location = New Point(506, 505)
        txtSubmissionElapsedTime.Margin = New Padding(4, 5, 4, 5)
        txtSubmissionElapsedTime.Name = "txtSubmissionElapsedTime"
        txtSubmissionElapsedTime.Size = New Size(328, 31)
        txtSubmissionElapsedTime.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.Location = New Point(273, 505)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 28)
        Label3.TabIndex = 17
        Label3.Text = "Stopwatch time"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(txtSubmissionElapsedTime)
        Controls.Add(Label3)
        Controls.Add(txtSubmissionGitHubRepo)
        Controls.Add(Label5)
        Controls.Add(txtSubmissionPhoneNumber)
        Controls.Add(Label4)
        Controls.Add(txtSubmissionEmail)
        Controls.Add(Label2)
        Controls.Add(txtSubmissionName)
        Controls.Add(Label1)
        Controls.Add(BtnNext)
        Controls.Add(BtnPrevious)
        Controls.Add(lblHelloWorld)
        Cursor = Cursors.Hand
        Margin = New Padding(4, 5, 4, 5)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHelloWorld As Label
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubmissionName As TextBox
    Friend WithEvents txtSubmissionEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSubmissionPhoneNumber As TextBox
    Friend WithEvents txtSubmissionGitHubRepo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSubmissionElapsedTime As TextBox
    Friend WithEvents Label3 As Label
End Class
