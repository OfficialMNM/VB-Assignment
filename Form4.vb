Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = InputBox("Enter a character:", "Input Character")
        If Not String.IsNullOrEmpty(input) Then
            Dim nextChar As String = GetNextChar(input)
            MessageBox.Show($"Next character after '{input}' is '{nextChar}'", "Next Character", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function GetNextChar(ByVal input As String) As String
        Dim asciicode As Integer = Asc(input)
        Dim nextAsciicode As Integer = asciicode + 1
        Dim nextChar As Char = ChrW(nextAsciicode)
        Return nextChar

    End Function
End Class