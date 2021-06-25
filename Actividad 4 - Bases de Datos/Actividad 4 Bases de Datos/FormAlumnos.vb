Public Class FormAlumnos

    'Se crea una variable para realizar conexiones/peticiones/etc con la base de datos SQL
    Private sqlA As New SQLcomandos("Data Source=PROPIETARIO-PC\SQLEXPRESS; Initial Catalog=Academia; Integrated Security=True")

    Private Sub FormAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se piden todos los datos de la tabla de Alumnos a través de la variable sql
        sqlA.Consulta("SELECT * FROM Alumnos")

        'Se cargan los datos de la tabla en el DataGridView
        DataGridViewA.DataSource = sqlA.tabla

        'Se carga el ComboBox con los campos de las columnas de la tabla
        sqlA.CargarComboBox(ComboBoxA, "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='Alumnos'", "COLUMN_NAME")
    End Sub

    Private Sub ButtonBuscarA_Click(sender As Object, e As EventArgs) Handles ButtonBuscarA.Click
        'Se realiza la búsqueda a través de la variable sql
        sqlA.Consulta("SELECT * FROM Alumnos WHERE [" & ComboBoxA.Text & "] LIKE '%" & TextBoxA.Text & "%'")

        'Se cargan los datos de la tabla filtrada en el DataGridView
        DataGridViewA.DataSource = sqlA.tabla
    End Sub

    Private Sub AñadirRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirRegistroToolStripMenuItem.Click
        FormRegistroA.Show()
    End Sub

    Private Sub ActualizarTablaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarTablaToolStripMenuItem.Click
        'Se piden todos los datos de la tabla de Alumnos a través de la variable sql
        sqlA.Consulta("SELECT * FROM Alumnos")

        'Se cargan los datos de la tabla en el DataGridView
        DataGridViewA.DataSource = sqlA.tabla
    End Sub
End Class
