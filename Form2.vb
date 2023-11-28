


Public Class Form2
    Const dblMonths_Year As Double = 12
    Const dblNewRate As Double = 0.05
    Const dblUsedRate As Double = 0.08
    Dim dblAnnualRate As Double = dblNewRate
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblPayment.Click

    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        radNew.Checked = False
        radUsed.Checked = False
        dblAnnualRate = dblNewRate
        lblRate.Text = dblNewRate.ToString("p")
        txtCost.Clear()
        txtPayment.Clear()
        txtMonths.Clear()
        lstBox.Items.Clear()
        txtCost.Focus()
        lblRate.Text = String.Empty

    End Sub


    Private Sub btnCalculate2_Click(sender As Object, e As EventArgs) Handles btnCalculate2.Click
        Dim dblCostVehicle As Double
        Dim dblDownPayment As Double
        Dim intMonths As Integer
        Dim dblLoan As Double
        Dim dblMonthlyPay As Double
        Dim dblInterest As Double
        Dim dblPrincipal As Double
        Dim intCount As Integer
        Dim strOut As String
        Dim bInputOk As Boolean = True

        If Not Double.TryParse(txtCost.Text, dblCostVehicle) Then
            MessageBox.Show("Vehicle Cost Must Be A Numeric Value")
            bInputOk = False
        End If

        If Not Double.TryParse(txtPayment.Text, dblDownPayment) Then
            MessageBox.Show("Down Payment Must Be A Numeric Value")
            bInputOk = False
        End If

        If Not Integer.TryParse(txtMonths.Text, intMonths) Then
            MessageBox.Show("Months Must Be A Value Integer")
            bInputOk = False
        End If
        If bInputOk = True Then
            dblLoan = dblCostVehicle - dblDownPayment
            dblMonthlyPay = Pmt(dblAnnualRate / dblMonths_Year, intMonths, -dblLoan)
            lstBox.Items.Clear()


            For intCount = 1 To intMonths
                dblInterest = IPmt(dblAnnualRate / dblMonths_Year, intCount, intMonths, -dblLoan)
                dblPrincipal = PPmt(dblAnnualRate / dblMonths_Year, intCount, intMonths, -dblLoan)
                strOut = "Month" & intCount.ToString("D2")
                strOut &= ": payment = " & dblMonthlyPay.ToString("n2")
                strOut &= ", interest = " & dblInterest.ToString("n2")
                strOut &= ", principal = " & dblPrincipal.ToString("n2")
                lstBox.Items.Add(strOut)
            Next

        End If

    End Sub

    Private Sub radNew_CheckedChanged(sender As Object, e As EventArgs) Handles radNew.CheckedChanged
        If radNew.Checked = True Then
            dblAnnualRate = dblNewRate
            lblRate.Text = dblNewRate.ToString("p")
            lstBox.Items.Clear()
        End If
    End Sub

    Private Sub radUsed_CheckedChanged(sender As Object, e As EventArgs) Handles radUsed.CheckedChanged
        If radUsed.Checked = True Then
            dblAnnualRate = dblUsedRate
            lblRate.Text = dblUsedRate.ToString("p")
            lstBox.Items.Clear()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult =
           MessageBox.Show("Do you wish to Exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


End Class