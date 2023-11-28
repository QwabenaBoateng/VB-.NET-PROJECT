<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label1 = New Label()
        Label2 = New Label()
        txtUserName = New TextBox()
        btnLogin = New Button()
        Label3 = New Label()
        chkPass = New CheckBox()
        txtPassWord = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(174, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 27)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(174, 236)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 33)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' txtUserName
        ' 
        txtUserName.Anchor = AnchorStyles.None
        txtUserName.Location = New Point(366, 150)
        txtUserName.Multiline = True
        txtUserName.Name = "txtUserName"
        txtUserName.PlaceholderText = "Enter Username"
        txtUserName.Size = New Size(220, 45)
        txtUserName.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.BackColor = Color.PaleGoldenrod
        btnLogin.BackgroundImageLayout = ImageLayout.None
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.Location = New Point(366, 341)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(220, 46)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.Font = New Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(36, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(739, 68)
        Label3.TabIndex = 5
        Label3.Text = " LOGIN PAGE"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' chkPass
        ' 
        chkPass.Anchor = AnchorStyles.None
        chkPass.AutoSize = True
        chkPass.Location = New Point(366, 294)
        chkPass.Name = "chkPass"
        chkPass.Size = New Size(108, 19)
        chkPass.TabIndex = 3
        chkPass.Text = "Show Password"
        chkPass.UseVisualStyleBackColor = True
        ' 
        ' txtPassWord
        ' 
        txtPassWord.Anchor = AnchorStyles.None
        txtPassWord.Location = New Point(366, 226)
        txtPassWord.Multiline = True
        txtPassWord.Name = "txtPassWord"
        txtPassWord.PasswordChar = "*"c
        txtPassWord.PlaceholderText = "Enter Password"
        txtPassWord.Size = New Size(220, 43)
        txtPassWord.TabIndex = 2
        ' 
        ' Form4
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Coral
        ClientSize = New Size(800, 450)
        Controls.Add(txtPassWord)
        Controls.Add(chkPass)
        Controls.Add(Label3)
        Controls.Add(btnLogin)
        Controls.Add(txtUserName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Screen"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents chkPass As CheckBox
    Friend WithEvents txtPassWord As TextBox
End Class
