Imports MySql.Data.MySqlClient

Public Class Form3






    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Guau.rangoUsuario = ""

        Dim consulta As String
        consulta = "Select * From majime.empleado Where ci_empleado = '" & TBUser.Text & "' And password_empleado = '" & TBPass.Text & "';"

        Dim comando As New MySqlCommand(consulta, Guau.conk)



        Dim drd As MySqlDataReader






        If Guau.conk.State.Open Then
            Guau.conk.Close()
            Guau.conk.Open()

        Else

        End If
        drd = comando.ExecuteReader

        Dim exito As Boolean


        exito = False
        Try
            If drd.Read() Then

                exito = True
                Guau.rangoUsuario = drd.Item("rango_empleado").ToString
                Guau.userUsuario = drd.Item("ci_empleado").ToString
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado. Intente más tarde.")
        End Try

        If exito Then

            If Guau.rangoUsuario = Guau.rangos(0) Then
                Guau.AbrirFormEnPanel(New MainGerente)
            ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
                Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
            ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
                Guau.AbrirFormEnPanel(New MainOficinista)
            End If



        Else

            MsgBox("Error en el inicio de sesión")

        End If

        TBUser.Text = ""
        TBPass.Text = ""
        drd.Close()
    End Sub








    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Guau.AbrirFormEnPanel(New Form1)

    End Sub


End Class