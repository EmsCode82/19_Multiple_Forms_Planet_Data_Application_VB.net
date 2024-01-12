<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEarth
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
        Me.btnTypeEarth = New System.Windows.Forms.Button()
        Me.btnAvgSunEarth = New System.Windows.Forms.Button()
        Me.btnSurfaceTempEarth = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTypeEarth
        '
        Me.btnTypeEarth.Location = New System.Drawing.Point(43, 30)
        Me.btnTypeEarth.Name = "btnTypeEarth"
        Me.btnTypeEarth.Size = New System.Drawing.Size(126, 42)
        Me.btnTypeEarth.TabIndex = 0
        Me.btnTypeEarth.Text = "Type"
        Me.btnTypeEarth.UseVisualStyleBackColor = True
        '
        'btnAvgSunEarth
        '
        Me.btnAvgSunEarth.Location = New System.Drawing.Point(43, 78)
        Me.btnAvgSunEarth.Name = "btnAvgSunEarth"
        Me.btnAvgSunEarth.Size = New System.Drawing.Size(126, 42)
        Me.btnAvgSunEarth.TabIndex = 1
        Me.btnAvgSunEarth.Text = "AVG Distance to Sun"
        Me.btnAvgSunEarth.UseVisualStyleBackColor = True
        '
        'btnSurfaceTempEarth
        '
        Me.btnSurfaceTempEarth.Location = New System.Drawing.Point(43, 126)
        Me.btnSurfaceTempEarth.Name = "btnSurfaceTempEarth"
        Me.btnSurfaceTempEarth.Size = New System.Drawing.Size(126, 42)
        Me.btnSurfaceTempEarth.TabIndex = 2
        Me.btnSurfaceTempEarth.Text = "Surface Tempurature"
        Me.btnSurfaceTempEarth.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(72, 174)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 26)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmEarth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 231)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSurfaceTempEarth)
        Me.Controls.Add(Me.btnAvgSunEarth)
        Me.Controls.Add(Me.btnTypeEarth)
        Me.Name = "frmEarth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Earth"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTypeEarth As Button
    Friend WithEvents btnAvgSunEarth As Button
    Friend WithEvents btnSurfaceTempEarth As Button
    Friend WithEvents btnClose As Button
End Class
