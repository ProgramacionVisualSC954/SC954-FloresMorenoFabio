Imports System.Reflection.Emit

Public Class Form1

    Dim operacion As String = ""
    Dim parentesisAbierto As Boolean = False

    Private Sub AgregarTexto(valor As String)

        operacion &= valor
        Digitalizar.Text = operacion

        Actualizar()

    End Sub

    Private Sub Actualizar()

        Try

            Dim dt As New DataTable()
            Dim resultado = dt.Compute(operacion, Nothing)

            If resultado.ToString.Contains("+") Or
                 resultado.ToString.Contains("-") Or
                 resultado.ToString.Contains("*") Or
                 resultado.ToString.Contains("/") Then

                'operacion = resultado.ToString()
                'Label3.Text = operacion
                mostrar.Text = resultado.ToString()

            End If

        Catch ex As Exception

            mostrar.Text = ""

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

    'borrar toda la operacion y el resultado

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        operacion = ""
        Digitalizar.Text = ""
        mostrar.Text = "0"
        parentesisAbierto = False

    End Sub

    'borrar un digito

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        If operacion.Length > 0 Then

            operacion = operacion.Substring(0, operacion.Length - 1)

            Digitalizar.Text = operacion

            If operacion = "" Then
                mostrar.Text = "0"
            Else
                Actualizar()
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


    ' Agregar parentesis o cerrar el parentesis
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        If parentesisAbierto = False Then

            AgregarTexto("(")
            parentesisAbierto = True

        Else

            AgregarTexto(")")
            parentesisAbierto = False

        End If

    End Sub

    ' Obtener el resultado de la operacion

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        Try

            Dim dt As New DataTable()
            Dim resultado = dt.Compute(operacion, Nothing)

            mostrar.Text = resultado.ToString()


        Catch ex As Exception

            mostrar.Text = "Error"

        End Try



    End Sub


End Class
