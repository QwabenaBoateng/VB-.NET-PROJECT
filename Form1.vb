

Public Class Form1
    ' Dim decDiscount As Decimal
    Dim decTotal As Decimal
    Dim intMonths As Integer
    Dim decBaseFee As Decimal

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult =
            MessageBox.Show("Do you wish to Exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radAdult.Checked = False
        radChild.Checked = False
        radStudent.Checked = False
        radSenior.Checked = False
        chkKarate.Checked = False
        chkYoga.Checked = False
        chkTrainer.Checked = False


        txtMonths.Text = String.Empty
        lblMonthlyFee.Text = String.Empty
        lblTotalFee.Text = String.Empty
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Not Integer.TryParse(txtMonths.Text, intMonths) Then
            MessageBox.Show("Months must be a valid integer", "Input Error")
            Return
        End If
        If (intMonths < 1) Or (intMonths > 24) Then
            MessageBox.Show("Enter the value in th range of " & "1 - 24 for months.", "Input Error")
            Return
        End If
        If radAdult.Checked = True Then
            decBaseFee = 40
        ElseIf radChild.Checked = True Then
            decBaseFee = 20
        ElseIf radStudent.Checked = True Then
            decBaseFee = 25
        ElseIf radSenior.Checked = True Then
            decBaseFee = 30
        End If

        If chkYoga.Checked = True Then
            decBaseFee += 10
        End If
        If chkKarate.Checked = True Then
            decBaseFee += 30
        End If
        If chkTrainer.Checked = True Then
            decBaseFee += 50
        End If


        decTotal = decBaseFee * intMonths

        lblMonthlyFee.Text = decBaseFee.ToString("C")
        lblTotalFee.Text = decTotal.ToString("C")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub txtMonths_TextChanged(sender As Object, e As EventArgs) Handles txtMonths.TextChanged

    End Sub

    Private Sub radSenior_CheckedChanged(sender As Object, e As EventArgs) Handles radSenior.CheckedChanged
    End Sub

    Private Sub radStudent_CheckedChanged(sender As Object, e As EventArgs) Handles radStudent.CheckedChanged
    End Sub

    Private Sub radChild_CheckedChanged(sender As Object, e As EventArgs) Handles radChild.CheckedChanged
    End Sub

    Private Sub radAdult_CheckedChanged(sender As Object, e As EventArgs) Handles radAdult.CheckedChanged
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
    End Sub

    Private Sub chkTrainer_CheckedChanged(sender As Object, e As EventArgs) Handles chkTrainer.CheckedChanged
    End Sub

    Private Sub chkKarate_CheckedChanged(sender As Object, e As EventArgs) Handles chkKarate.CheckedChanged
    End Sub

    Private Sub chkYoga_CheckedChanged(sender As Object, e As EventArgs) Handles chkYoga.CheckedChanged
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter
    End Sub

    Private Sub lblTotalFee_Click(sender As Object, e As EventArgs) Handles lblTotalFee.Click
    End Sub

    Private Sub lblMonthlyFee_Click(sender As Object, e As EventArgs) Handles lblMonthlyFee.Click
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
End Class
