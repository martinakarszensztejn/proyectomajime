Imports MySql.Data.MySqlClient

Public Class SalidaVehiculos
    Private transList As Transporta()
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If

    End Sub


    Private Sub SalidaVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "HH:mm"
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.Value = Now
        UpdateList()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addNew(1)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addNew(2)
    End Sub

    Private Sub addNew(accion As Integer)
        If ListBox1.Items.Count = 0 Then
            MsgBox("Lo sentimos. No hay transportes registrados, por lo que no se puede confirmar el movimiento.")
        Else
            Dim horaSelectE_S As String
            If ListBox1.SelectedIndex <> -1 Then

                If DateTimePicker1.Value.Hour < 10 Then
                    horaSelectE_S = "0"
                    horaSelectE_S = horaSelectE_S & DateTimePicker1.Value.Hour & ":"
                Else
                    horaSelectE_S = DateTimePicker1.Value.Hour & ":"
                End If

                If DateTimePicker1.Value.Minute < 10 Then
                    horaSelectE_S = horaSelectE_S & "0"
                End If
                horaSelectE_S = horaSelectE_S & DateTimePicker1.Value.Minute & ":00"
                Dim num_periodo_sel As Integer
                Dim horariosList = getHorarios()
                
                For index = 0 To horariosList.Length - 2
                    If horariosList(index).hora_inicio < horaSelectE_S AndAlso horariosList(index).hora_fin > horaSelectE_S Then
                        num_periodo_sel = horariosList(index).num_periodo
                    End If
                Next
                Dim diaSelE_S As String
                diaSelE_S = DateTimePicker1.Value.Year & "-"
                If DateTimePicker1.Value.Month < 10 Then
                    diaSelE_S = diaSelE_S & "0"
                End If
                diaSelE_S = diaSelE_S & DateTimePicker1.Value.Month & "-"
                If DateTimePicker1.Value.Day < 10 Then
                    diaSelE_S = diaSelE_S & "0"
                End If
                diaSelE_S = diaSelE_S & DateTimePicker1.Value.Day & " "

                horaSelectE_S = diaSelE_S & horaSelectE_S



                Dim sentencia As String
                Dim movimiento As String
                If accion = 1 Then
                    movimiento = "Salida"
                ElseIf accion = 2 Then
                    movimiento = "Entrada"
                Else
                    movimiento = "No registrado."
                End If

                Try
                    Dim num_masc_sel As Integer
                    Dim mom_cread_trans As String
                    Dim matricula_auto As String


                    For index = 0 To ListBox1.SelectedIndex
                        num_masc_sel = transList(index).num_mascota
                        matricula_auto = transList(index).matricula_camioneta
                        mom_cread_trans = transList(index).momento_creado_transporte.Year & "-"
                        If transList(index).momento_creado_transporte.Month < 10 Then
                            mom_cread_trans = mom_cread_trans & "0"
                        End If
                        mom_cread_trans = mom_cread_trans & transList(index).momento_creado_transporte.Month & "-"
                        If transList(index).momento_creado_transporte.Day < 10 Then
                            mom_cread_trans = mom_cread_trans & "0"
                        End If
                        mom_cread_trans = mom_cread_trans & transList(index).momento_creado_transporte.Day & " "

                        If transList(index).momento_creado_transporte.Hour < 10 Then
                            mom_cread_trans = mom_cread_trans & "0"
                        End If
                        mom_cread_trans = mom_cread_trans & transList(index).momento_creado_transporte.Hour & ":"
                        If transList(index).momento_creado_transporte.Minute < 10 Then
                            mom_cread_trans = mom_cread_trans & "0"
                        End If
                        mom_cread_trans = mom_cread_trans & transList(index).momento_creado_transporte.Minute & ":"
                        If transList(index).momento_creado_transporte.Second < 10 Then
                            mom_cread_trans = mom_cread_trans & "0"
                        End If
                        mom_cread_trans = mom_cread_trans & transList(index).momento_creado_transporte.Second

                    Next


                    If Guau.rangoUsuario = Guau.rangos(2) Then
                        sentencia = "INSERT INTO `mkarszensztejn`.`confirma e-s` (`num_mascota`, `momento_creado_transporte`, `matricula_camioneta`, `tipo_movimiento_e-s`, `num_periodo`, `ci_recepcionista`, `momento_e-s`) 
                VALUES (" & num_masc_sel & ", '" & mom_cread_trans & "', '" & matricula_auto & "', '" & movimiento & "', " & num_periodo_sel & ", '" & Guau.ci_usuario & "', '" & horaSelectE_S & "');"
                    ElseIf Guau.rangoUsuario = Guau.rangos(0) Then
                        sentencia = "INSERT INTO `mkarszensztejn`.`confirma e-s` (`num_mascota`, `momento_creado_transporte`, `matricula_camioneta`, `tipo_movimiento_e-s`, `num_periodo`, `ci_gerente`, `momento_e-s`) 
                VALUES (" & num_masc_sel & ", '" & mom_cread_trans & "', '" & matricula_auto & "', '" & movimiento & "', " & num_periodo_sel & ", '" & Guau.ci_usuario & "', '" & horaSelectE_S & "');"

                    End If

                    Dim comando As New MySqlCommand



                    comando = New MySqlCommand(sentencia, Guau.conk)



                    comando.ExecuteNonQuery()



                    MsgBox("Se confirmó exitosamente.")
                    UpdateList()
                Catch ex As Exception

                    MsgBox("Ocurrió un error en el ingreso de datos." & ex.Message)



                End Try


            Else
                MsgBox("Debe seleccionar un traslado")
            End If
        End If
    End Sub

    Private Sub UpdateList()
        transList = getTransporte()


        ListBox1.Items.Clear()

        For index = 0 To transList.Length - 2
            ListBox1.Items.Add("MASC N° " & transList(index).num_mascota & " Auto " & transList(index).matricula_camioneta & " Creado " & transList(index).momento_creado_transporte)
        Next
    End Sub
End Class