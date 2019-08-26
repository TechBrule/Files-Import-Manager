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
        Me.SuspendLayout()
        '
        'LbCDHeader
        '
        Me.LbCDHeader.AutoSize = True
        Me.LbCDHeader.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCDHeader.ForeColor = System.Drawing.Color.White
        Me.LbCDHeader.Location = New System.Drawing.Point(402, 9)
        Me.LbCDHeader.Name = "LbCDHeader"
        Me.LbCDHeader.Size = New System.Drawing.Size(433, 96)
        Me.LbCDHeader.TabIndex = 1
        Me.LbCDHeader.Text = "Co-op Deals"
        '
        'CoopDeals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1222, 1428)
        Me.Controls.Add(Me.LbCDHeader)
        Me.Name = "CoopDeals"
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbCDHeader As Label
End Class
