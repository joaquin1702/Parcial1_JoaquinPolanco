Imports System

Module Module1

    Sub Main()
        Dim menu As String = "MENU"
        Dim formato As String = String.Format(" {0,15}", menu)
        Dim opcion As Integer

        Console.WriteLine(formato)

        Console.WriteLine(" 1. Calcular La Media Artimetica ")
        Console.WriteLine(" 2. Calcular La Moda")
        Console.WriteLine(" 3. Calcular La Mediana")
        Console.WriteLine(" 4. Calcular El Numero Mayor y Numero Menor")
        Console.WriteLine(" Eliga Una De Las Cuatro")

        opcion = Console.ReadLine()
        Select Case opcion

            Case 1
                Dim suma, prom As Double
                Dim datos As Double
                Dim cantidad As Double
                Dim contador As Integer

                Console.WriteLine(" Ingrese el Numero 15 ")
                cantidad = Convert.ToInt32(Console.ReadLine())
                suma = 0
                contador = 0

                While cantidad > contador
                    contador = contador + 1
                    Console.WriteLine("Ingrese los datos")
                    datos = Convert.ToDouble(Console.ReadLine())
                    suma = suma + datos
                End While

                prom = suma / cantidad
                Console.WriteLine("El promedio es: {0} ", prom)

            Case 2
                Dim numeros(0 To 14) As Integer
                Dim auxiliar(0 To 14) As Integer
                Dim posicion As Integer = 0
                Dim numero As Integer = 0
                Dim contador2 As Integer = 0
                Dim mayor As Integer = 0
                Dim posicionmayor As Integer = 0

                For contador = 0 To 14
                    Console.WriteLine("Ingresar Numero Para Calcular la Moda {0} : ", contador + 1)
                    numeros(contador) = Integer.Parse(Console.ReadLine())

                Next
                Console.WriteLine("" & vbLf & "Los Datos Ingresados Son: ")
                For contador = 0 To 14
                    Console.Write(" {0}", numeros(contador))

                Next
                For contador = 0 To 14
                    auxiliar(contador) = 0

                Next
                For contador = 0 To 14
                    numero = numeros(contador)
                    posicion = contador
                    For contador2 = contador To 14
                        If (numeros(contador2) = numero) Then auxiliar(posicion) += 1

                    Next

                Next
                mayor = auxiliar(0)
                posicionmayor = 0
                For contador = 0 To 14
                    If auxiliar(contador) > mayor Then
                        posicionmayor = contador
                        mayor = auxiliar(contador)

                    End If

                Next
                Console.WriteLine("" & vbLf & "La Moda De Los Datos Ingresados Es : {0}", numeros(posicionmayor))
            Case 3


            Case 4


        End Select

        Console.ReadKey()
    End Sub

End Module