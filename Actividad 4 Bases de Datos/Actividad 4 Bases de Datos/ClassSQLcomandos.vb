Imports System.Data.SqlClient

Public Class SQLcomandos
    'Se crean variables para la conexión, el comando, DataAdapter, DataTable y DataReader
    Private conexion As SqlConnection
    Private comando As SqlCommand
    Private adapter As SqlDataAdapter
    Public tabla As New DataTable()
    Private reader As SqlDataReader

    Public Sub New(ByVal basededatos As String)
        conexion = New SqlConnection(basededatos)
    End Sub

    Public Sub Consulta(ByVal peticion1 As String)
        'Se abre la conexión con la base de datos
        conexion.Open()

        'Se realiza la petición especificada en la variable del Sub
        comando = New SqlCommand(peticion1, conexion)

        'Se cargan los datos en la DataTable
        adapter = New SqlDataAdapter(comando)
        tabla.Clear()
        adapter.Fill(tabla)

        'Se cierra la conexión
        conexion.Close()
    End Sub

    Public Sub CargarComboBox(ByRef combobox As ComboBox, ByVal peticion2 As String, ByVal campo As String)
        'Se abre la conexión con la base de datos
        conexion.Open()

        'Se realiza la petición especificada en el Sub
        comando = New SqlCommand(peticion2, conexion)

        'Se ejecuta el DataReader y se cargan los nombres de la tabla del campo elegido en el combobox
        reader = comando.ExecuteReader

        While reader.Read()
            combobox.Items.Add(reader(campo))
        End While

        'Se cierra la conexión
        conexion.Close()
    End Sub

    Public Sub NuevaFila(ByVal peticion3 As String)
        'Se abre la conexion con la base de datos
        conexion.Open()

        'Se realiza la petición de crear una nueva fila en la tabla de la base de datos
        comando = New SqlCommand(peticion3, conexion)

        'Se ejecuta la petición y se guardan los datos en la tabla de la base de datos
        comando.ExecuteNonQuery()
    End Sub
End Class
