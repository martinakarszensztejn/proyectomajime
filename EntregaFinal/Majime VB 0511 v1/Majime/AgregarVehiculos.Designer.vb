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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxMat = New System.Windows.Forms.TextBox()
        Me.TextBoxMar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCap = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxAdd = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBoxDel = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBoxEdit = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ButtonLoadToModify = New System.Windows.Forms.Button()
        Me.GroupBoxAdd.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDel.SuspendLayout()
        Me.GroupBoxEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Matricula*"
        '
        'TextBoxMat
        '
        Me.TextBoxMat.Location = New System.Drawing.Point(101, 35)
        Me.TextBoxMat.MaxLength = 20
        Me.TextBoxMat.Name = "TextBoxMat"
        Me.TextBoxMat.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMat.TabIndex = 2
        '
        'TextBoxMar
        '
        Me.TextBoxMar.Location = New System.Drawing.Point(101, 73)
        Me.TextBoxMar.MaxLength = 64
        Me.TextBoxMar.Name = "TextBoxMar"
        Me.TextBoxMar.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(15, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Marca*"
        '
        'TextBoxMod
        '
        Me.TextBoxMod.Location = New System.Drawing.Point(101, 110)
        Me.TextBoxMod.MaxLength = 64
        Me.TextBoxMod.Name = "TextBoxMod"
        Me.TextBoxMod.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMod.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Modelo*"
        '
        'TextBoxCap
        '
        Me.TextBoxCap.Location = New System.Drawing.Point(101, 148)
        Me.TextBoxCap.MaxLength = 3
        Me.TextBoxCap.Name = "TextBoxCap"
        Me.TextBoxCap.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCap.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(15, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Capacidad*"
        '
        'GroupBoxAdd
        '
        Me.GroupBoxAdd.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxAdd.Controls.Add(Me.Label3)
        Me.GroupBoxAdd.Controls.Add(Me.Label1)
        Me.GroupBoxAdd.Controls.Add(Me.TextBoxMat)
        Me.GroupBoxAdd.Controls.Add(Me.Label2)
        Me.GroupBoxAdd.Controls.Add(Me.TextBoxMar)
        Me.GroupBoxAdd.Controls.Add(Me.TextBoxCap)
        Me.GroupBoxAdd.Controls.Add(Me.TextBoxMod)
        Me.GroupBoxAdd.Controls.Add(Me.Label4)
        Me.GroupBoxAdd.Location = New System.Drawing.Point(119, 135)
        Me.GroupBoxAdd.Name = "GroupBoxAdd"
        Me.GroupBoxAdd.Size = New System.Drawing.Size(238, 246)
        Me.GroupBoxAdd.TabIndex = 9
        Me.GroupBoxAdd.TabStop = False
        Me.GroupBoxAdd.Text = "Agregar Vehículos"
        '
        'Button5
        '
        Me.Button5.Image = Global.Majime.My.Resources.Resources.arrow_rotate_clockwise
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(12, 135)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "   Volver"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Majime.My.Resources.Resources.add1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(12, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "  Agregar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Goudy Old Style", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(228, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(459, 40)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "ADMINISTRAR VEHÍCULOS"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(64, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 134)
        Me.ListBox1.TabIndex = 7
        '
        'GroupBoxDel
        '
        Me.GroupBoxDel.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxDel.Controls.Add(Me.Label6)
        Me.GroupBoxDel.Controls.Add(Me.ListBox1)
        Me.GroupBoxDel.Location = New System.Drawing.Point(588, 135)
        Me.GroupBoxDel.Name = "GroupBoxDel"
        Me.GroupBoxDel.Size = New System.Drawing.Size(200, 246)
        Me.GroupBoxDel.TabIndex = 77
        Me.GroupBoxDel.TabStop = False
        Me.GroupBoxDel.Text = "Eliminar Vehículos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(6, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Matricula"
        '
        'Button1
        '
        Me.Button1.Image = Global.Majime.My.Resources.Resources.script_delete
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(12, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "  Borrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Majime.My.Resources.Resources.basket_edit
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(12, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Modificar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBoxEdit
        '
        Me.GroupBoxEdit.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxEdit.Controls.Add(Me.ButtonLoadToModify)
        Me.GroupBoxEdit.Controls.Add(Me.Label7)
        Me.GroupBoxEdit.Controls.Add(Me.ListBox2)
        Me.GroupBoxEdit.Location = New System.Drawing.Point(373, 135)
        Me.GroupBoxEdit.Name = "GroupBoxEdit"
        Me.GroupBoxEdit.Size = New System.Drawing.Size(200, 246)
        Me.GroupBoxEdit.TabIndex = 78
        Me.GroupBoxEdit.TabStop = False
        Me.GroupBoxEdit.Text = "Modificar Vehículos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(6, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Matricula"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(64, 35)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 134)
        Me.ListBox2.TabIndex = 6
        '
        'ButtonLoadToModify
        '
        Me.ButtonLoadToModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonLoadToModify.FlatAppearance.BorderSize = 3
        Me.ButtonLoadToModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLoadToModify.Location = New System.Drawing.Point(64, 185)
        Me.ButtonLoadToModify.Name = "ButtonLoadToModify"
        Me.ButtonLoadToModify.Size = New System.Drawing.Size(120, 43)
        Me.ButtonLoadToModify.TabIndex = 10
        Me.ButtonLoadToModify.Text = "Cargar Para Modificar"
        Me.ButtonLoadToModify.UseVisualStyleBackColor = False
        '
        'AgregarVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.Majime.My.Resources.Resources.html_color_codes_color_tutorials_hero_00e10b1f
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 459)
        Me.Controls.Add(Me.GroupBoxEdit)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBoxDel)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBoxAdd)
        Me.Name = "AgregarVehiculos"
        Me.Text = "AgregarVehiculos"
        Me.GroupBoxAdd.ResumeLayout(False)
        Me.GroupBoxAdd.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDel.ResumeLayout(False)
        Me.GroupBoxDel.PerformLayout()
        Me.GroupBoxEdit.ResumeLayout(False)
        Me.GroupBoxEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxMat As TextBox
    Friend WithEvents TextBoxMar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMod As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCap As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBoxAdd As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBoxDel As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBoxEdit As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ButtonLoadToModify As Button
End Class
