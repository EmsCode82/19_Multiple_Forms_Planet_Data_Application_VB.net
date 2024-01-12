<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMercury
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
        Me.btnSurfaceTempMercury = New System.Windows.Forms.Button()
        Me.btnAvgSunMercury = New System.Windows.Forms.Button()
        Me.btnTypeMercury = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSurfaceTempMercury
        '
        Me.btnSurfaceTempMercury.Location = New System.Drawing.Point(43, 126)
        Me.btnSurfaceTempMercury.Name = "btnSurfaceTempMercury"
        Me.btnSurfaceTempMercury.Size = New System.Drawing.Size(126, 42)
        Me.btnSurfaceTempMercury.TabIndex = 5
        Me.btnSurfaceTempMercury.Text = "Surface Tempurature"
        Me.btnSurfaceTempMercury.UseVisualStyleBackColor = True
        '
        'btnAvgSunMercury
        '
        Me.btnAvgSunMercury.Location = New System.Drawing.Point(43, 78)
        Me.btnAvgSunMercury.Name = "btnAvgSunMercury"
        Me.btnAvgSunMercury.Size = New System.Drawing.Size(126, 42)
        Me.btnAvgSunMercury.TabIndex = 4
        Me.btnAvgSunMercury.Text = "AVG Distance to Sun"
        Me.btnAvgSunMercury.UseVisualStyleBackColor = True
        '
        'btnTypeMercury
        '
        Me.btnTypeMercury.Location = New System.Drawing.Point(43, 30)
        Me.btnTypeMercury.Name = "btnTypeMercury"
        Me.btnTypeMercury.Size = New System.Drawing.Size(126, 42)
        Me.btnTypeMercury.TabIndex = 3
        Me.btnTypeMercury.Text = "Type"
        Me.btnTypeMercury.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(72, 174)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 26)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMercury
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 231)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSurfaceTempMercury)
        Me.Controls.Add(Me.btnAvgSunMercury)
        Me.Controls.Add(Me.btnTypeMercury)
        Me.Name = "frmMercury"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mercury"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSurfaceTempMercury As Button
    Friend WithEvents btnAvgSunMercury As Button
    Friend WithEvents btnTypeMercury As Button
    Friend WithEvents btnClose As Button
End Class
