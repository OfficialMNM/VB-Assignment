Public Class Form3
    Private Sub DisplayAmounts()
        Dim P As Double = 1000000
        Dim R As Double = 0.05
        Dim n As Integer = 10

        ListBox1.Items.Clear()

        For year As Integer = 1 To n
            Dim A As Double = P * (1 + R) ^ year
            ListBox1.Items.Add($"Year {year}: KSh {A:N2}")
        Next
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAmounts()
    End Sub
End Class