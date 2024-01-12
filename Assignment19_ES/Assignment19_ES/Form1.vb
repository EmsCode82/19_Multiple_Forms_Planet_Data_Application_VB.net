Public Class frmMain
    Private Sub btnMercury_Click(sender As Object, e As EventArgs) Handles btnMercury.Click
        Dim frmMercury As New frmMercury

        frmMercury.ShowDialog()

        MessageBox.Show("Pick Another Planet")

    End Sub

    Private Sub btnVenus_Click(sender As Object, e As EventArgs) Handles btnVenus.Click
        Dim frmVenus As New frmVenus

        frmVenus.ShowDialog()

        MessageBox.Show("Pick Another Planet")

    End Sub

    Private Sub btnEarth_Click(sender As Object, e As EventArgs) Handles btnEarth.Click
        Dim frmEarth As New frmEarth

        frmEarth.ShowDialog()

        MessageBox.Show("Pick Another Planet")

    End Sub

    Private Sub btnMars_Click(sender As Object, e As EventArgs) Handles btnMars.Click
        Dim frmMars As New frmMars

        frmMars.ShowDialog()

        MessageBox.Show("Pick Another Planet")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub
End Class
