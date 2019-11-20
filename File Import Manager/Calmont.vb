Public Class Calmont
    Dim WorkingYearMonth As String = Nothing

    Private Sub Calmont_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Welcome.Location
        BtnCalmontUploadFile.Enabled = False
        BtnCalmontRunImport.Enabled = False
        BtnCalmontArchiveImport.Enabled = False
        BTNEmailCalmontExcludes.Enabled = False
        BTNArchiveExcludes.Enabled = False
        BTNSaveCalmontCatapultExports.Enabled = True
    End Sub

    Private Sub BtnCalmontSetWorkingYearMonth_Click(sender As Object, e As EventArgs) Handles BtnCalmontSetWorkingYearMonth.Click
        WorkingYearMonth = TBCalmontWorkingYearMonth.Text
        BtnCalmontUploadFile.Enabled = True
    End Sub

    Private Sub BtnCalmontUploadFile_Click(sender As Object, e As EventArgs) Handles BtnCalmontUploadFile.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Select the Cleaned Calmont Sale File"
        fd.InitialDirectory = "\\hmc\it\CoopDB\Calmont"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Process.Start("cmd", "/" + My.Settings.Debug + " xcopy " + Chr(34) + fd.FileName + Chr(34) + " \\hmc\it\Catapult\Calmont\Upload /Y")
            BtnCalmontRunImport.Enabled = True
        End If
    End Sub

    Private Sub BtnCalmontRunImport_Click(sender As Object, e As EventArgs) Handles BtnCalmontRunImport.Click

    End Sub

    Private Sub BtnCalmontArchiveImport_Click(sender As Object, e As EventArgs) Handles BtnCalmontArchiveImport.Click

    End Sub

    Private Sub BTNEmailCalmontExcludes_Click(sender As Object, e As EventArgs) Handles BTNEmailCalmontExcludes.Click

    End Sub

    Private Sub BTNArchiveExcludes_Click(sender As Object, e As EventArgs) Handles BTNArchiveExcludes.Click

    End Sub

    Private Sub BTNSaveCalmontCatapultExports_Click(sender As Object, e As EventArgs) Handles BTNSaveCalmontCatapultExports.Click

    End Sub
End Class