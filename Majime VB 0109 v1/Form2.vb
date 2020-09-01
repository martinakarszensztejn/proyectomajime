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

            Dim rangoReal As String
            Try
                If TextBox6.Text.ToString.ToLower = Form3.clavesDeRangoPrivadas(0) Then
                    rangoReal = Form3.rangos(0)
                ElseIf TextBox6.Text.ToString.ToLower = Form3.clavesDeRangoPrivadas(1) Then
                    rangoReal = Form3.rangos(1)
                ElseIf TextBox6.Text.ToString.ToLower = Form3.clavesDeRangoPrivadas(2) Then
                    rangoReal = Form3.rangos(2)
                Else
                    Throw New ArgumentException("ClaveInc")
                End If
                sentencia = "INSERT INTO `empleado` (`nombre`, `ci`, `usuario`, `password`, `telefono`, `rango`) VALUES ('" & TextBox1.Text.ToLower & "', " & TextBox2.Text & ", '" & TextBox3.Text.ToLower & "', '" & TextBox4.Text.ToLower & "', " & TextBox5.Text & ", '" & rangoReal & "');"
                Dim comando As New MySqlCommand
                comando = New MySqlCommand(sentencia, Form1.conk)



                comando.ExecuteNonQuery()
                MsgBox("Se agregó exitosamente al usuario.")
            Catch ex As Exception
                If ex.Message = "ClaveInc" Then
                    MsgBox("La clave de rango es incorrecta. Contacte al administrador de la empresa.")
                Else
                    MsgBox("Ocurrió un error en el ingreso de datos.")
                End If

            End Try


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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class