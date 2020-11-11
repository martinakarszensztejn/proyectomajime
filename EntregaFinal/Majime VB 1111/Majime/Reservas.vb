Imports MySql.Data.MySqlClient

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
        DateTimePickerA1.CustomFormat = "yyyy-MM-dd"
        DateTimePickerR1.CustomFormat = "yyyy-MM-dd"
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
            ListBoxMasc.Items.Add(mascota(index).nombre_mascota & " - ID: " & mascota(index).num_mascota)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cleanFields()

    End Sub

    Private Sub cleanFields()

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
        CheckBoxDogTV.Enabled = False
        CheckBoxWebcam.Enabled = False
        ListBoxMasc.SelectedIndex = -1
        ListBoxRoom.SelectedIndex = -1
        Label10.Text = "N° Habitación:"
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

    Private Function calculatePrice() As Double
        Dim preciosList = getPrices()
        Dim validPricePerDay As Double
        Dim finalPrice As Double
        finalPrice = -1
        If ListBoxRoom.SelectedIndex > -1 Then
            Dim cantidadPets As New Int16
            cantidadPets = 0
            For index = 0 To ListBoxMasc.Items.Count - 1
                If ListBoxMasc.GetSelected(index) = True Then
                    cantidadPets = cantidadPets + 1
                End If
            Next

            For index = 0 To preciosList.Length - 2
                If ListBoxRoom.SelectedItem = preciosList(index).tipo_hab Then
                    If cantidadPets = 1 Then
                        validPricePerDay = preciosList(index).precio_1m
                    ElseIf cantidadPets = 2 Then
                        validPricePerDay = preciosList(index).precio_2m
                    ElseIf cantidadPets > 2 Then
                        validPricePerDay = preciosList(index).precio_3m
                    Else
                        MsgBox("La cantidad de mascotas seleccionadas no fue válida. Debe seleccionar al menos una.")
                    End If

                    Dim periodoEstadia As New TimeSpan()
                    periodoEstadia = DateTimePickerR1.Value - DateTimePickerA1.Value
                    Dim diasEstadia = Math.Ceiling(periodoEstadia.TotalDays)

                    finalPrice = (diasEstadia * validPricePerDay)

                    If ListBoxRoom.SelectedItem = "Suite" Then
                        If CheckBoxDogTV.Checked Then
                            finalPrice = finalPrice + (diasEstadia * 2)
                        End If
                        If CheckBoxWebcam.Checked Then
                            finalPrice = finalPrice + (diasEstadia * 4)
                        End If
                    End If

                End If
            Next

        End If

        Return finalPrice
    End Function


    Private Sub addBooking()
        Label10.Text = "N° Habitación:"
        If ListBoxMasc.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar mascota")
        Else
            If DateTimePickerR1.Value < DateTimePickerA1.Value Then
                MsgBox("La fecha de retorno no puede ser anterior a la de arribo")
            Else
                Dim hay_selecto As Boolean = False
                For index = 0 To ListBoxRoom.Items.Count - 1
                    If ListBoxRoom.SelectedIndex = index Then
                        hay_selecto = True
                    End If
                Next
                If hay_selecto = False Then
                    MsgBox("Debe seleccionar un tipo de habitación para la mascota.")
                Else
                    If RadioButtonCC.Checked = False And RadioButtonCont.Checked = False Then
                        MsgBox("Debe seleccionar el metodo de pago.")
                    Else
                        Dim fechaSalidaSelected As New DateTime(DateTimePickerR1.Value.Year, DateTimePickerR1.Value.Month, DateTimePickerR1.Value.Day, DateTimePickerR2.Value.Hour, DateTimePickerR2.Value.Minute, DateTimePickerR2.Value.Second)
                        Dim fechaArriboSelected As New DateTime(DateTimePickerA1.Value.Year, DateTimePickerA1.Value.Month, DateTimePickerA1.Value.Day, DateTimePickerA2.Value.Hour, DateTimePickerA2.Value.Minute, DateTimePickerA2.Value.Second)
                        Dim selTransDateIdaInicio As DateTime
                        Dim selTransDateIdaFin As DateTime
                        Dim selTransDateVueltaInicio As DateTime
                        Dim selTransDateVueltaFin As DateTime
                        Dim horaPermitida As Boolean = False
                        Dim horaPermIda As Boolean = False
                        Dim horaPermVuelta As Boolean = False
                        Dim localHorarios As Horario() = listaHorarios
                        Dim potencialHab As New List(Of Int32)


                        Dim autosOcupadosListIda As New List(Of String)
                        Dim potencialAutoListIda As New List(Of String)
                        Dim autosOcupadosListVuelta As New List(Of String)
                        Dim potencialAutoListVuelta As New List(Of String)
                        potencialHab.Clear()
                        Dim allTransportes = getTransporte()
                        Dim allCamionetas = getCamioneta()

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
                            MsgBox("No puede realizar el CheckIn y/o el CheckOut a esa hora. Consulte los horarios para mas informacion. (1)")
                        Else
                            Dim errorIdaTrans As Boolean
                            Dim errorVueltaTrans As Boolean
                            errorIdaTrans = False
                            errorVueltaTrans = False
                            errorIdaTrans = False
                            errorVueltaTrans = False
                            If CheckBoxIda.Checked = True Then
                                Dim hrs3 As String = ""
                                Dim minutos3 As String = ""
                                Dim hrs4 As String = ""
                                Dim minutos4 As String = ""

                                horaPermIda = False
                                For index = 0 To localHorarios.Length - 2



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

                                selTransDateIdaInicio = New DateTime(fechaArriboSelected.Year, fechaArriboSelected.Month, fechaArriboSelected.Day, DateTimePickerA3.Value.Hour, DateTimePickerA3.Value.Minute, 0)

                                selTransDateIdaFin = New DateTime(fechaArriboSelected.Year, fechaArriboSelected.Month, fechaArriboSelected.Day, DateTimePickerR3.Value.Hour, DateTimePickerR3.Value.Minute, 0)

                                Dim giveRandomAutoIda As Int16
                                giveRandomAutoIda = 0
                                autosOcupadosListIda.Clear()

                                If allTransportes.Length > 1 Then


                                    For index = 0 To allTransportes.Length - 2
                                        If ((selTransDateIdaInicio > allTransportes(index).momento_inicio_transporte And selTransDateIdaFin < allTransportes(index).momento_fin_transporte) Or (selTransDateIdaInicio > allTransportes(index).momento_inicio_transporte And selTransDateIdaInicio < allTransportes(index).momento_fin_transporte) Or (selTransDateIdaFin < allTransportes(index).momento_fin_transporte And selTransDateIdaFin > allTransportes(index).momento_inicio_transporte)) Then



                                            For j = 0 To allTransportes.Length - 2
                                                If allTransportes(index).matricula_camioneta <> allTransportes(j).matricula_camioneta Then
                                                    Try
                                                        If autosOcupadosListIda.Count > index Then
                                                            For k = 0 To autosOcupadosListIda.Count - 2
                                                                If allTransportes(j).matricula_camioneta = autosOcupadosListIda.ElementAt(k) Then
                                                                    autosOcupadosListIda.Remove(j)

                                                                End If
                                                            Next
                                                        End If
                                                    Catch ex As Exception
                                                        MsgBox("Ocurrió un error grave. Lo sentimos")
                                                    End Try
                                                Else

                                                    autosOcupadosListIda.Add(allTransportes(j).matricula_camioneta)

                                                    giveRandomAutoIda = 2
                                                    errorIdaTrans = False
                                                End If
                                            Next
                                        Else
                                            If giveRandomAutoIda <> 2 And giveRandomAutoIda <> 1 Then
                                                giveRandomAutoIda = 1

                                            End If


                                        End If


                                    Next
                                Else
                                    giveRandomAutoIda = 1
                                End If
                                potencialAutoListIda.Clear()

                                For index = 0 To allCamionetas.Count - 2
                                    If autosOcupadosListIda.Contains(allCamionetas(index).matricula) = False Then

                                        potencialAutoListIda.Add(allCamionetas(index).matricula)

                                    End If
                                Next
                                If giveRandomAutoIda = 1 Then
                                    If IsNothing(allCamionetas(0).matricula) = False Then
                                        potencialAutoListIda.Add(allCamionetas(0).matricula)
                                        errorIdaTrans = False
                                    Else
                                        MsgBox("No se encuentra el registro de ningún vehiculo. Por favor agregue uno antes de asignar reservas.")
                                        errorIdaTrans = True
                                    End If
                                ElseIf giveRandomAutoIda = 0 Then
                                    MsgBox("Lo sentimos. No se encuentran vehículos con disponibilidad horaria en dicho momento. ")
                                    errorIdaTrans = True
                                End If
                            Else

                                horaPermIda = True
                            End If
                            If horaPermIda = False Then
                                MsgBox("No puede realizar el traslado a ese horario. Consulte los horarios para mas informacion. (2)")
                            Else
                                If CheckBoxVuelta.Checked = True Then
                                    Dim hrs6 As String = ""
                                    Dim minutos6 As String = ""
                                    Dim hrs5 As String = ""
                                    Dim minutos5 As String = ""

                                    horaPermVuelta = False
                                    For index = 0 To localHorarios.Length - 2



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
                                    '''''''''''''''''''''''''''
                                    selTransDateVueltaInicio = New DateTime(fechaSalidaSelected.Year, fechaSalidaSelected.Month, fechaSalidaSelected.Day, DateTimePickerA4.Value.Hour, DateTimePickerA4.Value.Minute, 0)

                                    selTransDateVueltaFin = New DateTime(fechaSalidaSelected.Year, fechaSalidaSelected.Month, fechaSalidaSelected.Day, DateTimePickerR4.Value.Hour, DateTimePickerR4.Value.Minute, 0)

                                    Dim giveRandomAutoVuelta As Int16
                                    giveRandomAutoVuelta = 0
                                    autosOcupadosListVuelta.Clear()

                                    If allTransportes.Length > 1 Then


                                        For index = 0 To allTransportes.Length - 2
                                            If ((selTransDateVueltaInicio > allTransportes(index).momento_inicio_transporte And selTransDateVueltaFin < allTransportes(index).momento_fin_transporte) Or (selTransDateVueltaInicio > allTransportes(index).momento_inicio_transporte And selTransDateVueltaInicio < allTransportes(index).momento_fin_transporte) Or (selTransDateVueltaFin < allTransportes(index).momento_fin_transporte And selTransDateVueltaFin > allTransportes(index).momento_inicio_transporte)) Then



                                                For j = 0 To allTransportes.Length - 2
                                                    If allTransportes(index).matricula_camioneta <> allTransportes(j).matricula_camioneta Then
                                                        Try
                                                            If autosOcupadosListVuelta.Count > index Then
                                                                For k = 0 To autosOcupadosListVuelta.Count - 2
                                                                    If allTransportes(j).matricula_camioneta = autosOcupadosListVuelta.ElementAt(k) Then
                                                                        autosOcupadosListVuelta.Remove(j)

                                                                    End If
                                                                Next
                                                            End If
                                                        Catch ex As Exception
                                                            MsgBox("Ocurrió un error grave. Lo sentimos")
                                                        End Try
                                                    Else

                                                        autosOcupadosListVuelta.Add(allTransportes(j).matricula_camioneta)

                                                        giveRandomAutoVuelta = 2
                                                        errorVueltaTrans = False
                                                    End If
                                                Next
                                            Else
                                                If giveRandomAutoVuelta <> 2 And giveRandomAutoVuelta <> 1 Then
                                                    giveRandomAutoVuelta = 1

                                                End If


                                            End If


                                        Next
                                    Else
                                        giveRandomAutoVuelta = 1
                                    End If
                                    potencialAutoListVuelta.Clear()

                                    For index = 0 To allCamionetas.Count - 2
                                        If autosOcupadosListVuelta.Contains(allCamionetas(index).matricula) = False Then

                                            autosOcupadosListVuelta.Add(allCamionetas(index).matricula)
                                            MsgBox("LIBRE: " & autosOcupadosListVuelta.ElementAt(autosOcupadosListVuelta.Count - 1))
                                        End If
                                    Next
                                    If giveRandomAutoVuelta = 1 Then
                                        If IsNothing(allCamionetas(0).matricula) = False Then
                                            potencialAutoListVuelta.Add(allCamionetas(0).matricula)
                                            errorVueltaTrans = False
                                        Else
                                            MsgBox("No se encuentra el registro de ningún vehiculo. Por favor agregue uno antes de asignar reservas.")
                                            errorVueltaTrans = True
                                        End If
                                    ElseIf giveRandomAutoVuelta = 0 Then
                                        MsgBox("Lo sentimos. No se encuentran vehículos con disponibilidad horaria en dicho momento. ")
                                        errorVueltaTrans = True
                                    End If






                                    ''''''''''''''''''''''''''

                                Else

                                    horaPermVuelta = True
                                End If
                                If horaPermVuelta = False Then
                                    MsgBox("No puede realizar el traslado de retorno a ese horario. Consulte los horarios para mas informacion. (3)")
                                Else
                                    If errorIdaTrans = False AndAlso errorVueltaTrans = False Then



                                        Dim listaReservas As Hospeda() = getReservas()
                                        Dim idReservaNew As Integer
                                        idReservaNew = -1
                                        For index = 0 To listaReservas.Count - 2
                                            If listaReservas(index).num_reserva > idReservaNew Then
                                                idReservaNew = listaReservas(index).num_reserva
                                            End If
                                        Next
                                        If idReservaNew <> -1 Then
                                            idReservaNew = idReservaNew + 1

                                        End If
                                        Dim giveRandomRoom As Int16
                                        Dim cant_habs As Int16
                                        cant_habs = 0
                                        giveRandomRoom = 0
                                        For index = 0 To listaReservas.Length - 7
                                            Dim momento_arribo As String = listaReservas(index).momento_arribo_reserva.ToString
                                            Dim momento_salida As String = listaReservas(index).momento_partida_reserva.ToString
                                            If momento_arribo.Chars(1) = "/" Then
                                                momento_arribo = "0" & momento_arribo
                                            End If
                                            Dim dia As String = momento_arribo.Chars(0)
                                            dia = dia & momento_arribo.Chars(1)
                                            Dim mes As String = Nothing
                                            If momento_arribo.Chars(4) = "/" Then
                                                momento_arribo = "X" & momento_arribo
                                                mes = "0" & momento_arribo.Chars(4)
                                            Else

                                                mes = momento_arribo.Chars(3)
                                                mes = mes & momento_arribo.Chars(4)
                                            End If
                                            Dim anio As String = momento_arribo.Chars(6)
                                            anio = anio & momento_arribo.Chars(7)
                                            anio = anio & momento_arribo.Chars(8)
                                            anio = anio & momento_arribo.Chars(9)



                                            Dim fechaArriboDT As New Date(anio, mes, dia)


                                            If momento_salida.Chars(1) = "/" Then
                                                momento_salida = "0" & momento_salida
                                            End If
                                            Dim diaRSelected As String = momento_salida.Chars(0)
                                            diaRSelected = diaRSelected & momento_salida.Chars(1)
                                            Dim mesRSelected As String = Nothing
                                            If momento_salida.Chars(4) = "/" Then
                                                momento_salida = "X" & momento_salida
                                                mesRSelected = "0" & momento_salida.Chars(4)
                                            Else

                                                mesRSelected = momento_salida.Chars(3)
                                                mesRSelected = mesRSelected & momento_salida.Chars(4)
                                            End If
                                            Dim anioRSelected As String = momento_salida.Chars(6)
                                            anioRSelected = anioRSelected & momento_salida.Chars(7)
                                            anioRSelected = anioRSelected & momento_salida.Chars(8)
                                            anioRSelected = anioRSelected & momento_salida.Chars(9)
                                            Dim fechaPartidaDT As New Date(anioRSelected, mesRSelected, diaRSelected)





                                            If listaReservas(index).nombre_tipo_habitacion = "Suite" Or listaReservas(index).nombre_tipo_habitacion = "Junior Suite" Then
                                                cant_habs = 18
                                            ElseIf listaReservas(index).nombre_tipo_habitacion = "Estandar" Or listaReservas(index).nombre_tipo_habitacion = "Mini Suite" Then
                                                cant_habs = 24
                                            End If

                                            If ListBoxRoom.SelectedItem = listaReservas(index).nombre_tipo_habitacion AndAlso ((fechaArriboSelected > fechaArriboDT And fechaSalidaSelected < fechaPartidaDT) Or (fechaArriboSelected > fechaArriboDT And fechaArriboSelected < fechaPartidaDT) Or (fechaSalidaSelected < fechaPartidaDT And fechaSalidaSelected > fechaArriboDT)) Then






                                                For j = 1 To cant_habs
                                                    If listaReservas(index).num_hab <> j Then
                                                        Try
                                                            If potencialHab.Count > 0 Then
                                                                For k = 0 To potencialHab.Count - 2
                                                                    If j = potencialHab.ElementAt(k) Then
                                                                        potencialHab.Remove(j)

                                                                    End If
                                                                Next
                                                            End If
                                                        Catch ex As Exception
                                                            MsgBox("Ocurrió un error grave. Lo sentimos")
                                                        End Try


                                                        potencialHab.Add(j)
                                                        giveRandomRoom = 2
                                                    End If
                                                Next
                                            Else
                                                If giveRandomRoom <> 2 And giveRandomRoom <> 1 Then
                                                    giveRandomRoom = 1
                                                End If


                                            End If



                                        Next

                                        If giveRandomRoom = 0 Then
                                            MsgBox("Lo sentimos. Se encuentran todas las habitaciones en uso.")
                                        ElseIf giveRandomRoom = 1 Or giveRandomRoom = 2 Then
                                            If giveRandomRoom = 1 Then


                                                Dim habRand As New Random
                                                potencialHab.Add(habRand.Next(1, cant_habs + 1))
                                            End If


                                            If potencialHab.Count > 0 Then
                                                Dim varrr As String
                                                For index = 0 To potencialHab.Count - 1

                                                    If index = 0 Then
                                                        If Not potencialHab.ElementAt(index) = Nothing Then
                                                            varrr = potencialHab.ElementAt(index)
                                                        Else
                                                            varrr = "NADA"
                                                        End If

                                                    ElseIf index > 0 Then
                                                        varrr = varrr & " --- " & potencialHab.ElementAt(index)
                                                    Else
                                                        varrr = "Nadita"
                                                    End If



                                                Next


                                                Label10.Text = Label10.Text & " " & potencialHab.ElementAt(0)

                                                Dim fechaActual As String
                                                Dim mesHoyFix
                                                Dim diaHoyFix
                                                If Now.Month < 10 Then
                                                    mesHoyFix = "0" & Now.Month.ToString
                                                Else
                                                    mesHoyFix = Now.Month.ToString
                                                End If
                                                If Now.Day < 10 Then
                                                    diaHoyFix = "0" & Now.Day.ToString
                                                Else
                                                    diaHoyFix = Now.Day.ToString
                                                End If
                                                fechaActual = Now.Year.ToString & "-" & mesHoyFix & "-" & diaHoyFix & " " & Now.Hour & ":" & Now.Minute & ":0"
                                                Dim extrasSuite As New Int16
                                                extrasSuite = 0
                                                If ListBoxRoom.SelectedItem = "Suite" AndAlso CheckBoxDogTV.Checked AndAlso CheckBoxWebcam.Checked = False Then
                                                    extrasSuite = 1
                                                ElseIf ListBoxRoom.SelectedItem = "Suite" AndAlso CheckBoxDogTV.Checked AndAlso CheckBoxWebcam.Checked Then
                                                    extrasSuite = 3
                                                ElseIf ListBoxRoom.SelectedItem = "Suite" AndAlso CheckBoxDogTV.Checked = False AndAlso CheckBoxWebcam.Checked Then
                                                    extrasSuite = 2
                                                End If

                                                Dim modPag As New Int16
                                                If RadioButtonCC.Checked AndAlso RadioButtonCont.Checked = False Then
                                                    modPag = 1

                                                ElseIf RadioButtonCC.Checked = False AndAlso RadioButtonCont.Checked Then
                                                    modPag = 0
                                                Else
                                                    modPag = -1
                                                End If
                                                If modPag <> -1 Then

                                                    Dim presio = calculatePrice()

                                                    Dim sentenciaIns As String
                                                    Dim fechaArriboFormatSQL As String
                                                    Dim fechaPartidaFormatSQL As String
                                                    Dim mesFix1 As String
                                                    Dim mesFix2 As String
                                                    Dim diaFix1 As String
                                                    Dim diaFix2 As String
                                                    If DateTimePickerA1.Value.Month < 10 Then
                                                        mesFix1 = "0" & DateTimePickerA1.Value.Month
                                                    Else
                                                        mesFix1 = DateTimePickerA1.Value.Month
                                                    End If
                                                    If DateTimePickerR1.Value.Month < 10 Then
                                                        mesFix2 = "0" & DateTimePickerR1.Value.Month
                                                    Else
                                                        mesFix2 = DateTimePickerR1.Value.Month
                                                    End If
                                                    If DateTimePickerA1.Value.Day < 10 Then
                                                        diaFix1 = "0" & DateTimePickerA1.Value.Day
                                                    Else
                                                        diaFix1 = DateTimePickerA1.Value.Day
                                                    End If
                                                    If DateTimePickerR1.Value.Day < 10 Then
                                                        diaFix2 = "0" & DateTimePickerR1.Value.Day
                                                    Else
                                                        diaFix2 = DateTimePickerR1.Value.Day
                                                    End If


                                                    Dim hourfix1 As String
                                                    Dim hourfix2 As String
                                                    Dim minfix1 As String
                                                    Dim minfix2 As String
                                                    If DateTimePickerA2.Value.Hour < 10 Then
                                                        hourfix1 = "0" & DateTimePickerA2.Value.Hour
                                                    Else
                                                        hourfix1 = DateTimePickerA2.Value.Hour
                                                    End If
                                                    If DateTimePickerR2.Value.Hour < 10 Then
                                                        hourfix2 = "0" & DateTimePickerR2.Value.Hour
                                                    Else
                                                        hourfix2 = DateTimePickerR2.Value.Hour
                                                    End If
                                                    If DateTimePickerA2.Value.Minute < 10 Then
                                                        minfix1 = "0" & DateTimePickerA2.Value.Minute
                                                    Else
                                                        minfix1 = DateTimePickerA2.Value.Minute
                                                    End If
                                                    If DateTimePickerR2.Value.Minute < 10 Then
                                                        minfix2 = "0" & DateTimePickerR2.Value.Minute
                                                    Else
                                                        minfix2 = DateTimePickerR2.Value.Minute
                                                    End If

                                                    Dim segundero As Int16
                                                    segundero = 0
                                                    fechaArriboFormatSQL = DateTimePickerA1.Value.Year & "-" & mesFix1 & "-" & diaFix1 & " " & hourfix1 & ":" & minfix1 & ":0" & segundero
                                                    fechaPartidaFormatSQL = DateTimePickerR1.Value.Year & "-" & mesFix2 & "-" & diaFix2 & " " & hourfix2 & ":" & minfix2 & ":0" & segundero
                                                    Dim nomMascSelectedList As New List(Of String)
                                                    Dim foundResult As Boolean


                                                    For index = 0 To ListBoxMasc.Items.Count - 1
                                                        If ListBoxMasc.GetSelected(index) Then

                                                            nomMascSelectedList.Add(ListBoxMasc.Items(index))
                                                        End If
                                                    Next
                                                    Dim nomMascCorrectedList As New List(Of String)

                                                    For j = 0 To nomMascSelectedList.Count - 1
                                                        foundResult = False

                                                        For index = 0 To nomMascSelectedList(j).Length - 2
                                                            If foundResult = False Then


                                                                If nomMascCorrectedList.Count > j AndAlso nomMascCorrectedList(j).Length > 0 AndAlso nomMascSelectedList(j).Chars(index) <> " " AndAlso nomMascSelectedList(j).Chars(index + 1) <> "-" Then
                                                                    nomMascCorrectedList(j) = nomMascCorrectedList(j) & nomMascSelectedList(j).Chars(index)

                                                                ElseIf nomMascSelectedList(j).Chars(index) <> " " AndAlso nomMascSelectedList(j).Chars(index + 1) <> "-" AndAlso (nomMascCorrectedList.Count = j OrElse nomMascCorrectedList(j).Length = 0) Then
                                                                    nomMascCorrectedList.Add(nomMascSelectedList(j).Chars(index))
                                                                Else
                                                                    foundResult = True

                                                                End If


                                                            End If
                                                        Next
                                                        MsgBox(nomMascCorrectedList(j).ToString)
                                                    Next
                                                    If nomMascSelectedList.Count >= 1 And nomMascSelectedList.Count <= 3 Then

                                                        Dim exitoAgregado As Boolean

                                                        For index = 0 To nomMascSelectedList.Count - 1
                                                            exitoAgregado = False
                                                            idReservaNew = idReservaNew + index
                                                            segundero = segundero + index
                                                            If Guau.rangoUsuario = Guau.rangos(0) Then
                                                                sentenciaIns = " INSERT INTO `hospeda`  (`nombre_tipo_habitacion`, `num_hab`, `num_mascota`, `momento_arribo_reserva`, `momento_partida_reserva`, `num_reserva`, `momento_reserva`, `estado_reserva`, `extras_reserva`, `modalidad_pago_reserva`, `precio_reserva`,`ci_gerente`) 
                                                SELECT  (SELECT '" & ListBoxRoom.SelectedItem & "' AS p1),
		                                                (SELECT " & potencialHab.ElementAt(0) & " AS p2),
		                                                (SELECT num_mascota FROM mascota WHERE nombre_mascota = '" & nomMascCorrectedList.ElementAt(index) & "'),
                                                        (SELECT '" & fechaArriboFormatSQL & "' AS p4),
                                                        (SELECT '" & fechaPartidaFormatSQL & "' AS p5),
                                                        (SELECT " & idReservaNew & "),
                                                        (SELECT '" & fechaActual & segundero & "' AS p7),
                                                        (SELECT 'En Pie' AS p8),
                                                        (SELECT " & extrasSuite & " AS p9),
                                                        (SELECT " & modPag & " AS p10),
                                                        (SELECT " & presio & " AS p11),
                                                        (SELECT " & Guau.userUsuario & " AS p12)
		                                                AS parasd
                                                        ;"

                                                            ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
                                                                sentenciaIns = " INSERT INTO `hospeda`  (`nombre_tipo_habitacion`, `num_hab`, `num_mascota`, `momento_arribo_reserva`, `momento_partida_reserva`, `num_reserva`, `momento_reserva`, `estado_reserva`, `extras_reserva`, `modalidad_pago_reserva`, `precio_reserva`,`ci_oficinista`) 
                                                SELECT  (SELECT '" & ListBoxRoom.SelectedItem & "' AS p1),
		                                                (SELECT " & potencialHab.ElementAt(0) & " AS p2),
		                                                (SELECT num_mascota FROM mascota WHERE nombre_mascota = '" & nomMascCorrectedList.ElementAt(index) & "'),
                                                        (SELECT '" & fechaArriboFormatSQL & "' AS p4),
                                                        (SELECT '" & fechaPartidaFormatSQL & "' AS p5),
                                                        (SELECT " & idReservaNew & "),
                                                        (SELECT '" & fechaActual & "' AS p7),
                                                        (SELECT 'En Pie' AS p8),
                                                        (SELECT " & extrasSuite & " AS p9),
                                                        (SELECT " & modPag & " AS p10),
                                                        (SELECT " & presio & " AS p11),
                                                        (SELECT " & Guau.userUsuario & " AS p12)
		                                                AS parasd
                                                        ;"
                                                            Else
                                                                MsgBox("No tiene permisos para esta acción.")
                                                                sentenciaIns = "NOTALLOWED"

                                                            End If

                                                            If sentenciaIns.Equals("NOTALLOWED") = False Then



                                                                Try

                                                                    If Guau.conk.State.Open Then
                                                                        Guau.conk.Close()
                                                                        Guau.conk.Open()

                                                                    Else
                                                                        Guau.conk.Open()
                                                                    End If
                                                                    Dim comando As New MySqlCommand



                                                                    comando = New MySqlCommand(sentenciaIns, Guau.conk)



                                                                    comando.ExecuteNonQuery()
                                                                    Guau.conk.Close()

                                                                    exitoAgregado = True

                                                                Catch ex As Exception

                                                                    MsgBox("Error en el proceso de agregar la reserva. " & ex.Message & " ------ " & sentenciaIns)
                                                                End Try



                                                            Else
                                                                MsgBox("Ocurrió un error con la modalidad de pago. La reserva no se realizó.")
                                                            End If
                                                        Next
                                                        If exitoAgregado Then
                                                            MsgBox("La reserva se agendó de forma exitosa.")


                                                            Guau.conk.Close()

                                                            segundero = 0
                                                            Dim sentenciaTransIda As String
                                                            Dim exitoAgregadoTransIda As Boolean
                                                            exitoAgregadoTransIda = False
                                                            For index = 0 To nomMascSelectedList.Count - 1

                                                                Try

                                                                    If Guau.conk.State.Open Then
                                                                        Guau.conk.Close()
                                                                        Guau.conk.Open()

                                                                    Else
                                                                        Guau.conk.Open()
                                                                    End If
                                                                    Dim comandou As New MySqlCommand

                                                                    segundero = segundero + index
                                                                    Dim idaDateFinSQLFormat As String
                                                                    Dim idaDateInicioSQLFormat As String


                                                                    idaDateInicioSQLFormat = selTransDateIdaInicio.Year & "-"
                                                                    If selTransDateIdaInicio.Month < 10 Then
                                                                        idaDateInicioSQLFormat = idaDateInicioSQLFormat & "0"
                                                                    End If
                                                                    idaDateInicioSQLFormat = idaDateInicioSQLFormat & selTransDateIdaInicio.Month & "-"
                                                                    If selTransDateIdaInicio.Day < 10 Then
                                                                        idaDateInicioSQLFormat = idaDateInicioSQLFormat & "0"
                                                                    End If
                                                                    idaDateInicioSQLFormat = idaDateInicioSQLFormat & selTransDateIdaInicio.Day & " " & selTransDateIdaInicio.Hour & ":" & selTransDateIdaInicio.Minute & ":00"

                                                                    idaDateFinSQLFormat = selTransDateIdaFin.Year & "-"
                                                                    If selTransDateIdaFin.Month < 10 Then
                                                                        idaDateFinSQLFormat = idaDateFinSQLFormat & "0"
                                                                    End If
                                                                    idaDateFinSQLFormat = idaDateFinSQLFormat & selTransDateIdaFin.Month & "-"
                                                                    If selTransDateIdaFin.Day < 10 Then
                                                                        idaDateFinSQLFormat = idaDateFinSQLFormat & "0"
                                                                    End If
                                                                    idaDateFinSQLFormat = idaDateFinSQLFormat & selTransDateIdaFin.Day & " " & selTransDateIdaFin.Hour & ":" & selTransDateIdaFin.Minute & ":00"


                                                                    sentenciaTransIda = "INSERT INTO `mkarszensztejn`.`transporta` (`num_mascota`, `momento_creado_transporte`, `matricula_camioneta`, `momento_inicio_transporte`, `momento_fin_transporte`) SELECT (SELECT num_mascota FROM mascota WHERE nombre_mascota = '" & nomMascCorrectedList.ElementAt(index) & "'), '" & fechaActual & segundero & "', '" & potencialAutoListIda.ElementAt(0) & "', '" & idaDateInicioSQLFormat & "', '" & idaDateFinSQLFormat & "';"




                                                                    comandou = New MySqlCommand(sentenciaTransIda, Guau.conk)



                                                                    comandou.ExecuteNonQuery()
                                                                    Guau.conk.Close()

                                                                    exitoAgregadoTransIda = True

                                                                Catch ex As Exception

                                                                    MsgBox("Error en el proceso de agregar el trslado IDA. " & ex.Message & " ------ " & sentenciaTransIda)
                                                                End Try
                                                            Next
                                                            Guau.conk.Close()

                                                            segundero = 0
                                                            Dim sentenciaTransVuelta As String
                                                            Dim exitoAgregadoTransVuelta As Boolean
                                                            exitoAgregadoTransVuelta = False
                                                            For j = 0 To nomMascSelectedList.Count - 1

                                                                Try

                                                                    If Guau.conk.State.Open Then
                                                                        Guau.conk.Close()
                                                                        Guau.conk.Open()

                                                                    Else
                                                                        Guau.conk.Open()
                                                                    End If
                                                                    Dim comandou As New MySqlCommand

                                                                    segundero = segundero + j
                                                                    Dim vueltaDateFinSQLFormat As String
                                                                    Dim vueltaDateInicioSQLFormat As String


                                                                    vueltaDateInicioSQLFormat = selTransDateVueltaInicio.Year & "-"
                                                                    If selTransDateIdaInicio.Month < 10 Then
                                                                        vueltaDateInicioSQLFormat = vueltaDateInicioSQLFormat & "0"
                                                                    End If
                                                                    vueltaDateInicioSQLFormat = vueltaDateInicioSQLFormat & selTransDateVueltaInicio.Month & "-"
                                                                    If selTransDateIdaInicio.Day < 10 Then
                                                                        vueltaDateInicioSQLFormat = vueltaDateInicioSQLFormat & "0"
                                                                    End If
                                                                    vueltaDateInicioSQLFormat = vueltaDateInicioSQLFormat & selTransDateVueltaInicio.Day & " " & selTransDateVueltaInicio.Hour & ":" & selTransDateVueltaInicio.Minute & ":00"

                                                                    vueltaDateFinSQLFormat = selTransDateIdaFin.Year & "-"
                                                                    If selTransDateIdaFin.Month < 10 Then
                                                                        vueltaDateFinSQLFormat = vueltaDateFinSQLFormat & "0"
                                                                    End If
                                                                    vueltaDateFinSQLFormat = vueltaDateFinSQLFormat & selTransDateIdaFin.Month & "-"
                                                                    If selTransDateIdaFin.Day < 10 Then
                                                                        vueltaDateFinSQLFormat = vueltaDateFinSQLFormat & "0"
                                                                    End If
                                                                    vueltaDateFinSQLFormat = vueltaDateFinSQLFormat & selTransDateIdaFin.Day & " " & selTransDateIdaFin.Hour & ":" & selTransDateIdaFin.Minute & ":00"


                                                                    sentenciaTransIda = "INSERT INTO `mkarszensztejn`.`transporta` (`num_mascota`, `momento_creado_transporte`, `matricula_camioneta`, `momento_inicio_transporte`, `momento_fin_transporte`) SELECT (SELECT num_mascota FROM mascota WHERE nombre_mascota = '" & nomMascCorrectedList.ElementAt(j) & "'), '" & fechaActual & segundero & "', '" & potencialAutoListVuelta.ElementAt(0) & "', '" & vueltaDateInicioSQLFormat & "', '" & vueltaDateFinSQLFormat & "';"




                                                                    comandou = New MySqlCommand(sentenciaTransIda, Guau.conk)



                                                                    comandou.ExecuteNonQuery()
                                                                    Guau.conk.Close()

                                                                    exitoAgregadoTransIda = True

                                                                Catch ex As Exception

                                                                    MsgBox("Error en el proceso de agregar el trslado IDA. " & ex.Message & " ------ " & sentenciaTransIda)
                                                                End Try


                                                            Next
                                                            If exitoAgregadoTransIda AndAlso exitoAgregadoTransVuelta Then



                                                                MsgBox("Se agrego el transporte correctamente.")
                                                            End If
                                                            cleanFields()
                                                        End If
                                                    Else
                                                        MsgBox("Lo sentimos. Solamente se pueden ingresar 3 mascotas a la vez.")
                                                    End If
                                                End If
                                            End If
                                        End If

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub lblPrecio_Click(sender As Object, e As EventArgs) Handles lblPrecio.Click
        calculatePrice()
    End Sub

    Private Sub ListBoxRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxRoom.SelectedIndexChanged
        If ListBoxRoom.SelectedItem = "Suite" Then
            CheckBoxDogTV.Enabled = True
            CheckBoxWebcam.Enabled = True
        Else
            CheckBoxDogTV.Enabled = False
            CheckBoxWebcam.Enabled = False
            CheckBoxDogTV.Checked = False
            CheckBoxWebcam.Checked = False
        End If
    End Sub
End Class