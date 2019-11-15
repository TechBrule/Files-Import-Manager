<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.TBSettingsServer = New System.Windows.Forms.TextBox()
        Me.TBSettingsDTEXECPath = New System.Windows.Forms.TextBox()
        Me.TBSettingsConnectionString = New System.Windows.Forms.TextBox()
        Me.SettingsLBL = New System.Windows.Forms.Label()
        Me.LBLServer = New System.Windows.Forms.Label()
        Me.DtexecPathLBL = New System.Windows.Forms.Label()
        Me.ConnectionStringLBL = New System.Windows.Forms.Label()
        Me.BtnSaveSettings = New System.Windows.Forms.Button()
        Me.BtnSetDebug = New System.Windows.Forms.Button()
        Me.LblDebugStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBUsersEmail = New System.Windows.Forms.Label()
        Me.TBUsersEmail = New System.Windows.Forms.TextBox()
        Me.LBUsersEmailPassword = New System.Windows.Forms.Label()
        Me.TBUsersEmailPassword = New System.Windows.Forms.TextBox()
        Me.LBSMTPServer = New System.Windows.Forms.Label()
        Me.TBMailServer = New System.Windows.Forms.TextBox()
        Me.LBBeerBuyerEmail = New System.Windows.Forms.Label()
        Me.TBBeerBuyerEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TBSettingsServer
        '
        Me.TBSettingsServer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBSettingsServer.Location = New System.Drawing.Point(297, 171)
        Me.TBSettingsServer.Name = "TBSettingsServer"
        Me.TBSettingsServer.Size = New System.Drawing.Size(940, 39)
        Me.TBSettingsServer.TabIndex = 0
        '
        'TBSettingsDTEXECPath
        '
        Me.TBSettingsDTEXECPath.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBSettingsDTEXECPath.Location = New System.Drawing.Point(297, 252)
        Me.TBSettingsDTEXECPath.Name = "TBSettingsDTEXECPath"
        Me.TBSettingsDTEXECPath.Size = New System.Drawing.Size(940, 39)
        Me.TBSettingsDTEXECPath.TabIndex = 1
        '
        'TBSettingsConnectionString
        '
        Me.TBSettingsConnectionString.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBSettingsConnectionString.Location = New System.Drawing.Point(297, 338)
        Me.TBSettingsConnectionString.Name = "TBSettingsConnectionString"
        Me.TBSettingsConnectionString.ReadOnly = True
        Me.TBSettingsConnectionString.Size = New System.Drawing.Size(940, 39)
        Me.TBSettingsConnectionString.TabIndex = 2
        '
        'SettingsLBL
        '
        Me.SettingsLBL.AutoSize = True
        Me.SettingsLBL.Font = New System.Drawing.Font("Segoe UI", 36.0!)
        Me.SettingsLBL.ForeColor = System.Drawing.Color.White
        Me.SettingsLBL.Location = New System.Drawing.Point(592, 15)
        Me.SettingsLBL.Name = "SettingsLBL"
        Me.SettingsLBL.Size = New System.Drawing.Size(295, 96)
        Me.SettingsLBL.TabIndex = 3
        Me.SettingsLBL.Text = "Settings"
        '
        'LBLServer
        '
        Me.LBLServer.AutoSize = True
        Me.LBLServer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LBLServer.ForeColor = System.Drawing.Color.White
        Me.LBLServer.Location = New System.Drawing.Point(176, 183)
        Me.LBLServer.Name = "LBLServer"
        Me.LBLServer.Size = New System.Drawing.Size(94, 32)
        Me.LBLServer.TabIndex = 4
        Me.LBLServer.Text = "Server :"
        '
        'DtexecPathLBL
        '
        Me.DtexecPathLBL.AutoSize = True
        Me.DtexecPathLBL.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DtexecPathLBL.ForeColor = System.Drawing.Color.White
        Me.DtexecPathLBL.Location = New System.Drawing.Point(84, 265)
        Me.DtexecPathLBL.Name = "DtexecPathLBL"
        Me.DtexecPathLBL.Size = New System.Drawing.Size(195, 32)
        Me.DtexecPathLBL.TabIndex = 5
        Me.DtexecPathLBL.Text = "Dtexec.exe Path :"
        '
        'ConnectionStringLBL
        '
        Me.ConnectionStringLBL.AutoSize = True
        Me.ConnectionStringLBL.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ConnectionStringLBL.ForeColor = System.Drawing.Color.White
        Me.ConnectionStringLBL.Location = New System.Drawing.Point(57, 351)
        Me.ConnectionStringLBL.Name = "ConnectionStringLBL"
        Me.ConnectionStringLBL.Size = New System.Drawing.Size(219, 32)
        Me.ConnectionStringLBL.TabIndex = 6
        Me.ConnectionStringLBL.Text = "Connection String :"
        '
        'BtnSaveSettings
        '
        Me.BtnSaveSettings.BackColor = System.Drawing.Color.DimGray
        Me.BtnSaveSettings.FlatAppearance.BorderSize = 0
        Me.BtnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveSettings.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSaveSettings.ForeColor = System.Drawing.Color.White
        Me.BtnSaveSettings.Location = New System.Drawing.Point(940, 869)
        Me.BtnSaveSettings.Name = "BtnSaveSettings"
        Me.BtnSaveSettings.Size = New System.Drawing.Size(297, 82)
        Me.BtnSaveSettings.TabIndex = 7
        Me.BtnSaveSettings.Text = "Save Settings"
        Me.BtnSaveSettings.UseVisualStyleBackColor = False
        '
        'BtnSetDebug
        '
        Me.BtnSetDebug.BackColor = System.Drawing.Color.DimGray
        Me.BtnSetDebug.FlatAppearance.BorderSize = 0
        Me.BtnSetDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSetDebug.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSetDebug.ForeColor = System.Drawing.Color.White
        Me.BtnSetDebug.Location = New System.Drawing.Point(297, 869)
        Me.BtnSetDebug.Name = "BtnSetDebug"
        Me.BtnSetDebug.Size = New System.Drawing.Size(252, 82)
        Me.BtnSetDebug.TabIndex = 8
        Me.BtnSetDebug.Text = "Set Debug Mode"
        Me.BtnSetDebug.UseVisualStyleBackColor = False
        '
        'LblDebugStatus
        '
        Me.LblDebugStatus.AutoSize = True
        Me.LblDebugStatus.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugStatus.ForeColor = System.Drawing.Color.White
        Me.LblDebugStatus.Location = New System.Drawing.Point(287, 991)
        Me.LblDebugStatus.Name = "LblDebugStatus"
        Me.LblDebugStatus.Size = New System.Drawing.Size(480, 55)
        Me.LblDebugStatus.TabIndex = 9
        Me.LblDebugStatus.Text = "Debug Status : Disabled"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(509, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 96)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Mail Settings"
        '
        'LBUsersEmail
        '
        Me.LBUsersEmail.AutoSize = True
        Me.LBUsersEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LBUsersEmail.ForeColor = System.Drawing.Color.White
        Me.LBUsersEmail.Location = New System.Drawing.Point(122, 530)
        Me.LBUsersEmail.Name = "LBUsersEmail"
        Me.LBUsersEmail.Size = New System.Drawing.Size(148, 32)
        Me.LBUsersEmail.TabIndex = 12
        Me.LBUsersEmail.Text = "Users Email :"
        '
        'TBUsersEmail
        '
        Me.TBUsersEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBUsersEmail.Location = New System.Drawing.Point(297, 523)
        Me.TBUsersEmail.Name = "TBUsersEmail"
        Me.TBUsersEmail.Size = New System.Drawing.Size(940, 39)
        Me.TBUsersEmail.TabIndex = 11
        '
        'LBUsersEmailPassword
        '
        Me.LBUsersEmailPassword.AutoSize = True
        Me.LBUsersEmailPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LBUsersEmailPassword.ForeColor = System.Drawing.Color.White
        Me.LBUsersEmailPassword.Location = New System.Drawing.Point(18, 616)
        Me.LBUsersEmailPassword.Name = "LBUsersEmailPassword"
        Me.LBUsersEmailPassword.Size = New System.Drawing.Size(252, 32)
        Me.LBUsersEmailPassword.TabIndex = 14
        Me.LBUsersEmailPassword.Text = "Users Email Password :"
        '
        'TBUsersEmailPassword
        '
        Me.TBUsersEmailPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBUsersEmailPassword.Location = New System.Drawing.Point(297, 609)
        Me.TBUsersEmailPassword.Name = "TBUsersEmailPassword"
        Me.TBUsersEmailPassword.Size = New System.Drawing.Size(940, 39)
        Me.TBUsersEmailPassword.TabIndex = 13
        '
        'LBSMTPServer
        '
        Me.LBSMTPServer.AutoSize = True
        Me.LBSMTPServer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LBSMTPServer.ForeColor = System.Drawing.Color.White
        Me.LBSMTPServer.Location = New System.Drawing.Point(130, 697)
        Me.LBSMTPServer.Name = "LBSMTPServer"
        Me.LBSMTPServer.Size = New System.Drawing.Size(140, 32)
        Me.LBSMTPServer.TabIndex = 16
        Me.LBSMTPServer.Text = "Mail Server:"
        '
        'TBMailServer
        '
        Me.TBMailServer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBMailServer.Location = New System.Drawing.Point(297, 690)
        Me.TBMailServer.Name = "TBMailServer"
        Me.TBMailServer.Size = New System.Drawing.Size(940, 39)
        Me.TBMailServer.TabIndex = 15
        '
        'LBBeerBuyerEmail
        '
        Me.LBBeerBuyerEmail.AutoSize = True
        Me.LBBeerBuyerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LBBeerBuyerEmail.ForeColor = System.Drawing.Color.White
        Me.LBBeerBuyerEmail.Location = New System.Drawing.Point(70, 778)
        Me.LBBeerBuyerEmail.Name = "LBBeerBuyerEmail"
        Me.LBBeerBuyerEmail.Size = New System.Drawing.Size(200, 32)
        Me.LBBeerBuyerEmail.TabIndex = 18
        Me.LBBeerBuyerEmail.Text = "Beer Buyer Email:"
        '
        'TBBeerBuyerEmail
        '
        Me.TBBeerBuyerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBBeerBuyerEmail.Location = New System.Drawing.Point(297, 771)
        Me.TBBeerBuyerEmail.Name = "TBBeerBuyerEmail"
        Me.TBBeerBuyerEmail.Size = New System.Drawing.Size(940, 39)
        Me.TBBeerBuyerEmail.TabIndex = 17
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1384, 1142)
        Me.Controls.Add(Me.LBBeerBuyerEmail)
        Me.Controls.Add(Me.TBBeerBuyerEmail)
        Me.Controls.Add(Me.LBSMTPServer)
        Me.Controls.Add(Me.TBMailServer)
        Me.Controls.Add(Me.LBUsersEmailPassword)
        Me.Controls.Add(Me.TBUsersEmailPassword)
        Me.Controls.Add(Me.LBUsersEmail)
        Me.Controls.Add(Me.TBUsersEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDebugStatus)
        Me.Controls.Add(Me.BtnSetDebug)
        Me.Controls.Add(Me.BtnSaveSettings)
        Me.Controls.Add(Me.ConnectionStringLBL)
        Me.Controls.Add(Me.DtexecPathLBL)
        Me.Controls.Add(Me.LBLServer)
        Me.Controls.Add(Me.SettingsLBL)
        Me.Controls.Add(Me.TBSettingsConnectionString)
        Me.Controls.Add(Me.TBSettingsDTEXECPath)
        Me.Controls.Add(Me.TBSettingsServer)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBSettingsServer As TextBox
    Friend WithEvents TBSettingsDTEXECPath As TextBox
    Friend WithEvents TBSettingsConnectionString As TextBox
    Friend WithEvents SettingsLBL As Label
    Friend WithEvents LBLServer As Label
    Friend WithEvents DtexecPathLBL As Label
    Friend WithEvents ConnectionStringLBL As Label
    Friend WithEvents BtnSaveSettings As Button
    Friend WithEvents BtnSetDebug As Button
    Friend WithEvents LblDebugStatus As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBUsersEmail As Label
    Friend WithEvents TBUsersEmail As TextBox
    Friend WithEvents LBUsersEmailPassword As Label
    Friend WithEvents TBUsersEmailPassword As TextBox
    Friend WithEvents LBSMTPServer As Label
    Friend WithEvents TBMailServer As TextBox
    Friend WithEvents LBBeerBuyerEmail As Label
    Friend WithEvents TBBeerBuyerEmail As TextBox
End Class
