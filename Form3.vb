Public Class Form3
    Dim i As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        lblProgress.Text = "Progress " & i & " % Completed"
        i += 1
        If i > 100 Then
            Timer1.Enabled = False
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()

            Form4.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Enabled = True
        ProgressBar1.Maximum = 100
        i = 1

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class