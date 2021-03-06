﻿Public Class Settings

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = Welcome.Location
        TBSettingsServer.Text = My.Settings.Server
        TBSettingsDTEXECPath.Text = My.Settings.DtexecPath
        TBSettingsConnectionString.Text = My.Settings.CATProductConnetionString
        TBUsersEmail.Text = My.Settings.UsersEmail
        TBUsersEmailPassword.Text = My.Settings.UsersEmailPassword
        TBMailServer.Text = My.Settings.MailSMTPServer
        TBBeerBuyerEmail.Text = My.Settings.BeerBuyersEmail
        TBUsersEmailPassword.UseSystemPasswordChar = True
        TBCAPExcludesList.Text = My.Settings.CAPExcludeList
        TBCAPBulkExcludesList.Text = My.Settings.CAPBulkExcludeList
        TBBulkBuyerEmail.Text = My.Settings.BulkBuyersEmail
        TBCheeseBuyerEmail.Text = My.Settings.CheeseBuyersEmail
        TBGroceryBuyerEmail.Text = My.Settings.GroceryBuyersEmail
        TBMeatBuyerEmail.Text = My.Settings.MeatBuyersEmail
        TBWellnessBuyerEmail.Text = My.Settings.WellnessBuyersEmail

    End Sub

    Private Sub BtnSaveSettings_Click(sender As Object, e As EventArgs) Handles BtnSaveSettings.Click
        My.Settings.Server = TBSettingsServer.Text
        My.Settings.DtexecPath = TBSettingsDTEXECPath.Text
        My.Settings.UsersEmail = TBUsersEmail.Text
        My.Settings.UsersEmailPassword = TBUsersEmailPassword.Text
        My.Settings.MailSMTPServer = TBMailServer.Text
        My.Settings.BeerBuyersEmail = TBBeerBuyerEmail.Text
        My.Settings.CAPExcludeList = TBCAPExcludesList.Text
        My.Settings.CAPBulkExcludeList = TBCAPBulkExcludesList.Text
        My.Settings.BulkBuyersEmail = TBBulkBuyerEmail.Text
        My.Settings.CheeseBuyersEmail = TBCheeseBuyerEmail.Text
        My.Settings.GroceryBuyersEmail = TBGroceryBuyerEmail.Text
        My.Settings.MeatBuyersEmail = TBMeatBuyerEmail.Text
        My.Settings.WellnessBuyersEmail = TBWellnessBuyerEmail.Text
    End Sub

    Private Sub BtnSetDebug_Click(sender As Object, e As EventArgs) Handles BtnSetDebug.Click
        My.Settings.Debug = "k"
        LblDebugStatus.Text = "Debug Status : Enabled"
    End Sub



End Class