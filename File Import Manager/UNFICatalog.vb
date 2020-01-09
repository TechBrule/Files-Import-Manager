Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces
Imports System.Text
Imports System.IO

Public Class UNFICatalog
    Dim WorkingYearMonth As String = Nothing
    Dim CostingEffectiveDate As String = Nothing

    Private Sub UNFICatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Welcome.Location
        BtnUNFIUploadFile.Enabled = False
        BtnUNFIRunImport.Enabled = False
        BtnUNFIRunImport.Enabled = False
        BtnArchiveFile.Enabled = False
        BtnArchiveEmailFiles.Enabled = False
        'BtnUNFIOpenCatalog.Enabled = False
        'BtnUNFIOpenMassUpdates.Enabled = False

    End Sub

    Private Sub BtnUNFISetWorkingYearMonth_Click(sender As Object, e As EventArgs) Handles BtnUNFISetWorkingYearMonth.Click
        WorkingYearMonth = TBUNFIWorkingYearMonth.Text
        CostingEffectiveDate = TBCostEffectiveDate.Text
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
        'Old process to open Excel files, No longer used.
        'Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\BulkandBulkHerbsUNFIMassUpdates.xlsx")
        'Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\CheeseUNFIMassUpdates.xlsx")
        'Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\GroceryMassUpdates.xlsx")
        'Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\MeatUNFIMassUpdates.xlsx")
        'Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\PerishablesUNFIMassUpdates.xlsx")
        'Process.Start("\\hmc\it\Catapult\UNFI\MassUpdateSheets\WellnessUNFIMassUpdates.xlsx")
        'New Proccess to export tables as excel files and then email them automatically.
        Dim dpath As String
        dpath = My.Settings.DtexecPath
        MessageBox.Show("You are about to see many command windows, wait for them all to close before clicking ok on the next message box. Click OK to start.", "Wait!", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  UNFIMonthlyPCBulk /ser " + My.Settings.Server)
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  UNFIMonthlyPCCheese /ser " + My.Settings.Server)
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  UNFIMonthlyPCGrocery /ser " + My.Settings.Server)
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  UNFIMonthlyPCMeat /ser " + My.Settings.Server)
        Process.Start("cmd", "/" + My.Settings.Debug + " " + dpath + " /sq  UNFIMonthlyPCWellness /ser " + My.Settings.Server)
        MessageBox.Show("Wait for all command windows to close before clicking OK", "Wait!", MessageBoxButtons.OK)
        Process.Start("cmd", "/" + My.Settings.Debug + " rename \\hmc\it\Catapult\UNFI\MonthlyPC\BulkUNFIPC.xls " + WorkingYearMonth + "BulkUNFIPC.xls")
        Process.Start("cmd", "/" + My.Settings.Debug + " rename \\hmc\it\Catapult\UNFI\MonthlyPC\CheeseUNFIPC.xls " + WorkingYearMonth + "CheeseUNFIPC.xls")
        Process.Start("cmd", "/" + My.Settings.Debug + " rename \\hmc\it\Catapult\UNFI\MonthlyPC\GroceryUNFIPC.xls " + WorkingYearMonth + "GroceryUNFIPC.xls")
        Process.Start("cmd", "/" + My.Settings.Debug + " rename \\hmc\it\Catapult\UNFI\MonthlyPC\MeatUNFIPC.xls " + WorkingYearMonth + "MeatUNFIPC.xls")
        Process.Start("cmd", "/" + My.Settings.Debug + " rename \\hmc\it\Catapult\UNFI\MonthlyPC\WellnessUNFIPC.xls " + WorkingYearMonth + "WellnessUNFIPC.xls")
        MessageBox.Show("Wait for all command windows to close before clicking OK", "Wait!", MessageBoxButtons.OK)


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

    Private Function SendUNFIMonthlyPCBulk(ByVal scriptText As String) As String

        ' create Powershell runspace
        Dim MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()

        ' open it
        MyRunSpace.Open()

        ' create a pipeline and feed it the script text
        Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()

        'MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34) + " $To = " + Chr(34) + My.Settings.BeerBuyersEmail + Chr(34) + " $smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34) + " $Sub = " + Chr(34) + "Baker Monthly Sales Excluded Items" + Chr(34) + " $secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force" + " $mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)" + " $attachment = " + Chr(34) + " \\ hmc \ it \ Catapult \ Baker \ Excludes \ BakerExcludedItems.xls" + Chr(34) + " Send-MailMessage -To $To -Subject $Sub -body $body -Attachments $attachment -smtpserver $smtp -Credential $mycreds -from $from")
        MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34))
        MyPipeline.Commands.AddScript("$to =" + Chr(34) + My.Settings.BulkBuyersEmail + Chr(34) + "," + Chr(34) + "sc@hungermountain.coop" + Chr(34))
        MyPipeline.Commands.AddScript("$smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34))
        MyPipeline.Commands.AddScript("$Sub = " + Chr(34) + "UNFI Bulk Monthly Price Changes For " + WorkingYearMonth + Chr(34))
        MyPipeline.Commands.AddScript("$body = " + Chr(34) + "                                                              Master file is up!

                                                              Please fill out the sheet and return!

                                                              If the file is empty you have no changes this month.

                                                              Thanks!

                                                              Costing for this file goes into effect " + CostingEffectiveDate + Chr(34))

        MyPipeline.Commands.AddScript("$secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force")
        MyPipeline.Commands.AddScript("$mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)")
        MyPipeline.Commands.AddScript("$attachment = " + Chr(34) + "\\hmc\it\Catapult\UNFI\MonthlyPC\" + WorkingYearMonth + "BulkUNFIPC.xls" + Chr(34))
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

    Private Sub Btnemail_Click(sender As Object, e As EventArgs) Handles Btnemail.Click
        SendUNFIMonthlyPCBulk(Nothing)
        SendUNFIMonthlyPCCheese(Nothing)
        SendUNFIMonthlyPCGrocery(Nothing)
        SendUNFIMonthlyPCMeat(Nothing)
        SendUNFIMonthlyPCWellness(Nothing)


        BtnArchiveEmailFiles.Text = 20

        Timer1.Start()

        MessageBox.Show("Wait for the count down to end before clicking OK", "Wait!", MessageBoxButtons.OK)
    End Sub


    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000

        If BtnArchiveEmailFiles.Text = 0 Then
            Timer1.Enabled = False
            BtnArchiveEmailFiles.Text = "Archive Files"
            BtnArchiveEmailFiles.Enabled = True
        Else
            BtnArchiveEmailFiles.Text = Val(BtnArchiveEmailFiles.Text) - 1
        End If
    End Sub

    Private Function SendUNFIMonthlyPCCheese(ByVal scriptText As String) As String

        ' create Powershell runspace
        Dim MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()

        ' open it
        MyRunSpace.Open()

        ' create a pipeline and feed it the script text
        Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()

        'MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34) + " $To = " + Chr(34) + My.Settings.BeerBuyersEmail + Chr(34) + " $smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34) + " $Sub = " + Chr(34) + "Baker Monthly Sales Excluded Items" + Chr(34) + " $secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force" + " $mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)" + " $attachment = " + Chr(34) + " \\ hmc \ it \ Catapult \ Baker \ Excludes \ BakerExcludedItems.xls" + Chr(34) + " Send-MailMessage -To $To -Subject $Sub -body $body -Attachments $attachment -smtpserver $smtp -Credential $mycreds -from $from")
        MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34))
        MyPipeline.Commands.AddScript("$to =" + Chr(34) + My.Settings.CheeseBuyersEmail + Chr(34) + "," + Chr(34) + "sc@hungermountain.coop" + Chr(34))
        MyPipeline.Commands.AddScript("$smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34))
        MyPipeline.Commands.AddScript("$Sub = " + Chr(34) + "UNFI Cheese Monthly Price Changes For " + WorkingYearMonth + Chr(34))
        MyPipeline.Commands.AddScript("$body = " + Chr(34) + "                                                              Master file is up!

                                                              Please fill out the sheet and return!

                                                              If the file is empty you have no changes this month.

                                                              Thanks!

                                                              Costing for this file goes into effect " + CostingEffectiveDate + Chr(34))

        MyPipeline.Commands.AddScript("$secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force")
        MyPipeline.Commands.AddScript("$mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)")
        MyPipeline.Commands.AddScript("$attachment = " + Chr(34) + "\\hmc\it\Catapult\UNFI\MonthlyPC\" + WorkingYearMonth + "CheeseUNFIPC.xls" + Chr(34))
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



    Private Function SendUNFIMonthlyPCGrocery(ByVal scriptText As String) As String

        ' create Powershell runspace
        Dim MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()

        ' open it
        MyRunSpace.Open()

        ' create a pipeline and feed it the script text
        Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()

        'MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34) + " $To = " + Chr(34) + My.Settings.BeerBuyersEmail + Chr(34) + " $smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34) + " $Sub = " + Chr(34) + "Baker Monthly Sales Excluded Items" + Chr(34) + " $secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force" + " $mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)" + " $attachment = " + Chr(34) + " \\ hmc \ it \ Catapult \ Baker \ Excludes \ BakerExcludedItems.xls" + Chr(34) + " Send-MailMessage -To $To -Subject $Sub -body $body -Attachments $attachment -smtpserver $smtp -Credential $mycreds -from $from")
        MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34))
        MyPipeline.Commands.AddScript("$to =" + Chr(34) + My.Settings.GroceryBuyersEmail + Chr(34) + "," + Chr(34) + "sc@hungermountain.coop" + Chr(34))
        MyPipeline.Commands.AddScript("$smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34))
        MyPipeline.Commands.AddScript("$Sub = " + Chr(34) + "UNFI Grocery, Frozen and Refrigerated Monthly Price Changes For " + WorkingYearMonth + Chr(34))
        MyPipeline.Commands.AddScript("$body = " + Chr(34) + "                                                              Master file is up!

                                                              Please fill out the sheet and return!

                                                              If the file is empty you have no changes this month.

                                                              Thanks!

                                                              Costing for this file goes into effect " + CostingEffectiveDate + Chr(34))

        MyPipeline.Commands.AddScript("$secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force")
        MyPipeline.Commands.AddScript("$mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)")
        MyPipeline.Commands.AddScript("$attachment = " + Chr(34) + "\\hmc\it\Catapult\UNFI\MonthlyPC\" + WorkingYearMonth + "GroceryUNFIPC.xls" + Chr(34))
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


    Private Function SendUNFIMonthlyPCMeat(ByVal scriptText As String) As String

        ' create Powershell runspace
        Dim MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()

        ' open it
        MyRunSpace.Open()

        ' create a pipeline and feed it the script text
        Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()

        'MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34) + " $To = " + Chr(34) + My.Settings.BeerBuyersEmail + Chr(34) + " $smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34) + " $Sub = " + Chr(34) + "Baker Monthly Sales Excluded Items" + Chr(34) + " $secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force" + " $mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)" + " $attachment = " + Chr(34) + " \\ hmc \ it \ Catapult \ Baker \ Excludes \ BakerExcludedItems.xls" + Chr(34) + " Send-MailMessage -To $To -Subject $Sub -body $body -Attachments $attachment -smtpserver $smtp -Credential $mycreds -from $from")
        MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34))
        MyPipeline.Commands.AddScript("$to =" + Chr(34) + My.Settings.MeatBuyersEmail + Chr(34) + "," + Chr(34) + "sc@hungermountain.coop" + Chr(34))
        MyPipeline.Commands.AddScript("$smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34))
        MyPipeline.Commands.AddScript("$Sub = " + Chr(34) + "UNFI Meat Monthly Price Changes For " + WorkingYearMonth + Chr(34))
        MyPipeline.Commands.AddScript("$body = " + Chr(34) + "                                                              Master file is up!

                                                              Please fill out the sheet and return!

                                                              If the file is empty you have no changes this month.

                                                              Thanks!

                                                              Costing for this file goes into effect " + CostingEffectiveDate + Chr(34))

        MyPipeline.Commands.AddScript("$secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force")
        MyPipeline.Commands.AddScript("$mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)")
        MyPipeline.Commands.AddScript("$attachment = " + Chr(34) + "\\hmc\it\Catapult\UNFI\MonthlyPC\" + WorkingYearMonth + "MeatUNFIPC.xls" + Chr(34))
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



    Private Function SendUNFIMonthlyPCWellness(ByVal scriptText As String) As String

        ' create Powershell runspace
        Dim MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()

        ' open it
        MyRunSpace.Open()

        ' create a pipeline and feed it the script text
        Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()

        'MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34) + " $To = " + Chr(34) + My.Settings.BeerBuyersEmail + Chr(34) + " $smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34) + " $Sub = " + Chr(34) + "Baker Monthly Sales Excluded Items" + Chr(34) + " $secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force" + " $mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)" + " $attachment = " + Chr(34) + " \\ hmc \ it \ Catapult \ Baker \ Excludes \ BakerExcludedItems.xls" + Chr(34) + " Send-MailMessage -To $To -Subject $Sub -body $body -Attachments $attachment -smtpserver $smtp -Credential $mycreds -from $from")
        MyPipeline.Commands.AddScript("$from = " + Chr(34) + My.Settings.UsersEmail + Chr(34))
        MyPipeline.Commands.AddScript("$to =" + Chr(34) + My.Settings.WellnessBuyersEmail + Chr(34) + "," + Chr(34) + "sc@hungermountain.coop" + Chr(34))
        MyPipeline.Commands.AddScript("$smtp = " + Chr(34) + My.Settings.MailSMTPServer + Chr(34))
        MyPipeline.Commands.AddScript("$Sub = " + Chr(34) + "UNFI Wellness Monthly Price Changes For " + WorkingYearMonth + Chr(34))
        MyPipeline.Commands.AddScript("$body = " + Chr(34) + "                                                              Master file is up!

                                                              Please fill out the sheet and return!

                                                              If the file is empty you have no changes this month.

                                                              Thanks!

                                                              Costing for this file goes into effect " + CostingEffectiveDate + Chr(34))

        MyPipeline.Commands.AddScript("$secpasswd = ConvertTo-SecureString " + Chr(34) + My.Settings.UsersEmailPassword + Chr(34) + " -AsPlainText -Force")
        MyPipeline.Commands.AddScript("$mycreds = New-Object System.Management.Automation.PSCredential(" + Chr(34) + My.Settings.UsersEmail + Chr(34) + ", $secpasswd)")
        MyPipeline.Commands.AddScript("$attachment = " + Chr(34) + "\\hmc\it\Catapult\UNFI\MonthlyPC\" + WorkingYearMonth + "WellnessUNFIPC.xls" + Chr(34))
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

    Private Sub BtnArchiveEmailFiles_Click(sender As Object, e As EventArgs) Handles BtnArchiveEmailFiles.Click

        Process.Start("cmd", "/" + My.Settings.Debug + " move \\hmc\it\Catapult\UNFI\MonthlyPC\*.* \\hmc\it\Catapult\UNFI\MonthlyPC\Archive\")
        MessageBox.Show("Wait for all command windows to close before clicking OK", "Wait!", MessageBoxButtons.OK)
    End Sub


End Class