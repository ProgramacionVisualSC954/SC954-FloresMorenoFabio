Public Class Form1

    Dim productos As New List(Of String)()
    Dim precios As New List(Of Decimal)()

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
    Dim nombreProd As String = txtNombreProducto.Text.Trim()
    Dim precioProd As Decimal


        If nombreProd = "" Then
        MessageBox.Show("Ingresa el nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        txtNombreProducto.Focus()
        Return
    End If

        If Not Decimal.TryParse(txtPrecioProducto.Text, precioProd) OrElse precioProd <= 0 Then
        MessageBox.Show("Ingresa un precio decimal positivo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        txtPrecioProducto.Clear()
        txtPrecioProducto.Focus()
        Return
    End If


        productos.Add(nombreProd)
    precios.Add(precioProd)

        lstProductos.Items.Add($"{nombreProd}  —  {precioProd:C}")

        Dim subtotal As Decimal = 0
    For Each p As Decimal In precios
        subtotal += p
    Next

        Dim descuento As Decimal = 0
    If productos.Count >= 3 Then
        descuento = subtotal * 0.05D
        subtotal -= descuento
    End If

    Dim iva As Decimal = subtotal * 0.16D
    Dim total As Decimal = subtotal + iva

    lblSubtotal.Text = $"Subtotal: {subtotal:C}"
    lblIva.Text = $"IVA (16%): {iva:C}"
    lblTotal.Text = $"Total: {total:C}"

        txtNombreProducto.Clear()
    txtPrecioProducto.Clear()
    txtNombreProducto.Focus()
End Sub

Private Sub btnGenerarTicket_Click(sender As Object, e As EventArgs) Handles btnGenerarTicket.Click
    If productos.Count = 0 Then
        MessageBox.Show("No hay productos en la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return
    End If


        Dim ticket As String = "========== TICKET DE COMPRA ==========" & Environment.NewLine

    Dim item As Integer = 1
    Dim subtotalBruto As Decimal = 0
    For Each nombre As String In productos
        ticket &= $"{item}. {nombre}  —  {precios(item - 1):C}" & Environment.NewLine
        subtotalBruto += precios(item - 1)
        item += 1
    Next

    ticket &= "--------------------------------------" & Environment.NewLine

        Dim descuento As Decimal = 0
    If productos.Count >= 3 Then
        descuento = subtotalBruto * 0.05D
        ticket &= $"Descuento (5%):  -{descuento:C}" & Environment.NewLine
    End If

    Dim subtotalFinal As Decimal = subtotalBruto - descuento
    Dim iva As Decimal = subtotalFinal * 0.16D
    Dim total As Decimal = subtotalFinal + iva

    ticket &= $"Subtotal:         {subtotalFinal:C}" & Environment.NewLine
    ticket &= $"IVA (16%):        {iva:C}" & Environment.NewLine
    ticket &= $"TOTAL:            {total:C}" & Environment.NewLine
    ticket &= "======================================"

    MessageBox.Show(ticket, "Ticket de compra", MessageBoxButtons.OK, MessageBoxIcon.None)
End Sub
End Class
