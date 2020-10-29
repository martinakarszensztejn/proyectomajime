<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainRecepcionistaGaraje
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(421, 106)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(211, 37)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Ver Reserva"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(83, 106)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(211, 37)
        Me.Button13.TabIndex = 14
        Me.Button13.Text = "Salida y Llegada de Vehículos"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(685, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(103, 23)
        Me.Button9.TabIndex = 15
        Me.Button9.Text = "Salir de la Sesión"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'MainRecepcionistaGaraje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button5)
        Me.Name = "MainRecepcionistaGaraje"
        Me.Text = "MainRecepcionistaGaraje"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button9 As Button
End Class
