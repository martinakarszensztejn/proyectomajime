Imports MySql.Data.MySqlClient

Public Class VerCliente
    Public clientesCI(0) As Integer
    Public clientesNom(0) As String
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

        If ListBox1.Items.Count = 0 Then
            MsgBox("Lo sentimos pero no hay ítems disponibles.")
        Else
            If ListBox1.SelectedItem = Nothing Then
                MsgBox("Debe seleccionar un ítem!")
            Else
                Guau.AbrirFormEnPanel(New VerClienteElegido)
            End If
        End If
    End Sub



    Private Sub VerCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLista()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            If ListBox1.Items.Count = 0 Then
                MsgBox("Lo sentimos pero no hay ítems disponibles.")
            Else
                If ListBox1.SelectedItem = Nothing Then
                    MsgBox("Debe seleccionar un ítem!")
                Else
                    Dim seleccionprev As String
                    seleccionprev = ListBox1.SelectedItem
                    Dim seleccion As String
                    seleccion = Nothing
                    Dim longitud As Integer
                    longitud = seleccionprev.IndexOf(" ")
                    For index = 0 To (longitud - 1)
                        seleccion = seleccion & seleccionprev.Chars(index)
                    Next



                    Dim sentenciaBorrarUno As String = "DELETE FROM `pertenece` WHERE (`ci_cliente` = " & Integer.Parse(seleccion) & ");"
                    Dim comandoUno As New MySqlCommand
                    comandoUno = New MySqlCommand(sentenciaBorrarUno, Guau.conk)
                    comandoUno.ExecuteNonQuery()


                    'Dim sentenciaBorrarDos As String = "DELETE FROM mascota WHERE num_mascota = (SELECT num_mascota FROM pertenece WHERE ci_cliente = " & Integer.Parse(seleccion) & ");"
                    'Dim comandoDos As New MySqlCommand
                    'comandoDos = New MySqlCommand(sentenciaBorrarDos, Guau.conk)
                    'comandoDos.ExecuteNonQuery()




                    Dim sentenciaBorrar As String = "DELETE FROM `cliente` WHERE (`ci_cliente` = " & Integer.Parse(seleccion) & ");"
                    Dim comando As New MySqlCommand
                    comando = New MySqlCommand(sentenciaBorrar, Guau.conk)
                    comando.ExecuteNonQuery()
                    CargarLista()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en el borrado. Intente más tarde." & ex.Message)

        End Try
    End Sub

    Private Sub CargarLista()
        Dim consulta As String
        consulta = "Select * From cliente;"

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
        ReDim Preserve clientesCI(0)
        ReDim Preserve clientesNom(0)
        clientesCI(0) = Nothing
        clientesNom(0) = Nothing
        Try
            While drd.HasRows()


                While drd.Read()

                    exito = True
                    clientesCI(clientesCI.Length() - 1) = drd.GetString(0)
                    clientesNom(clientesNom.Length() - 1) = drd.GetString(1)

                    valorlong = clientesCI.Length
                    ReDim Preserve clientesCI(valorlong)
                    ReDim Preserve clientesNom(valorlong)

                End While

                drd.NextResult()

            End While
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado. Intente más tarde.")
        End Try

        If exito Then

            ListBox1.Items.Clear()
            For index = 0 To (clientesCI.Length - 2)
                ListBox1.Items.Add(clientesCI(index).ToString & " - " & clientesNom(index).ToString.ToUpper)
            Next
        Else
            If ListBox1.Items.Count >= 1 Then
                ListBox1.Items.RemoveAt(0)
            End If





        End If




        drd.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CargarLista()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.Items.Count = 0 Then
            MsgBox("Lo sentimos pero no hay ítems disponibles.")
        Else
            If ListBox1.SelectedItem = Nothing Then
                MsgBox("Debe seleccionar un ítem!")
            Else
                MsgBox("Lo sentimos. Esta funcionalidad aún no fue implementada, sin embargo, todos los campos fueron verificados.")
            End If
        End If
    End Sub
End Class