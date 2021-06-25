Public Class FormDocentes

    'Se crea una variable para realizar conexiones/peticiones/etc con la base de datos SQL
    Private sqlD As New SQLcomandos("Data Source=PROPIETARIO-PC\SQLEXPRESS; Initial Catalog=Academia; Integrated Security=True")
    Private Sub FormDocentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se piden todos los datos de la tabla de Docentes a través de la variable sql
        sqlD.Consulta("SELECT * FROM Docentes")

        'Se cargan los datos de la tabla en el DataGridView
        DataGridViewD.DataSource = sqlD.tabla

        'Se carga el ComboBox con los campos de las columnas de la tabla
        sqlD.CargarComboBox(ComboBoxD, "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='Docentes'", "COLUMN_NAME")
    End Sub

    Private Sub ButtonBuscarD_Click(sender As Object, e As EventArgs) Handles ButtonBuscarD.Click
        'Se realiza la búsqueda a través de la variable sql
        sqlD.Consulta("SELECT * FROM Docentes WHERE [" & ComboBoxD.Text & "] LIKE '%" & TextBoxD.Text & "%'")

        'Se cargan los datos de la tabla filtrada en el DataGridView
        DataGridViewD.DataSource = sqlD.tabla
    End Sub

    Private Sub AñadirRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirRegistroToolStripMenuItem.Click
        FormRegistroD.Show()
    End Sub

    Private Sub ActualizarTablaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarTablaToolStripMenuItem.Click
        'Se piden todos los datos de la tabla de Docentes a través de la variable sql
        sqlD.Consulta("SELECT * FROM Docentes")

        'Se cargan los datos de la tabla en el DataGridView
        DataGridViewD.DataSource = sqlD.tabla
    End Sub
End Class