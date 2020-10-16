Imports System.Text.RegularExpressions

Public Class AgregarVehiculos


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = String.Empty OrElse TextBox2.Text = String.Empty OrElse TextBox3.Text = String.Empty OrElse TextBox4.Text = String.Empty Then
            MsgBox("No deje campos vacíos.")
        Else
            If Not Regex.IsMatch(TextBox4.Text, "^[0-9 ]+$") OrElse Integer.Parse(TextBox4.Text) < 1 OrElse Integer.Parse(TextBox4.Text) > 30 Then
                MsgBox("La capacidad debe ser válida")
            Else
                MsgBox("Lo sentimos. Esta funcionalidad aún no fue implementada, sin embargo, todos los campos fueron verificados.")
            End If
        End If
    End Sub
End Class