﻿Public Class Habitaciones


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If
    End Sub





    Private Sub Habitaciones_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Guau.rangoUsuario = Guau.rangos(1) Then

            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            TextBox11.Enabled = False
            TextBox12.Enabled = False
            TextBox4.Enabled = False
            TextBox3.Enabled = False
            TextBox1.Enabled = False
            Button1.Visible = False
            Button2.Visible = False
            TextBox2.Enabled = False
        ElseIf Guau.rangoUsuario = Guau.rangos(0) Then
            TextBox4.Enabled = True
            TextBox3.Enabled = True
            TextBox1.Enabled = True
            TextBox2.Enabled = True

            Button1.Visible = True
            Button2.Visible = True

            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
            TextBox8.Enabled = True
            TextBox9.Enabled = True
            TextBox10.Enabled = True
            TextBox11.Enabled = True
            TextBox12.Enabled = True

        End If
    End Sub
End Class