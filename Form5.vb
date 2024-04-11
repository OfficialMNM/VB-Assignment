Public Class Form5
    Dim progressValue As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressValue += 1

        Me.ProgressBar1.Value = progressValue
        Me.Label1.Text = $"Progress: {progressValue}%"
        If progressValue >= ProgressBar1.Maximum Then
            Timer1.Enabled = False
            MessageBox.Show("Process Completed!", "Completed", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class