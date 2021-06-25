Public Class FSumaDiferencia
    Private Sub VolverMI_Click(sender As Object, e As EventArgs) Handles VolverMI.Click
        ' Al darle a volver se limpian todos los campos y se cierra el formulario
        txtNumerador1.Text = ""
        txtDenominador1.Text = ""
        txtNumerador2.Text = ""
        txtDenominador2.Text = ""
        txtNumeradorSuma.Text = ""
        txtDenominadorSuma.Text = ""
        txtNumeradorResta.Text = ""
        txtDenominadorResta.Text = ""

        lblError.Visible = False
        lblError0.Visible = False

        Me.Hide()
    End Sub

    Private Sub SalirMI_Click(sender As Object, e As EventArgs) Handles SalirMI.Click
        End
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lblError0.Visible = False
        lblError.Visible = False
        txtNumeradorSuma.Text = ""
        txtDenominadorSuma.Text = ""
        txtNumeradorResta.Text = ""
        txtDenominadorResta.Text = ""

        ' Se crea la primera fracción como un objeto de la clase racional
        Dim fraccion1 As New Racional()

        ' Se le asignan al numerador y denominador de fraccion1 los datos aportados por el usuario 
        If fraccion1.Asignar(txtNumerador1.Text, txtDenominador1.Text) Then
            ' Si el denominador es 0 se comunica que no se puede dividir por 0
            If fraccion1.denominador = 0 Then
                lblError0.Visible = True
                Exit Sub
            End If
        Else
            ' Si los datos no eran números enteros se comunica el error
            lblError.Visible = True
            Exit Sub
        End If

        ' Se crea la segunda fracción como un objeto de la clase racional
        Dim fraccion2 As New Racional()

        ' Se le asignan al numerador y denominador de fraccion2 los datos aportados por el usuario 
        If fraccion2.Asignar(txtNumerador2.Text, txtDenominador2.Text) Then
            ' Si el denominador es 0 se comunica que no se puede dividir por 0
            If fraccion2.denominador = 0 Then
                lblError0.Visible = True
                Exit Sub
            End If
        Else
            ' Si los datos no eran números enteros se comunica el error
            lblError.Visible = True
            Exit Sub
        End If

        ' Se realiza la suma y se le asigna a una tercera fracción resultado
        Dim numSuma As Integer = (fraccion1.numerador * fraccion2.denominador) + (fraccion2.numerador * fraccion1.denominador)
        Dim denomSuma As Integer = fraccion1.denominador * fraccion2.denominador
        Dim fraccionSuma As New Racional()
        fraccionSuma.Asignar(numSuma, denomSuma)

        ' Se realiza la resta y se le asigna a una cuarta fracción resultado
        Dim numResta As Integer = (fraccion1.numerador * fraccion2.denominador) - (fraccion2.numerador * fraccion1.denominador)
        Dim denomResta As Integer = fraccion1.denominador * fraccion2.denominador
        Dim fraccionResta As New Racional()
        fraccionResta.Asignar(numResta, denomResta)

        ' Se simplifican las fracciones
        fraccionSuma.SimplificarFraccion()
        fraccionResta.SimplificarFraccion()

        'Se muestran los resultados
        txtNumeradorSuma.Text = CStr(fraccionSuma.numerador)
        txtDenominadorSuma.Text = CStr(fraccionSuma.denominador)
        txtNumeradorResta.Text = CStr(fraccionResta.numerador)
        txtDenominadorResta.Text = CStr(fraccionResta.denominador)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtNumerador1.Text = ""
        txtDenominador1.Text = ""
        txtNumerador2.Text = ""
        txtDenominador2.Text = ""
        txtNumeradorSuma.Text = ""
        txtDenominadorSuma.Text = ""
        txtNumeradorResta.Text = ""
        txtDenominadorResta.Text = ""

        lblError.Visible = False
        lblError0.Visible = False
    End Sub
End Class