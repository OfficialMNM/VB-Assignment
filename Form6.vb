Public Class Form6
    Const WeeklyBasePay As Double = 2500
    Const Quota As Double = 1000
    Const Commission_rate As Double = 0.15
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim salespersons(9) As String
        Dim dailysales(9, 6) As Double

        For i As Integer = 0 To 9
            salespersons(i) = InputBox("Enter SalesPerson name:", "Salesperson Name")
            If salespersons(i) = "" Then
                Exit For
            End If
            For j As Integer = 0 To 6
                Dim input As String = InputBox($"Enter daily sales for {salespersons(i)} (Day {j + 1}):", "Daily Sales")
                If input = "" Then
                    Exit For
                End If
                If Not Double.TryParse(input, dailysales(i, j)) Then
                    MessageBox.Show("Invalid Input. Please try to enter a valid input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    j -= 1
                End If

            Next
        Next

        For i As Integer = 0 To 9
            If salespersons(i) Is Nothing Then
                Exit For
            End If
            Dim Weekly_Sales As Double = 0
            For j As Integer = 0 To 6
                Weekly_Sales += dailysales(i, j)
            Next
            Dim Commission As Double = 0
            If Weekly_Sales > Quota Then
                Commission = Commission_rate * Weekly_Sales
            End If
            Dim weeklySalary As Double = WeeklyBasePay + Commission

            ListBox1.Items.Add($"Name: {salespersons(i)}, Weekly Sales: {Weekly_Sales:C}, Weekly Salary: {weeklySalary:C}")

            For day As Integer = 0 To 6
                ListBox1.Items.Add($" Day  {day + 1} : {dailysales(i, day):C}")
            Next
        Next
    End Sub
End Class