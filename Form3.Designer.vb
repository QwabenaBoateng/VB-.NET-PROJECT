<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        ProgressBar1 = New ProgressBar()
        lblProgress = New Label()
        Timer1 = New Timer(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Anchor = AnchorStyles.None
        ProgressBar1.Location = New Point(105, 231)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(640, 56)
        ProgressBar1.TabIndex = 0
        ' 
        ' lblProgress
        ' 
        lblProgress.Anchor = AnchorStyles.None
        lblProgress.BackColor = Color.White
        lblProgress.BorderStyle = BorderStyle.Fixed3D
        lblProgress.Location = New Point(105, 311)
        lblProgress.Name = "lblProgress"
        lblProgress.Size = New Size(640, 23)
        lblProgress.TabIndex = 1
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(158, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(517, 124)
        Label1.TabIndex = 2
        Label1.Text = "WELCOME"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lblProgress)
        Controls.Add(ProgressBar1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Splash Screen"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblProgress As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
