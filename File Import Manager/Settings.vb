Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = Welcome.Location
        TBSettingsServer.Text = My.Settings.Server
        TBSettingsDTEXECPath.Text = My.Settings.DtexecPath
        TBSettingsConnectionString.Text = My.Settings.CATProductConnetionString
    End Sub

    Private Sub BtnSaveSettings_Click(sender As Object, e As EventArgs) Handles BtnSaveSettings.Click
        My.Settings.Server = TBSettingsServer.Text
        My.Settings.DtexecPath = TBSettingsDTEXECPath.Text
    End Sub

    Private Sub BtnSetDebug_Click(sender As Object, e As EventArgs) Handles BtnSetDebug.Click
        My.Settings.Debug = "k"
        LblDebugStatus.Text = "Debug Status : Enabled"
        'test
    End Sub



End Class