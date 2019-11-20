Public Class Welcome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CoopBasics.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LBMX.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UNFICatalog.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CoopDeals.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Settings.Show()
    End Sub

    Private Sub Welcome_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        My.Settings.Debug = "c"
    End Sub 'Form1_Closing

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Baker.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Farrell.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Calmont.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        VTWine.Show()
    End Sub
End Class
