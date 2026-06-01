Public Class Form1

    Dim nombres(9) As String
    Dim preciosInv(9) As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombres(0) = "Laptop Dell Inspiron"
        nombres(1) = "Mouse Logitech MX Master"
        nombres(2) = "Teclado Mecánico Redragon"
        nombres(3) = "Monitor Samsung 24"
        nombres(4) = "Auriculares Sony WH-1000XM5"
        nombres(5) = "Webcam Logitech C920"
        nombres(6) = "SSD Kingston 1TB"
        nombres(7) = "Memoria RAM Corsair 16GB"
        nombres(8) = "Tarjeta Gráfica NVIDIA RTX 3060"
        nombres(9) = "Impresora"

        preciosInv(0) = 18500D
        preciosInv(1) = 1850D
        preciosInv(2) = 1200D
        preciosInv(3) = 5400D
        preciosInv(4) = 7200D
        preciosInv(5) = 2100D
        preciosInv(6) = 1650D
        preciosInv(7) = 1400D
        preciosInv(8) = 12000D
        preciosInv(9) = 3800D
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim busqueda As String = txtBusqueda.Text.Trim().ToLower()

        If busqueda = "" Then
            MessageBox.Show("Ingresa el nombre del producto a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBusqueda.Focus()
            Return
        End If

        Dim encontrado As Boolean = False


        For i As Integer = 0 To nombres.Length - 1
            If nombres(i).ToLower() = busqueda Then
                lblResultado.Text = $"✔ Encontrado en posición {i + 1}: {nombres(i)}  —  Precio: {preciosInv(i):C}"
                encontrado = True
                Exit For
            End If
        Next

        If Not encontrado Then
            lblResultado.Text = "✘ Producto no encontrado en el inventario."
        End If
    End Sub
End Class
