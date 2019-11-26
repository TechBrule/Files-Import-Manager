<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LBMX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LBMX))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbLBMXStep1 = New System.Windows.Forms.Label()
        Me.LbLBMXStep2 = New System.Windows.Forms.Label()
        Me.LbLBMXWorkingMonth = New System.Windows.Forms.Label()
        Me.LbLBMXWorkingYear = New System.Windows.Forms.Label()
        Me.LbLBMXWorkingYearMonth = New System.Windows.Forms.Label()
        Me.LbLBMXStep3 = New System.Windows.Forms.Label()
        Me.LbLBMXStep4 = New System.Windows.Forms.Label()
        Me.LbLBMXStep5 = New System.Windows.Forms.Label()
        Me.TBLBMXWorkingYear = New System.Windows.Forms.TextBox()
        Me.TBLBMXWorkingYearMonth = New System.Windows.Forms.TextBox()
        Me.BntSetWorkingData = New System.Windows.Forms.Button()
        Me.BtnLBMXUploadNewFile = New System.Windows.Forms.Button()
        Me.BtnLBMXRun = New System.Windows.Forms.Button()
        Me.BtnLBMXArchiveFile = New System.Windows.Forms.Button()
        Me.CBLBMXWorkingMonth = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(343, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LBMX Preview"
        '
        'LbLBMXStep1
        '
        Me.LbLBMXStep1.AutoSize = True
        Me.LbLBMXStep1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLBMXStep1.ForeColor = System.Drawing.Color.White
        Me.LbLBMXStep1.Location = New System.Drawing.Point(66, 116)
        Me.LbLBMXStep1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LbLBMXStep1.Name = "LbLBMXStep1"
        Me.LbLBMXStep1.Size = New System.Drawing.Size(666, 75)
        Me.LbLBMXStep1.TabIndex = 1
        Me.LbLBMXStep1.Text = "Step 1:          Save the file sent from the Grocery Manager to your desktop and " &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "open it in Excel. Name the sheet LBMX and save the file as a xlsx file named " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LBMX to your desktop."
        '
        'LbLBMXStep2
        '
        Me.LbLBMXStep2.AutoSize = True
        Me.LbLBMXStep2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLBMXStep2.ForeColor = System.Drawing.Color.White
        Me.LbLBMXStep2.Location = New System.Drawing.Point(66, 227)
        Me.LbLBMXStep2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LbLBMXStep2.Name = "LbLBMXStep2"
        Me.LbLBMXStep2.Size = New System.Drawing.Size(641, 50)
        Me.LbLBMXStep2.TabIndex = 2
        Me.LbLBMXStep2.Text = "Step 2:          Fill the Working Month, Working Year and Working YearMonth" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Boxe" &
    "s and Click Set Working Data."
        '
        'LbLBMXWorkingMonth
        '
        Me.LbLBMXWorkingMonth.AutoSize = True
        Me.LbLBMXWorkingMonth.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLBMXWorkingMonth.ForeColor = System.Drawing.Color.White
        Me.LbLBMXWorkingMonth.Location = New System.Drawing.Point(293, 334)
        Me.LbLBMXWorkingMonth.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LbLBMXWorkingMonth.Name = "LbLBMXWorkingMonth"
        Me.LbLBMXWorkingMonth.Size = New System.Drawing.Size(289, 25)
        Me.LbLBMXWorkingMonth.TabIndex = 3
        Me.LbLBMXWorkingMonth.Text = "Working Month (Select from List)"
        '
        'LbLBMXWorkingYear
        '
        Me.LbLBMXWorkingYear.AutoSize = True
        Me.LbLBMXWorkingYear.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLBMXWorkingYear.ForeColor = System.Drawing.Color.White
        Me.LbLBMXWorkingYear.Location = New System.Drawing.Point(293, 391)
        Me.LbLBMXWorkingYear.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LbLBMXWorkingYear.Name = "LbLBMXWorkingYear"
        Me.LbLBMXWorkingYear.Size = New System.Drawing.Size(289, 25)
        Me.LbLBMXWorkingYear.TabIndex = 4
        Me.LbLBMXWorkingYear.Text = "Working Year (For example 2019)"
        '
        'LbLBMXWorkingYearMonth
        '
        Me.LbLBMXWorkingYearMonth.AutoSize = True
        Me.LbLBMXWorkingYearMonth.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLBMXWorkingYearMonth.ForeColor = System.Drawing.Color.White
        Me.LbLBMXWorkingYearMonth.Location = New System.Drawing.Point(293, 446)
        Me.LbLBMXWorkingYearMonth.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LbLBMXWorkingYearMonth.Name = "LbLBMXWorkingYearMonth"
        Me.LbLBMXWorkingYearMonth.Size = New System.Drawing.Size(365, 25)
        Me.LbLBMXWorkingYearMonth.TabIndex = 5
        Me.LbLBMXWorkingYearMonth.Text = "Working YearMonth (For example 201903)"
        '
        'LbLBMXStep3
        '
        Me.LbLBMXStep3.AutoSize = True
        Me.LbLBMXStep3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLBMXStep3.ForeColor = System.Drawing.Color.White
        Me.LbLBMXStep3.Location = New System.Drawing.Point(69, 530)
        Me.LbLBMXStep3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LbLBMXStep3.Name = "LbLBMXStep3"
        Me.LbLBMXStep3.Size = New System.Drawing.Size(453, 50)
        Me.LbLBMXStep3.TabIndex = 6
        Me.LbLBMXStep3.Text = "Step 3:          Click Upload New File and select the file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you just saved."
        '
        'LbLBMXStep4
        '
        Me.LbLBMXStep4.AutoSize = True
        Me.LbLBMXStep4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLBMXStep4.ForeColor = System.Drawing.Color.White
        Me.LbLBMXStep4.Location = New System.Drawing.Point(69, 628)
        Me.LbLBMXStep4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LbLBMXStep4.Name = "LbLBMXStep4"
        Me.LbLBMXStep4.Size = New System.Drawing.Size(518, 75)
        Me.LbLBMXStep4.TabIndex = 7
        Me.LbLBMXStep4.Text = "Step 4:     Click Run Import. Follow the prompts. Some " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "command windows will ope" &
    "n you will need to wait for them " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to close on their own before you continue."
        '
        'LbLBMXStep5
        '
        Me.LbLBMXStep5.AutoSize = True
        Me.LbLBMXStep5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLBMXStep5.ForeColor = System.Drawing.Color.White
        Me.LbLBMXStep5.Location = New System.Drawing.Point(72, 734)
        Me.LbLBMXStep5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LbLBMXStep5.Name = "LbLBMXStep5"
        Me.LbLBMXStep5.Size = New System.Drawing.Size(515, 100)
        Me.LbLBMXStep5.TabIndex = 8
        Me.LbLBMXStep5.Text = resources.GetString("LbLBMXStep5.Text")
        '
        'TBLBMXWorkingYear
        '
        Me.TBLBMXWorkingYear.Location = New System.Drawing.Point(74, 391)
        Me.TBLBMXWorkingYear.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TBLBMXWorkingYear.Name = "TBLBMXWorkingYear"
        Me.TBLBMXWorkingYear.Size = New System.Drawing.Size(196, 36)
        Me.TBLBMXWorkingYear.TabIndex = 10
        '
        'TBLBMXWorkingYearMonth
        '
        Me.TBLBMXWorkingYearMonth.Location = New System.Drawing.Point(74, 446)
        Me.TBLBMXWorkingYearMonth.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TBLBMXWorkingYearMonth.Name = "TBLBMXWorkingYearMonth"
        Me.TBLBMXWorkingYearMonth.Size = New System.Drawing.Size(196, 36)
        Me.TBLBMXWorkingYearMonth.TabIndex = 11
        '
        'BntSetWorkingData
        '
        Me.BntSetWorkingData.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BntSetWorkingData.FlatAppearance.BorderSize = 0
        Me.BntSetWorkingData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntSetWorkingData.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntSetWorkingData.ForeColor = System.Drawing.Color.White
        Me.BntSetWorkingData.Location = New System.Drawing.Point(718, 321)
        Me.BntSetWorkingData.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BntSetWorkingData.Name = "BntSetWorkingData"
        Me.BntSetWorkingData.Size = New System.Drawing.Size(162, 66)
        Me.BntSetWorkingData.TabIndex = 12
        Me.BntSetWorkingData.Text = "Set Working Data"
        Me.BntSetWorkingData.UseVisualStyleBackColor = False
        '
        'BtnLBMXUploadNewFile
        '
        Me.BtnLBMXUploadNewFile.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnLBMXUploadNewFile.FlatAppearance.BorderSize = 0
        Me.BtnLBMXUploadNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLBMXUploadNewFile.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLBMXUploadNewFile.ForeColor = System.Drawing.Color.White
        Me.BtnLBMXUploadNewFile.Location = New System.Drawing.Point(718, 530)
        Me.BtnLBMXUploadNewFile.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BtnLBMXUploadNewFile.Name = "BtnLBMXUploadNewFile"
        Me.BtnLBMXUploadNewFile.Size = New System.Drawing.Size(162, 66)
        Me.BtnLBMXUploadNewFile.TabIndex = 13
        Me.BtnLBMXUploadNewFile.Text = "Upload New File"
        Me.BtnLBMXUploadNewFile.UseVisualStyleBackColor = False
        '
        'BtnLBMXRun
        '
        Me.BtnLBMXRun.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnLBMXRun.FlatAppearance.BorderSize = 0
        Me.BtnLBMXRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLBMXRun.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLBMXRun.ForeColor = System.Drawing.Color.White
        Me.BtnLBMXRun.Location = New System.Drawing.Point(718, 628)
        Me.BtnLBMXRun.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BtnLBMXRun.Name = "BtnLBMXRun"
        Me.BtnLBMXRun.Size = New System.Drawing.Size(162, 66)
        Me.BtnLBMXRun.TabIndex = 14
        Me.BtnLBMXRun.Text = "Run Import"
        Me.BtnLBMXRun.UseVisualStyleBackColor = False
        '
        'BtnLBMXArchiveFile
        '
        Me.BtnLBMXArchiveFile.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnLBMXArchiveFile.FlatAppearance.BorderSize = 0
        Me.BtnLBMXArchiveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLBMXArchiveFile.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLBMXArchiveFile.ForeColor = System.Drawing.Color.White
        Me.BtnLBMXArchiveFile.Location = New System.Drawing.Point(718, 734)
        Me.BtnLBMXArchiveFile.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BtnLBMXArchiveFile.Name = "BtnLBMXArchiveFile"
        Me.BtnLBMXArchiveFile.Size = New System.Drawing.Size(162, 66)
        Me.BtnLBMXArchiveFile.TabIndex = 15
        Me.BtnLBMXArchiveFile.Text = "Archive File"
        Me.BtnLBMXArchiveFile.UseVisualStyleBackColor = False
        '
        'CBLBMXWorkingMonth
        '
        Me.CBLBMXWorkingMonth.FormattingEnabled = True
        Me.CBLBMXWorkingMonth.Items.AddRange(New Object() {"January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", "Giles"})
        Me.CBLBMXWorkingMonth.Location = New System.Drawing.Point(74, 334)
        Me.CBLBMXWorkingMonth.Name = "CBLBMXWorkingMonth"
        Me.CBLBMXWorkingMonth.Size = New System.Drawing.Size(196, 38)
        Me.CBLBMXWorkingMonth.TabIndex = 16
        '
        'LBMX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1038, 937)
        Me.Controls.Add(Me.CBLBMXWorkingMonth)
        Me.Controls.Add(Me.BtnLBMXArchiveFile)
        Me.Controls.Add(Me.BtnLBMXRun)
        Me.Controls.Add(Me.BtnLBMXUploadNewFile)
        Me.Controls.Add(Me.BntSetWorkingData)
        Me.Controls.Add(Me.TBLBMXWorkingYearMonth)
        Me.Controls.Add(Me.TBLBMXWorkingYear)
        Me.Controls.Add(Me.LbLBMXStep5)
        Me.Controls.Add(Me.LbLBMXStep4)
        Me.Controls.Add(Me.LbLBMXStep3)
        Me.Controls.Add(Me.LbLBMXWorkingYearMonth)
        Me.Controls.Add(Me.LbLBMXWorkingYear)
        Me.Controls.Add(Me.LbLBMXWorkingMonth)
        Me.Controls.Add(Me.LbLBMXStep2)
        Me.Controls.Add(Me.LbLBMXStep1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "LBMX"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LbLBMXStep1 As Label
    Friend WithEvents LbLBMXStep2 As Label
    Friend WithEvents LbLBMXWorkingMonth As Label
    Friend WithEvents LbLBMXWorkingYear As Label
    Friend WithEvents LbLBMXWorkingYearMonth As Label
    Friend WithEvents LbLBMXStep3 As Label
    Friend WithEvents LbLBMXStep4 As Label
    Friend WithEvents LbLBMXStep5 As Label
    Friend WithEvents TBLBMXWorkingYear As TextBox
    Friend WithEvents TBLBMXWorkingYearMonth As TextBox
    Friend WithEvents BntSetWorkingData As Button
    Friend WithEvents BtnLBMXUploadNewFile As Button
    Friend WithEvents BtnLBMXRun As Button
    Friend WithEvents BtnLBMXArchiveFile As Button
    Friend WithEvents CBLBMXWorkingMonth As ComboBox
End Class
