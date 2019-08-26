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
    'test 2
End Class
