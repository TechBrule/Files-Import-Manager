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
        Me.SuspendLayout()
        '
        'TBSettingsServer
        '
        Me.TBSettingsServer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBSettingsServer.Location = New System.Drawing.Point(198, 111)
        Me.TBSettingsServer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TBSettingsServer.Name = "TBSettingsServer"
        Me.TBSettingsServer.Size = New System.Drawing.Size(628, 29)
        Me.TBSettingsServer.TabIndex = 0
        '
        'TBSettingsDTEXECPath
        '
        Me.TBSettingsDTEXECPath.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBSettingsDTEXECPath.Location = New System.Drawing.Point(198, 164)
        Me.TBSettingsDTEXECPath.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TBSettingsDTEXECPath.Name = "TBSettingsDTEXECPath"
        Me.TBSettingsDTEXECPath.Size = New System.Drawing.Size(628, 29)
        Me.TBSettingsDTEXECPath.TabIndex = 1
        '
        'TBSettingsConnectionString
        '
        Me.TBSettingsConnectionString.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TBSettingsConnectionString.Location = New System.Drawing.Point(198, 220)
        Me.TBSettingsConnectionString.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.SettingsLBL.Location = New System.Drawing.Point(366, 9)
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
        Me.LBLServer.Location = New System.Drawing.Point(117, 119)
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
        Me.DtexecPathLBL.Location = New System.Drawing.Point(56, 172)
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
        Me.ConnectionStringLBL.Location = New System.Drawing.Point(38, 228)
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
        Me.BtnSaveSettings.Location = New System.Drawing.Point(628, 267)
        Me.BtnSaveSettings.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.BtnSetDebug.Location = New System.Drawing.Point(198, 267)
        Me.BtnSetDebug.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.LblDebugStatus.Location = New System.Drawing.Point(194, 337)
        Me.LblDebugStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDebugStatus.Name = "LblDebugStatus"
        Me.LblDebugStatus.Size = New System.Drawing.Size(321, 37)
        Me.LblDebugStatus.TabIndex = 9
        Me.LblDebugStatus.Text = "Debug Status : Disabled"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(923, 401)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
End Class
