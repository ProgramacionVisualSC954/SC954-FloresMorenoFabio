Imports System.Reflection.Emit

Option Strict On

Public Class Form1

   
    Dim operacion As String = ""
    Dim parentesisAbierto As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar.Text = "0"
        Digitalizar.Text = ""
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            CalcularResultado()
        End If
    End Sub


    Private Function ParentesisBalanceados(expresion As String) As Boolean
        Dim abiertos As Integer = 0
        Dim cerrados As Integer = 0
        For Each c As Char In expresion
            If c = "("c Then abiertos += 1
            If c = ")"c Then cerrados += 1
        Next
        Return abiertos = cerrados
    End Function

    Private Sub MostrarError(mensaje As String)
        mostrar.Text = mensaje
    End Sub


  
    Private Sub AgregarTexto(valor As String)
        operacion &= valor
        Digitalizar.Text = operacion
        ActualizarVistaPrevia()
    End Sub

    Private Sub ActualizarVistaPrevia()
        If operacion = "" Then
            mostrar.Text = "0"
            Return
        End If

        Try
            If Not ParentesisBalanceados(operacion) Then Return

            Dim dt As New DataTable()
            Dim resultado As Object = dt.Compute(operacion, Nothing)

            Dim valorDecimal As Decimal
            If Decimal.TryParse(resultado.ToString(),
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture,
                                valorDecimal) Then
                mostrar.Text = FormatearResultado(valorDecimal)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function FormatearResultado(valor As Decimal) As String
        If valor = Math.Floor(valor) Then
            Return valor.ToString("N0")
        Else
            Return valor.ToString("N2")
        End If
    End Function

    Private Sub CalcularResultado()

      
        If operacion.Trim() = "" Then
            MostrarError("El campo no puede estar vacío")
            Digitalizar.Focus()
            Return
        End If

      
        If Not ParentesisBalanceados(operacion) Then
            MostrarError("La expresión contiene paréntesis no balanceados")
            Return
        End If

        
        If ContieneDivisionEntreCero(operacion) Then
            MostrarError("No se puede dividir entre cero")
            Return
        End If

       
        Try
            Dim dt As New DataTable()
            Dim resultadoObj As Object = dt.Compute(operacion, Nothing)

            Dim valorDecimal As Decimal
            If Decimal.TryParse(resultadoObj.ToString(),
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture,
                                valorDecimal) Then

                ' ── 5. Overflow de Decimal ──────────────────────────
                ' (Decimal.TryParse falla si el valor excede el rango)
                mostrar.Text = FormatearResultado(valorDecimal)

            Else
                ' Resultado no parseable como Decimal (ej. NaN de raíz negativa)
                MostrarError("El resultado está fuera del rango permitido")
            End If

        Catch ex As OverflowException
            MostrarError("El resultado está fuera del rango permitido")

        Catch ex As Exception
            MostrarError("El valor ingresado no es un número válido")
        End Try
    End Sub

  
    Private Function ContieneDivisionEntreCero(expresion As String) As Boolean
        
        Dim exp As String = expresion.Replace(" ", "")

        Dim i As Integer = 0
        While i < exp.Length - 1
            If exp(i) = "/"c Then
                
                Dim j As Integer = i + 1
               
                If j < exp.Length AndAlso exp(j) = "-"c Then j += 1
                Dim numStr As String = ""
                While j < exp.Length AndAlso (Char.IsDigit(exp(j)) OrElse exp(j) = "."c)
                    numStr &= exp(j)
                    j += 1
                End While
                Dim num As Decimal
                If numStr <> "" AndAlso
                   Decimal.TryParse(numStr,
                                    System.Globalization.NumberStyles.Any,
                                    System.Globalization.CultureInfo.InvariantCulture,
                                    num) Then
                    If num = 0D Then Return True
                End If
            End If
            i += 1
        End While
        Return False
    End Function


    Private Sub CalcularRaiz()
    
        If operacion.Trim() = "" Then
            MostrarError("El campo no puede estar vacío")
            Digitalizar.Focus()
            Return
        End If

        Dim valorDecimal As Decimal
        If Not Decimal.TryParse(operacion,
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture,
                                valorDecimal) Then
            MostrarError("El valor ingresado no es un número válido")
            Return
        End If

        If valorDecimal < 0D Then
            MostrarError("La raíz cuadrada de un número negativo no es real")
            Return
        End If

        Try
            Dim raizDouble As Double = Math.Sqrt(CDbl(valorDecimal))

            If Double.IsNaN(raizDouble) Then
                MostrarError("La raíz cuadrada de un número negativo no es real")
                Return
            End If

            Dim raizDecimal As Decimal = CDec(raizDouble)
            mostrar.Text = FormatearResultado(raizDecimal)

            operacion = raizDecimal.ToString(System.Globalization.CultureInfo.InvariantCulture)
            Digitalizar.Text = operacion

        Catch ex As OverflowException
            MostrarError("El resultado está fuera del rango permitido")
        Catch ex As Exception
            MostrarError("Error al calcular la raíz cuadrada")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarTexto("1")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AgregarTexto("2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AgregarTexto("3")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AgregarTexto("4")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AgregarTexto("5")
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AgregarTexto("6")
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AgregarTexto("7")
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AgregarTexto("8")
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AgregarTexto("9")
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AgregarTexto("0")
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        operacion = ""
        Digitalizar.Text = ""
        mostrar.Text = "0"
        parentesisAbierto = False
        Digitalizar.Focus()  
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If operacion.Length > 0 Then
        
            Dim ultimo As Char = operacion(operacion.Length - 1)
            operacion = operacion.Substring(0, operacion.Length - 1)
            Digitalizar.Text = operacion

            parentesisAbierto = (operacion.Replace(" ", "").
                                     Split("("c).Length - 1) >
                                (operacion.Replace(" ", "").
                                     Split(")"c).Length - 1)

            If operacion = "" Then
                mostrar.Text = "0"
            Else
                ActualizarVistaPrevia()
            End If
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AgregarTexto("+")
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AgregarTexto("-")
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        AgregarTexto("*")
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        AgregarTexto("/")
    End Sub
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        AgregarTexto("x3")
        calcularCubo()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Not parentesisAbierto Then
            AgregarTexto("(")
            parentesisAbierto = True
        Else
            AgregarTexto(")")
            parentesisAbierto = False
        End If
    End Sub

 
    Private Sub CalcularCubo()
 
        If operacion.Trim() = "" Then
            MostrarError("El campo no puede estar vacío")
            Digitalizar.Focus()
            Return
        End If
 
    
        Dim valorDecimal As Decimal
        If Not Decimal.TryParse(operacion,
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture,
                                valorDecimal) Then
            MostrarError("El valor ingresado no es un número válido")
            Return
        End If
 
        Try
            Dim cubo As Decimal = valorDecimal * valorDecimal * valorDecimal
            mostrar.Text = FormatearResultado(cubo)
 
        
            operacion = cubo.ToString(System.Globalization.CultureInfo.InvariantCulture)
            Digitalizar.Text = operacion
 
        Catch ex As OverflowException
            MostrarError("El resultado está fuera del rango permitido")
        Catch ex As Exception
            MostrarError("Error al calcular el cubo")
        End Try
    End Sub
 

    Private Sub ButtonCubo_Click(sender As Object, e As EventArgs) Handles ButtonCubo.Click
        CalcularCubo()
    End Sub


    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        CalcularResultado()
    End Sub


    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        agregarTexto("√")
        CalcularRaiz()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        AgregarTexto(".")
    End Sub

    Private Sub txtExpresion_TextChanged(sender As Object, e As EventArgs) Handles Digitalizar.TextChanged
        operacion = Digitalizar.Text
        
        Dim abier As Integer = operacion.Split("("c).Length - 1
        Dim cerr As Integer = operacion.Split(")"c).Length - 1
        parentesisAbierto = (abier > cerr)
        ActualizarVistaPrevia()
    End Sub




    Private Sub txtExpresion_KeyDown(sender As Object, e As KeyEventArgs) Handles Digitalizar.KeyDown
        If e.KeyCode = Keys.Enter Then
            CalcularResultado()
            e.SuppressKeyPress = True
        End If
    End Sub

End Class