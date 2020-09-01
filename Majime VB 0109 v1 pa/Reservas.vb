﻿Public Class CrearReservas
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CrearReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerA1.Format = DateTimePickerFormat.Custom
        DateTimePickerA2.Format = DateTimePickerFormat.Custom
        DateTimePickerA3.Format = DateTimePickerFormat.Custom
        DateTimePickerA4.Format = DateTimePickerFormat.Custom
        DateTimePickerR4.Format = DateTimePickerFormat.Custom
        DateTimePickerR3.Format = DateTimePickerFormat.Custom
        DateTimePickerR1.Format = DateTimePickerFormat.Custom
        DateTimePickerR2.Format = DateTimePickerFormat.Custom
        DateTimePickerA1.CustomFormat = "dd/MM/yyyy"
        DateTimePickerR1.CustomFormat = "dd/MM/yyyy"
        DateTimePickerA2.CustomFormat = "HH:mm"
        DateTimePickerR2.CustomFormat = "HH:mm"
        DateTimePickerA3.CustomFormat = "HH:mm"
        DateTimePickerR3.CustomFormat = "HH:mm"
        DateTimePickerA4.CustomFormat = "HH:mm"
        DateTimePickerR4.CustomFormat = "HH:mm"
        DateTimePickerA2.ShowUpDown = True
        DateTimePickerR2.ShowUpDown = True
        DateTimePickerA3.ShowUpDown = True
        DateTimePickerR3.ShowUpDown = True
        DateTimePickerA4.ShowUpDown = True
        DateTimePickerR4.ShowUpDown = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox3.SelectedItem = 1
        ListBox1.SelectedItem = 1
        ListBox2.SelectedItem = 1
        DateTimePickerA1.Value = DateTime.Now
        DateTimePickerA2.Value = DateTime.Now
        DateTimePickerA3.Value = DateTime.Now
        DateTimePickerA4.Value = DateTime.Now
        DateTimePickerR1.Value = DateTime.Now
        DateTimePickerR2.Value = DateTime.Now
        DateTimePickerR3.Value = DateTime.Now
        DateTimePickerR4.Value = DateTime.Now
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Form3.rangoUsuario = Form3.rangos(0) Then
            MainGerente.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(2) Then
            MainRecepcionistaGaraje.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(1) Then
            MainOficinista.Show()
            Me.Hide()
        End If
    End Sub


End Class