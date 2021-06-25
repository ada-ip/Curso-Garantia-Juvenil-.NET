Public Class FormRegistroA

    'Se crea una variable para realizar conexiones/peticiones/etc con la base de datos SQL
    Private sqlA As New SQLcomandos("Data Source=PROPIETARIO-PC\SQLEXPRESS; Initial Catalog=Academia; Integrated Security=True")
    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        'Se chequea si el teléfono y el código postal son numeros
        Dim result As Integer
        If Integer.TryParse(TextBoxTelfA.Text, result) = False Or Integer.TryParse(TextBoxPostalA.Text, result) = False Then
            FormError.Show()
            Exit Sub
        End If

        'Se crean variables para recoger los datos introducidos por el usuario
        Dim nombreA As String = TextBoxNombreA.Text
        Dim primerA As String = TextBoxPrimerA.Text
        Dim segundoA As String = TextBoxSegundoA.Text
        Dim asignaturaA As String = TextBoxAsignaturaA.Text
        Dim telfA As Integer = CInt(TextBoxTelfA.Text)
        Dim dirA As String = TextBoxDirA.Text
        Dim ciudadA As String = TextBoxCiudadA.Text
        Dim postalA As Integer = CInt(TextBoxPostalA.Text)

        'Se realiza la consulta para guardar un nuevo registro en la base de datos a través de la variable sql
        sqlA.NuevaFila("INSERT INTO Alumnos(Nombre,[Primer Apellido],[Segundo Apellido],Asignatura,Teléfono,Dirección,Ciudad,[Código Postal]) 
VALUES ('" & nombreA & "','" & primerA & "','" & segundoA & "','" & asignaturaA & "'," & telfA & ",'" & dirA & "','" & ciudadA & "'," & postalA & ")")

        'Se borran todos los campos y se cierra el formulario
        TextBoxNombreA.Text = ""
        TextBoxPrimerA.Text = ""
        TextBoxSegundoA.Text = ""
        TextBoxAsignaturaA.Text = ""
        TextBoxTelfA.Text = ""
        TextBoxDirA.Text = ""
        TextBoxCiudadA.Text = ""
        TextBoxPostalA.Text = ""
        Me.Hide()
    End Sub
End Class