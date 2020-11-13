<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModReserva
    Inherits System.Windows.Forms.Form
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblMascota = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerA1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerA2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBoxDogTV = New System.Windows.Forms.CheckBox()
        Me.CheckBoxWebcam = New System.Windows.Forms.CheckBox()
        Me.DateTimePickerR1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePickerR2 = New System.Windows.Forms.DateTimePicker()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.btnAddBooking = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RadioButtonCont = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCC = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNumRes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMascota
        '
        Me.lblMascota.AutoSize = True
        Me.lblMascota.BackColor = System.Drawing.Color.Transparent
        Me.lblMascota.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMascota.Location = New System.Drawing.Point(363, 90)
        Me.lblMascota.Name = "lblMascota"
        Me.lblMascota.Size = New System.Drawing.Size(68, 16)
        Me.lblMascota.TabIndex = 3
        Me.lblMascota.Text = "Mascota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.Label3.Size = New System.Drawing.Size(73, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Día Arribo"
        '
        'DateTimePickerA1
        '
        Me.DateTimePickerA1.Enabled = False
        Me.DateTimePickerA1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerA1.Location = New System.Drawing.Point(436, 188)
        Me.DateTimePickerA1.Name = "DateTimePickerA1"
        Me.DateTimePickerA1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerA1.TabIndex = 8
        '
        'DateTimePickerA2
        '
        Me.DateTimePickerA2.Enabled = False
        Me.DateTimePickerA2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerA2.Location = New System.Drawing.Point(436, 215)
        Me.DateTimePickerA2.Name = "DateTimePickerA2"
        Me.DateTimePickerA2.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerA2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.Label4.Size = New System.Drawing.Size(78, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Hora Arribo"
        '
        'CheckBoxDogTV
        '
        Me.CheckBoxDogTV.AutoSize = True
        Me.CheckBoxDogTV.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxDogTV.Enabled = False
        Me.CheckBoxDogTV.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxDogTV.Location = New System.Drawing.Point(523, 109)
        Me.CheckBoxDogTV.Name = "CheckBoxDogTV"
        Me.CheckBoxDogTV.Padding = New System.Windows.Forms.Padding(3, 2, 6, 0)
        Me.CheckBoxDogTV.Size = New System.Drawing.Size(78, 20)
        Me.CheckBoxDogTV.TabIndex = 14
        Me.CheckBoxDogTV.Text = "DOGTV"
        Me.CheckBoxDogTV.UseVisualStyleBackColor = False
        '
        'CheckBoxWebcam
        '
        Me.CheckBoxWebcam.AutoSize = True
        Me.CheckBoxWebcam.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxWebcam.Enabled = False
        Me.CheckBoxWebcam.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxWebcam.Location = New System.Drawing.Point(523, 135)
        Me.CheckBoxWebcam.Name = "CheckBoxWebcam"
        Me.CheckBoxWebcam.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.CheckBoxWebcam.Size = New System.Drawing.Size(81, 20)
        Me.CheckBoxWebcam.TabIndex = 15
        Me.CheckBoxWebcam.Text = "WebCam"
        Me.CheckBoxWebcam.UseVisualStyleBackColor = False
        '
        'DateTimePickerR1
        '
        Me.DateTimePickerR1.Enabled = False
        Me.DateTimePickerR1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerR1.Location = New System.Drawing.Point(606, 188)
        Me.DateTimePickerR1.Name = "DateTimePickerR1"
        Me.DateTimePickerR1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerR1.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(534, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Label6.Size = New System.Drawing.Size(69, 14)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Día Retiro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(534, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 14)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Hora Retiro"
        '
        'DateTimePickerR2
        '
        Me.DateTimePickerR2.Enabled = False
        Me.DateTimePickerR2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerR2.Location = New System.Drawing.Point(606, 215)
        Me.DateTimePickerR2.Name = "DateTimePickerR2"
        Me.DateTimePickerR2.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerR2.TabIndex = 18
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecio.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(362, 349)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPrecio.Size = New System.Drawing.Size(80, 33)
        Me.lblPrecio.TabIndex = 22
        Me.lblPrecio.Text = "Precio:"
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.BackColor = System.Drawing.Color.Transparent
        Me.lblRoom.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom.Location = New System.Drawing.Point(520, 88)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Padding = New System.Windows.Forms.Padding(1)
        Me.lblRoom.Size = New System.Drawing.Size(95, 18)
        Me.lblRoom.TabIndex = 24
        Me.lblRoom.Text = "Habitación:"
        '
        'btnAddBooking
        '
        Me.btnAddBooking.Image = Global.Majime.My.Resources.Resources.add1
        Me.btnAddBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddBooking.Location = New System.Drawing.Point(25, 264)
        Me.btnAddBooking.Name = "btnAddBooking"
        Me.btnAddBooking.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBooking.TabIndex = 25
        Me.btnAddBooking.Text = "Modificar  "
        Me.btnAddBooking.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Majime.My.Resources.Resources.basket_put
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(25, 214)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Cargar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.Majime.My.Resources.Resources.arrow_rotate_clockwise
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(25, 164)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Volver"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(393, 269)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 14)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Modalidad de Pago"
        '
        'RadioButtonCont
        '
        Me.RadioButtonCont.AutoSize = True
        Me.RadioButtonCont.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonCont.Enabled = False
        Me.RadioButtonCont.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonCont.Location = New System.Drawing.Point(22, 7)
        Me.RadioButtonCont.Name = "RadioButtonCont"
        Me.RadioButtonCont.Size = New System.Drawing.Size(72, 18)
        Me.RadioButtonCont.TabIndex = 29
        Me.RadioButtonCont.TabStop = True
        Me.RadioButtonCont.Text = "Contado"
        Me.RadioButtonCont.UseVisualStyleBackColor = False
        '
        'RadioButtonCC
        '
        Me.RadioButtonCC.AutoSize = True
        Me.RadioButtonCC.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonCC.Enabled = False
        Me.RadioButtonCC.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonCC.Location = New System.Drawing.Point(93, 7)
        Me.RadioButtonCC.Name = "RadioButtonCC"
        Me.RadioButtonCC.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.RadioButtonCC.Size = New System.Drawing.Size(75, 18)
        Me.RadioButtonCC.TabIndex = 30
        Me.RadioButtonCC.TabStop = True
        Me.RadioButtonCC.Text = "Tarjeta"
        Me.RadioButtonCC.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Majime.My.Resources.Resources.logou
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Goudy Old Style", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(255, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(389, 40)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "MODIFICAR RESERVAS"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Majime.My.Resources.Resources.html_color_codes_color_tutorials_hero_00e10b1f
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lblNumRes)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblMascota)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateTimePickerA1)
        Me.Panel1.Controls.Add(Me.DateTimePickerA2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CheckBoxDogTV)
        Me.Panel1.Controls.Add(Me.CheckBoxWebcam)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DateTimePickerR1)
        Me.Panel1.Controls.Add(Me.DateTimePickerR2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblPrecio)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lblRoom)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.btnAddBooking)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 498)
        Me.Panel1.TabIndex = 76
        '
        'lblNumRes
        '
        Me.lblNumRes.AutoSize = True
        Me.lblNumRes.BackColor = System.Drawing.Color.Transparent
        Me.lblNumRes.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumRes.Location = New System.Drawing.Point(363, 126)
        Me.lblNumRes.Name = "lblNumRes"
        Me.lblNumRes.Padding = New System.Windows.Forms.Padding(1)
        Me.lblNumRes.Size = New System.Drawing.Size(91, 18)
        Me.lblNumRes.TabIndex = 81
        Me.lblNumRes.Text = "N° Reserva:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 14)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Num. Reserva"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(250, 126)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(76, 212)
        Me.ListBox1.TabIndex = 79
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.RadioButtonCont)
        Me.Panel2.Controls.Add(Me.RadioButtonCC)
        Me.Panel2.Location = New System.Drawing.Point(361, 285)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 32)
        Me.Panel2.TabIndex = 78
        '
        'ModReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ModReserva"
        Me.Text = "Reservas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMascota As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerA1 As DateTimePicker
    Friend WithEvents DateTimePickerA2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxDogTV As CheckBox
    Friend WithEvents CheckBoxWebcam As CheckBox
    Friend WithEvents DateTimePickerR1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePickerR2 As DateTimePicker
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblRoom As Label
    Friend WithEvents btnAddBooking As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents RadioButtonCont As RadioButton
    Friend WithEvents RadioButtonCC As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblNumRes As Label
End Class
