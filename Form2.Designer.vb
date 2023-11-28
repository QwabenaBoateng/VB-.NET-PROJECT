<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnBack = New Button()
        GroupBox1 = New GroupBox()
        txtMonths = New TextBox()
        txtPayment = New TextBox()
        txtCost = New TextBox()
        lblMonths = New Label()
        lblPayment = New Label()
        lblCost = New Label()
        GroupBox2 = New GroupBox()
        radUsed = New RadioButton()
        radNew = New RadioButton()
        GroupBox3 = New GroupBox()
        lstBox = New ListBox()
        btnClear2 = New Button()
        btnCalculate2 = New Button()
        Label4 = New Label()
        lblRate = New Label()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.None
        btnBack.Location = New Point(589, 601)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.Controls.Add(txtMonths)
        GroupBox1.Controls.Add(txtPayment)
        GroupBox1.Controls.Add(txtCost)
        GroupBox1.Controls.Add(lblMonths)
        GroupBox1.Controls.Add(lblPayment)
        GroupBox1.Controls.Add(lblCost)
        GroupBox1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(45, 34)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(335, 164)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Vehicle && Loan Information"
        ' 
        ' txtMonths
        ' 
        txtMonths.Anchor = AnchorStyles.None
        txtMonths.Location = New Point(191, 103)
        txtMonths.Name = "txtMonths"
        txtMonths.Size = New Size(100, 26)
        txtMonths.TabIndex = 5
        ' 
        ' txtPayment
        ' 
        txtPayment.Anchor = AnchorStyles.None
        txtPayment.Location = New Point(191, 69)
        txtPayment.Name = "txtPayment"
        txtPayment.Size = New Size(100, 26)
        txtPayment.TabIndex = 4
        ' 
        ' txtCost
        ' 
        txtCost.Anchor = AnchorStyles.None
        txtCost.Location = New Point(191, 34)
        txtCost.Name = "txtCost"
        txtCost.Size = New Size(100, 26)
        txtCost.TabIndex = 3
        ' 
        ' lblMonths
        ' 
        lblMonths.Anchor = AnchorStyles.None
        lblMonths.AutoSize = True
        lblMonths.Location = New Point(16, 106)
        lblMonths.Name = "lblMonths"
        lblMonths.Size = New Size(128, 19)
        lblMonths.TabIndex = 2
        lblMonths.Text = "Number of Months:"
        ' 
        ' lblPayment
        ' 
        lblPayment.Anchor = AnchorStyles.None
        lblPayment.AutoSize = True
        lblPayment.Location = New Point(16, 70)
        lblPayment.Name = "lblPayment"
        lblPayment.Size = New Size(173, 19)
        lblPayment.TabIndex = 1
        lblPayment.Text = "Amount of Down Payment:"
        ' 
        ' lblCost
        ' 
        lblCost.Anchor = AnchorStyles.None
        lblCost.AutoSize = True
        lblCost.Location = New Point(16, 37)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(104, 19)
        lblCost.TabIndex = 0
        lblCost.Text = "Cost of Vehicle:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.None
        GroupBox2.Controls.Add(radUsed)
        GroupBox2.Controls.Add(radNew)
        GroupBox2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(439, 50)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 100)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "New or Used?"
        ' 
        ' radUsed
        ' 
        radUsed.Anchor = AnchorStyles.None
        radUsed.AutoSize = True
        radUsed.Location = New Point(58, 57)
        radUsed.Name = "radUsed"
        radUsed.Size = New Size(59, 23)
        radUsed.TabIndex = 1
        radUsed.TabStop = True
        radUsed.Text = "Used"
        radUsed.UseVisualStyleBackColor = True
        ' 
        ' radNew
        ' 
        radNew.Anchor = AnchorStyles.None
        radNew.AutoSize = True
        radNew.Location = New Point(58, 22)
        radNew.Name = "radNew"
        radNew.Size = New Size(57, 23)
        radNew.TabIndex = 0
        radNew.TabStop = True
        radNew.Text = "New"
        radNew.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.None
        GroupBox3.Controls.Add(lstBox)
        GroupBox3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.Location = New Point(45, 228)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(685, 338)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Interest and Principal Payment"
        ' 
        ' lstBox
        ' 
        lstBox.Anchor = AnchorStyles.None
        lstBox.FormattingEnabled = True
        lstBox.HorizontalScrollbar = True
        lstBox.ItemHeight = 19
        lstBox.Location = New Point(16, 22)
        lstBox.Name = "lstBox"
        lstBox.ScrollAlwaysVisible = True
        lstBox.Size = New Size(654, 289)
        lstBox.TabIndex = 0
        ' 
        ' btnClear2
        ' 
        btnClear2.Anchor = AnchorStyles.None
        btnClear2.Location = New Point(449, 601)
        btnClear2.Name = "btnClear2"
        btnClear2.Size = New Size(75, 23)
        btnClear2.TabIndex = 4
        btnClear2.Text = "Clear"
        btnClear2.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate2
        ' 
        btnCalculate2.Anchor = AnchorStyles.None
        btnCalculate2.Location = New Point(291, 601)
        btnCalculate2.Name = "btnCalculate2"
        btnCalculate2.Size = New Size(75, 23)
        btnCalculate2.TabIndex = 5
        btnCalculate2.Text = "Calculate"
        btnCalculate2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(781, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 19)
        Label4.TabIndex = 6
        Label4.Text = "Annual Interest Rate:"
        ' 
        ' lblRate
        ' 
        lblRate.Anchor = AnchorStyles.None
        lblRate.BorderStyle = BorderStyle.Fixed3D
        lblRate.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblRate.Location = New Point(789, 88)
        lblRate.Name = "lblRate"
        lblRate.Size = New Size(100, 23)
        lblRate.TabIndex = 7
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.None
        btnExit.Location = New Point(716, 604)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 8
        btnExit.Text = "&Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AcceptButton = btnCalculate2
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSalmon
        CancelButton = btnBack
        ClientSize = New Size(1020, 652)
        Controls.Add(btnExit)
        Controls.Add(lblRate)
        Controls.Add(Label4)
        Controls.Add(btnCalculate2)
        Controls.Add(btnClear2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnBack)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Loan Calculator Screen"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lblMonths As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radUsed As RadioButton
    Friend WithEvents radNew As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnClear2 As Button
    Friend WithEvents btnCalculate2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lstBox As ListBox
    Friend WithEvents btnExit As Button
End Class
