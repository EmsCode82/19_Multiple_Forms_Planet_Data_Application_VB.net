Public Class frmMercury
    Private Sub btnTypeMercury_Click(sender As Object, e As EventArgs) Handles btnTypeMercury.Click

        MessageBox.Show("Terrestrial")

    End Sub

    Private Sub btnAvgSunMercury_Click(sender As Object, e As EventArgs) Handles btnAvgSunMercury.Click

        MessageBox.Show(".387 AU")

    End Sub

    Private Sub btnSurfaceTempMercury_Click(sender As Object, e As EventArgs) Handles btnSurfaceTempMercury.Click

        MessageBox.Show("-173 C to 430 C")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub
End Class