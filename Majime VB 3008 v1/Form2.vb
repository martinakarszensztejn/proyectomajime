Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" OrElse TextBox2.Text <> "" OrElse TextBox3.Text <> "" OrElse TextBox4.Text <> "" OrElse TextBox5.Text <> "" OrElse TextBox6.Text <> "" Then
            Dim sentencia As String
            Try

                sentencia = "INSERT INTO `empleado` (`nombre`, `ci`, `usuario`, `password`, `telefono`, `rango`) VALUES ('" & TextBox1.Text & "', " & TextBox2.Text & ", '" & TextBox3.Text & "', '" & TextBox4.Text & "', " & TextBox5.Text & ", '" & TextBox6.Text & "');"
                Dim comando As New MySqlCommand
                comando = New MySqlCommand(sentencia, Form1.conGlob)

                comando.ExecuteNonQuery()
                MsgBox("Se agregó exitosamente al usuario.")
            Catch ex As Exception
                MsgBox("Ocurrió un error en el ingreso de datos.")


            End Try


        Else
            MsgBox("No se pueden dejar campos vacíos")
        End If
    End Sub
End Class