<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarVehiculos
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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.GroupBox1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Image = Global.Majime.My.Resources.Resources.add1
		Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button1.Location = New System.Drawing.Point(89, 204)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Agregar Vehículo"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(288, 88)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(50, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Matricula"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(374, 88)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 2
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(374, 126)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(100, 20)
		Me.TextBox2.TabIndex = 4
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(288, 126)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(37, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Marca"
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(374, 163)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(100, 20)
		Me.TextBox3.TabIndex = 6
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(288, 163)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(42, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Modelo"
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(374, 201)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(100, 20)
		Me.TextBox4.TabIndex = 8
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(288, 201)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(58, 13)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Capacidad"
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Location = New System.Drawing.Point(273, 59)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(238, 246)
		Me.GroupBox1.TabIndex = 9
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Agregado de Vehículos"
		'
		'PictureBox1
		'
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox1.Image = Global.Majime.My.Resources.Resources.logou
		Me.PictureBox1.Location = New System.Drawing.Point(12, 14)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(175, 94)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 36
		Me.PictureBox1.TabStop = False
		'
		'AgregarVehiculos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "AgregarVehiculos"
		Me.Text = "AgregarVehiculos"
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
