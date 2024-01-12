Public Class frmVenus
    Private Sub btnTypeVenus_Click(sender As Object, e As EventArgs) Handles btnTypeVenus.Click

        MessageBox.Show("Terrestrial")

    End Sub

    Private Sub btnAvgSunVenus_Click(sender As Object, e As EventArgs) Handles btnAvgSunVenus.Click

        MessageBox.Show(".7233 AU")

    End Sub

    Private Sub btnSurfaceTempVenus_Click(sender As Object, e As EventArgs) Handles btnSurfaceTempVenus.Click

        MessageBox.Show("472 C")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub
End Class