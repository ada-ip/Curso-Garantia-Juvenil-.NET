Public Class FArrayFracciones
    Private Sub VolverMI_Click(sender As Object, e As EventArgs) Handles VolverMI.Click
        Borrar()
        txtNumFracciones.Text = ""

        Me.Hide()
    End Sub

    Private Sub SalirMI_Click(sender As Object, e As EventArgs) Handles SalirMI.Click
        End
    End Sub


    ' Lista que recogerá todos los textbox y labels que se vayan creando para poderlos borrar luego
    Private MyControls As New List(Of Control)


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Borrar()

        ' Se chequea si el input del usuario es un número y si es un número se inicializa la variable numFracciones con ese número
        Dim numFracciones As Integer
        If Integer.TryParse(txtNumFracciones.Text, numFracciones) = False Then
            ' Si el dato no era un número se comunica el error
            lblErrorNum.Visible = True
        Else
            'Si el dato era un número se chequea que sea mayor de 0
            If numFracciones < 1 Then
                lblErrorNum.Visible = True
                Exit Sub
            End If

            ' Se crea un array de Racional con el mismo número de elementos que ha aportado el usuario
            Dim fraccion(numFracciones - 1) As Racional

            ' Se recorre todo el array Racional y se inicializa cada fracción
            For i As Integer = 0 To fraccion.GetUpperBound(0)

                ' Se le pide al usuario un numerador
                Dim iNumerador As String = InputBox("Introduce el numerador de la " + CStr(i + 1) + "º fracción: ", "Conjunto de Fracciones", " ")

                ' Si el usuario le ha dado a cancelar, se para la rutina
                If String.IsNullOrEmpty(iNumerador) Then
                    txtNumFracciones.Text = ""
                    Exit Sub
                End If

                ' Si el usuario no ha escrito nada, se le comunica su error
                If iNumerador = " " Then
                    lblErrorDatos.Visible = True
                    Exit Sub
                End If

                ' Se le pide al usuario un denominador
                Dim iDenominador As String = InputBox("Introduce el denominador de la " + CStr(i + 1) + "º fracción: ", "Conjunto de Fracciones", " ")

                ' Si el usuario le ha dado a cancelar, se para la rutina
                If String.IsNullOrEmpty(iNumerador) Then
                    txtNumFracciones.Text = ""
                    Exit Sub
                End If

                ' Si el usuario no ha escrito nada, se le comunica su error
                If iNumerador = " " Then
                    lblErrorDatos.Visible = True
                    Exit Sub
                End If

                ' Se inicializa ya la fracción con su numerador y su denominador
                fraccion(i) = New Racional()
                If fraccion(i).Asignar(iNumerador, iDenominador) Then
                    ' Si el denominador es 0 se comunica que no se puede dividir por 0
                    If fraccion(i).denominador = 0 Then
                        lblError0.Visible = True
                        Exit Sub
                    End If
                Else
                    ' Si el usuario no ha introducido un número entero se le comunica su error
                    lblErrorDatos.Visible = True
                    Exit Sub
                End If
            Next

            'Se crean todos los textbox necesarios y se rellenan con las fracciones del array
            CrearTextBoxs(fraccion)
        End If
    End Sub


    Private Sub CrearTextBoxs(ByVal datos() As Racional)
        lblFracciones.Visible = True

        ' x e y serán el punto(x, y) donde se colocará el numerador de la fracción. El denominador se colocará en x, z
        Dim x As Integer = 150
        Dim y As Integer = 200
        Dim z As Integer = 245

        ' Contador para saber cuándo hacer un salto de línea
        Dim counter As Integer = 1

        ' Se recorre todo el array de fracciones y se muestran en pantalla el numerador y denominador de cada fracción
        For i As Integer = 0 To datos.GetUpperBound(0)
            ' Label que indica el número de fracción
            Dim lblNumero As New Label()
            lblNumero.Name = "lblContador" & CStr(i + 1)
            lblNumero.Text = CStr(i + 1) & ": "
            lblNumero.Font = New Font(FontFamily.GenericSansSerif, 9.75)
            ' Se coloca con respecto al textbox del numerador
            lblNumero.Location = New Point(x - 35, y + 25)
            lblNumero.AutoSize = True
            Me.Controls.Add(lblNumero)
            ' Se añade a la lista de controles creada
            MyControls.Add(lblNumero)

            ' Textbox del numerador
            Dim txtNumerador As New TextBox()
            txtNumerador.Name = "txtNumerador" & CStr(i + 1)
            txtNumerador.TextAlign = HorizontalAlignment.Center
            txtNumerador.Location = New Point(x, y)
            txtNumerador.Text = CStr(datos(i).numerador)
            Me.Controls.Add(txtNumerador)
            ' Se añade a la lista de controles creada
            MyControls.Add(txtNumerador)

            ' Label que divide el numerador y el denominador
            Dim lblDivision As New Label()
            lblDivision.Name = "lblDivision" & CStr(i + 1)
            ' Se coloca con respecto al textbox del numerador
            lblDivision.Location = New Point(x - 12, y + 25)
            lblDivision.Text = "                                        "
            lblDivision.Font = New Font(FontFamily.GenericSansSerif, 9.75, FontStyle.Strikeout)
            lblDivision.AutoSize = True
            Me.Controls.Add(lblDivision)
            ' Se añade a la lista de controles creada
            MyControls.Add(lblDivision)

            ' Textbox del denominador
            Dim txtDenominador As New TextBox()
            txtDenominador.Name = "txtDenominador" & CStr(i + 1)
            txtDenominador.TextAlign = HorizontalAlignment.Center
            txtDenominador.Location = New Point(x, z)
            txtDenominador.Text = CStr(datos(i).denominador)
            Me.Controls.Add(txtDenominador)
            'Se añade a la lista de controles creada
            MyControls.Add(txtDenominador)

            ' Se suma a x 200 para que la próxima fracción esté 200px a la derecha
            x += 200

            ' Si todavía no se han mostrado 4 fracciones, se suma 1 al contador
            If counter < 4 Then
                counter += 1
            Else
                ' Si se han mostrado 4 fracciones se realiza un salto de línea
                counter = 1
                x = 150
                y += 120
                z += 120
            End If
        Next
    End Sub


    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Borrar()
        txtNumFracciones.Text = ""
    End Sub


    Private Sub Borrar()
        ' Se esconden las labels de error y de fracciones
        lblErrorNum.Visible = False
        lblErrorDatos.Visible = False
        lblError0.Visible = False
        lblFracciones.Visible = False

        ' Se borran los textbox y las labels creadas al mostrar las fracciones introducidas por el usuario
        If MyControls.Count > 0 Then
            For Each c As Control In MyControls
                Me.Controls.Remove(c)
                c.Dispose()
            Next
        End If
    End Sub
End Class