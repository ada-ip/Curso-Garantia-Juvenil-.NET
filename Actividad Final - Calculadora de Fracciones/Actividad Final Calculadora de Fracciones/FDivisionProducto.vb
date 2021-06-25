Public Class FDivisionProducto
    Private Sub VolverMI_Click(sender As Object, e As EventArgs) Handles VolverMI.Click
        txtNumerador1.Text = ""
        txtDenominador1.Text = ""
        txtNumerador2.Text = ""
        txtDenominador2.Text = ""
        txtNumeradorDiv.Text = ""
        txtDenominadorDiv.Text = ""
        txtNumeradorProd.Text = ""
        txtDenominadorProd.Text = ""

        lblError.Visible = False
        lblError0.Visible = False
        lblError0_2.Visible = False

        Me.Hide()
    End Sub

    Private Sub SalirMI_Click(sender As Object, e As EventArgs) Handles SalirMI.Click
        End
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lblError.Visible = False
        lblError0.Visible = False
        lblError0_2.Visible = False
        txtNumeradorDiv.Text = ""
        txtDenominadorDiv.Text = ""
        txtNumeradorProd.Text = ""
        txtDenominadorProd.Text = ""

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

        ' Se realiza la división y se le asigna a una tercera fracción resultado
        Dim numDivision As Integer = fraccion1.numerador * fraccion2.denominador
        Dim denomDivision As Integer = fraccion1.denominador * fraccion2.numerador
        Dim fraccionDiv As New Racional()
        fraccionDiv.Asignar(numDivision, denomDivision)

        ' Se realiza el producto y se le asigna a una cuarta fracción resultado
        Dim numProducto As Integer = fraccion1.numerador * fraccion2.numerador
        Dim denomProducto As Integer = fraccion1.denominador * fraccion2.denominador
        Dim fraccionProd As New Racional()
        fraccionProd.Asignar(numProducto, denomProducto)

        ' Se simplifican las fracciones resultado
        fraccionDiv.SimplificarFraccion()
        fraccionProd.SimplificarFraccion()

        'Se muestran los resultados
        txtNumeradorDiv.Text = CStr(fraccionDiv.numerador)
        txtDenominadorDiv.Text = CStr(fraccionDiv.denominador)
        txtNumeradorProd.Text = CStr(fraccionProd.numerador)
        txtDenominadorProd.Text = CStr(fraccionProd.denominador)

        If fraccionDiv.denominador = 0 Then
            lblError0_2.Visible = True
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtNumerador1.Text = ""
        txtDenominador1.Text = ""
        txtNumerador2.Text = ""
        txtDenominador2.Text = ""
        txtNumeradorDiv.Text = ""
        txtDenominadorDiv.Text = ""
        txtNumeradorProd.Text = ""
        txtDenominadorProd.Text = ""

        lblError.Visible = False
        lblError0.Visible = False
        lblError0_2.Visible = False
    End Sub
End Class