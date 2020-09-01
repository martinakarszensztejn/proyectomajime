<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerReserva
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
		Me.btnVolver = New System.Windows.Forms.Button()
		Me.btnBorrar = New System.Windows.Forms.Button()
		Me.btnModificar = New System.Windows.Forms.Button()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.btnVer = New System.Windows.Forms.Button()
		Me.btnAgregar = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnVolver
		'
		Me.btnVolver.Image = Global.Majime.My.Resources.Resources.arrow_rotate_clockwise
		Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnVolver.Location = New System.Drawing.Point(557, 294)
		Me.btnVolver.Name = "btnVolver"
		Me.btnVolver.Size = New System.Drawing.Size(75, 23)
		Me.btnVolver.TabIndex = 57
		Me.btnVolver.Text = "Volver"
		Me.btnVolver.UseVisualStyleBackColor = True
		'
		'btnBorrar
		'
		Me.btnBorrar.Image = Global.Majime.My.Resources.Resources.cancel
		Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnBorrar.Location = New System.Drawing.Point(464, 294)
		Me.btnBorrar.Name = "btnBorrar"
		Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
		Me.btnBorrar.TabIndex = 56
		Me.btnBorrar.Text = "Borrar"
		Me.btnBorrar.UseVisualStyleBackColor = True
		'
		'btnModificar
		'
		Me.btnModificar.Image = Global.Majime.My.Resources.Resources.basket_edit
		Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnModificar.Location = New System.Drawing.Point(366, 294)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(75, 23)
		Me.btnModificar.TabIndex = 55
		Me.btnModificar.Text = "Modificar"
		Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnModificar.UseVisualStyleBackColor = True
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label13.Location = New System.Drawing.Point(256, 233)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(62, 13)
		Me.Label13.TabIndex = 62
		Me.Label13.Text = "N° Reserva"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(345, 230)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox1.TabIndex = 63
		'
		'btnVer
		'
		Me.btnVer.Image = Global.Majime.My.Resources.Resources.search16
		Me.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnVer.Location = New System.Drawing.Point(270, 294)
		Me.btnVer.Name = "btnVer"
		Me.btnVer.Size = New System.Drawing.Size(75, 23)
		Me.btnVer.TabIndex = 64
		Me.btnVer.Text = "Visualizar"
		Me.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnVer.UseVisualStyleBackColor = True
		'
		'btnAgregar
		'
		Me.btnAgregar.Image = Global.Majime.My.Resources.Resources.add1
		Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnAgregar.Location = New System.Drawing.Point(177, 294)
		Me.btnAgregar.Name = "btnAgregar"
		Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
		Me.btnAgregar.TabIndex = 65
		Me.btnAgregar.Text = "Agregar"
		Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnAgregar.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox1.Image = Global.Majime.My.Resources.Resources.logou
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(175, 94)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 67
		Me.PictureBox1.TabStop = False
		'
		'VerReserva
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.btnAgregar)
		Me.Controls.Add(Me.btnVer)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.btnVolver)
		Me.Controls.Add(Me.btnBorrar)
		Me.Controls.Add(Me.btnModificar)
		Me.Name = "VerReserva"
		Me.Text = "VerMascotas"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnVolver As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnVer As Button
    Friend WithEvents btnAgregar As Button
	Friend WithEvents PictureBox1 As PictureBox
End Class
