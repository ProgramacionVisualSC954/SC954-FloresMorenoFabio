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
        txtBusqueda = New TextBox()
        btnBuscar = New Button()
        lblResultado = New CheckedListBox()
        SuspendLayout()
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(65, 78)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(215, 27)
        txtBusqueda.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(65, 134)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(94, 29)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.BackColor = SystemColors.Highlight
        lblResultado.FormattingEnabled = True
        lblResultado.Location = New Point(44, 203)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(236, 180)
        lblResultado.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(337, 450)
        Controls.Add(lblResultado)
        Controls.Add(btnBuscar)
        Controls.Add(txtBusqueda)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblResultado As CheckedListBox

End Class
