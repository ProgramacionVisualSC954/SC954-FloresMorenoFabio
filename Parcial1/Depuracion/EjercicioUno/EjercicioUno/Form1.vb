Public Class Form1

    Private Sub btnClasificar_Click(sender As Object, e As EventArgs) Handles btnClasificar.Click
        Dim precio As Decimal
        Dim nombre As String = txtNombre.Text.Trim()

        If nombre = "" Then
            MessageBox.Show("Ingresa el nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return
        End If

        If Not Decimal.TryParse(txtPrecio.Text, precio) OrElse precio <= 0 Then
            MessageBox.Show("Ingresa un precio decimal positivo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrecio.Clear()
            txtPrecio.Focus()
            Return
        End If

        Dim categoria As String
        If precio < 500 Then
            categoria = "Económico"
        ElseIf precio <= 2000 Then
            categoria = "Estándar"
        Else
            categoria = "Premium"
        End If

        Dim iva As Decimal = precio * 0.16D
        Dim precioFinal As Decimal = precio + iva

        lblCategoria.Text = $"Categoría: {categoria}"
        lblIva.Text = $"IVA (16%): {iva:C}"
        lblPrecioFinal.Text = $"Precio final: {precioFinal:C}"
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Clear()
        txtPrecio.Clear()
        lblCategoria.Text = "Categoría:"
        lblIva.Text = "IVA:"
        lblPrecioFinal.Text = "Precio final:"
        txtNombre.Focus()
    End Sub
End Class
