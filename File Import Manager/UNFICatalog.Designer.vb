﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UNFICatalog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UNFICatalog))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbUNFIStep1 = New System.Windows.Forms.Label()
        Me.LbUNFIStep2 = New System.Windows.Forms.Label()
        Me.LbUNFIStep3 = New System.Windows.Forms.Label()
        Me.LbUNFIStep4 = New System.Windows.Forms.Label()
        Me.LbUNFIStep5 = New System.Windows.Forms.Label()
        Me.LbUNFIStep6 = New System.Windows.Forms.Label()
        Me.LbUNFIStep7 = New System.Windows.Forms.Label()
        Me.TBUNFIWorkingYearMonth = New System.Windows.Forms.TextBox()
        Me.BtnUNFISetWorkingYearMonth = New System.Windows.Forms.Button()
        Me.BtnUNFIUploadFile = New System.Windows.Forms.Button()
        Me.BtnUNFIRunImport = New System.Windows.Forms.Button()
        Me.BtnArchiveFile = New System.Windows.Forms.Button()
        Me.BtnUNFIOpenCatalog = New System.Windows.Forms.Button()
        Me.BtnUNFIOpenMassUpdates = New System.Windows.Forms.Button()
        Me.TBCostEffectiveDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btnemail = New System.Windows.Forms.Button()
        Me.Llbemail = New System.Windows.Forms.Label()
        Me.BtnArchiveEmailFiles = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(710, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UNFI Catalog and Price Changes"
        '
        'LbUNFIStep1
        '
        Me.LbUNFIStep1.AutoSize = True
        Me.LbUNFIStep1.Location = New System.Drawing.Point(73, 135)
        Me.LbUNFIStep1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbUNFIStep1.Name = "LbUNFIStep1"
        Me.LbUNFIStep1.Size = New System.Drawing.Size(631, 75)
        Me.LbUNFIStep1.TabIndex = 1
        Me.LbUNFIStep1.Text = "Step 1:     Save the file from the UNFI email to your desktop and open it in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ex" &
    "cel. Name the sheet UNFI and save the file as a xlsx file named UNFI to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your d" &
    "esktop."
        '
        'LbUNFIStep2
        '
        Me.LbUNFIStep2.AutoSize = True
        Me.LbUNFIStep2.Location = New System.Drawing.Point(73, 246)
        Me.LbUNFIStep2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbUNFIStep2.Name = "LbUNFIStep2"
        Me.LbUNFIStep2.Size = New System.Drawing.Size(406, 125)
        Me.LbUNFIStep2.TabIndex = 2
        Me.LbUNFIStep2.Text = resources.GetString("LbUNFIStep2.Text")
        '
        'LbUNFIStep3
        '
        Me.LbUNFIStep3.AutoSize = True
        Me.LbUNFIStep3.Location = New System.Drawing.Point(73, 393)
        Me.LbUNFIStep3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbUNFIStep3.Name = "LbUNFIStep3"
        Me.LbUNFIStep3.Size = New System.Drawing.Size(469, 50)
        Me.LbUNFIStep3.TabIndex = 3
        Me.LbUNFIStep3.Text = "Step 3:     Click Upload New File and select the file you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "just saved."
        '
        'LbUNFIStep4
        '
        Me.LbUNFIStep4.AutoSize = True
        Me.LbUNFIStep4.Location = New System.Drawing.Point(73, 489)
        Me.LbUNFIStep4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbUNFIStep4.Name = "LbUNFIStep4"
        Me.LbUNFIStep4.Size = New System.Drawing.Size(470, 75)
        Me.LbUNFIStep4.TabIndex = 4
        Me.LbUNFIStep4.Text = "Step 4:     Click Run Import. Follow the prompts. Some " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "command windows will ope" &
    "n you will need to wait for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "them to close on their own before you continue."
        '
        'LbUNFIStep5
        '
        Me.LbUNFIStep5.AutoSize = True
        Me.LbUNFIStep5.Location = New System.Drawing.Point(73, 608)
        Me.LbUNFIStep5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbUNFIStep5.Name = "LbUNFIStep5"
        Me.LbUNFIStep5.Size = New System.Drawing.Size(478, 50)
        Me.LbUNFIStep5.TabIndex = 5
        Me.LbUNFIStep5.Text = "Step 5:     Click Archive File. Follow the prompts and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "then you are done with i" &
    "mporting the UNFI Catalog file."
        '
        'LbUNFIStep6
        '
        Me.LbUNFIStep6.AutoSize = True
        Me.LbUNFIStep6.Location = New System.Drawing.Point(73, 727)
        Me.LbUNFIStep6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbUNFIStep6.Name = "LbUNFIStep6"
        Me.LbUNFIStep6.Size = New System.Drawing.Size(514, 225)
        Me.LbUNFIStep6.TabIndex = 6
        Me.LbUNFIStep6.Text = resources.GetString("LbUNFIStep6.Text")
        '
        'LbUNFIStep7
        '
        Me.LbUNFIStep7.AutoSize = True
        Me.LbUNFIStep7.Location = New System.Drawing.Point(73, 975)
        Me.LbUNFIStep7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbUNFIStep7.Name = "LbUNFIStep7"
        Me.LbUNFIStep7.Size = New System.Drawing.Size(541, 25)
        Me.LbUNFIStep7.TabIndex = 7
        Me.LbUNFIStep7.Text = "Step 7:     Click Create Price Change Files and follow the promts"
        '
        'TBUNFIWorkingYearMonth
        '
        Me.TBUNFIWorkingYearMonth.Location = New System.Drawing.Point(542, 243)
        Me.TBUNFIWorkingYearMonth.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TBUNFIWorkingYearMonth.Name = "TBUNFIWorkingYearMonth"
        Me.TBUNFIWorkingYearMonth.Size = New System.Drawing.Size(128, 32)
        Me.TBUNFIWorkingYearMonth.TabIndex = 8
        '
        'BtnUNFISetWorkingYearMonth
        '
        Me.BtnUNFISetWorkingYearMonth.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnUNFISetWorkingYearMonth.FlatAppearance.BorderSize = 0
        Me.BtnUNFISetWorkingYearMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUNFISetWorkingYearMonth.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUNFISetWorkingYearMonth.Location = New System.Drawing.Point(709, 246)
        Me.BtnUNFISetWorkingYearMonth.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnUNFISetWorkingYearMonth.Name = "BtnUNFISetWorkingYearMonth"
        Me.BtnUNFISetWorkingYearMonth.Size = New System.Drawing.Size(161, 63)
        Me.BtnUNFISetWorkingYearMonth.TabIndex = 9
        Me.BtnUNFISetWorkingYearMonth.Text = "Set Dates"
        Me.BtnUNFISetWorkingYearMonth.UseVisualStyleBackColor = False
        '
        'BtnUNFIUploadFile
        '
        Me.BtnUNFIUploadFile.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnUNFIUploadFile.FlatAppearance.BorderSize = 0
        Me.BtnUNFIUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUNFIUploadFile.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUNFIUploadFile.Location = New System.Drawing.Point(709, 393)
        Me.BtnUNFIUploadFile.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnUNFIUploadFile.Name = "BtnUNFIUploadFile"
        Me.BtnUNFIUploadFile.Size = New System.Drawing.Size(161, 63)
        Me.BtnUNFIUploadFile.TabIndex = 10
        Me.BtnUNFIUploadFile.Text = "Upload New File"
        Me.BtnUNFIUploadFile.UseVisualStyleBackColor = False
        '
        'BtnUNFIRunImport
        '
        Me.BtnUNFIRunImport.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnUNFIRunImport.FlatAppearance.BorderSize = 0
        Me.BtnUNFIRunImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUNFIRunImport.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUNFIRunImport.Location = New System.Drawing.Point(709, 489)
        Me.BtnUNFIRunImport.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnUNFIRunImport.Name = "BtnUNFIRunImport"
        Me.BtnUNFIRunImport.Size = New System.Drawing.Size(161, 63)
        Me.BtnUNFIRunImport.TabIndex = 11
        Me.BtnUNFIRunImport.Text = "Run Import"
        Me.BtnUNFIRunImport.UseVisualStyleBackColor = False
        '
        'BtnArchiveFile
        '
        Me.BtnArchiveFile.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnArchiveFile.FlatAppearance.BorderSize = 0
        Me.BtnArchiveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArchiveFile.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArchiveFile.Location = New System.Drawing.Point(709, 608)
        Me.BtnArchiveFile.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnArchiveFile.Name = "BtnArchiveFile"
        Me.BtnArchiveFile.Size = New System.Drawing.Size(161, 63)
        Me.BtnArchiveFile.TabIndex = 12
        Me.BtnArchiveFile.Text = "Archive File"
        Me.BtnArchiveFile.UseVisualStyleBackColor = False
        '
        'BtnUNFIOpenCatalog
        '
        Me.BtnUNFIOpenCatalog.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnUNFIOpenCatalog.FlatAppearance.BorderSize = 0
        Me.BtnUNFIOpenCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUNFIOpenCatalog.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUNFIOpenCatalog.Location = New System.Drawing.Point(709, 717)
        Me.BtnUNFIOpenCatalog.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnUNFIOpenCatalog.Name = "BtnUNFIOpenCatalog"
        Me.BtnUNFIOpenCatalog.Size = New System.Drawing.Size(161, 63)
        Me.BtnUNFIOpenCatalog.TabIndex = 13
        Me.BtnUNFIOpenCatalog.Text = "Open Catalog"
        Me.BtnUNFIOpenCatalog.UseVisualStyleBackColor = False
        '
        'BtnUNFIOpenMassUpdates
        '
        Me.BtnUNFIOpenMassUpdates.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnUNFIOpenMassUpdates.FlatAppearance.BorderSize = 0
        Me.BtnUNFIOpenMassUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUNFIOpenMassUpdates.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUNFIOpenMassUpdates.Location = New System.Drawing.Point(709, 975)
        Me.BtnUNFIOpenMassUpdates.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnUNFIOpenMassUpdates.Name = "BtnUNFIOpenMassUpdates"
        Me.BtnUNFIOpenMassUpdates.Size = New System.Drawing.Size(161, 63)
        Me.BtnUNFIOpenMassUpdates.TabIndex = 14
        Me.BtnUNFIOpenMassUpdates.Text = "Create Price Change Files"
        Me.BtnUNFIOpenMassUpdates.UseVisualStyleBackColor = False
        '
        'TBCostEffectiveDate
        '
        Me.TBCostEffectiveDate.Location = New System.Drawing.Point(542, 309)
        Me.TBCostEffectiveDate.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TBCostEffectiveDate.Name = "TBCostEffectiveDate"
        Me.TBCostEffectiveDate.Size = New System.Drawing.Size(128, 32)
        Me.TBCostEffectiveDate.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(498, 288)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Cost Dates are Effective"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(515, 221)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Working Year\Month"
        '
        'Btnemail
        '
        Me.Btnemail.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Btnemail.FlatAppearance.BorderSize = 0
        Me.Btnemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnemail.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnemail.Location = New System.Drawing.Point(709, 1087)
        Me.Btnemail.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Btnemail.Name = "Btnemail"
        Me.Btnemail.Size = New System.Drawing.Size(161, 63)
        Me.Btnemail.TabIndex = 19
        Me.Btnemail.Text = "Email Buyers"
        Me.Btnemail.UseVisualStyleBackColor = False
        '
        'Llbemail
        '
        Me.Llbemail.AutoSize = True
        Me.Llbemail.Location = New System.Drawing.Point(73, 1087)
        Me.Llbemail.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Llbemail.Name = "Llbemail"
        Me.Llbemail.Size = New System.Drawing.Size(570, 75)
        Me.Llbemail.TabIndex = 18
        Me.Llbemail.Text = "Step 8:     Click Email Buyers, this will automatically email the price " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "change " &
    "files to the buyer. follow the promts and wiat for the timer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to end before cli" &
    "cking the final OK."
        '
        'BtnArchiveEmailFiles
        '
        Me.BtnArchiveEmailFiles.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnArchiveEmailFiles.FlatAppearance.BorderSize = 0
        Me.BtnArchiveEmailFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnArchiveEmailFiles.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArchiveEmailFiles.Location = New System.Drawing.Point(709, 1196)
        Me.BtnArchiveEmailFiles.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnArchiveEmailFiles.Name = "BtnArchiveEmailFiles"
        Me.BtnArchiveEmailFiles.Size = New System.Drawing.Size(161, 63)
        Me.BtnArchiveEmailFiles.TabIndex = 21
        Me.BtnArchiveEmailFiles.Text = "Archive Files"
        Me.BtnArchiveEmailFiles.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 1196)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(598, 50)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Step 9:     Click Archive FIles to archive the files just " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sent to the buyers. C" &
    "heck your email and make sure all files were sent."
        '
        'UNFICatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(967, 1296)
        Me.Controls.Add(Me.BtnArchiveEmailFiles)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btnemail)
        Me.Controls.Add(Me.Llbemail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBCostEffectiveDate)
        Me.Controls.Add(Me.BtnUNFIOpenMassUpdates)
        Me.Controls.Add(Me.BtnUNFIOpenCatalog)
        Me.Controls.Add(Me.BtnArchiveFile)
        Me.Controls.Add(Me.BtnUNFIRunImport)
        Me.Controls.Add(Me.BtnUNFIUploadFile)
        Me.Controls.Add(Me.BtnUNFISetWorkingYearMonth)
        Me.Controls.Add(Me.TBUNFIWorkingYearMonth)
        Me.Controls.Add(Me.LbUNFIStep7)
        Me.Controls.Add(Me.LbUNFIStep6)
        Me.Controls.Add(Me.LbUNFIStep5)
        Me.Controls.Add(Me.LbUNFIStep4)
        Me.Controls.Add(Me.LbUNFIStep3)
        Me.Controls.Add(Me.LbUNFIStep2)
        Me.Controls.Add(Me.LbUNFIStep1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "UNFICatalog"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LbUNFIStep1 As Label
    Friend WithEvents LbUNFIStep2 As Label
    Friend WithEvents LbUNFIStep3 As Label
    Friend WithEvents LbUNFIStep4 As Label
    Friend WithEvents LbUNFIStep5 As Label
    Friend WithEvents LbUNFIStep6 As Label
    Friend WithEvents LbUNFIStep7 As Label
    Friend WithEvents TBUNFIWorkingYearMonth As TextBox
    Friend WithEvents BtnUNFISetWorkingYearMonth As Button
    Friend WithEvents BtnUNFIUploadFile As Button
    Friend WithEvents BtnUNFIRunImport As Button
    Friend WithEvents BtnArchiveFile As Button
    Friend WithEvents BtnUNFIOpenCatalog As Button
    Friend WithEvents BtnUNFIOpenMassUpdates As Button
    Friend WithEvents TBCostEffectiveDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btnemail As Button
    Friend WithEvents Llbemail As Label
    Friend WithEvents BtnArchiveEmailFiles As Button
    Friend WithEvents Label4 As Label
    Private WithEvents Timer1 As Timer
End Class
