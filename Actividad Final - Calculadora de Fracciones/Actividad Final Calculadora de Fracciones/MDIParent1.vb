Imports System.Windows.Forms

Public Class MDIParent1
    Private Sub SumaDiferenciaMI_Click(sender As Object, e As EventArgs) Handles SumaDiferenciaMI.Click
        FSumaDiferencia.MdiParent = Me
        FSumaDiferencia.Show()
        FDivisionProducto.Hide()
        FArrayFracciones.Hide()
    End Sub

    Private Sub DivisionProductoMI_Click(sender As Object, e As EventArgs) Handles DivisionProductoMI.Click
        FDivisionProducto.MdiParent = Me
        FDivisionProducto.Show()
        FSumaDiferencia.Hide()
        FArrayFracciones.Hide()
    End Sub

    Private Sub ArrayFraccionesMI_Click(sender As Object, e As EventArgs) Handles ArrayFraccionesMI.Click
        FArrayFracciones.MdiParent = Me
        FArrayFracciones.Show()
        FSumaDiferencia.Hide()
        FDivisionProducto.Hide()
    End Sub

    Private Sub SalirMI_Click(sender As Object, e As EventArgs) Handles SalirMI.Click
        End
    End Sub


End Class
