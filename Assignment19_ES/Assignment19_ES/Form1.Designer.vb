<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMercury = New System.Windows.Forms.Button()
        Me.btnVenus = New System.Windows.Forms.Button()
        Me.btnEarth = New System.Windows.Forms.Button()
        Me.btnMars = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(228, 74)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 26)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMercury
        '
        Me.btnMercury.Location = New System.Drawing.Point(17, 21)
        Me.btnMercury.Name = "btnMercury"
        Me.btnMercury.Size = New System.Drawing.Size(118, 32)
        Me.btnMercury.TabIndex = 1
        Me.btnMercury.Text = "Mercury"
        Me.btnMercury.UseVisualStyleBackColor = True
        '
        'btnVenus
        '
        Me.btnVenus.Location = New System.Drawing.Point(141, 21)
        Me.btnVenus.Name = "btnVenus"
        Me.btnVenus.Size = New System.Drawing.Size(118, 32)
        Me.btnVenus.TabIndex = 2
        Me.btnVenus.Text = "Venus"
        Me.btnVenus.UseVisualStyleBackColor = True
        '
        'btnEarth
        '
        Me.btnEarth.Location = New System.Drawing.Point(265, 21)
        Me.btnEarth.Name = "btnEarth"
        Me.btnEarth.Size = New System.Drawing.Size(118, 32)
        Me.btnEarth.TabIndex = 3
        Me.btnEarth.Text = "Earth"
        Me.btnEarth.UseVisualStyleBackColor = True
        '
        'btnMars
        '
        Me.btnMars.Location = New System.Drawing.Point(389, 21)
        Me.btnMars.Name = "btnMars"
        Me.btnMars.Size = New System.Drawing.Size(118, 32)
        Me.btnMars.TabIndex = 4
        Me.btnMars.Text = "Mars"
        Me.btnMars.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 120)
        Me.Controls.Add(Me.btnMars)
        Me.Controls.Add(Me.btnEarth)
        Me.Controls.Add(Me.btnVenus)
        Me.Controls.Add(Me.btnMercury)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planets Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnMercury As Button
    Friend WithEvents btnVenus As Button
    Friend WithEvents btnEarth As Button
    Friend WithEvents btnMars As Button
End Class
