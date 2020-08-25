<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainGerente
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
        Me.Reservas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Reservas
        '
        Me.Reservas.Location = New System.Drawing.Point(162, 129)
        Me.Reservas.Name = "Reservas"
        Me.Reservas.Size = New System.Drawing.Size(101, 23)
        Me.Reservas.TabIndex = 0
        Me.Reservas.Text = "Agregar Reservas"
        Me.Reservas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Precio Habitaciones"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(55, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Horarios"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(162, 158)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Ver Reservas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(55, 158)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Ver Clientes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(55, 129)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Agregar Clientes"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(269, 158)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(101, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Ver Mascotas"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(269, 129)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(101, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Agregar Mascotas"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(377, 129)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(97, 23)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Pagar Reserva"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'MainGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Reservas)
        Me.Name = "MainGerente"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "|"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Reservas As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
