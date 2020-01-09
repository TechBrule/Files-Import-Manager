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
        Me.LblCapExcludes = New System.Windows.Forms.Label()
        Me.TBCAPExcludesList = New System.Windows.Forms.TextBox()
        Me.LblCapBulkExcludes = New System.Windows.Forms.Label()
        Me.TBCAPBulkExcludesList = New System.Windows.Forms.TextBox()
        Me.LbBulkBuyer = New System.Windows.Forms.Label()
        Me.TBBulkBuyerEmail = New System.Windows.Forms.TextBox()
        Me.LbCheeseBuyer = New System.Windows.Forms.Label()
        Me.TBCheeseBuyerEmail = New System.Windows.Forms.TextBox()
        Me.LbGroceryBuyer = New System.Windows.Forms.Label()
        Me.TBGroceryBuyerEmail = New System.Windows.Forms.TextBox()
        Me.LbMeatBuyerEmail = New System.Windows.Forms.Label()
        Me.TBMeatBuyerEmail = New System.Windows.Forms.TextBox()
        Me.LbWellnessBuyerEmail = New System.Windows.Forms.Label()
        Me.TBWellnessBuyerEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TBSettingsServer
        '
        Me.TBSettingsServer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBSettingsServer.Location = New System.Drawing.Point(215, 111)
        Me.TBSettingsServer.Margin = New System.Windows.Forms.Padding(2)
        Me.TBSettingsServer.Name = "TBSettingsServer"
        Me.TBSettingsServer.Size = New System.Drawing.Size(628, 29)
        Me.TBSettingsServer.TabIndex = 0
        '
        'TBSettingsDTEXECPath
        '
        Me.TBSettingsDTEXECPath.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBSettingsDTEXECPath.Location = New System.Drawing.Point(215, 164)
        Me.TBSettingsDTEXECPath.Margin = New System.Windows.Forms.Padding(2)
        Me.TBSettingsDTEXECPath.Name = "TBSettingsDTEXECPath"
        Me.TBSettingsDTEXECPath.Size = New System.Drawing.Size(628, 29)
        Me.TBSettingsDTEXECPath.TabIndex = 1
        '
        'TBSettingsConnectionString
        '
        Me.TBSettingsConnectionString.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBSettingsConnectionString.Location = New System.Drawing.Point(215, 220)
        Me.TBSettingsConnectionString.Margin = New System.Windows.Forms.Padding(2)
        Me.TBSettingsConnectionString.Name = "TBSettingsConnectionString"
        Me.TBSettingsConnectionString.ReadOnly = True
        Me.TBSettingsConnectionString.Size = New System.Drawing.Size(628, 29)
        Me.TBSettingsConnectionString.TabIndex = 2
        '
        'SettingsLBL
        '
        Me.SettingsLBL.AutoSize = True
        Me.SettingsLBL.Font = New System.Drawing.Font("Segoe UI", 36.0!)
        Me.SettingsLBL.ForeColor = System.Drawing.Color.White
        Me.SettingsLBL.Location = New System.Drawing.Point(412, 10)
        Me.SettingsLBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SettingsLBL.Name = "SettingsLBL"
        Me.SettingsLBL.Size = New System.Drawing.Size(198, 65)
        Me.SettingsLBL.TabIndex = 3
        Me.SettingsLBL.Text = "Settings"
        '
        'LBLServer
        '
        Me.LBLServer.AutoSize = True
        Me.LBLServer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LBLServer.ForeColor = System.Drawing.Color.White
        Me.LBLServer.Location = New System.Drawing.Point(134, 119)
        Me.LBLServer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLServer.Name = "LBLServer"
        Me.LBLServer.Size = New System.Drawing.Size(62, 21)
        Me.LBLServer.TabIndex = 4
        Me.LBLServer.Text = "Server :"
        '
        'DtexecPathLBL
        '
        Me.DtexecPathLBL.AutoSize = True
        Me.DtexecPathLBL.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DtexecPathLBL.ForeColor = System.Drawing.Color.White
        Me.DtexecPathLBL.Location = New System.Drawing.Point(73, 172)
        Me.DtexecPathLBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DtexecPathLBL.Name = "DtexecPathLBL"
        Me.DtexecPathLBL.Size = New System.Drawing.Size(123, 21)
        Me.DtexecPathLBL.TabIndex = 5
        Me.DtexecPathLBL.Text = "Dtexec.exe Path :"
        '
        'ConnectionStringLBL
        '
        Me.ConnectionStringLBL.AutoSize = True
        Me.ConnectionStringLBL.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ConnectionStringLBL.ForeColor = System.Drawing.Color.White
        Me.ConnectionStringLBL.Location = New System.Drawing.Point(55, 228)
        Me.ConnectionStringLBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ConnectionStringLBL.Name = "ConnectionStringLBL"
        Me.ConnectionStringLBL.Size = New System.Drawing.Size(141, 21)
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
        Me.BtnSaveSettings.Location = New System.Drawing.Point(644, 921)
        Me.BtnSaveSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSaveSettings.Name = "BtnSaveSettings"
        Me.BtnSaveSettings.Size = New System.Drawing.Size(198, 53)
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
        Me.BtnSetDebug.Location = New System.Drawing.Point(215, 921)
        Me.BtnSetDebug.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSetDebug.Name = "BtnSetDebug"
        Me.BtnSetDebug.Size = New System.Drawing.Size(168, 53)
        Me.BtnSetDebug.TabIndex = 8
        Me.BtnSetDebug.Text = "Set Debug Mode"
        Me.BtnSetDebug.UseVisualStyleBackColor = False
        '
        'LblDebugStatus
        '
        Me.LblDebugStatus.AutoSize = True
        Me.LblDebugStatus.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebugStatus.ForeColor = System.Drawing.Color.White
        Me.LblDebugStatus.Location = New System.Drawing.Point(208, 974)
        Me.LblDebugStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDebugStatus.Name = "LblDebugStatus"
        Me.LblDebugStatus.Size = New System.Drawing.Size(321, 37)
        Me.LblDebugStatus.TabIndex = 9
        Me.LblDebugStatus.Text = "Debug Status : Disabled"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(356, 267)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 65)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Mail Settings"
        '
        'LBUsersEmail
        '
        Me.LBUsersEmail.AutoSize = True
        Me.LBUsersEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LBUsersEmail.ForeColor = System.Drawing.Color.White
        Me.LBUsersEmail.Location = New System.Drawing.Point(98, 348)
        Me.LBUsersEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBUsersEmail.Name = "LBUsersEmail"
        Me.LBUsersEmail.Size = New System.Drawing.Size(98, 21)
        Me.LBUsersEmail.TabIndex = 12
        Me.LBUsersEmail.Text = "Users Email :"
        '
        'TBUsersEmail
        '
        Me.TBUsersEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBUsersEmail.Location = New System.Drawing.Point(215, 340)
        Me.TBUsersEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TBUsersEmail.Name = "TBUsersEmail"
        Me.TBUsersEmail.Size = New System.Drawing.Size(628, 29)
        Me.TBUsersEmail.TabIndex = 11
        '
        'LBUsersEmailPassword
        '
        Me.LBUsersEmailPassword.AutoSize = True
        Me.LBUsersEmailPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LBUsersEmailPassword.ForeColor = System.Drawing.Color.White
        Me.LBUsersEmailPassword.Location = New System.Drawing.Point(28, 404)
        Me.LBUsersEmailPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBUsersEmailPassword.Name = "LBUsersEmailPassword"
        Me.LBUsersEmailPassword.Size = New System.Drawing.Size(168, 21)
        Me.LBUsersEmailPassword.TabIndex = 14
        Me.LBUsersEmailPassword.Text = "Users Email Password :"
        '
        'TBUsersEmailPassword
        '
        Me.TBUsersEmailPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBUsersEmailPassword.Location = New System.Drawing.Point(215, 396)
        Me.TBUsersEmailPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TBUsersEmailPassword.Name = "TBUsersEmailPassword"
        Me.TBUsersEmailPassword.Size = New System.Drawing.Size(628, 29)
        Me.TBUsersEmailPassword.TabIndex = 13
        '
        'LBSMTPServer
        '
        Me.LBSMTPServer.AutoSize = True
        Me.LBSMTPServer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LBSMTPServer.ForeColor = System.Drawing.Color.White
        Me.LBSMTPServer.Location = New System.Drawing.Point(104, 456)
        Me.LBSMTPServer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBSMTPServer.Name = "LBSMTPServer"
        Me.LBSMTPServer.Size = New System.Drawing.Size(92, 21)
        Me.LBSMTPServer.TabIndex = 16
        Me.LBSMTPServer.Text = "Mail Server:"
        '
        'TBMailServer
        '
        Me.TBMailServer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBMailServer.Location = New System.Drawing.Point(215, 448)
        Me.TBMailServer.Margin = New System.Windows.Forms.Padding(2)
        Me.TBMailServer.Name = "TBMailServer"
        Me.TBMailServer.Size = New System.Drawing.Size(628, 29)
        Me.TBMailServer.TabIndex = 15
        '
        'LBBeerBuyerEmail
        '
        Me.LBBeerBuyerEmail.AutoSize = True
        Me.LBBeerBuyerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LBBeerBuyerEmail.ForeColor = System.Drawing.Color.White
        Me.LBBeerBuyerEmail.Location = New System.Drawing.Point(63, 509)
        Me.LBBeerBuyerEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBBeerBuyerEmail.Name = "LBBeerBuyerEmail"
        Me.LBBeerBuyerEmail.Size = New System.Drawing.Size(130, 21)
        Me.LBBeerBuyerEmail.TabIndex = 18
        Me.LBBeerBuyerEmail.Text = "Beer Buyer Email:"
        '
        'TBBeerBuyerEmail
        '
        Me.TBBeerBuyerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBBeerBuyerEmail.Location = New System.Drawing.Point(215, 501)
        Me.TBBeerBuyerEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TBBeerBuyerEmail.Name = "TBBeerBuyerEmail"
        Me.TBBeerBuyerEmail.Size = New System.Drawing.Size(628, 29)
        Me.TBBeerBuyerEmail.TabIndex = 17
        '
        'LblCapExcludes
        '
        Me.LblCapExcludes.AutoSize = True
        Me.LblCapExcludes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblCapExcludes.ForeColor = System.Drawing.Color.White
        Me.LblCapExcludes.Location = New System.Drawing.Point(42, 816)
        Me.LblCapExcludes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCapExcludes.Name = "LblCapExcludes"
        Me.LblCapExcludes.Size = New System.Drawing.Size(154, 21)
        Me.LblCapExcludes.TabIndex = 20
        Me.LblCapExcludes.Text = "CAP Excludes Emails:"
        '
        'TBCAPExcludesList
        '
        Me.TBCAPExcludesList.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBCAPExcludesList.Location = New System.Drawing.Point(215, 808)
        Me.TBCAPExcludesList.Margin = New System.Windows.Forms.Padding(2)
        Me.TBCAPExcludesList.Name = "TBCAPExcludesList"
        Me.TBCAPExcludesList.Size = New System.Drawing.Size(628, 29)
        Me.TBCAPExcludesList.TabIndex = 19
        '
        'LblCapBulkExcludes
        '
        Me.LblCapBulkExcludes.AutoSize = True
        Me.LblCapBulkExcludes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblCapBulkExcludes.ForeColor = System.Drawing.Color.White
        Me.LblCapBulkExcludes.Location = New System.Drawing.Point(13, 870)
        Me.LblCapBulkExcludes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCapBulkExcludes.Name = "LblCapBulkExcludes"
        Me.LblCapBulkExcludes.Size = New System.Drawing.Size(181, 21)
        Me.LblCapBulkExcludes.TabIndex = 22
        Me.LblCapBulkExcludes.Text = "CAP Bulk Excludes Email:"
        '
        'TBCAPBulkExcludesList
        '
        Me.TBCAPBulkExcludesList.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBCAPBulkExcludesList.Location = New System.Drawing.Point(215, 862)
        Me.TBCAPBulkExcludesList.Margin = New System.Windows.Forms.Padding(2)
        Me.TBCAPBulkExcludesList.Name = "TBCAPBulkExcludesList"
        Me.TBCAPBulkExcludesList.Size = New System.Drawing.Size(628, 29)
        Me.TBCAPBulkExcludesList.TabIndex = 21
        '
        'LbBulkBuyer
        '
        Me.LbBulkBuyer.AutoSize = True
        Me.LbBulkBuyer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LbBulkBuyer.ForeColor = System.Drawing.Color.White
        Me.LbBulkBuyer.Location = New System.Drawing.Point(67, 561)
        Me.LbBulkBuyer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbBulkBuyer.Name = "LbBulkBuyer"
        Me.LbBulkBuyer.Size = New System.Drawing.Size(129, 21)
        Me.LbBulkBuyer.TabIndex = 24
        Me.LbBulkBuyer.Text = "Bulk Buyer Email:"
        '
        'TBBulkBuyerEmail
        '
        Me.TBBulkBuyerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBBulkBuyerEmail.Location = New System.Drawing.Point(215, 553)
        Me.TBBulkBuyerEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TBBulkBuyerEmail.Name = "TBBulkBuyerEmail"
        Me.TBBulkBuyerEmail.Size = New System.Drawing.Size(628, 29)
        Me.TBBulkBuyerEmail.TabIndex = 23
        '
        'LbCheeseBuyer
        '
        Me.LbCheeseBuyer.AutoSize = True
        Me.LbCheeseBuyer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LbCheeseBuyer.ForeColor = System.Drawing.Color.White
        Me.LbCheeseBuyer.Location = New System.Drawing.Point(45, 611)
        Me.LbCheeseBuyer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbCheeseBuyer.Name = "LbCheeseBuyer"
        Me.LbCheeseBuyer.Size = New System.Drawing.Size(149, 21)
        Me.LbCheeseBuyer.TabIndex = 26
        Me.LbCheeseBuyer.Text = "Cheese Buyer Email:"
        '
        'TBCheeseBuyerEmail
        '
        Me.TBCheeseBuyerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBCheeseBuyerEmail.Location = New System.Drawing.Point(215, 603)
        Me.TBCheeseBuyerEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TBCheeseBuyerEmail.Name = "TBCheeseBuyerEmail"
        Me.TBCheeseBuyerEmail.Size = New System.Drawing.Size(628, 29)
        Me.TBCheeseBuyerEmail.TabIndex = 25
        '
        'LbGroceryBuyer
        '
        Me.LbGroceryBuyer.AutoSize = True
        Me.LbGroceryBuyer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LbGroceryBuyer.ForeColor = System.Drawing.Color.White
        Me.LbGroceryBuyer.Location = New System.Drawing.Point(42, 662)
        Me.LbGroceryBuyer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbGroceryBuyer.Name = "LbGroceryBuyer"
        Me.LbGroceryBuyer.Size = New System.Drawing.Size(154, 21)
        Me.LbGroceryBuyer.TabIndex = 28
        Me.LbGroceryBuyer.Text = "Grocery Buyer Email:"
        '
        'TBGroceryBuyerEmail
        '
        Me.TBGroceryBuyerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBGroceryBuyerEmail.Location = New System.Drawing.Point(215, 654)
        Me.TBGroceryBuyerEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TBGroceryBuyerEmail.Name = "TBGroceryBuyerEmail"
        Me.TBGroceryBuyerEmail.Size = New System.Drawing.Size(628, 29)
        Me.TBGroceryBuyerEmail.TabIndex = 27
        '
        'LbMeatBuyerEmail
        '
        Me.LbMeatBuyerEmail.AutoSize = True
        Me.LbMeatBuyerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LbMeatBuyerEmail.ForeColor = System.Drawing.Color.White
        Me.LbMeatBuyerEmail.Location = New System.Drawing.Point(60, 715)
        Me.LbMeatBuyerEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbMeatBuyerEmail.Name = "LbMeatBuyerEmail"
        Me.LbMeatBuyerEmail.Size = New System.Drawing.Size(134, 21)
        Me.LbMeatBuyerEmail.TabIndex = 30
        Me.LbMeatBuyerEmail.Text = "Meat Buyer Email:"
        '
        'TBMeatBuyerEmail
        '
        Me.TBMeatBuyerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBMeatBuyerEmail.Location = New System.Drawing.Point(215, 707)
        Me.TBMeatBuyerEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TBMeatBuyerEmail.Name = "TBMeatBuyerEmail"
        Me.TBMeatBuyerEmail.Size = New System.Drawing.Size(628, 29)
        Me.TBMeatBuyerEmail.TabIndex = 29
        '
        'LbWellnessBuyerEmail
        '
        Me.LbWellnessBuyerEmail.AutoSize = True
        Me.LbWellnessBuyerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LbWellnessBuyerEmail.ForeColor = System.Drawing.Color.White
        Me.LbWellnessBuyerEmail.Location = New System.Drawing.Point(36, 766)
        Me.LbWellnessBuyerEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbWellnessBuyerEmail.Name = "LbWellnessBuyerEmail"
        Me.LbWellnessBuyerEmail.Size = New System.Drawing.Size(160, 21)
        Me.LbWellnessBuyerEmail.TabIndex = 32
        Me.LbWellnessBuyerEmail.Text = "Wellness Buyer Email:"
        '
        'TBWellnessBuyerEmail
        '
        Me.TBWellnessBuyerEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBWellnessBuyerEmail.Location = New System.Drawing.Point(215, 758)
        Me.TBWellnessBuyerEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TBWellnessBuyerEmail.Name = "TBWellnessBuyerEmail"
        Me.TBWellnessBuyerEmail.Size = New System.Drawing.Size(628, 29)
        Me.TBWellnessBuyerEmail.TabIndex = 31
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(923, 1027)
        Me.Controls.Add(Me.LbWellnessBuyerEmail)
        Me.Controls.Add(Me.TBWellnessBuyerEmail)
        Me.Controls.Add(Me.LbMeatBuyerEmail)
        Me.Controls.Add(Me.TBMeatBuyerEmail)
        Me.Controls.Add(Me.LbGroceryBuyer)
        Me.Controls.Add(Me.TBGroceryBuyerEmail)
        Me.Controls.Add(Me.LbCheeseBuyer)
        Me.Controls.Add(Me.TBCheeseBuyerEmail)
        Me.Controls.Add(Me.LbBulkBuyer)
        Me.Controls.Add(Me.TBBulkBuyerEmail)
        Me.Controls.Add(Me.LblCapBulkExcludes)
        Me.Controls.Add(Me.TBCAPBulkExcludesList)
        Me.Controls.Add(Me.LblCapExcludes)
        Me.Controls.Add(Me.TBCAPExcludesList)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents LblCapExcludes As Label
    Friend WithEvents TBCAPExcludesList As TextBox
    Friend WithEvents LblCapBulkExcludes As Label
    Friend WithEvents TBCAPBulkExcludesList As TextBox
    Friend WithEvents LbBulkBuyer As Label
    Friend WithEvents TBBulkBuyerEmail As TextBox
    Friend WithEvents LbCheeseBuyer As Label
    Friend WithEvents TBCheeseBuyerEmail As TextBox
    Friend WithEvents LbGroceryBuyer As Label
    Friend WithEvents TBGroceryBuyerEmail As TextBox
    Friend WithEvents LbMeatBuyerEmail As Label
    Friend WithEvents TBMeatBuyerEmail As TextBox
    Friend WithEvents LbWellnessBuyerEmail As Label
    Friend WithEvents TBWellnessBuyerEmail As TextBox
End Class
