Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class AgregarCliente


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" OrElse TextBox2.Text <> "" OrElse TextBox3.Text <> "" OrElse TextBox5.Text <> "" Then
            If (Not Regex.IsMatch(TextBox1.Text, "^[0-9 ]+$") OrElse (Integer.Parse(TextBox1.Text) < 1000000 Or Integer.Parse(TextBox1.Text) > 70000000)) Then
                MsgBox("El valor de CI es inválido")
            Else
                If Not Regex.IsMatch(TextBox4.Text, "^[0-9 ]+$") And Not TextBox5.Text.ToString = String.Empty Then
                    MsgBox("El valor de teléfono es inválido")
                Else
                    If Not Regex.IsMatch(TextBox5.Text, "^[0-9 ]+$") Then
                        MsgBox("El valor de celular es inválido")
                    Else
                        If (TextBox6.Text <> String.Empty And TextBox6.Text.IndexOf("@") = -1) Or (TextBox6.Text <> String.Empty And TextBox6.Text.IndexOf(".") = -1) Then
                            MsgBox("El valor del email no es válido.")
                        Else




                            Dim sentencia As String


                            Try

                                sentencia = "INSERT INTO `cliente` (`ci_cliente`, `nombre_cliente`, `telefono_cliente`, `celular_cliente`, `direccion_cliente`, `email_cliente`) VALUES (" & TextBox1.Text & ", '" & TextBox2.Text.ToLower & "', " & TextBox4.Text & ", " & TextBox5.Text & ", '" & TextBox3.Text.ToLower & "', '" & TextBox6.Text.ToLower & "');"

                                Dim comando As New MySqlCommand



                                comando = New MySqlCommand(sentencia, Guau.conk)



                                comando.ExecuteNonQuery()



                                MsgBox("Se agregó exitosamente al cliente.")
                                TextBox1.Text = ""
                                TextBox2.Text = ""
                                TextBox3.Text = ""
                                TextBox4.Text = ""
                                TextBox5.Text = ""
                                TextBox6.Text = ""
                            Catch ex As Exception

                                MsgBox("Ocurrió un error en el ingreso de datos." & ex.Message)



                            End Try
                        End If

                    End If
                End If
            End If

        Else
            MsgBox("No se pueden dejar campos vacíos")
        End If
    End Sub


End Class