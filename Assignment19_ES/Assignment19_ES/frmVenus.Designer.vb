<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenus
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
        Me.btnSurfaceTempVenus = New System.Windows.Forms.Button()
        Me.btnAvgSunVenus = New System.Windows.Forms.Button()
        Me.btnTypeVenus = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSurfaceTempVenus
        '
        Me.btnSurfaceTempVenus.Location = New System.Drawing.Point(43, 126)
        Me.btnSurfaceTempVenus.Name = "btnSurfaceTempVenus"
        Me.btnSurfaceTempVenus.Size = New System.Drawing.Size(126, 42)
        Me.btnSurfaceTempVenus.TabIndex = 8
        Me.btnSurfaceTempVenus.Text = "Surface Tempurature"
        Me.btnSurfaceTempVenus.UseVisualStyleBackColor = True
        '
        'btnAvgSunVenus
        '
        Me.btnAvgSunVenus.Location = New System.Drawing.Point(43, 78)
        Me.btnAvgSunVenus.Name = "btnAvgSunVenus"
        Me.btnAvgSunVenus.Size = New System.Drawing.Size(126, 42)
        Me.btnAvgSunVenus.TabIndex = 7
        Me.btnAvgSunVenus.Text = "AVG Distance to Sun"
        Me.btnAvgSunVenus.UseVisualStyleBackColor = True
        '
        'btnTypeVenus
        '
        Me.btnTypeVenus.Location = New System.Drawing.Point(43, 30)
        Me.btnTypeVenus.Name = "btnTypeVenus"
        Me.btnTypeVenus.Size = New System.Drawing.Size(126, 42)
        Me.btnTypeVenus.TabIndex = 6
        Me.btnTypeVenus.Text = "Type"
        Me.btnTypeVenus.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(72, 174)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 26)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmVenus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 231)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSurfaceTempVenus)
        Me.Controls.Add(Me.btnAvgSunVenus)
        Me.Controls.Add(Me.btnTypeVenus)
        Me.Name = "frmVenus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Venus"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSurfaceTempVenus As Button
    Friend WithEvents btnAvgSunVenus As Button
    Friend WithEvents btnTypeVenus As Button
    Friend WithEvents btnClose As Button
End Class
