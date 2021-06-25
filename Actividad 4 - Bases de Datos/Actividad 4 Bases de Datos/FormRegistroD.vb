Public Class FormRegistroD

    'Se crea una variable para realizar conexiones/peticiones/etc con la base de datos SQL
    Private sqlD As New SQLcomandos("Data Source=PROPIETARIO-PC\SQLEXPRESS; Initial Catalog=Academia; Integrated Security=True")

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        'Se chequea si el teléfono y el código postal son numeros
        Dim result As Integer
        If Integer.TryParse(TextBoxTelfD.Text, result) = False Or Integer.TryParse(TextBoxPostalD.Text, result) = False Then
            FormError.Show()
            Exit Sub
        End If

        'Se crean variables para recoger los datos introducidos por el usuario
        Dim nombreD As String = TextBoxNombreD.Text
        Dim primerD As String = TextBoxPrimerD.Text
        Dim segundoD As String = TextBoxSegundoD.Text
        Dim asignaturaD As String = TextBoxAsignaturaD.Text
        Dim telfD As Integer = CInt(TextBoxTelfD.Text)
        Dim dirD As String = TextBoxDirD.Text
        Dim ciudadD As String = TextBoxCiudadD.Text
        Dim postalD As Integer = CInt(TextBoxPostalD.Text)

        'Se realiza la consulta para guardar un nuevo registro en la base de datos a través de la variable sql
        sqlD.NuevaFila("INSERT INTO Docentes(Nombre,[Primer Apellido],[Segundo Apellido],Asignatura,Teléfono,Dirección,Ciudad,[Código Postal]) 
VALUES ('" & nombreD & "','" & primerD & "','" & segundoD & "','" & asignaturaD & "'," & telfD & ",'" & dirD & "','" & ciudadD & "'," & postalD & ")")

        'Se borran todos los campos y se cierra el formulario
        TextBoxNombreD.Text = ""
        TextBoxPrimerD.Text = ""
        TextBoxSegundoD.Text = ""
        TextBoxAsignaturaD.Text = ""
        TextBoxTelfD.Text = ""
        TextBoxDirD.Text = ""
        TextBoxCiudadD.Text = ""
        TextBoxPostalD.Text = ""
        Me.Hide()
    End Sub
End Class