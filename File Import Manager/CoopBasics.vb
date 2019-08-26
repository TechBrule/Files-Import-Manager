Public Class CoopBasics
    Dim WorkingYearMonth As String = Nothing
    Private Sub CoopBasics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Welcome.Location
        BtnCBUploadNewFile.Enabled = False
        BtnCBRunImport.Enabled = False
        BtnCBArchiveFile.Enabled = False
    End Sub

    Private Sub BtnCBSetWorkingMonth_Click(sender As Object, e As EventArgs) Handles BtnCBSetWorkingMonth.Click

        If TBCBWorkingMonth.Text = "" Then
            MessageBox.Show("You must enter a working month first", "Error?", MessageBoxButtons.OKCancel)
        Else
            WorkingYearMonth = TBCBWorkingMonth.Text
            BtnCBUploadNewFile.Enabled = True
        End If

    End Sub

    Private Sub BtnCBUploadNewFile_Click(sender As Object, e As EventArgs) Handles BtnCBUploadNewFile.Click

        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Select the Co-op Basics File"
        fd.InitialDirectory = "U:\Desktop"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Process.Start("cmd", "/" + My.Settings.Debug + " xcopy " + Chr(34) + fd.FileName + Chr(34) + " \\hmc\it\Catapult\CoopBasics\Upload /Y")
            BtnCBRunImport.Enabled = True
        End If


    End Sub

    Private Sub BtnCBRunImport_Click(sender As Object, e As EventArgs) Handles BtnCBRunImport.Click
        Dim dpath As String
        dpath = My.Settings.DtexecPath
        ExecSP("exec [dbo].[CoopBasicsCompareStep1]")
        MessageBox.Show("Step one complete", "Next?", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq CoopBasicsImport /ser " + My.Settings.Server)
        'Process.Start("cmd", "/" + My.Settings.Debug + " Dtexec" /sq CoopBasicsImport /ser " + My.Settings.Server)
        MessageBox.Show("Wait until the command window closes on its own before you click ok", "Wait", MessageBoxButtons.OK)
        ExecSP("exec [dbo].[Fill_RPT_TMP_CoopBasicsChanges]")
        MessageBox.Show("Import Complete", "Done", MessageBoxButtons.OK)
        BtnCBArchiveFile.Enabled = True
    End Sub

    Private Sub BtnCBArchiveFile_Click(sender As Object, e As EventArgs) Handles BtnCBArchiveFile.Click
        Process.Start("cmd", "/" + My.Settings.Debug + " rename \\hmc\it\Catapult\CoopBasics\Upload\CoopBasics.xlsx " + WorkingYearMonth + "CoopBasics.xlsx")
        MessageBox.Show("First Step Done", "Step One", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " move \\hmc\it\Catapult\CoopBasics\Upload\*.* \\hmc\it\Catapult\CoopBasics\Archive\")
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




End Class