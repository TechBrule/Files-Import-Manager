Public Class Baker
    Dim WorkingYearMonth As String = Nothing


    Private Sub Baker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Welcome.Location
        BtnBakerUploadFile.Enabled = False
        BtnBakerRunImport.Enabled = False
        BtnBakerRunImport.Enabled = False
        BtnBakerArchiveImport.Enabled = False
        If Screen.PrimaryScreen.Bounds.Height < 2160 Then
            Me.Height = 900
            Me.AutoScroll = True
            Me.VerticalScroll.Visible = True
        Else

        End If
    End Sub

    Private Sub BtnBakerSetWorkingYearMonth_Click(sender As Object, e As EventArgs) Handles BtnBakerSetWorkingYearMonth.Click
        WorkingYearMonth = TBBakerWorkingYearMonth.Text
        BtnBakerUploadFile.Enabled = True
    End Sub

    Private Sub BtnBakerUploadFile_Click(sender As Object, e As EventArgs) Handles BtnBakerUploadFile.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Select the Cleaned Baker Sale File"
        fd.InitialDirectory = "U:\Desktop"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Process.Start("cmd", "/" + My.Settings.Debug + " xcopy " + Chr(34) + fd.FileName + Chr(34) + " \\hmc\it\Catapult\Baker\Upload /Y")
            BtnBakerRunImport.Enabled = True
        End If
    End Sub

    Private Sub BtnBakerRunImport_Click(sender As Object, e As EventArgs) Handles BtnBakerRunImport.Click
        Dim dpath As String
        dpath = My.Settings.DtexecPath
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  BakerMonthlySales /ser " + My.Settings.Server)
        MessageBox.Show("Wait for all command windows to close before clicking OK", "Wait!", MessageBoxButtons.OK)
        ExecSP("exec [dbo].[ProcessBakerMonthlySales]")
        MessageBox.Show("Import Complete", "Done", MessageBoxButtons.OK)
        BtnBakerArchiveImport.Enabled = True
    End Sub

    Private Sub BtnBakerArchiveImport_Click(sender As Object, e As EventArgs) Handles BtnBakerArchiveImport.Click
        Process.Start("cmd", "/" + My.Settings.Debug + " rename \\hmc\it\Catapult\Baker\Upload\BakerMonthlySales.xlsx " + WorkingYearMonth + "BakerMonthlySales.xlsx")
        MessageBox.Show("First Step Done", "Step One", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " move \\hmc\it\Catapult\Baker\Upload\*.* \\hmc\it\Catapult\Baker\Archive\")
        MessageBox.Show("Step Two Done", "Finished", MessageBoxButtons.OK)
    End Sub

    Private Sub ExecSP(ByVal CommandText As String)
        Dim SQLCon As New SqlClient.SqlConnection
        Dim SQLCmd As New SqlClient.SqlCommand
        SQLCon.ConnectionString = My.Settings.CATProductConnetionString
        SQLCon.Open()
        SQLCmd.CommandText = CommandText
        SQLCmd.Connection = SQLCon
        SQLCmd.ExecuteNonQuery()
        SQLCon.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("cmd", "/" + My.Settings.Debug + " powershell Send-MailMessage -to " + My.Settings.BeerBuyersEmail + " -subject BakerMonthlyExcludedItems -body SeeAttachement -smtpserver " + My.Settings.MailSMTPServer + "-port " + Chr(34) + "49525" + Chr(34) + " -from " + My.Settings.UsersEmail)
        'Process.Start("powershell", "/" + My.Settings.Debug + " Send-MailMessage " + Chr(34) + fd.FileName + Chr(34) + " \\hmc\it\Catapult\Baker\Upload /Y")
    End Sub
End Class