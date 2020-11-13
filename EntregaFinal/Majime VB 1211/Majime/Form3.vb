Imports MySql.Data.MySqlClient

Public Class Form3






    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Guau.rangoUsuario = ""

        Dim consulta As String
        Dim tabla As String
        If ListBox1.SelectedIndex = 0 Then
            tabla = "rec_garaje"
        ElseIf ListBox1.SelectedIndex = 1 Then
            tabla = "oficinista"
        ElseIf ListBox1.SelectedIndex = 2 Then
            tabla = "gerente"
        End If

        consulta = "Select * From " & tabla & " WHERE ci_" & tabla & " = '" & TBUser.Text & "' And contrasena_" & tabla & " ='" & TBPass.Text & "'"






        Dim comando As New MySqlCommand(consulta, Guau.conk)



        Dim drd As MySqlDataReader






        If Guau.conk.State.Open Then
            Guau.conk.Close()
            Guau.conk.Open()

        Else
            Guau.conk.Open()
        End If



        Dim exito As Boolean


        exito = False



        Try
            drd = comando.ExecuteReader
            If drd.Read() Then

                exito = True


                If ListBox1.SelectedIndex = 0 Then
                    Guau.rangoUsuario = "Recepcionista de Garaje"
                    Guau.ci_usuario = drd.Item("ci_rec_garaje").ToString
                ElseIf ListBox1.SelectedIndex = 1 Then
                    Guau.rangoUsuario = "Oficinista"
                    Guau.ci_usuario = drd.Item("ci_oficinista").ToString
                ElseIf ListBox1.SelectedIndex = 2 Then
                    Guau.rangoUsuario = "Gerente"
                    Guau.ci_usuario = drd.Item("ci_gerente").ToString
                End If
            End If

        Catch ex As Exception

            exito = False
        End Try
        Try




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
            If IsNothing(drd) = False Then
                drd.Close()
            End If


        Catch ex As Exception

        End Try
    End Sub








    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Guau.AbrirFormEnPanel(New Form1)

    End Sub

End Class