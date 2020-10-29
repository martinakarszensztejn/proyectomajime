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
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Button13 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox1.Image = Global.Majime.My.Resources.Resources.logou
		Me.PictureBox1.Location = New System.Drawing.Point(139, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(175, 94)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 65
		Me.PictureBox1.TabStop = False
		'
		'Button13
		'
		Me.Button13.Image = Global.Majime.My.Resources.Resources.car
		Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button13.Location = New System.Drawing.Point(127, 222)
		Me.Button13.Name = "Button13"
		Me.Button13.Size = New System.Drawing.Size(206, 37)
		Me.Button13.TabIndex = 14
		Me.Button13.Text = "Salida y Llegada de Vehículos"
		Me.Button13.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.Image = Global.Majime.My.Resources.Resources.search16
		Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button5.Location = New System.Drawing.Point(169, 138)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(143, 37)
		Me.Button5.TabIndex = 3
		Me.Button5.Text = "Ver Reserva"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Image = Global.Majime.My.Resources.Resources.arrow_rotate_clockwise
		Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button4.Location = New System.Drawing.Point(202, 301)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(75, 23)
		Me.Button4.TabIndex = 66
		Me.Button4.Text = "Volver"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'MainRecepcionistaGaraje
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.ClientSize = New System.Drawing.Size(466, 450)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Button13)
		Me.Controls.Add(Me.Button5)
		Me.Name = "MainRecepcionistaGaraje"
		Me.Text = "MainRecepcionistaGaraje"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Button5 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Button4 As Button
End Class
