Public Class CrearReservas

    Private listaHorarios As Horario()
    Private listaHabitaciones As Habitacion()
    Private Sub CrearReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaHorarios = getHorarios()
        listaHabitaciones = getHabitacion()
        ListBoxRoom.Items.Clear()
        For index = 0 To listaHabitaciones.Length - 2
            ListBoxRoom.Items.Add(listaHabitaciones(index).nombre_tipo_hab.ToString)
        Next

        DateTimePickerA1.Format = DateTimePickerFormat.Custom
        DateTimePickerA2.Format = DateTimePickerFormat.Custom
        DateTimePickerA3.Format = DateTimePickerFormat.Custom
        DateTimePickerA4.Format = DateTimePickerFormat.Custom
        DateTimePickerR4.Format = DateTimePickerFormat.Custom
        DateTimePickerR3.Format = DateTimePickerFormat.Custom
        DateTimePickerR1.Format = DateTimePickerFormat.Custom
        DateTimePickerR2.Format = DateTimePickerFormat.Custom
        DateTimePickerA1.CustomFormat = "dd/MM/yyyy"
        DateTimePickerR1.CustomFormat = "dd/MM/yyyy"
        DateTimePickerA2.CustomFormat = "HH:mm"
        DateTimePickerR2.CustomFormat = "HH:mm"
        DateTimePickerA3.CustomFormat = "HH:mm"
        DateTimePickerR3.CustomFormat = "HH:mm"
        DateTimePickerA4.CustomFormat = "HH:mm"
        DateTimePickerR4.CustomFormat = "HH:mm"
        DateTimePickerA2.ShowUpDown = True
        DateTimePickerR2.ShowUpDown = True
        DateTimePickerA3.ShowUpDown = True
        DateTimePickerR3.ShowUpDown = True
        DateTimePickerA4.ShowUpDown = True
        DateTimePickerR4.ShowUpDown = True
        DateTimePickerA1.MinDate = Now
        DateTimePickerR1.MinDate = Now
        Dim mascota() As Mascota = GetAllPets()
        For index = 0 To mascota.Length - 2
            ListBoxMasc.Items.Add(mascota(index).num_mascota & " - " & mascota(index).nombre_mascota)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ListBoxMasc.SelectedItem = 1
        ListBoxRoom.SelectedItem = 1
        DateTimePickerA1.Value = DateTime.Now
        DateTimePickerA2.Value = DateTime.Now
        DateTimePickerA3.Value = DateTime.Now
        DateTimePickerA4.Value = DateTime.Now
        DateTimePickerR1.Value = DateTime.Now
        DateTimePickerR2.Value = DateTime.Now
        DateTimePickerR3.Value = DateTime.Now
        DateTimePickerR4.Value = DateTime.Now
        CheckBoxIda.Checked = False
        CheckBoxDogTV.Checked = False
        CheckBoxWebcam.Checked = False
        CheckBoxVuelta.Checked = False
        RadioButtonCont.Checked = False
        RadioButtonCC.Checked = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Guau.AbrirFormEnPanel(New AgregarMascota)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddBooking.Click
        addBooking()
    End Sub

    Private Sub addBooking()
        If ListBoxMasc.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar mascota")
        Else
            If DateTimePickerR1.Value < DateTimePickerA1.Value Then
                MsgBox("La fecha de retorno no puede ser anterior a la de arribo")
            Else
                Dim horaPermitida As Boolean = False
                Dim horaPermIda As Boolean = False
                Dim horaPermVuelta As Boolean = False
                Dim localHorarios As Horario() = listaHorarios

                For index = 0 To localHorarios.Length - 2


                    Dim hrs As String = ""
                    Dim minutos As String = ""
                    hrs = localHorarios(index).hora_inicio.ToString.Chars(9)
                    hrs = hrs & localHorarios(index).hora_inicio.ToString.Chars(10)
                    minutos = localHorarios(index).hora_inicio.ToString.Chars(12)
                    minutos = minutos & localHorarios(index).hora_inicio.ToString.Chars(13)
                    Dim anio2 = DateTimePickerA2.Value.Year
                    Dim mess2 = DateTimePickerA2.Value.Month
                    Dim diaa2 = DateTimePickerA2.Value.Day
                    Dim minimo As DateTime
                    minimo = Nothing
                    minimo = New DateTime(anio2, mess2, diaa2, hrs, minutos, 0)


                    Dim hrs2 As String = ""
                    Dim minutos2 As String = ""
                    hrs2 = localHorarios(index).hora_fin.ToString.Chars(9)
                    hrs2 = hrs2 & localHorarios(index).hora_fin.ToString.Chars(10)


                    minutos2 = localHorarios(index).hora_fin.ToString.Chars(12)
                    minutos2 = minutos2 & localHorarios(index).hora_fin.ToString.Chars(13)
                    Dim anio = DateTimePickerR2.Value.Year
                    Dim mess = DateTimePickerR2.Value.Month
                    Dim diaa = DateTimePickerR2.Value.Day
                    Dim maximo As DateTime
                    maximo = Nothing
                    maximo = New DateTime(anio, mess, diaa, hrs2, minutos2, 0)




                    If DateTimePickerA2.Value > minimo And DateTimePickerA2.Value < maximo And DateTimePickerR2.Value > minimo And DateTimePickerR2.Value < maximo Then
                        horaPermitida = True
                    End If
                Next
                If horaPermitida = False Then
                    MsgBox("No puede realizar el CheckIn y/o el CheckOut a esa hora. Consulte los horarios para mas informacion.")
                Else
                    horaPermIda = False
                    For index = 0 To localHorarios.Length - 2


                        Dim hrs3 As String = ""
                        Dim minutos3 As String = ""
                        hrs3 = localHorarios(index).hora_inicio.ToString.Chars(9)
                        hrs3 = hrs3 & localHorarios(index).hora_inicio.ToString.Chars(10)
                        minutos3 = localHorarios(index).hora_inicio.ToString.Chars(12)
                        minutos3 = minutos3 & localHorarios(index).hora_inicio.ToString.Chars(13)
                        Dim anio3 = DateTimePickerA3.Value.Year
                        Dim mess3 = DateTimePickerA3.Value.Month
                        Dim diaa3 = DateTimePickerA3.Value.Day
                        Dim minimo3 As DateTime
                        minimo3 = Nothing
                        minimo3 = New DateTime(anio3, mess3, diaa3, hrs3, minutos3, 0)


                        Dim hrs4 As String = ""
                        Dim minutos4 As String = ""
                        hrs4 = localHorarios(index).hora_fin.ToString.Chars(9)
                        hrs4 = hrs4 & localHorarios(index).hora_fin.ToString.Chars(10)


                        minutos4 = localHorarios(index).hora_fin.ToString.Chars(12)
                        minutos4 = minutos4 & localHorarios(index).hora_fin.ToString.Chars(13)
                        Dim anio4 = DateTimePickerR3.Value.Year
                        Dim mess4 = DateTimePickerR3.Value.Month
                        Dim diaa4 = DateTimePickerR3.Value.Day
                        Dim maximo4 As DateTime
                        maximo4 = Nothing
                        maximo4 = New DateTime(anio4, mess4, diaa4, hrs4, minutos4, 0)




                        If DateTimePickerA3.Value > minimo3 And DateTimePickerA3.Value < maximo4 And DateTimePickerR3.Value > minimo3 And DateTimePickerR3.Value < maximo4 Then
                            horaPermIda = True
                        End If
                    Next
                    If horaPermIda = False Then
                        MsgBox("No puede realizar el traslado a ese horario. Consulte los horarios para mas informacion.")
                    Else
                        horaPermVuelta = False
                        For index = 0 To localHorarios.Length - 2


                            Dim hrs5 As String = ""
                            Dim minutos5 As String = ""
                            hrs5 = localHorarios(index).hora_inicio.ToString.Chars(9)
                            hrs5 = hrs5 & localHorarios(index).hora_inicio.ToString.Chars(10)
                            minutos5 = localHorarios(index).hora_inicio.ToString.Chars(12)
                            minutos5 = minutos5 & localHorarios(index).hora_inicio.ToString.Chars(13)
                            Dim anio5 = DateTimePickerA4.Value.Year
                            Dim mess5 = DateTimePickerA4.Value.Month
                            Dim diaa5 = DateTimePickerA4.Value.Day
                            Dim minimo5 As DateTime
                            minimo5 = Nothing
                            minimo5 = New DateTime(anio5, mess5, diaa5, hrs5, minutos5, 0)


                            Dim hrs6 As String = ""
                            Dim minutos6 As String = ""
                            hrs6 = localHorarios(index).hora_fin.ToString.Chars(9)
                            hrs6 = hrs6 & localHorarios(index).hora_fin.ToString.Chars(10)


                            minutos6 = localHorarios(index).hora_fin.ToString.Chars(12)
                            minutos6 = minutos6 & localHorarios(index).hora_fin.ToString.Chars(13)
                            Dim anio6 = DateTimePickerR4.Value.Year
                            Dim mess6 = DateTimePickerR4.Value.Month
                            Dim diaa6 = DateTimePickerR4.Value.Day
                            Dim maximo6 As DateTime
                            maximo6 = Nothing
                            maximo6 = New DateTime(anio6, mess6, diaa6, hrs6, minutos6, 0)




                            If DateTimePickerA4.Value > minimo5 And DateTimePickerA4.Value < maximo6 And DateTimePickerR4.Value > minimo5 And DateTimePickerR4.Value < maximo6 Then
                                horaPermVuelta = True
                            End If
                        Next
                        If horaPermVuelta = False Then
                            MsgBox("No puede realizar el traslado de retorno a ese horario. Consulte los horarios para mas informacion.")
                        Else
                            MsgBox("SIIIIIIIIII :P")
                            If RadioButtonCC.Checked = False And RadioButtonCont.Checked = False Then
                                MsgBox("Debe seleccionar el metodo de pago.")
                            Else

                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub


End Class