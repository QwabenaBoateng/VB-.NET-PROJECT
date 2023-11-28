<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        btnCancel = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackgroundImage = My.Resources.Resources.Loan_Calculator_540x360
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(475, 195)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(228, 209)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackgroundImage = My.Resources.Resources._18401869
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Location = New Point(160, 195)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(202, 209)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Coral
        Label1.Location = New Point(188, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(515, 78)
        Label1.TabIndex = 2
        Label1.Text = "MAIN PAGE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Coral
        Label2.Location = New Point(281, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(323, 23)
        Label2.TabIndex = 3
        Label2.Text = "Click on any of the Images for further details"
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.None
        btnCancel.BackColor = Color.White
        btnCancel.Location = New Point(616, 458)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(87, 33)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        ClientSize = New Size(858, 547)
        Controls.Add(btnCancel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Screen"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
End Class
