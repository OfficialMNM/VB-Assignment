Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeForm()
    End Sub

    Private Sub ResizeForm()
            Dim ScreenHeight As Integer
            Dim ScreenWidth As Integer

            ScreenHeight = Screen.PrimaryScreen.Bounds.Height
            ScreenWidth = Screen.PrimaryScreen.Bounds.Width

            Me.Height = ScreenHeight / 2
            Me.Width = ScreenWidth * 0.75
        End Sub
End Class