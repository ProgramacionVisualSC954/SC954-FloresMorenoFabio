<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGenerarTicket = New Button()
        Label1 = New Label()
        txtPrecioProducto = New TextBox()
        lblSubtotal = New Label()
        lblIva = New Label()
        txtNombreProducto = New TextBox()
        btnAgregar = New Button()
        lblTotal = New Label()
        lstProductos = New CheckedListBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btnGenerarTicket
        ' 
        btnGenerarTicket.Location = New Point(224, 324)
        btnGenerarTicket.Name = "btnGenerarTicket"
        btnGenerarTicket.Size = New Size(94, 29)
        btnGenerarTicket.TabIndex = 0
        btnGenerarTicket.Text = "ticket"
        btnGenerarTicket.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(370, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 1
        ' 
        ' txtPrecioProducto
        ' 
        txtPrecioProducto.Location = New Point(88, 207)
        txtPrecioProducto.Name = "txtPrecioProducto"
        txtPrecioProducto.Size = New Size(125, 27)
        txtPrecioProducto.TabIndex = 2
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(448, 242)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(53, 20)
        lblSubtotal.TabIndex = 4
        lblSubtotal.Text = "Label3"
        ' 
        ' lblIva
        ' 
        lblIva.AutoSize = True
        lblIva.Location = New Point(448, 282)
        lblIva.Name = "lblIva"
        lblIva.Size = New Size(53, 20)
        lblIva.TabIndex = 5
        lblIva.Text = "Label4"
        ' 
        ' txtNombreProducto
        ' 
        txtNombreProducto.Location = New Point(88, 139)
        txtNombreProducto.Name = "txtNombreProducto"
        txtNombreProducto.Size = New Size(208, 27)
        txtNombreProducto.TabIndex = 6
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(88, 324)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(94, 29)
        btnAgregar.TabIndex = 8
        btnAgregar.Text = "agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(448, 318)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(53, 20)
        lblTotal.TabIndex = 9
        lblTotal.Text = "Label2"
        ' 
        ' lstProductos
        ' 
        lstProductos.FormattingEnabled = True
        lstProductos.Location = New Point(448, 120)
        lstProductos.Name = "lstProductos"
        lstProductos.Size = New Size(225, 114)
        lstProductos.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label2.Location = New Point(90, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 32)
        Label2.TabIndex = 11
        Label2.Text = "Producto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label3.Location = New Point(85, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 32)
        Label3.TabIndex = 12
        Label3.Text = "Precio"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label4.Location = New Point(448, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(225, 32)
        Label4.TabIndex = 13
        Label4.Text = "Lista de Productos"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(706, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lstProductos)
        Controls.Add(lblTotal)
        Controls.Add(btnAgregar)
        Controls.Add(txtNombreProducto)
        Controls.Add(lblIva)
        Controls.Add(lblSubtotal)
        Controls.Add(txtPrecioProducto)
        Controls.Add(Label1)
        Controls.Add(btnGenerarTicket)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGenerarTicket As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lstProductos As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
