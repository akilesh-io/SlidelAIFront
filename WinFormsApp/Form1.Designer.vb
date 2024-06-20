<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHelloWorld = New Label()
        btnSub = New Button()
        btnView = New Button()
        SuspendLayout()
        ' 
        ' lblHelloWorld
        ' 
        lblHelloWorld.AutoSize = True
        lblHelloWorld.Font = New Font("Segoe UI", 30.0F)
        lblHelloWorld.Location = New Point(9, 41)
        lblHelloWorld.Name = "lblHelloWorld"
        lblHelloWorld.Size = New Size(782, 54)
        lblHelloWorld.TabIndex = 5
        lblHelloWorld.Text = "John Doe, Slidely Task 2 - Slidely Form App"
        ' 
        ' btnSub
        ' 
        btnSub.BackColor = SystemColors.ActiveCaption
        btnSub.Font = New Font("Segoe UI", 12.0F)
        btnSub.Location = New Point(247, 359)
        btnSub.Name = "btnSub"
        btnSub.Size = New Size(299, 47)
        btnSub.TabIndex = 4
        btnSub.Text = "Create New Submissions (CTRL + N)"
        btnSub.UseVisualStyleBackColor = False
        ' 
        ' btnView
        ' 
        btnView.BackColor = Color.Khaki
        btnView.Font = New Font("Segoe UI", 12.0F)
        btnView.Location = New Point(247, 265)
        btnView.Name = "btnView"
        btnView.Size = New Size(299, 47)
        btnView.TabIndex = 3
        btnView.Text = "View Submissions (CTRL + V)"
        btnView.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblHelloWorld)
        Controls.Add(btnSub)
        Controls.Add(btnView)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHelloWorld As Label
    Friend WithEvents btnSub As Button
    Friend WithEvents btnView As Button

End Class
