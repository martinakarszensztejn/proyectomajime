Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class AgregarVehiculos
    Private loadedToModifyMatricula As String = "None"

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
        AddVehicle()
    End Sub

    Private Sub AddVehicle()
        If TextBoxMat.Text = String.Empty OrElse TextBoxMar.Text = String.Empty OrElse TextBoxMod.Text = String.Empty OrElse TextBoxCap.Text = String.Empty Then
            MsgBox("No deje campos vacíos.")
        Else
            If Not Regex.IsMatch(TextBoxCap.Text, "^[0-9 ]+$") OrElse Integer.Parse(TextBoxCap.Text) < 1 OrElse Integer.Parse(TextBoxCap.Text) > 30 Then
                MsgBox("La capacidad debe ser válida")
            Else

                Dim sentencia As String


                Try

                    sentencia = "INSERT INTO `camioneta` (`matricula_camioneta`, `marca_camioneta`, `modelo_camioneta`, `capacidad_camioneta`) VALUES ('" & TextBoxMat.Text.ToLower & "', '" & TextBoxMar.Text.ToLower & "', '" & TextBoxMod.Text.ToLower & "', " & TextBoxCap.Text & ");"

                    Dim comando As New MySqlCommand



                    comando = New MySqlCommand(sentencia, Guau.conk)



                    comando.ExecuteNonQuery()



                    MsgBox("Se agregó exitosamente al vehículo.")
                    ListAllVehicles()
                    cleanFields()
                Catch ex As Exception

                    MsgBox("Ocurrió un error en el ingreso de datos." & ex.Message)



                End Try
            End If
        End If
    End Sub

    Private Sub cleanFields()
        TextBoxMat.Text = ""
        TextBoxMar.Text = ""
        TextBoxMod.Text = ""
        TextBoxCap.Text = ""
    End Sub

    Private Sub AgregarVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListAllVehicles()
    End Sub

    Private Sub ListAllVehicles()
        Dim consulta As String
        consulta = "Select UPPER(matricula_camioneta) From camioneta;"

        Dim comando As New MySqlCommand(consulta, Guau.conk)

        Dim drd As MySqlDataReader
        If IsNothing(drd) = False Then
            drd.Close()

        End If
        If Guau.conk.State.Open Then
            Guau.conk.Close()
            Guau.conk.Open()

        Else
            Guau.conk.Open()
        End If
        drd = comando.ExecuteReader






        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Try
            While drd.HasRows()


                While drd.Read()

                    ListBox1.Items.Add(drd.GetString(0))
                    ListBox2.Items.Add(drd.GetString(0))

                End While

                drd.NextResult()

            End While
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado. Intente más tarde.")
        End Try
        drd.Close()

    End Sub
    Private Sub DeleteVehicle()

        Try
            If ListBox1.Items.Count = 0 Then
                MsgBox("Lo sentimos pero no hay ítems disponibles.")
            Else
                If ListBox1.SelectedItem = Nothing Then
                    MsgBox("Debe seleccionar un ítem!")
                Else
                    Dim selectedMatricula As String
                    selectedMatricula = ListBox1.SelectedItem.ToString.ToLower


                    Dim sentenciaBorrarUno As String = "DELETE FROM `camioneta` WHERE (`matricula_camioneta` = '" & selectedMatricula & "');"
                    Dim comandoUno As New MySqlCommand
                    comandoUno = New MySqlCommand(sentenciaBorrarUno, Guau.conk)
                    comandoUno.ExecuteNonQuery()
                    MsgBox("Éxito en el borrado.")
                    ListAllVehicles()
                End If
            End If


        Catch ex As Exception
            MsgBox("Error en el borrado. Intente más tarde." & ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DeleteVehicle()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If loadedToModifyMatricula = "None" Then
            MsgBox("Seleccione y cargue los datos de un automóvil")
        Else
            modifyVehicle()
            loadedToModifyMatricula = "None"
        End If

    End Sub

    Private Sub modifyVehicle()
        If TextBoxMar.Text = String.Empty OrElse TextBoxMod.Text = String.Empty OrElse TextBoxCap.Text = String.Empty Then
            MsgBox("No deje campos vacíos.")
        Else
            If Not Regex.IsMatch(TextBoxCap.Text, "^[0-9 ]+$") OrElse Integer.Parse(TextBoxCap.Text) < 1 OrElse Integer.Parse(TextBoxCap.Text) > 30 Then
                MsgBox("La capacidad debe ser válida")
            Else

                Dim sentencia As String


                Try

                    sentencia = "INSERT INTO `camioneta` (`matricula_camioneta`, `marca_camioneta`, `modelo_camioneta`, `capacidad_camioneta`) VALUES ('" & TextBoxMat.Text.ToLower & "', '" & TextBoxMar.Text.ToLower & "', '" & TextBoxMod.Text.ToLower & "', " & TextBoxCap.Text & ");"
                    sentencia = "UPDATE `mkarszensztejn`.`camioneta` SET `marca_camioneta` = '" & TextBoxMar.Text.ToLower & "', `modelo_camioneta` = '" & TextBoxMod.Text.ToLower & "', `capacidad_camioneta` = " & TextBoxCap.Text & " WHERE (`matricula_camioneta` = '" & TextBoxMat.Text.ToLower & "');"
                    Dim comando As New MySqlCommand



                    comando = New MySqlCommand(sentencia, Guau.conk)



                    comando.ExecuteNonQuery()



                    MsgBox("Se agregó exitosamente al vehículo.")
                    ListAllVehicles()
                    cleanFields()
                    UnLoadToModify()


                Catch ex As Exception

                    MsgBox("Ocurrió un error en el ingreso de datos." & ex.Message)



                End Try
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonLoadToModify.Click
        If loadedToModifyMatricula = "None" Then
            LoadToModify()
        Else
            UnLoadToModify()
        End If


    End Sub

    Private Sub UnLoadToModify()
        cleanFields()
        ButtonLoadToModify.Text = "Cargar Para Modificar"
        Button2.Enabled = True
        TextBoxMat.ReadOnly = False
        loadedToModifyMatricula = "None"
    End Sub

    Private Sub LoadToModify()
        Try
            If ListBox2.Items.Count = 0 Then
                MsgBox("Lo sentimos pero no hay ítems disponibles.")
            Else
                If ListBox2.SelectedItem = Nothing Then
                    MsgBox("Debe seleccionar un ítem!")
                Else

                    Dim consulta As String
                    consulta = "Select * From camioneta WHERE matricula_camioneta = '" & ListBox2.SelectedItem.ToString.ToLower & "' ;"

                    Dim comando As New MySqlCommand(consulta, Guau.conk)

                    Dim drd As MySqlDataReader
                    If IsNothing(drd) = False Then
                        drd.Close()

                    End If
                    If Guau.conk.State.Open Then
                        Guau.conk.Close()
                        Guau.conk.Open()

                    Else
                        Guau.conk.Open()
                    End If
                    drd = comando.ExecuteReader



                    While drd.Read()

                        loadedToModifyMatricula = drd.GetString(0)
                        TextBoxMat.Text = loadedToModifyMatricula
                        TextBoxMar.Text = drd.GetString(1)
                        TextBoxMod.Text = drd.GetString(2)
                        TextBoxCap.Text = drd.GetString(3)
                        ButtonLoadToModify.Text = "Descargar Datos"
                        Button2.Enabled = False
                        TextBoxMat.ReadOnly = True

                    End While


                    If IsNothing(drd) = False Then
                        drd.Close()

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en la modificacion. Intente más tarde." & ex.Message)


        End Try

    End Sub
End Class