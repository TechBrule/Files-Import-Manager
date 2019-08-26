Public Class LBMX
    Dim WorkingMonth As String = Nothing
    Dim WorkingYear As String = Nothing
    Dim WorkingYearMonth As String = Nothing

    Private Sub ExecSP(ByVal CommandText As String)
        Dim SQLCon As New SqlClient.SqlConnection
        Dim SQLCmd As New SqlClient.SqlCommand
        SQLCon.ConnectionString = My.Settings.CATProductConnetionString
        SQLCon.Open()
        SQLCmd.CommandText = CommandText
        SQLCmd.Parameters.AddWithValue("@PromoMonth", WorkingMonth)
        SQLCmd.Parameters.AddWithValue("@PromoYear", WorkingYear)
        SQLCmd.Parameters.AddWithValue("@PromoYearMonth", WorkingYearMonth)
        SQLCmd.Connection = SQLCon
        SQLCmd.ExecuteNonQuery()
        SQLCon.Close()
    End Sub


    Private Sub LBMX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Welcome.Location
        BtnLBMXUploadNewFile.Enabled = False
        BtnLBMXRun.Enabled = False
        BtnLBMXArchiveFile.Enabled = False
    End Sub

    Private Sub BntSetWorkingData_Click(sender As Object, e As EventArgs) Handles BntSetWorkingData.Click
        WorkingYear = TBLBMXWorkingYear.Text
        WorkingYearMonth = TBLBMXWorkingYearMonth.Text
        If WorkingMonth = Nothing Then
            MsgBox("You Must Select a Working Month", MsgBoxStyle.OkOnly, "Error")
        ElseIf WorkingYear = Nothing Then
            MsgBox("You Must Enter a Working Year", MsgBoxStyle.OkOnly, "Error")
        ElseIf WorkingYearMonth = Nothing Then
            MsgBox("You Must Enter a Working YearMonth", MsgBoxStyle.OkOnly, "Error")
        Else
            BtnLBMXUploadNewFile.Enabled = True
        End If
    End Sub

    Private Sub BtnLBMXUploadNewFile_Click(sender As Object, e As EventArgs) Handles BtnLBMXUploadNewFile.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Select the LBMX File"
        fd.InitialDirectory = "U:\Desktop"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Process.Start("cmd", "/" + My.Settings.Debug + " xcopy " + Chr(34) + fd.FileName + Chr(34) + " \\hmc\it\Catapult\LBMX\Upload /Y")
            MsgBox("File Uploaded", MsgBoxStyle.OkOnly)
            BtnLBMXRun.Enabled = True
        End If
    End Sub

    Private Sub BtnLBMXRun_Click(sender As Object, e As EventArgs) Handles BtnLBMXRun.Click
        Dim dpath As String
        dpath = My.Settings.DtexecPath
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq LbmxImport /ser " + My.Settings.Server)
        'Process.Start("cmd", "/" + My.Settings.Debug + " Dtexec /sq LbmxImport /ser " + My.Settings.Server)
        MessageBox.Show("Wait for all command windows to close before clicking OK", "Wait!", MessageBoxButtons.OK)
        ExecSP("exec [dbo].[FillLbmxHistory] @PromoMonth, @PromoYear, @PromoYearMonth")
        MessageBox.Show("Import Complete", "Done", MessageBoxButtons.OK)
        BtnLBMXArchiveFile.Enabled = True
    End Sub

    Private Sub BtnLBMXArchiveFile_Click(sender As Object, e As EventArgs) Handles BtnLBMXArchiveFile.Click
        Process.Start("cmd", "/" + My.Settings.Debug + " rename \\hmc\it\Catapult\LBMX\Upload\LBMX.xlsx " + WorkingYearMonth + "LBMX.xlsx")
        MessageBox.Show("First Step Done", "Step One", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " move \\hmc\it\Catapult\LBMX\Upload\*.* \\hmc\it\Catapult\LBMX\Archive\")
        MessageBox.Show("Step Two Done", "Finished", MessageBoxButtons.OK)
    End Sub

    Private Sub CBLBMXWorkingMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBLBMXWorkingMonth.SelectedIndexChanged
        WorkingMonth = CBLBMXWorkingMonth.SelectedItem
    End Sub
End Class