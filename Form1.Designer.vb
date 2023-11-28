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
        GroupBox1 = New GroupBox()
        radSenior = New RadioButton()
        radStudent = New RadioButton()
        radChild = New RadioButton()
        radAdult = New RadioButton()
        GroupBox2 = New GroupBox()
        chkTrainer = New CheckBox()
        chkKarate = New CheckBox()
        chkYoga = New CheckBox()
        GroupBox3 = New GroupBox()
        Label3 = New Label()
        txtMonths = New TextBox()
        GroupBox4 = New GroupBox()
        lblTotalFee = New Label()
        lblMonthlyFee = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        Label4 = New Label()
        btnBack = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.Controls.Add(radSenior)
        GroupBox1.Controls.Add(radStudent)
        GroupBox1.Controls.Add(radChild)
        GroupBox1.Controls.Add(radAdult)
        GroupBox1.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(131, 51)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(265, 216)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Type of Membership"
        ' 
        ' radSenior
        ' 
        radSenior.Anchor = AnchorStyles.None
        radSenior.AutoSize = True
        radSenior.Location = New Point(19, 146)
        radSenior.Name = "radSenior"
        radSenior.Size = New Size(132, 25)
        radSenior.TabIndex = 3
        radSenior.TabStop = True
        radSenior.Text = "S&enior Citizen"
        radSenior.UseVisualStyleBackColor = True
        ' 
        ' radStudent
        ' 
        radStudent.Anchor = AnchorStyles.None
        radStudent.AutoSize = True
        radStudent.Location = New Point(19, 109)
        radStudent.Name = "radStudent"
        radStudent.Size = New Size(85, 25)
        radStudent.TabIndex = 2
        radStudent.TabStop = True
        radStudent.Text = "&Student"
        radStudent.UseVisualStyleBackColor = True
        ' 
        ' radChild
        ' 
        radChild.Anchor = AnchorStyles.None
        radChild.AutoSize = True
        radChild.Location = New Point(19, 67)
        radChild.Name = "radChild"
        radChild.Size = New Size(174, 25)
        radChild.TabIndex = 1
        radChild.TabStop = True
        radChild.Text = "Chil&d (12 && Under)"
        radChild.UseVisualStyleBackColor = True
        ' 
        ' radAdult
        ' 
        radAdult.Anchor = AnchorStyles.None
        radAdult.AutoSize = True
        radAdult.Location = New Point(19, 26)
        radAdult.Name = "radAdult"
        radAdult.Size = New Size(140, 25)
        radAdult.TabIndex = 0
        radAdult.TabStop = True
        radAdult.Text = "Standard &Adult"
        radAdult.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.None
        GroupBox2.Controls.Add(chkTrainer)
        GroupBox2.Controls.Add(chkKarate)
        GroupBox2.Controls.Add(chkYoga)
        GroupBox2.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(523, 51)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(273, 216)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Options"
        ' 
        ' chkTrainer
        ' 
        chkTrainer.Anchor = AnchorStyles.None
        chkTrainer.AutoSize = True
        chkTrainer.FlatStyle = FlatStyle.Popup
        chkTrainer.Location = New Point(43, 109)
        chkTrainer.Name = "chkTrainer"
        chkTrainer.Size = New Size(148, 25)
        chkTrainer.TabIndex = 2
        chkTrainer.Text = "&Personal Trainer"
        chkTrainer.UseVisualStyleBackColor = True
        ' 
        ' chkKarate
        ' 
        chkKarate.Anchor = AnchorStyles.None
        chkKarate.AutoSize = True
        chkKarate.FlatStyle = FlatStyle.Popup
        chkKarate.Location = New Point(43, 67)
        chkKarate.Name = "chkKarate"
        chkKarate.Size = New Size(75, 25)
        chkKarate.TabIndex = 1
        chkKarate.Text = "&Karate"
        chkKarate.UseVisualStyleBackColor = True
        ' 
        ' chkYoga
        ' 
        chkYoga.Anchor = AnchorStyles.None
        chkYoga.AutoSize = True
        chkYoga.BackgroundImageLayout = ImageLayout.None
        chkYoga.FlatStyle = FlatStyle.Popup
        chkYoga.Location = New Point(43, 26)
        chkYoga.Name = "chkYoga"
        chkYoga.Size = New Size(65, 25)
        chkYoga.TabIndex = 0
        chkYoga.Text = "&Yoga"
        chkYoga.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.None
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(txtMonths)
        GroupBox3.Location = New Point(131, 307)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(265, 203)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Membership Length"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(51, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(173, 47)
        Label3.TabIndex = 1
        Label3.Text = "Enter the number of Months:"
        ' 
        ' txtMonths
        ' 
        txtMonths.Anchor = AnchorStyles.None
        txtMonths.Location = New Point(36, 147)
        txtMonths.Name = "txtMonths"
        txtMonths.Size = New Size(197, 23)
        txtMonths.TabIndex = 0
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.None
        GroupBox4.Controls.Add(lblTotalFee)
        GroupBox4.Controls.Add(lblMonthlyFee)
        GroupBox4.Controls.Add(Label2)
        GroupBox4.Controls.Add(Label1)
        GroupBox4.Location = New Point(512, 307)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(284, 203)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Membership Fees"
        ' 
        ' lblTotalFee
        ' 
        lblTotalFee.Anchor = AnchorStyles.None
        lblTotalFee.BorderStyle = BorderStyle.Fixed3D
        lblTotalFee.Location = New Point(163, 82)
        lblTotalFee.Name = "lblTotalFee"
        lblTotalFee.Size = New Size(100, 23)
        lblTotalFee.TabIndex = 3
        ' 
        ' lblMonthlyFee
        ' 
        lblMonthlyFee.Anchor = AnchorStyles.None
        lblMonthlyFee.BorderStyle = BorderStyle.Fixed3D
        lblMonthlyFee.Location = New Point(163, 36)
        lblMonthlyFee.Name = "lblMonthlyFee"
        lblMonthlyFee.Size = New Size(100, 23)
        lblMonthlyFee.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(50, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 1
        Label2.Text = "Total:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(11, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 23)
        Label1.TabIndex = 0
        Label1.Text = "Monthly Fee:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Anchor = AnchorStyles.None
        btnCalculate.Location = New Point(247, 568)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "&Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.None
        btnClear.Location = New Point(414, 568)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 5
        btnClear.Text = "Clea&r"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.None
        btnExit.Location = New Point(688, 568)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 6
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Location = New Point(-3, 628)
        Label4.Name = "Label4"
        Label4.Size = New Size(924, 23)
        Label4.TabIndex = 8
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.None
        btnBack.Location = New Point(556, 568)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 9
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        CancelButton = btnExit
        ClientSize = New Size(923, 660)
        Controls.Add(btnBack)
        Controls.Add(Label4)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Membership Fee Calculator Screen"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSenior As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents radAdult As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotalFee As Label
    Friend WithEvents lblMonthlyFee As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBack As Button
End Class
