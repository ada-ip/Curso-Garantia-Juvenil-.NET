Public Class Racional
    'Se declaran las variables base
    Public numerador As Integer
    Public denominador As Integer

    ' Se define el constructor
    Public Sub New()

    End Sub

    ' Se define el primer método de asignación del racional
    Public Sub Asignar(ByVal x As Integer, y As Integer)
        numerador = x
        denominador = y
    End Sub

    ' Se define el segundo método de asignación del racional
    Public Function Asignar(ByVal x As String, y As String)
        ' Se le asigna al numerador el número introducido por el usuario
        If EsUnNumero(x, numerador) = False Then
            ' Si el dato introducido por el usuario no era un número entero se comunica el error
            Return False
        End If

        ' Se le asigna al denominador el número introducido por el usuario
        If EsUnNumero(y, denominador) = False Then
            ' Si el dato introducido por el usuario no era un número entero se comunica el error
            Return False
        End If

        ' Si los dos datos eran números enteros se comunica que la asignacíón se ha hecho bien
        Return True
    End Function


    ' Función que chequea si una cadena de texto se puede convertir a un número entero y si es así lo convierte y lo guarda en la variable num
    Private Function EsUnNumero(ByRef input As String, ByRef num As Integer)
        If Integer.TryParse(input, num) Then
            Return True
        Else
            Return False
        End If
    End Function


    ' Método que simplifica una fracción 
    Public Sub SimplificarFraccion()

        'Si el numerador/denominador es 0 o 1 no hay nada que simplificar
        If numerador = 0 Or denominador = 0 Or Math.Abs(numerador) = 1 Or Math.Abs(denominador) = 1 Then
            Exit Sub
        End If

        Dim numArray As Integer

        ' Se chequea qué número es más pequeño, si el numerador o el denominador, y se le asigna a la variable numArray
        If numerador <= denominador Then
            numArray = Math.Abs(numerador)
        Else
            numArray = Math.Abs(denominador)
        End If

        ' Se crea un array booleano con el mismo número de elementos que el número más pequeño entre numerador y denominador que indica si
        ' el numerador y denominador de la fracción se pueden dividir por cada número del array y simplificar la fracción
        Dim numeros(numArray - 1) As Boolean

        ' Se inicializa el array con todos los elementos en True excepto el primero porque representa al número 1 y el número 1 no simplifica fracciones
        numeros(0) = False
        For i As Integer = 1 To numeros.GetUpperBound(0)
            numeros(i) = True
        Next

        ' Se simplifica la fracción con el método Simplificar
        Simplificar(numeros)
    End Sub


    Private Sub Simplificar(ByRef numeros() As Boolean)
        ' Se chequean todos los números del array para ver si pueden simplificar la fracción
        For i As Integer = 0 To numeros.GetUpperBound(0)

            ' Si el número todavía no ha sido descartado, se chequea si ambos, numerador y denominador, son divisibles por el número
            If numeros(i) = True Then
                If (numerador Mod (i + 1) = 0) And (denominador Mod (i + 1) = 0) Then

                    ' El numerador y el denominador de la fracción se dividen por el número y se vuelve a llamar al método para ver si se sigue pudiendo dividir por el mismo número
                    numerador /= i + 1
                    denominador /= i + 1
                    Simplificar(numeros)
                Else

                    ' Si el numerador o el denominador no son divisibles por el número, se cambia a False el valor del número en el array y también el de todos sus múltiplos
                    For j As Integer = i To numeros.GetUpperBound(0) Step i + 1
                        If numeros(j) = True Then
                            numeros(j) = False
                        End If
                    Next
                End If
            End If
        Next

        ' Por último, si ambos numerador y denominador tienen signo negativo, se cambian a positivo
        If numerador < 0 And denominador < 0 Then
            numerador = Math.Abs(numerador)
            denominador = Math.Abs(denominador)
        End If
    End Sub
End Class
