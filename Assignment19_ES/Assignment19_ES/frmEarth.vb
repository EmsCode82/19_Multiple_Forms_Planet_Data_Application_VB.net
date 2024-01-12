Public Class frmEarth
    Private Sub btnTypeEarth_Click(sender As Object, e As EventArgs) Handles btnTypeEarth.Click

        MessageBox.Show("Terrestrial")

    End Sub

    Private Sub btnAvgSunEarth_Click(sender As Object, e As EventArgs) Handles btnAvgSunEarth.Click

        MessageBox.Show("1 AU")

    End Sub

    Private Sub btnSurfaceTempEarth_Click(sender As Object, e As EventArgs) Handles btnSurfaceTempEarth.Click

        MessageBox.Show("-50 C to 50 C")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub
End Class