Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Form2




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Guau.AbrirFormEnPanel(New Form1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text <> "" OrElse TextBox2.Text <> "" OrElse TextBox3.Text <> "" OrElse TextBox4.Text <> "" OrElse TextBox5.Text <> "" OrElse TextBox6.Text <> "" Then
            If (Not Regex.IsMatch(TextBox2.Text, "^[0-9 ]+$")) OrElse (Integer.Parse(TextBox2.Text) < 1000000 Or Integer.Parse(TextBox2.Text) > 70000000) Then
                MsgBox("El valor de CI es inválido")
            Else
                If Not Regex.IsMatch(TextBox5.Text, "^[0-9 ]+$") Then
                    MsgBox("El valor de teléfono es inválido")
                Else


                    Dim sentencia As String

                    Dim rangoReal As String
                    Try
                        If TextBox6.Text.ToString.ToLower = Guau.clavesDeRangoPrivadas(0) Then
                            rangoReal = Guau.rangos(0)
                        ElseIf TextBox6.Text.ToString.ToLower = Guau.clavesDeRangoPrivadas(1) Then
                            rangoReal = Guau.rangos(1)
                        ElseIf TextBox6.Text.ToString.ToLower = Guau.clavesDeRangoPrivadas(2) Then
                            rangoReal = Guau.rangos(2)
                        Else
                            Throw New ArgumentException("ClaveInc")
                        End If
                        sentencia = "INSERT INTO `empleado` (`nombre_empleado`, `ci_empleado`, `usuario_empleado`, `password_empleado`, `telefono_empleado`, `rango_empleado`) VALUES ('" & TextBox1.Text.ToLower & "', " & TextBox2.Text & ", '" & TextBox3.Text.ToLower & "', '" & TextBox4.Text.ToLower & "', " & TextBox5.Text & ", '" & rangoReal & "');"
                        Dim comando As New MySqlCommand
                        comando = New MySqlCommand(sentencia, Guau.conk)



                        comando.ExecuteNonQuery()



                        MsgBox("Se agregó exitosamente al usuario.")
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        TextBox3.Text = ""
                        TextBox4.Text = ""
                        TextBox5.Text = ""
                        TextBox6.Text = ""
                        comando.Dispose()
                    Catch ex As Exception
                        If ex.Message = "ClaveInc" Then
                            MsgBox("La clave de rango es incorrecta. Contacte al administrador de la empresa.")
                        Else
                            MsgBox("Ocurrió un error en el ingreso de datos.")
                            MsgBox(ex.Message)
                        End If

                    End Try
                End If
            End If

        Else
            MsgBox("No se pueden dejar campos vacíos")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

    End Sub


End Class