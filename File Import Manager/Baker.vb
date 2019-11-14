Public Class Baker
    Private Sub Baker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Welcome.Location
        If Screen.PrimaryScreen.Bounds.Height < 2160 Then
            Me.Height = 900
            Me.AutoScroll = True
            Me.VerticalScroll.Visible = True
        Else

        End If
    End Sub
End Class