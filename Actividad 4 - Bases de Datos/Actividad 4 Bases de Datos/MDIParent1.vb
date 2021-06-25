Imports System.Windows.Forms

Public Class MDIParent1
    Private Sub AlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosToolStripMenuItem.Click
        FormAlumnos.MdiParent = Me
        FormAlumnos.Show()
        FormDocentes.Hide()
    End Sub

    Private Sub DocentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocentesToolStripMenuItem.Click
        FormDocentes.MdiParent = Me
        FormDocentes.Show()
        FormAlumnos.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class
