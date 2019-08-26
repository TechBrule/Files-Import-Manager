<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoopBasics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoopBasics))
        Me.LbCBHeader = New System.Windows.Forms.Label()
        Me.LbCBStep1 = New System.Windows.Forms.Label()
        Me.LbCBStep2 = New System.Windows.Forms.Label()
        Me.LbCBStep3 = New System.Windows.Forms.Label()
        Me.LbCBStep4 = New System.Windows.Forms.Label()
        Me.LbCBStep5 = New System.Windows.Forms.Label()
        Me.TBCBWorkingMonth = New System.Windows.Forms.TextBox()
        Me.BtnCBSetWorkingMonth = New System.Windows.Forms.Button()
        Me.BtnCBUploadNewFile = New System.Windows.Forms.Button()
        Me.BtnCBRunImport = New System.Windows.Forms.Button()
        Me.BtnCBArchiveFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbCBHeader
        '
        Me.LbCBHeader.AutoSize = True
        Me.LbCBHeader.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCBHeader.ForeColor = System.Drawing.Color.White
        Me.LbCBHeader.Location = New System.Drawing.Point(373, 9)
        Me.LbCBHeader.Name = "LbCBHeader"
        Me.LbCBHeader.Size = New System.Drawing.Size(450, 96)
        Me.LbCBHeader.TabIndex = 0
        Me.LbCBHeader.Text = "Co-op Basics"
        '
        'LbCBStep1
        '
        Me.LbCBStep1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCBStep1.ForeColor = System.Drawing.Color.White
        Me.LbCBStep1.Location = New System.Drawing.Point(90, 167)
        Me.LbCBStep1.Name = "LbCBStep1"
        Me.LbCBStep1.Size = New System.Drawing.Size(1036, 103)
        Me.LbCBStep1.TabIndex = 1
        Me.LbCBStep1.Text = "Step 1:          Save the file sent from the Grocery Manager to you desktop and o" &
    "pen it in Excel. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name the sheet CoopBasics and save the file as a xlsx file na" &
    "med CoopBasics to your desktop." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LbCBStep2
        '
        Me.LbCBStep2.AutoSize = True
        Me.LbCBStep2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCBStep2.ForeColor = System.Drawing.Color.White
        Me.LbCBStep2.Location = New System.Drawing.Point(90, 318)
        Me.LbCBStep2.Name = "LbCBStep2"
        Me.LbCBStep2.Size = New System.Drawing.Size(584, 96)
        Me.LbCBStep2.TabIndex = 2
        Me.LbCBStep2.Text = "Step 2:          Enter the year/month of the file you are" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "importing. For example" &
    " for March of 2019 enter " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "201903. Click Set Working Month."
        '
        'LbCBStep3
        '
        Me.LbCBStep3.AutoSize = True
        Me.LbCBStep3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCBStep3.ForeColor = System.Drawing.Color.White
        Me.LbCBStep3.Location = New System.Drawing.Point(90, 476)
        Me.LbCBStep3.Name = "LbCBStep3"
        Me.LbCBStep3.Size = New System.Drawing.Size(801, 64)
        Me.LbCBStep3.TabIndex = 3
        Me.LbCBStep3.Text = "Step 3:         Click Upload New File and then move the file you just saved " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "int" &
    "o the folder that opens. Close the folder after you have copied the file."
        '
        'LbCBStep4
        '
        Me.LbCBStep4.AutoSize = True
        Me.LbCBStep4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCBStep4.ForeColor = System.Drawing.Color.White
        Me.LbCBStep4.Location = New System.Drawing.Point(90, 637)
        Me.LbCBStep4.Name = "LbCBStep4"
        Me.LbCBStep4.Size = New System.Drawing.Size(832, 96)
        Me.LbCBStep4.TabIndex = 4
        Me.LbCBStep4.Text = "Step 4:          Click Run Import. Follow the promts. Some command windows " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will" &
    " open, you will need to wait for each window to close on its own before " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you co" &
    "ntinue. "
        '
        'LbCBStep5
        '
        Me.LbCBStep5.AutoSize = True
        Me.LbCBStep5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCBStep5.ForeColor = System.Drawing.Color.White
        Me.LbCBStep5.Location = New System.Drawing.Point(90, 798)
        Me.LbCBStep5.Name = "LbCBStep5"
        Me.LbCBStep5.Size = New System.Drawing.Size(801, 128)
        Me.LbCBStep5.TabIndex = 5
        Me.LbCBStep5.Text = resources.GetString("LbCBStep5.Text")
        '
        'TBCBWorkingMonth
        '
        Me.TBCBWorkingMonth.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCBWorkingMonth.Location = New System.Drawing.Point(714, 318)
        Me.TBCBWorkingMonth.Name = "TBCBWorkingMonth"
        Me.TBCBWorkingMonth.Size = New System.Drawing.Size(194, 50)
        Me.TBCBWorkingMonth.TabIndex = 6
        '
        'BtnCBSetWorkingMonth
        '
        Me.BtnCBSetWorkingMonth.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BtnCBSetWorkingMonth.FlatAppearance.BorderSize = 0
        Me.BtnCBSetWorkingMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCBSetWorkingMonth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCBSetWorkingMonth.ForeColor = System.Drawing.Color.White
        Me.BtnCBSetWorkingMonth.Location = New System.Drawing.Point(931, 318)
        Me.BtnCBSetWorkingMonth.Name = "BtnCBSetWorkingMonth"
        Me.BtnCBSetWorkingMonth.Size = New System.Drawing.Size(195, 82)
        Me.BtnCBSetWorkingMonth.TabIndex = 7
        Me.BtnCBSetWorkingMonth.Text = "Set Working Year\Month"
        Me.BtnCBSetWorkingMonth.UseVisualStyleBackColor = False
        '
        'BtnCBUploadNewFile
        '
        Me.BtnCBUploadNewFile.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BtnCBUploadNewFile.FlatAppearance.BorderSize = 0
        Me.BtnCBUploadNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCBUploadNewFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCBUploadNewFile.ForeColor = System.Drawing.Color.White
        Me.BtnCBUploadNewFile.Location = New System.Drawing.Point(931, 476)
        Me.BtnCBUploadNewFile.Name = "BtnCBUploadNewFile"
        Me.BtnCBUploadNewFile.Size = New System.Drawing.Size(195, 82)
        Me.BtnCBUploadNewFile.TabIndex = 8
        Me.BtnCBUploadNewFile.Text = "Upload New File"
        Me.BtnCBUploadNewFile.UseVisualStyleBackColor = False
        '
        'BtnCBRunImport
        '
        Me.BtnCBRunImport.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BtnCBRunImport.FlatAppearance.BorderSize = 0
        Me.BtnCBRunImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCBRunImport.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCBRunImport.ForeColor = System.Drawing.Color.White
        Me.BtnCBRunImport.Location = New System.Drawing.Point(931, 637)
        Me.BtnCBRunImport.Name = "BtnCBRunImport"
        Me.BtnCBRunImport.Size = New System.Drawing.Size(195, 82)
        Me.BtnCBRunImport.TabIndex = 9
        Me.BtnCBRunImport.Text = "Run Import"
        Me.BtnCBRunImport.UseVisualStyleBackColor = False
        '
        'BtnCBArchiveFile
        '
        Me.BtnCBArchiveFile.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BtnCBArchiveFile.FlatAppearance.BorderSize = 0
        Me.BtnCBArchiveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCBArchiveFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCBArchiveFile.ForeColor = System.Drawing.Color.White
        Me.BtnCBArchiveFile.Location = New System.Drawing.Point(931, 798)
        Me.BtnCBArchiveFile.Name = "BtnCBArchiveFile"
        Me.BtnCBArchiveFile.Size = New System.Drawing.Size(195, 82)
        Me.BtnCBArchiveFile.TabIndex = 10
        Me.BtnCBArchiveFile.Text = "Archive File"
        Me.BtnCBArchiveFile.UseVisualStyleBackColor = False
        '
        'CoopBasics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1222, 973)
        Me.Controls.Add(Me.BtnCBArchiveFile)
        Me.Controls.Add(Me.BtnCBRunImport)
        Me.Controls.Add(Me.BtnCBUploadNewFile)
        Me.Controls.Add(Me.BtnCBSetWorkingMonth)
        Me.Controls.Add(Me.TBCBWorkingMonth)
        Me.Controls.Add(Me.LbCBStep5)
        Me.Controls.Add(Me.LbCBStep4)
        Me.Controls.Add(Me.LbCBStep3)
        Me.Controls.Add(Me.LbCBStep2)
        Me.Controls.Add(Me.LbCBStep1)
        Me.Controls.Add(Me.LbCBHeader)
        Me.Name = "CoopBasics"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbCBHeader As Label
    Friend WithEvents LbCBStep1 As Label
    Friend WithEvents LbCBStep2 As Label
    Friend WithEvents LbCBStep3 As Label
    Friend WithEvents LbCBStep4 As Label
    Friend WithEvents LbCBStep5 As Label
    Friend WithEvents TBCBWorkingMonth As TextBox
    Friend WithEvents BtnCBSetWorkingMonth As Button
    Friend WithEvents BtnCBUploadNewFile As Button
    Friend WithEvents BtnCBRunImport As Button
    Friend WithEvents BtnCBArchiveFile As Button
End Class
