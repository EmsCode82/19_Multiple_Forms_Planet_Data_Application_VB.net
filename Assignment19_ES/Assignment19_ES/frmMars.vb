Public Class frmMars
    Private Sub btnTypeMars_Click(sender As Object, e As EventArgs) Handles btnTypeMars.Click

        MessageBox.Show("Terrestrial")

    End Sub

    Private Sub btnAvgSunMars_Click(sender As Object, e As EventArgs) Handles btnAvgSunMars.Click

        MessageBox.Show("1.4237 AU")

    End Sub

    Private Sub btnSurfaceTempMars_Click(sender As Object, e As EventArgs) Handles btnSurfaceTempMars.Click

        MessageBox.Show("-140 C to 20 C")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub
End Class