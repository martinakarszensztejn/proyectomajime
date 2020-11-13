Imports MySql.Data.MySqlClient

Public Class VerHorarios

    Private horariosList As Horario()
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If
    End Sub

    Private Sub VerHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerIni.Format = DateTimePickerFormat.Custom
        DateTimePickerFin.Format = DateTimePickerFormat.Custom
        DateTimePickerIni.CustomFormat = "HH:mm"
        DateTimePickerFin.CustomFormat = "HH:mm"
        DateTimePickerIni.ShowUpDown = True
        DateTimePickerFin.ShowUpDown = True
        UpdateList()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim selectedIndex = ListBox1.SelectedIndex
        Dim idSel As Integer
        idSel = -1
        For index = 0 To selectedIndex
            idSel = horariosList(index).num_periodo
        Next
        If idSel = -1 Then
            MsgBox("Error obteniendo el periodo seleccionado.")
        Else
            Try





                Dim sentenciaBorrarUno As String = "DELETE FROM `horario_hotel` WHERE (`num_periodo` = " & idSel & ");"
                Dim comandoUno As New MySqlCommand
                comandoUno = New MySqlCommand(sentenciaBorrarUno, Guau.conk)
                comandoUno.ExecuteNonQuery()
                MsgBox("Exito en el borrado")
                UpdateList()







            Catch ex As Exception
                MsgBox("Error en el borrado. Intente más tarde." & ex.Message)
            End Try
        End If
    End Sub

    Private Sub UpdateList()
        horariosList = getHorarios()
        ListBox1.Items.Clear()

        For index = 0 To horariosList.Length - 2
            ListBox1.Items.Add(horariosList(index).hora_inicio & " HASTA " & horariosList(index).hora_fin)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If DateTimePickerFin.Value > DateTimePickerIni.Value Then
            Dim horaIni As String
            Dim horaFin As String
            Dim foundError As Boolean
            foundError = False
            horaIni = DateTimePickerIni.Value.Hour & ":" & DateTimePickerIni.Value.Minute & ":00"
            horaFin = DateTimePickerFin.Value.Hour & ":" & DateTimePickerFin.Value.Minute & ":00"
            For index = 0 To horariosList.Length - 2
                If ((horaIni > horariosList(index).hora_inicio And horaFin < horariosList(index).hora_fin) Or (horaIni > horariosList(index).hora_inicio And horaIni < horariosList(index).hora_fin) Or (horaFin < horariosList(index).hora_fin And horaFin > horariosList(index).hora_inicio)) Then
                    foundError = True
                End If
            Next
            If foundError = False Then


                Try
                    Dim sentencia As String
                    sentencia = "INSERT INTO `horario_hotel` (`hora_inicio_horario`, `hora_fin_horario`) VALUES ('" & horaIni & "', '" & horaFin & "');"


                    Dim comando As New MySqlCommand



                    comando = New MySqlCommand(sentencia, Guau.conk)



                    comando.ExecuteNonQuery()



                    MsgBox("Se agregó exitosamente al horario.")
                    DateTimePickerFin.Value = Now
                    DateTimePickerIni.Value = Now
                    UpdateList()
                Catch ex As Exception

                    MsgBox("Ocurrió un error en el ingreso de datos." & ex.Message)



                End Try
            Else
                MsgBox("Ya se encuentra registrado un horario de trabajo en ese período de tiempo.")

            End If
        Else
            MsgBox("La hora seleccionada no es válida.")
        End If
    End Sub
End Class