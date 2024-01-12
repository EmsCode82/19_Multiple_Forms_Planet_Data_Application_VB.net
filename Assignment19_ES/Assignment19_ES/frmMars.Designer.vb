<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMars
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
        Me.btnSurfaceTempMars = New System.Windows.Forms.Button()
        Me.btnAvgSunMars = New System.Windows.Forms.Button()
        Me.btnTypeMars = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSurfaceTempMars
        '
        Me.btnSurfaceTempMars.Location = New System.Drawing.Point(43, 126)
        Me.btnSurfaceTempMars.Name = "btnSurfaceTempMars"
        Me.btnSurfaceTempMars.Size = New System.Drawing.Size(126, 42)
        Me.btnSurfaceTempMars.TabIndex = 11
        Me.btnSurfaceTempMars.Text = "Surface Tempurature"
        Me.btnSurfaceTempMars.UseVisualStyleBackColor = True
        '
        'btnAvgSunMars
        '
        Me.btnAvgSunMars.Location = New System.Drawing.Point(43, 78)
        Me.btnAvgSunMars.Name = "btnAvgSunMars"
        Me.btnAvgSunMars.Size = New System.Drawing.Size(126, 42)
        Me.btnAvgSunMars.TabIndex = 10
        Me.btnAvgSunMars.Text = "AVG Distance to Sun"
        Me.btnAvgSunMars.UseVisualStyleBackColor = True
        '
        'btnTypeMars
        '
        Me.btnTypeMars.Location = New System.Drawing.Point(43, 30)
        Me.btnTypeMars.Name = "btnTypeMars"
        Me.btnTypeMars.Size = New System.Drawing.Size(126, 42)
        Me.btnTypeMars.TabIndex = 9
        Me.btnTypeMars.Text = "Type"
        Me.btnTypeMars.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(72, 174)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 26)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 231)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSurfaceTempMars)
        Me.Controls.Add(Me.btnAvgSunMars)
        Me.Controls.Add(Me.btnTypeMars)
        Me.Name = "frmMars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mars"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSurfaceTempMars As Button
    Friend WithEvents btnAvgSunMars As Button
    Friend WithEvents btnTypeMars As Button
    Friend WithEvents btnClose As Button
End Class
