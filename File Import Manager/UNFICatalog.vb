Public Class UNFICatalog
    Dim WorkingYearMonth As String = Nothing

    Private Sub UNFICatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Welcome.Location
        BtnUNFIUploadFile.Enabled = False
        BtnUNFIRunImport.Enabled = False
        BtnUNFIRunImport.Enabled = False
        BtnArchiveFile.Enabled = False
        'BtnUNFIOpenCatalog.Enabled = False
        'BtnUNFIOpenMassUpdates.Enabled = False
        If Screen.PrimaryScreen.Bounds.Height < 2160 Then
            Me.Height = 900
            Me.AutoScroll = True
            Me.VerticalScroll.Visible = True
        Else

        End If
    End Sub

    Private Sub BtnUNFISetWorkingYearMonth_Click(sender As Object, e As EventArgs) Handles BtnUNFISetWorkingYearMonth.Click
        WorkingYearMonth = TBUNFIWorkingYearMonth.Text
        BtnUNFIUploadFile.Enabled = True
    End Sub

    Private Sub BtnUNFIUploadFile_Click(sender As Object, e As EventArgs) Handles BtnUNFIUploadFile.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Select the UNFI Pricing File"
        fd.InitialDirectory = "U:\Desktop"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Process.Start("cmd", "/" + My.Settings.Debug + " xcopy " + Chr(34) + fd.FileName + Chr(34) + " \\hmc\it\Catapult\UNFI\Upload /Y")
            BtnUNFIRunImport.Enabled = True
        End If
    End Sub

    Private Sub BtnUNFIRunImport_Click(sender As Object, e As EventArgs) Handles BtnUNFIRunImport.Click
        Dim dpath As String
        dpath = My.Settings.DtexecPath
        ExecSP("exec [dbo].[UNFICatalogStep1]")
        MessageBox.Show("Step 1 Complete", "", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  UNFICatalogImport /ser " + My.Settings.Server)
        'Process.Start("cmd", "/" + My.Settings.Debug + " Dtexec /sq UNFICatalogImport /ser " + My.Settings.Server)
        MessageBox.Show("Wait for all command windows to close before clicking OK", "Wait!", MessageBoxButtons.OK)
        ExecSP("exec [dbo].[FillUNFICurrentPrior]")
        MessageBox.Show("Import Complete", "Done", MessageBoxButtons.OK)
        BtnArchiveFile.Enabled = True
    End Sub

    Private Sub BtnArchiveFile_Click(sender As Object, e As EventArgs) Handles BtnArchiveFile.Click
        Process.Start("cmd", "/" + My.Settings.Debug + " rename \\hmc\it\Catapult\UNFI\Upload\UNFI.xlsx " + WorkingYearMonth + "UNFI.xlsx")
        MessageBox.Show("First Step Done", "Step One", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " move \\hmc\it\Catapult\UNFI\Upload\*.* \\hmc\it\Catapult\UNFI\Archive\")
        MessageBox.Show("Step Two Done", "Finished", MessageBoxButtons.OK)
    End Sub

    Private Sub BtnUNFIOpenCatalog_Click(sender As Object, e As EventArgs) Handles BtnUNFIOpenCatalog.Click
        Process.Start("\\hmc\it\Catapult\UNFI\CatalogSheet\UNFIFullCatalogData.xlsx")
        Process.Start("\\hmc\it\Catapult\UNFI\CatalogSheet\UNFIFullCatalogTemplate.xlsx")

    End Sub

    Private Sub BtnUNFIOpenMassUpdates_Click(sender As Object, e As EventArgs) Handles BtnUNFIOpenMassUpdates.Click
        Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\BulkandBulkHerbsUNFIMassUpdates.xlsx")
        Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\CheeseUNFIMassUpdates.xlsx")
        Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\GroceryMassUpdates.xlsx")
        Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\MeatUNFIMassUpdates.xlsx")
        Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\PerishablesUNFIMassUpdates.xlsx")
        Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\WellnessUNFIMassUpdates.xlsx")

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