Imports MySql.Data.MySqlClient

Public Class VerMascota
    Public mascNomb(0) As String
    Public mascNum(0) As Integer
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

        Guau.AbrirFormEnPanel(New VerMascotaElegida)
    End Sub

    Private Sub VerMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLista()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            Dim seleccionprev As String
            seleccionprev = ListBox1.SelectedItem
            Dim seleccion As String
            seleccion = Nothing
            Dim longitud As Integer
            longitud = seleccionprev.IndexOf(" ")
            For index = 0 To (longitud - 1)
                seleccion = seleccion & seleccionprev.Chars(index)
            Next
            Dim sentenciaBorrarUno As String = "DELETE FROM `majime`.`pertenece` WHERE (`num_mascota` = " & Integer.Parse(seleccion) & ");"
            Dim comandoUno As New MySqlCommand
            comandoUno = New MySqlCommand(sentenciaBorrarUno, Guau.conk)
            comandoUno.ExecuteNonQuery()
            Dim sentenciaBorrar As String = "DELETE FROM `majime`.`mascota` WHERE (`num_mascota` = " & Integer.Parse(seleccion) & ");"
            Dim comando As New MySqlCommand
            comando = New MySqlCommand(sentenciaBorrar, Guau.conk)
            comando.ExecuteNonQuery()
            CargarLista()
        Catch ex As Exception
            MsgBox("Error en el borrado. Intente más tarde." & ex.Message)
        End Try
    End Sub


    Private Sub CargarLista()
        Dim consulta As String
        consulta = "Select * From majime.mascota;"

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
        Dim valorlong As Integer
        ReDim Preserve mascNomb(0)
        ReDim Preserve mascNum(0)
        mascNomb(0) = Nothing
        mascNum(0) = Nothing
        Try
            While drd.HasRows()


                While drd.Read()

                    exito = True
                    mascNum(mascNum.Length() - 1) = drd.GetString(0)
                    mascNomb(mascNomb.Length() - 1) = drd.GetString(1)

                    valorlong = mascNum.Length
                    ReDim Preserve mascNum(valorlong)
                    ReDim Preserve mascNomb(valorlong)

                End While

                drd.NextResult()

            End While
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado. Intente más tarde." & ex.Message)
        End Try

        If exito Then

            ListBox1.Items.Clear()
            For index = 0 To (mascNum.Length - 2)
                ListBox1.Items.Add(mascNum(index).ToString & " - " & mascNomb(index).ToString.ToUpper)
            Next




        End If


        drd.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Guau.AbrirFormEnPanel(New AgregarMascota)
    End Sub
End Class