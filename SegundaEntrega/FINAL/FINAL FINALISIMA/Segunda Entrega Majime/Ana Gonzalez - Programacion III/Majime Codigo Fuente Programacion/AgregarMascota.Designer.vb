<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarMascota
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
        Me.TextBoxPeso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxRaza = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButtonM = New System.Windows.Forms.RadioButton()
        Me.RadioButtonF = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxVac = New System.Windows.Forms.TextBox()
        Me.RadioButtonSi = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNo = New System.Windows.Forms.RadioButton()
        Me.TextBoxMed = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxDos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxHor = New System.Windows.Forms.TextBox()
        Me.TextBoxCA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxPeso
        '
        Me.TextBoxPeso.Location = New System.Drawing.Point(345, 205)
        Me.TextBoxPeso.Name = "TextBoxPeso"
        Me.TextBoxPeso.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPeso.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(245, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Label4.Size = New System.Drawing.Size(36, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Peso*"
        '
        'TextBoxRaza
        '
        Me.TextBoxRaza.Location = New System.Drawing.Point(345, 165)
        Me.TextBoxRaza.Name = "TextBoxRaza"
        Me.TextBoxRaza.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRaza.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(245, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Label2.Size = New System.Drawing.Size(33, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Raza"
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(345, 130)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(245, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(246, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Label3.Size = New System.Drawing.Size(32, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Sexo"
        '
        'RadioButtonM
        '
        Me.RadioButtonM.AutoSize = True
        Me.RadioButtonM.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonM.Location = New System.Drawing.Point(15, 12)
        Me.RadioButtonM.Name = "RadioButtonM"
        Me.RadioButtonM.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.RadioButtonM.Size = New System.Drawing.Size(59, 18)
        Me.RadioButtonM.TabIndex = 4
        Me.RadioButtonM.TabStop = True
        Me.RadioButtonM.Text = "Macho"
        Me.RadioButtonM.UseVisualStyleBackColor = False
        '
        'RadioButtonF
        '
        Me.RadioButtonF.AutoSize = True
        Me.RadioButtonF.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonF.Location = New System.Drawing.Point(15, 35)
        Me.RadioButtonF.Name = "RadioButtonF"
        Me.RadioButtonF.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.RadioButtonF.Size = New System.Drawing.Size(63, 18)
        Me.RadioButtonF.TabIndex = 5
        Me.RadioButtonF.TabStop = True
        Me.RadioButtonF.Text = "Hembra"
        Me.RadioButtonF.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(569, 130)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(470, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Label5.Size = New System.Drawing.Size(73, 14)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "F. Nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(470, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Label6.Size = New System.Drawing.Size(44, 14)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Dueño*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(470, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Label8.Size = New System.Drawing.Size(50, 14)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Vacunas"
        '
        'TextBoxVac
        '
        Me.TextBoxVac.Location = New System.Drawing.Point(569, 237)
        Me.TextBoxVac.Name = "TextBoxVac"
        Me.TextBoxVac.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVac.TabIndex = 9
        '
        'RadioButtonSi
        '
        Me.RadioButtonSi.AutoSize = True
        Me.RadioButtonSi.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonSi.Location = New System.Drawing.Point(6, 3)
        Me.RadioButtonSi.Name = "RadioButtonSi"
        Me.RadioButtonSi.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.RadioButtonSi.Size = New System.Drawing.Size(124, 18)
        Me.RadioButtonSi.TabIndex = 10
        Me.RadioButtonSi.TabStop = True
        Me.RadioButtonSi.Text = "Toma Medicamento*"
        Me.RadioButtonSi.UseVisualStyleBackColor = False
        '
        'RadioButtonNo
        '
        Me.RadioButtonNo.AutoSize = True
        Me.RadioButtonNo.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonNo.Location = New System.Drawing.Point(5, 26)
        Me.RadioButtonNo.Name = "RadioButtonNo"
        Me.RadioButtonNo.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.RadioButtonNo.Size = New System.Drawing.Size(143, 18)
        Me.RadioButtonNo.TabIndex = 11
        Me.RadioButtonNo.TabStop = True
        Me.RadioButtonNo.Text = "NO Toma Medicamento*"
        Me.RadioButtonNo.UseVisualStyleBackColor = False
        '
        'TextBoxMed
        '
        Me.TextBoxMed.Location = New System.Drawing.Point(429, 303)
        Me.TextBoxMed.Name = "TextBoxMed"
        Me.TextBoxMed.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMed.TabIndex = 12
        Me.TextBoxMed.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(350, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Label7.Size = New System.Drawing.Size(73, 14)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Medicación"
        Me.Label7.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(368, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Label9.Size = New System.Drawing.Size(39, 14)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Dosis"
        Me.Label9.Visible = False
        '
        'TextBoxDos
        '
        Me.TextBoxDos.Location = New System.Drawing.Point(429, 329)
        Me.TextBoxDos.Name = "TextBoxDos"
        Me.TextBoxDos.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDos.TabIndex = 13
        Me.TextBoxDos.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(576, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Label10.Size = New System.Drawing.Size(49, 14)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Horario"
        Me.Label10.Visible = False
        '
        'TextBoxHor
        '
        Me.TextBoxHor.Location = New System.Drawing.Point(665, 301)
        Me.TextBoxHor.Name = "TextBoxHor"
        Me.TextBoxHor.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHor.TabIndex = 14
        Me.TextBoxHor.Visible = False
        '
        'TextBoxCA
        '
        Me.TextBoxCA.Location = New System.Drawing.Point(665, 330)
        Me.TextBoxCA.Name = "TextBoxCA"
        Me.TextBoxCA.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCA.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(553, 329)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Label11.Size = New System.Drawing.Size(93, 27)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Complementos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alimenticios"
        '
        'Button3
        '
        Me.Button3.Image = Global.Majime.My.Resources.Resources.cancel
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(20, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Majime.My.Resources.Resources.arrow_rotate_clockwise
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(20, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Volver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Majime.My.Resources.Resources.add1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(20, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Majime.My.Resources.Resources.logou
        Me.PictureBox1.Location = New System.Drawing.Point(20, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(570, 156)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(120, 69)
        Me.ListBox1.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.RadioButtonM)
        Me.Panel1.Controls.Add(Me.RadioButtonF)
        Me.Panel1.Location = New System.Drawing.Point(345, 231)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(96, 68)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.RadioButtonSi)
        Me.Panel2.Controls.Add(Me.RadioButtonNo)
        Me.Panel2.Location = New System.Drawing.Point(130, 306)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(151, 48)
        Me.Panel2.TabIndex = 10
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.Majime.My.Resources.Resources.add1
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(710, 168)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 29)
        Me.Button5.TabIndex = 8
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Goudy Old Style", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(290, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(357, 40)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "AGREGAR MASCOTA"
        '
        'AgregarMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.Majime.My.Resources.Resources.html_color_codes_color_tutorials_hero_00e10b1f
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 459)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxCA)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxHor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxDos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxMed)
        Me.Controls.Add(Me.TextBoxVac)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxPeso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxRaza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarMascota"
        Me.Padding = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.Text = "AgregarMascota"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxPeso As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxRaza As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButtonM As RadioButton
    Friend WithEvents RadioButtonF As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxVac As TextBox
    Friend WithEvents RadioButtonSi As RadioButton
    Friend WithEvents RadioButtonNo As RadioButton
    Friend WithEvents TextBoxMed As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxDos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxHor As TextBox
    Friend WithEvents TextBoxCA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label12 As Label
End Class
