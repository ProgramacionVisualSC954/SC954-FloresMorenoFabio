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
        btnClasificar = New Button()
        txtNombre = New TextBox()
        txtPrecio = New TextBox()
        btnLimpiar = New Button()
        lblCategoria = New Label()
        lblIva = New Label()
        lblPrecioFinal = New Label()
        SuspendLayout()
        ' 
        ' btnClasificar
        ' 
        btnClasificar.Location = New Point(65, 319)
        btnClasificar.Name = "btnClasificar"
        btnClasificar.Size = New Size(94, 29)
        btnClasificar.TabIndex = 0
        btnClasificar.Text = "clasificar"
        btnClasificar.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(46, 68)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(221, 27)
        txtNombre.TabIndex = 1
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(46, 124)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(125, 27)
        txtPrecio.TabIndex = 2
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(191, 319)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(94, 29)
        btnLimpiar.TabIndex = 3
        btnLimpiar.Text = "limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Location = New Point(173, 180)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New Size(53, 20)
        lblCategoria.TabIndex = 4
        lblCategoria.Text = "Label1"
        ' 
        ' lblIva
        ' 
        lblIva.AutoSize = True
        lblIva.Location = New Point(173, 213)
        lblIva.Name = "lblIva"
        lblIva.Size = New Size(53, 20)
        lblIva.TabIndex = 5
        lblIva.Text = "Label2"
        ' 
        ' lblPrecioFinal
        ' 
        lblPrecioFinal.AutoSize = True
        lblPrecioFinal.Location = New Point(173, 250)
        lblPrecioFinal.Name = "lblPrecioFinal"
        lblPrecioFinal.Size = New Size(53, 20)
        lblPrecioFinal.TabIndex = 6
        lblPrecioFinal.Text = "Label3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(344, 450)
        Controls.Add(lblPrecioFinal)
        Controls.Add(lblIva)
        Controls.Add(lblCategoria)
        Controls.Add(btnLimpiar)
        Controls.Add(txtPrecio)
        Controls.Add(txtNombre)
        Controls.Add(btnClasificar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClasificar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblPrecioFinal As Label

End Class
