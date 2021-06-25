Imports System

Module Program

    'Se declara la clase
    Public Class Racional
        'Se declaran las variables base
        Private numerador As Integer
        Private denominador As Integer

        'Se define el constructor
        Public Sub New()
            numerador = 1
            denominador = 1
        End Sub

        'Se define el método de modificación del racional
        Public Sub Modificacion(ByVal x As Integer, y As Integer)
            numerador = x
            denominador = y
        End Sub

        'Se define el método de mostrar el número en pantalla
        Public Sub MostrarRacional()
            Console.WriteLine("Número racional: {0}/{1}", numerador, denominador)
        End Sub

        'Se define el método para pedir al usuario un numerador y un denominador y guardarlos en las variables de la clase
        Public Sub LeerRacional()
            Dim input As String

            Console.WriteLine("Introduzca el numerador")
            input = Console.ReadLine()
            Dim input1 As Integer
            EsUnNumero(input, input1)

            Console.WriteLine("Introduzca el denominador")
            input = Console.ReadLine()
            Dim input2 As Integer
            EsUnNumero(input, input2)

            Modificacion(input1, input2)
        End Sub

        'Se incluye el chequeo de los números dados por el usuario
        Public Function EsUnNumero(ByRef entradainput As String, ByRef salidainput As Integer)
            Do Until Integer.TryParse(entradainput, salidainput)
                Console.WriteLine("Introduzca un número válido")
                entradainput = Console.ReadLine()
            Loop
            Return salidainput
        End Function
    End Class


    Sub Main()
        'Se crea una instancia de la clase
        Dim numracional As Racional = New Racional()

        'Se le pide el numerador y el denominador al usuario
        numracional.LeerRacional()

        'Se muestra el racional elegido por el usuario
        numracional.MostrarRacional()
    End Sub
End Module
