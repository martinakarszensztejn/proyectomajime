﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrearReservas
    Inherits System.Windows.Forms.Form
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerA1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerA2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBoxDogTV = New System.Windows.Forms.CheckBox()
        Me.CheckBoxWebcam = New System.Windows.Forms.CheckBox()
        Me.DateTimePickerR1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePickerR2 = New System.Windows.Forms.DateTimePicker()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.btnAddBooking = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RadioButtonCont = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCC = New System.Windows.Forms.RadioButton()
        Me.ListBoxMasc = New System.Windows.Forms.ListBox()
        Me.ListBoxRoom = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DateTimePickerR4 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxIda = New System.Windows.Forms.CheckBox()
        Me.DateTimePickerR3 = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePickerA4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerA3 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckBoxVuelta = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mascota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.Label3.Size = New System.Drawing.Size(73, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Día Arribo"
        '
        'DateTimePickerA1
        '
        Me.DateTimePickerA1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerA1.Location = New System.Drawing.Point(341, 98)
        Me.DateTimePickerA1.Name = "DateTimePickerA1"
        Me.DateTimePickerA1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerA1.TabIndex = 8
        '
        'DateTimePickerA2
        '
        Me.DateTimePickerA2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerA2.Location = New System.Drawing.Point(341, 125)
        Me.DateTimePickerA2.Name = "DateTimePickerA2"
        Me.DateTimePickerA2.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerA2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(260, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.Label4.Size = New System.Drawing.Size(78, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Hora Arribo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(265, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(1)
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Habitación"
        '
        'CheckBoxDogTV
        '
        Me.CheckBoxDogTV.AutoSize = True
        Me.CheckBoxDogTV.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxDogTV.Enabled = False
        Me.CheckBoxDogTV.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxDogTV.Location = New System.Drawing.Point(503, 368)
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
        Me.CheckBoxWebcam.Location = New System.Drawing.Point(503, 394)
        Me.CheckBoxWebcam.Name = "CheckBoxWebcam"
        Me.CheckBoxWebcam.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.CheckBoxWebcam.Size = New System.Drawing.Size(81, 20)
        Me.CheckBoxWebcam.TabIndex = 15
        Me.CheckBoxWebcam.Text = "WebCam"
        Me.CheckBoxWebcam.UseVisualStyleBackColor = False
        '
        'DateTimePickerR1
        '
        Me.DateTimePickerR1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerR1.Location = New System.Drawing.Point(511, 98)
        Me.DateTimePickerR1.Name = "DateTimePickerR1"
        Me.DateTimePickerR1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerR1.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(439, 98)
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
        Me.Label7.Location = New System.Drawing.Point(439, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 14)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Hora Retiro"
        '
        'DateTimePickerR2
        '
        Me.DateTimePickerR2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerR2.Location = New System.Drawing.Point(511, 125)
        Me.DateTimePickerR2.Name = "DateTimePickerR2"
        Me.DateTimePickerR2.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerR2.TabIndex = 18
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.lblPrecio.Location = New System.Drawing.Point(25, 347)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPrecio.Size = New System.Drawing.Size(72, 28)
        Me.lblPrecio.TabIndex = 22
        Me.lblPrecio.Text = "Precio:"
        '
        'btnAddBooking
        '
        Me.btnAddBooking.Image = Global.Majime.My.Resources.Resources.add1
        Me.btnAddBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddBooking.Location = New System.Drawing.Point(25, 271)
        Me.btnAddBooking.Name = "btnAddBooking"
        Me.btnAddBooking.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBooking.TabIndex = 25
        Me.btnAddBooking.Text = "Reservar   "
        Me.btnAddBooking.UseVisualStyleBackColor = True
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
        Me.Label12.Location = New System.Drawing.Point(598, 198)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 14)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Modalidad de Pago"
        '
        'RadioButtonCont
        '
        Me.RadioButtonCont.AutoSize = True
        Me.RadioButtonCont.BackColor = System.Drawing.Color.Transparent
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
        'ListBoxMasc
        '
        Me.ListBoxMasc.FormattingEnabled = True
        Me.ListBoxMasc.Location = New System.Drawing.Point(332, 35)
        Me.ListBoxMasc.Name = "ListBoxMasc"
        Me.ListBoxMasc.ScrollAlwaysVisible = True
        Me.ListBoxMasc.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxMasc.Size = New System.Drawing.Size(122, 43)
        Me.ListBoxMasc.TabIndex = 44
        '
        'ListBoxRoom
        '
        Me.ListBoxRoom.FormattingEnabled = True
        Me.ListBoxRoom.Location = New System.Drawing.Point(352, 371)
        Me.ListBoxRoom.Name = "ListBoxRoom"
        Me.ListBoxRoom.ScrollAlwaysVisible = True
        Me.ListBoxRoom.Size = New System.Drawing.Size(122, 69)
        Me.ListBoxRoom.TabIndex = 45
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
        Me.Label8.Location = New System.Drawing.Point(575, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 40)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "RESERVAS"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Majime.My.Resources.Resources.html_color_codes_color_tutorials_hero_00e10b1f
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.DateTimePickerA4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ListBoxRoom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ListBoxMasc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateTimePickerA1)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.DateTimePickerA2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DateTimePickerR4)
        Me.Panel1.Controls.Add(Me.CheckBoxIda)
        Me.Panel1.Controls.Add(Me.DateTimePickerR3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.CheckBoxDogTV)
        Me.Panel1.Controls.Add(Me.CheckBoxWebcam)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DateTimePickerR1)
        Me.Panel1.Controls.Add(Me.DateTimePickerA3)
        Me.Panel1.Controls.Add(Me.DateTimePickerR2)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CheckBoxVuelta)
        Me.Panel1.Controls.Add(Me.lblPrecio)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.btnAddBooking)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 498)
        Me.Panel1.TabIndex = 76
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.RadioButtonCont)
        Me.Panel2.Controls.Add(Me.RadioButtonCC)
        Me.Panel2.Location = New System.Drawing.Point(566, 214)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 32)
        Me.Panel2.TabIndex = 78
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Silver
        Me.Button6.BackgroundImage = Global.Majime.My.Resources.Resources.add1
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(470, 36)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(30, 29)
        Me.Button6.TabIndex = 76
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(265, 330)
        Me.Label19.Name = "Label19"
        Me.Label19.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.Label19.Size = New System.Drawing.Size(163, 18)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Hora Fin Traslado VUELTA"
        '
        'DateTimePickerR4
        '
        Me.DateTimePickerR4.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerR4.Location = New System.Drawing.Point(453, 324)
        Me.DateTimePickerR4.Name = "DateTimePickerR4"
        Me.DateTimePickerR4.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerR4.TabIndex = 38
        '
        'CheckBoxIda
        '
        Me.CheckBoxIda.AutoSize = True
        Me.CheckBoxIda.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxIda.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxIda.Location = New System.Drawing.Point(274, 164)
        Me.CheckBoxIda.Name = "CheckBoxIda"
        Me.CheckBoxIda.Padding = New System.Windows.Forms.Padding(5, 5, 15, 5)
        Me.CheckBoxIda.Size = New System.Drawing.Size(117, 28)
        Me.CheckBoxIda.TabIndex = 11
        Me.CheckBoxIda.Text = "Traslado Ida"
        Me.CheckBoxIda.UseVisualStyleBackColor = False
        '
        'DateTimePickerR3
        '
        Me.DateTimePickerR3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerR3.Location = New System.Drawing.Point(453, 245)
        Me.DateTimePickerR3.Name = "DateTimePickerR3"
        Me.DateTimePickerR3.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerR3.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(265, 252)
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New System.Windows.Forms.Padding(0, 0, 26, 0)
        Me.Label18.Size = New System.Drawing.Size(161, 14)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Hora Fin Traslado IDA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(265, 301)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(0, 2, 24, 2)
        Me.Label14.Size = New System.Drawing.Size(200, 18)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Hora Inicio Traslado VUELTA"
        '
        'DateTimePickerA4
        '
        Me.DateTimePickerA4.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerA4.Location = New System.Drawing.Point(453, 298)
        Me.DateTimePickerA4.Name = "DateTimePickerA4"
        Me.DateTimePickerA4.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerA4.TabIndex = 33
        '
        'DateTimePickerA3
        '
        Me.DateTimePickerA3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerA3.Location = New System.Drawing.Point(453, 217)
        Me.DateTimePickerA3.Name = "DateTimePickerA3"
        Me.DateTimePickerA3.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerA3.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(265, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(0, 2, 50, 2)
        Me.Label13.Size = New System.Drawing.Size(198, 18)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Hora Inicio Traslado IDA"
        '
        'CheckBoxVuelta
        '
        Me.CheckBoxVuelta.AutoSize = True
        Me.CheckBoxVuelta.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxVuelta.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxVuelta.Location = New System.Drawing.Point(442, 164)
        Me.CheckBoxVuelta.Name = "CheckBoxVuelta"
        Me.CheckBoxVuelta.Padding = New System.Windows.Forms.Padding(5)
        Me.CheckBoxVuelta.Size = New System.Drawing.Size(128, 28)
        Me.CheckBoxVuelta.TabIndex = 20
        Me.CheckBoxVuelta.Text = "Traslado Vuelta"
        Me.CheckBoxVuelta.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Image = Global.Majime.My.Resources.Resources.cancel
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(25, 214)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Limpiar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CrearReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CrearReservas"
        Me.Text = "Reservas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerA1 As DateTimePicker
    Friend WithEvents DateTimePickerA2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBoxDogTV As CheckBox
    Friend WithEvents CheckBoxWebcam As CheckBox
    Friend WithEvents DateTimePickerR1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePickerR2 As DateTimePicker
    Friend WithEvents lblPrecio As Label
    Friend WithEvents btnAddBooking As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents RadioButtonCont As RadioButton
    Friend WithEvents RadioButtonCC As RadioButton
    Friend WithEvents ListBoxMasc As ListBox
    Friend WithEvents ListBoxRoom As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents DateTimePickerR4 As DateTimePicker
    Friend WithEvents CheckBoxIda As CheckBox
    Friend WithEvents DateTimePickerR3 As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePickerA4 As DateTimePicker
    Friend WithEvents DateTimePickerA3 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckBoxVuelta As CheckBox
    Friend WithEvents Button4 As Button
End Class