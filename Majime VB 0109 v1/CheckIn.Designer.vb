﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckIn
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
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(202, 108)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(48, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Mascota"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(309, 108)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox1.TabIndex = 1
		'
		'ComboBox2
		'
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Location = New System.Drawing.Point(309, 162)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
		Me.ComboBox2.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(202, 165)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(101, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Empleado Receptor"
		'
		'Button1
		'
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Button1.Image = Global.Majime.My.Resources.Resources.accept
		Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button1.Location = New System.Drawing.Point(206, 282)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Confirmar"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Image = Global.Majime.My.Resources.Resources.arrow_rotate_clockwise
		Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button2.Location = New System.Drawing.Point(355, 282)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 5
		Me.Button2.Text = "Volver"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox1.Image = Global.Majime.My.Resources.Resources.logou
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(175, 94)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 37
		Me.PictureBox1.TabStop = False
		'
		'CheckIn
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.ClientSize = New System.Drawing.Size(557, 360)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.ComboBox2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label1)
		Me.Name = "CheckIn"
		Me.Text = "CheckIn"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
