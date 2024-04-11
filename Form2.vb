Public Class Form2
    Private Sub MultiplicationTable()
        Dim table As String = "Multiplication Table" & vbCrLf
        table &= vbCrLf
        table &= " *    1    2    3    4    5    6    7" & vbCrLf

        For i As Integer = 1 To 7
            table &= i.ToString().PadLeft(2) & " "

            For j As Integer = 1 To 7
                table &= (i * j).ToString().PadLeft(4) & " "
            Next
            table &= vbCrLf
        Next
        TextBox1.Text = table
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Font = New Font("Consolas", 10, FontStyle.Bold)
        MultiplicationTable()

        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.SelectionLength = 0
    End Sub
End Class
