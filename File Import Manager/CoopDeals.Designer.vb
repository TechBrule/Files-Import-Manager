<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoopDeals
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LbCDHeader = New System.Windows.Forms.Label()
        Me.LbCAPStep1 = New System.Windows.Forms.Label()
        Me.BTNSaveCAPCatapultExports = New System.Windows.Forms.Button()
        Me.BTNArchiveExcludes = New System.Windows.Forms.Button()
        Me.BTNEmailCAPExcludes = New System.Windows.Forms.Button()
        Me.BtnCAPArchiveImport = New System.Windows.Forms.Button()
        Me.BtnCAPRunImport = New System.Windows.Forms.Button()
        Me.BtnCAPUploadFile = New System.Windows.Forms.Button()
        Me.BtnCAPSetWorkingYearMonth = New System.Windows.Forms.Button()
        Me.TBCAPWorkingYearMonth = New System.Windows.Forms.TextBox()
        Me.LbCAPStep8 = New System.Windows.Forms.Label()
        Me.LbCAPStep7 = New System.Windows.Forms.Label()
        Me.LbCAPStep6 = New System.Windows.Forms.Label()
        Me.LbCAPStep5 = New System.Windows.Forms.Label()
        Me.LbCAPStep4 = New System.Windows.Forms.Label()
        Me.LbCAPStep3 = New System.Windows.Forms.Label()
        Me.LbCAPStep2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LbCDHeader
        '
        Me.LbCDHeader.AutoSize = True
        Me.LbCDHeader.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCDHeader.ForeColor = System.Drawing.Color.White
        Me.LbCDHeader.Location = New System.Drawing.Point(375, 6)
        Me.LbCDHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbCDHeader.Name = "LbCDHeader"
        Me.LbCDHeader.Size = New System.Drawing.Size(289, 65)
        Me.LbCDHeader.TabIndex = 1
        Me.LbCDHeader.Text = "Co-op Deals"
        '
        'LbCAPStep1
        '
        Me.LbCAPStep1.AutoSize = True
        Me.LbCAPStep1.Location = New System.Drawing.Point(118, 111)
        Me.LbCAPStep1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbCAPStep1.Name = "LbCAPStep1"
        Me.LbCAPStep1.Size = New System.Drawing.Size(642, 75)
        Me.LbCAPStep1.TabIndex = 78
        Me.LbCAPStep1.Text = "Step 1:     Open the file saved from LBMX and name the sheet ExportPromo." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Save t" &
    "he file as CAPImport.xlsx in the  \\hmc\it\CoopDB\UNFI CATAPULT\" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Folder in a ne" &
    "w folder named for the Month and year. "
        '
        'BTNSaveCAPCatapultExports
        '
        Me.BTNSaveCAPCatapultExports.BackColor = System.Drawing.Color.Tomato
        Me.BTNSaveCAPCatapultExports.FlatAppearance.BorderSize = 0
        Me.BTNSaveCAPCatapultExports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSaveCAPCatapultExports.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSaveCAPCatapultExports.Location = New System.Drawing.Point(756, 873)
        Me.BTNSaveCAPCatapultExports.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BTNSaveCAPCatapultExports.Name = "BTNSaveCAPCatapultExports"
        Me.BTNSaveCAPCatapultExports.Size = New System.Drawing.Size(162, 66)
        Me.BTNSaveCAPCatapultExports.TabIndex = 77
        Me.BTNSaveCAPCatapultExports.Text = "Save Catapult Files"
        Me.BTNSaveCAPCatapultExports.UseVisualStyleBackColor = False
        '
        'BTNArchiveExcludes
        '
        Me.BTNArchiveExcludes.BackColor = System.Drawing.Color.Tomato
        Me.BTNArchiveExcludes.FlatAppearance.BorderSize = 0
        Me.BTNArchiveExcludes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNArchiveExcludes.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNArchiveExcludes.Location = New System.Drawing.Point(756, 766)
        Me.BTNArchiveExcludes.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BTNArchiveExcludes.Name = "BTNArchiveExcludes"
        Me.BTNArchiveExcludes.Size = New System.Drawing.Size(162, 66)
        Me.BTNArchiveExcludes.TabIndex = 76
        Me.BTNArchiveExcludes.Text = "Archive File"
        Me.BTNArchiveExcludes.UseVisualStyleBackColor = False
        '
        'BTNEmailCAPExcludes
        '
        Me.BTNEmailCAPExcludes.BackColor = System.Drawing.Color.Tomato
        Me.BTNEmailCAPExcludes.FlatAppearance.BorderSize = 0
        Me.BTNEmailCAPExcludes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEmailCAPExcludes.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEmailCAPExcludes.Location = New System.Drawing.Point(756, 661)
        Me.BTNEmailCAPExcludes.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BTNEmailCAPExcludes.Name = "BTNEmailCAPExcludes"
        Me.BTNEmailCAPExcludes.Size = New System.Drawing.Size(162, 66)
        Me.BTNEmailCAPExcludes.TabIndex = 75
        Me.BTNEmailCAPExcludes.Text = "Email Buyer"
        Me.BTNEmailCAPExcludes.UseVisualStyleBackColor = False
        '
        'BtnCAPArchiveImport
        '
        Me.BtnCAPArchiveImport.BackColor = System.Drawing.Color.Tomato
        Me.BtnCAPArchiveImport.FlatAppearance.BorderSize = 0
        Me.BtnCAPArchiveImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCAPArchiveImport.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCAPArchiveImport.Location = New System.Drawing.Point(756, 558)
        Me.BtnCAPArchiveImport.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnCAPArchiveImport.Name = "BtnCAPArchiveImport"
        Me.BtnCAPArchiveImport.Size = New System.Drawing.Size(162, 66)
        Me.BtnCAPArchiveImport.TabIndex = 74
        Me.BtnCAPArchiveImport.Text = "Archive File"
        Me.BtnCAPArchiveImport.UseVisualStyleBackColor = False
        '
        'BtnCAPRunImport
        '
        Me.BtnCAPRunImport.BackColor = System.Drawing.Color.Tomato
        Me.BtnCAPRunImport.FlatAppearance.BorderSize = 0
        Me.BtnCAPRunImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCAPRunImport.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCAPRunImport.Location = New System.Drawing.Point(756, 455)
        Me.BtnCAPRunImport.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnCAPRunImport.Name = "BtnCAPRunImport"
        Me.BtnCAPRunImport.Size = New System.Drawing.Size(162, 66)
        Me.BtnCAPRunImport.TabIndex = 73
        Me.BtnCAPRunImport.Text = "Run Import"
        Me.BtnCAPRunImport.UseVisualStyleBackColor = False
        '
        'BtnCAPUploadFile
        '
        Me.BtnCAPUploadFile.BackColor = System.Drawing.Color.Tomato
        Me.BtnCAPUploadFile.FlatAppearance.BorderSize = 0
        Me.BtnCAPUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCAPUploadFile.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCAPUploadFile.Location = New System.Drawing.Point(756, 351)
        Me.BtnCAPUploadFile.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnCAPUploadFile.Name = "BtnCAPUploadFile"
        Me.BtnCAPUploadFile.Size = New System.Drawing.Size(162, 66)
        Me.BtnCAPUploadFile.TabIndex = 72
        Me.BtnCAPUploadFile.Text = "Upload New File"
        Me.BtnCAPUploadFile.UseVisualStyleBackColor = False
        '
        'BtnCAPSetWorkingYearMonth
        '
        Me.BtnCAPSetWorkingYearMonth.BackColor = System.Drawing.Color.Tomato
        Me.BtnCAPSetWorkingYearMonth.FlatAppearance.BorderSize = 0
        Me.BtnCAPSetWorkingYearMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCAPSetWorkingYearMonth.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCAPSetWorkingYearMonth.Location = New System.Drawing.Point(756, 241)
        Me.BtnCAPSetWorkingYearMonth.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnCAPSetWorkingYearMonth.Name = "BtnCAPSetWorkingYearMonth"
        Me.BtnCAPSetWorkingYearMonth.Size = New System.Drawing.Size(162, 66)
        Me.BtnCAPSetWorkingYearMonth.TabIndex = 71
        Me.BtnCAPSetWorkingYearMonth.Text = "Set Working Year\Month"
        Me.BtnCAPSetWorkingYearMonth.UseVisualStyleBackColor = False
        '
        'TBCAPWorkingYearMonth
        '
        Me.TBCAPWorkingYearMonth.Location = New System.Drawing.Point(576, 241)
        Me.TBCAPWorkingYearMonth.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TBCAPWorkingYearMonth.Name = "TBCAPWorkingYearMonth"
        Me.TBCAPWorkingYearMonth.Size = New System.Drawing.Size(128, 32)
        Me.TBCAPWorkingYearMonth.TabIndex = 70
        '
        'LbCAPStep8
        '
        Me.LbCAPStep8.AutoSize = True
        Me.LbCAPStep8.Location = New System.Drawing.Point(118, 873)
        Me.LbCAPStep8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbCAPStep8.Name = "LbCAPStep8"
        Me.LbCAPStep8.Size = New System.Drawing.Size(469, 50)
        Me.LbCAPStep8.TabIndex = 69
        Me.LbCAPStep8.Text = "Step 8:     Export files for import into catapult. Files are " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "exported to  \\hmc" &
    "\it\CoopDB\UNFI CATAPULT\ "
        '
        'LbCAPStep7
        '
        Me.LbCAPStep7.AutoSize = True
        Me.LbCAPStep7.Location = New System.Drawing.Point(118, 766)
        Me.LbCAPStep7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbCAPStep7.Name = "LbCAPStep7"
        Me.LbCAPStep7.Size = New System.Drawing.Size(472, 50)
        Me.LbCAPStep7.TabIndex = 68
        Me.LbCAPStep7.Text = "Step 7:     Click Archive File to archive the excludes file. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Follow the prompts" &
    "."
        '
        'LbCAPStep6
        '
        Me.LbCAPStep6.AutoSize = True
        Me.LbCAPStep6.Location = New System.Drawing.Point(118, 661)
        Me.LbCAPStep6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbCAPStep6.Name = "LbCAPStep6"
        Me.LbCAPStep6.Size = New System.Drawing.Size(434, 25)
        Me.LbCAPStep6.TabIndex = 67
        Me.LbCAPStep6.Text = "Step 6:     Email the excluded list to the Beer Buyer."
        '
        'LbCAPStep5
        '
        Me.LbCAPStep5.AutoSize = True
        Me.LbCAPStep5.Location = New System.Drawing.Point(118, 558)
        Me.LbCAPStep5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbCAPStep5.Name = "LbCAPStep5"
        Me.LbCAPStep5.Size = New System.Drawing.Size(409, 25)
        Me.LbCAPStep5.TabIndex = 66
        Me.LbCAPStep5.Text = "Step 5:     Click Archive File. Follow the prompts."
        '
        'LbCAPStep4
        '
        Me.LbCAPStep4.AutoSize = True
        Me.LbCAPStep4.Location = New System.Drawing.Point(118, 455)
        Me.LbCAPStep4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbCAPStep4.Name = "LbCAPStep4"
        Me.LbCAPStep4.Size = New System.Drawing.Size(470, 75)
        Me.LbCAPStep4.TabIndex = 65
        Me.LbCAPStep4.Text = "Step 4:     Click Run Import. Follow the prompts. Some " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "command windows will ope" &
    "n you will need to wait for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "them to close on their own before you continue."
        '
        'LbCAPStep3
        '
        Me.LbCAPStep3.AutoSize = True
        Me.LbCAPStep3.Location = New System.Drawing.Point(118, 351)
        Me.LbCAPStep3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbCAPStep3.Name = "LbCAPStep3"
        Me.LbCAPStep3.Size = New System.Drawing.Size(469, 50)
        Me.LbCAPStep3.TabIndex = 64
        Me.LbCAPStep3.Text = "Step 3:     Click Upload New File and select the file you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "just saved."
        '
        'LbCAPStep2
        '
        Me.LbCAPStep2.AutoSize = True
        Me.LbCAPStep2.Location = New System.Drawing.Point(118, 241)
        Me.LbCAPStep2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LbCAPStep2.Name = "LbCAPStep2"
        Me.LbCAPStep2.Size = New System.Drawing.Size(399, 75)
        Me.LbCAPStep2.TabIndex = 63
        Me.LbCAPStep2.Text = "Step 2:     Enter the year\month of the file you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are importing. For example for" &
    " March of 2019 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "enter 201903. Click Set Working Month."
        '
        'CoopDeals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1038, 1107)
        Me.Controls.Add(Me.LbCAPStep1)
        Me.Controls.Add(Me.BTNSaveCAPCatapultExports)
        Me.Controls.Add(Me.BTNArchiveExcludes)
        Me.Controls.Add(Me.BTNEmailCAPExcludes)
        Me.Controls.Add(Me.BtnCAPArchiveImport)
        Me.Controls.Add(Me.BtnCAPRunImport)
        Me.Controls.Add(Me.BtnCAPUploadFile)
        Me.Controls.Add(Me.BtnCAPSetWorkingYearMonth)
        Me.Controls.Add(Me.TBCAPWorkingYearMonth)
        Me.Controls.Add(Me.LbCAPStep8)
        Me.Controls.Add(Me.LbCAPStep7)
        Me.Controls.Add(Me.LbCAPStep6)
        Me.Controls.Add(Me.LbCAPStep5)
        Me.Controls.Add(Me.LbCAPStep4)
        Me.Controls.Add(Me.LbCAPStep3)
        Me.Controls.Add(Me.LbCAPStep2)
        Me.Controls.Add(Me.LbCDHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CoopDeals"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbCDHeader As Label
    Friend WithEvents LbCAPStep1 As Label
    Friend WithEvents BTNSaveCAPCatapultExports As Button
    Friend WithEvents BTNArchiveExcludes As Button
    Friend WithEvents BTNEmailCAPExcludes As Button
    Friend WithEvents BtnCAPArchiveImport As Button
    Friend WithEvents BtnCAPRunImport As Button
    Friend WithEvents BtnCAPUploadFile As Button
    Friend WithEvents BtnCAPSetWorkingYearMonth As Button
    Friend WithEvents TBCAPWorkingYearMonth As TextBox
    Friend WithEvents LbCAPStep8 As Label
    Friend WithEvents LbCAPStep7 As Label
    Friend WithEvents LbCAPStep6 As Label
    Friend WithEvents LbCAPStep5 As Label
    Friend WithEvents LbCAPStep4 As Label
    Friend WithEvents LbCAPStep3 As Label
    Friend WithEvents LbCAPStep2 As Label
End Class
