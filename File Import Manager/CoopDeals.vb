﻿Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text
Imports System.IO

Public Class CoopDeals
    Dim WorkingYearMonth As String = Nothing

    Private Sub CoopDeals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Welcome.Location
        BtnCAPUploadFile.Enabled = False
        BtnCAPRunImport.Enabled = False
        BtnCAPArchiveImport.Enabled = False
        BTNEmailCAPExcludes.Enabled = False
        BTNArchiveExcludes.Enabled = False
        BTNSaveCAPCatapultExports.Enabled = True
    End Sub

    Private Sub BtnCAPSetWorkingYearMonth_Click(sender As Object, e As EventArgs) Handles BtnCAPSetWorkingYearMonth.Click
        WorkingYearMonth = TBCAPWorkingYearMonth.Text
        BtnCAPUploadFile.Enabled = True
    End Sub

    Private Sub BtnCAPUploadFile_Click(sender As Object, e As EventArgs) Handles BtnCAPUploadFile.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Select the UNFI Coop Deals xlsx File"
        fd.InitialDirectory = "\\hmc\it\CoopDB\UNFI CATAPULT"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Process.Start("cmd", "/" + My.Settings.Debug + " xcopy " + Chr(34) + fd.FileName + Chr(34) + " \\hmc\it\Catapult\CoopDeals\Upload /Y")
            BtnCAPRunImport.Enabled = True
        End If
    End Sub

    Private Sub BtnCAPRunImport_Click(sender As Object, e As EventArgs) Handles BtnCAPRunImport.Click
        Dim dpath As String
        dpath = My.Settings.DtexecPath
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  CAPMonthlyImport /ser " + My.Settings.Server)
        MessageBox.Show("Wait for all command windows to close before clicking OK", "Wait!", MessageBoxButtons.OK)
        ExecSP("exec [dbo].[ProcessCAPMonthlySales]")
        MessageBox.Show("Import Complete", "Click ok to export excluded items", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  ExportCAPMonthlyExcludedItems /ser " + My.Settings.Server)
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  ExportCAPBulkMonthlyExcludedItems /ser " + My.Settings.Server)
        MessageBox.Show("Wait for all command windows to close before clicking OK", "Wait!", MessageBoxButtons.OK)
        MessageBox.Show("Import Complete", "Imports and exports finsihed.", MessageBoxButtons.OK)
        BtnCAPArchiveImport.Enabled = True
    End Sub

    Private Sub BtnCalmontArchiveImport_Click(sender As Object, e As EventArgs) Handles BtnCAPArchiveImport.Click
        Process.Start("cmd", "/" + My.Settings.Debug + " rename \\hmc\it\Catapult\Calmont\Upload\CalmontMonthlyImport.xlsx " + WorkingYearMonth + "CalmontMonthlyImport.xlsx")
        MessageBox.Show("First Step Done", "Step One", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " move \\hmc\it\Catapult\Calmont\Upload\*.* \\hmc\it\Catapult\Calmont\Archive\")
        MessageBox.Show("Step Two Done", "Finished", MessageBoxButtons.OK)
        BTNEmailCAPExcludes.Enabled = True
    End Sub

    Private Sub BTNEmailCalmontExcludes_Click(sender As Object, e As EventArgs) Handles BTNEmailCAPExcludes.Click
        SendCalmontExclusion(Nothing)
        BTNArchiveExcludes.Enabled = True
    End Sub

    Private Sub BTNArchiveExcludes_Click(sender As Object, e As EventArgs) Handles BTNArchiveExcludes.Click
        Process.Start("cmd", "/" + My.Settings.Debug + " rename \\hmc\it\Catapult\Calmont\Excludes\CalmontMonthlyExcludedItems.xls " + WorkingYearMonth + "CalmontMonthlyExcludedItems.xls")
        MessageBox.Show("First Step Done", "Step One", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " move \\hmc\it\Catapult\Calmont\Excludes\*.* \\hmc\it\Catapult\Calmont\Excludes\Archive\")
        MessageBox.Show("Step Two Done", "Finished", MessageBoxButtons.OK)
        BTNSaveCAPCatapultExports.Enabled = True
    End Sub

    Private Sub BTNSaveCalmontCatapultExports_Click(sender As Object, e As EventArgs) Handles BTNSaveCAPCatapultExports.Click
        Dim dpath As String
        dpath = My.Settings.DtexecPath
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  CalmontMonthlyAExport /ser " + My.Settings.Server)
        MessageBox.Show("Wait for all command windows to close before clicking OK", "Wait!", MessageBoxButtons.OK)
        MessageBox.Show("First Export Complete", "Click ok to continue", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  CalmontMonthlyBExport /ser " + My.Settings.Server)
        MessageBox.Show("Wait for all command windows to close before clicking OK", "Wait!", MessageBoxButtons.OK)
        MessageBox.Show("All exports are complete", "All exports are complete.", MessageBoxButtons.OK)
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

    Private Function SendCalmontExclusion(ByVal scriptText As String) As String

        ' create Powershell runspace
        Dim MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()

        ' open it
        MyRunSpace.Open()

        ' create a pipeline and feed it the script text
        Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()

        'MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34) + " $To = " + Chr(34) + My.Settings.BeerBuyersEmail + Chr(34) + " $smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34) + " $Sub = " + Chr(34) + "Baker Monthly Sales Excluded Items" + Chr(34) + " $secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force" + " $mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)" + " $attachment = " + Chr(34) + " \\ hmc \ it \ Catapult \ Baker \ Excludes \ BakerExcludedItems.xls" + Chr(34) + " Send-MailMessage -To $To -Subject $Sub -body $body -Attachments $attachment -smtpserver $smtp -Credential $mycreds -from $from")
        MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34))
        MyPipeline.Commands.AddScript("$to =" + Chr(34) + My.Settings.BeerBuyersEmail + Chr(34) + "," + Chr(34) + "sc@hungermountain.coop" + Chr(34))
        MyPipeline.Commands.AddScript("$smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34))
        MyPipeline.Commands.AddScript("$Sub = " + Chr(34) + "Calmont Monthly Sales Excluded Items For " + WorkingYearMonth + Chr(34))
        MyPipeline.Commands.AddScript("$body = " + Chr(34) + "See attached file" + Chr(34))
        MyPipeline.Commands.AddScript("$secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force")
        MyPipeline.Commands.AddScript("$mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)")
        MyPipeline.Commands.AddScript("$attachment = " + Chr(34) + "\\hmc\it\Catapult\Calmont\Excludes\CalmontMonthlyExcludedItems.xls" + Chr(34))
        MyPipeline.Commands.AddScript("Send-MailMessage -To $To -Subject $Sub -body $body -Attachments $attachment -smtpserver $smtp -Credential $mycreds -from $from")
        ' add an extra command to transform the script output objects into nicely formatted strings
        ' remove this line to get the actual objects that the script returns. For example, the script
        ' "Get-Process" returns a collection of System.Diagnostics.Process instances.
        MyPipeline.Commands.Add("Out-String")

        ' execute the script
        Dim results As Collection(Of PSObject) = MyPipeline.Invoke()

        ' close the runspace
        MyRunSpace.Close()

        ' convert the script result into a single string
        Dim MyStringBuilder As New StringBuilder()

        For Each obj As PSObject In results
            MyStringBuilder.AppendLine(obj.ToString())
        Next

        ' return the results of the script that has
        ' now been converted to text
        Return MyStringBuilder.ToString()

    End Function



End Class