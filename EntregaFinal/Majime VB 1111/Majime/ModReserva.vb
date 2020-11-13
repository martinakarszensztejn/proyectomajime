Imports MySql.Data.MySqlClient

Public Class ModReserva
    Private listaHorarios As Horario()
    Private listaHabitaciones As Habitacion()
    Private fieldsLoaded As Boolean
    Private datosHospedaSel As Hospeda

    Private Sub ModReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fieldsLoaded = False
        Dim reservas() As Hospeda = getReservas()
        ListBox1.Items.Clear()

        For index = 0 To reservas.Length - 2
            ListBox1.Items.Add(reservas(index).num_reserva)
        Next


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If fieldsLoaded Then
            cleanFields()
        Else
            loadFields()

        End If


    End Sub

    Private Sub loadFields()


        Button4.Text = "Descargar  "

        Dim idQueryToMod = ListBox1.SelectedItem


        datosHospedaSel = GetReservaByID(idQueryToMod)


        lblPrecio.Text = "PRECIO: US$" & datosHospedaSel.precio_reserva
        listaHorarios = getHorarios()
        listaHabitaciones = getHabitacion()



        If datosHospedaSel.modalidad_pago_reserva = True Then
            RadioButtonCC.Select()
        ElseIf datosHospedaSel.modalidad_pago_reserva = False Then
            RadioButtonCont.Select()
        Else
            RadioButtonCont.Checked = False
            RadioButtonCC.Checked = False
        End If



        If datosHospedaSel.extras_reserva = 1 Then
            CheckBoxDogTV.Checked = True
            CheckBoxWebcam.Checked = False
        ElseIf datosHospedaSel.extras_reserva = 2 Then
            CheckBoxWebcam.Checked = True
            CheckBoxDogTV.Checked = False
        ElseIf datosHospedaSel.extras_reserva = 3 Then
            CheckBoxWebcam.Checked = True
            CheckBoxDogTV.Checked = True
        Else
            CheckBoxWebcam.Checked = False
            CheckBoxDogTV.Checked = False
        End If

        lblRoom.Text = lblRoom.Text & " " & datosHospedaSel.num_hab
        DateTimePickerA1.Value = datosHospedaSel.momento_arribo_reserva
        DateTimePickerA2.Value = datosHospedaSel.momento_arribo_reserva
        DateTimePickerR1.Value = datosHospedaSel.momento_partida_reserva
        DateTimePickerR2.Value = datosHospedaSel.momento_partida_reserva



        DateTimePickerA1.Format = DateTimePickerFormat.Custom
        DateTimePickerA2.Format = DateTimePickerFormat.Custom

        DateTimePickerR1.Format = DateTimePickerFormat.Custom
        DateTimePickerR2.Format = DateTimePickerFormat.Custom
        DateTimePickerA1.CustomFormat = "yyyy-MM-dd"
        DateTimePickerR1.CustomFormat = "yyyy-MM-dd"
        DateTimePickerA2.CustomFormat = "HH:mm"
        DateTimePickerR2.CustomFormat = "HH:mm"

        DateTimePickerA2.ShowUpDown = True
        DateTimePickerR2.ShowUpDown = True

        DateTimePickerA1.MinDate = Now
        DateTimePickerR1.MinDate = Now
        Dim mascota() As Mascota = GetAllPets()


        DateTimePickerA1.Enabled = True
        DateTimePickerA2.Enabled = True
        DateTimePickerR1.Enabled = True
        DateTimePickerR2.Enabled = True

        If datosHospedaSel.nombre_tipo_habitacion = "Suite" Then
            CheckBoxDogTV.Enabled = True
            CheckBoxWebcam.Enabled = True
        Else
            CheckBoxDogTV.Enabled = False
            CheckBoxWebcam.Enabled = False
        End If

        RadioButtonCC.Enabled = True
        RadioButtonCont.Enabled = True
        fieldsLoaded = True
        ListBox1.Enabled = False
        lblNumRes.Text = "N° Reserva: " & datosHospedaSel.num_reserva.ToString
        lblMascota.Text = "Mascota N° " & datosHospedaSel.num_masc.ToString
        lblRoom.Text = "Habitacion: " & datosHospedaSel.nombre_tipo_habitacion.ToString & " N° " & datosHospedaSel.num_hab.ToString
    End Sub

    Private Sub cleanFields()

        Button4.Text = "Cargar"
        lblMascota.Text = "Mascota N° "
        lblRoom.Text = "Habitacion: "

        lblNumRes.Text = "N° Reserva: "
        DateTimePickerA1.Value = DateTime.Now
        DateTimePickerA2.Value = DateTime.Now

        DateTimePickerR1.Value = DateTime.Now
        DateTimePickerR2.Value = DateTime.Now

        CheckBoxDogTV.Checked = False
        CheckBoxWebcam.Checked = False

        RadioButtonCont.Checked = False

        RadioButtonCC.Checked = False
        CheckBoxDogTV.Enabled = False
        CheckBoxWebcam.Enabled = False

        lblRoom.Text = "N° Habitación:"
        lblPrecio.Text = "Precio:"

        DateTimePickerA1.Enabled = False
        DateTimePickerA2.Enabled = False
        DateTimePickerR1.Enabled = False
        DateTimePickerR2.Enabled = False

        CheckBoxDogTV.Enabled = False
        CheckBoxWebcam.Enabled = False
        RadioButtonCC.Enabled = False
        RadioButtonCont.Enabled = False
        fieldsLoaded = False
        ListBox1.Enabled = True
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

    Private Sub Button6_Click(sender As Object, e As EventArgs)
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

        Dim cantidadPets As New Int16
            cantidadPets = 0


        For index = 0 To preciosList.Length - 2

            If datosHospedaSel.nombre_tipo_habitacion = preciosList(index).tipo_hab Then
                validPricePerDay = preciosList(index).precio_1m
            End If
            Dim periodoEstadia As New TimeSpan()
            periodoEstadia = DateTimePickerR1.Value - DateTimePickerA1.Value
            Dim diasEstadia = Math.Ceiling(periodoEstadia.TotalDays)

            finalPrice = (diasEstadia * validPricePerDay)

            If datosHospedaSel.nombre_tipo_habitacion = "Suite" Then
                If CheckBoxDogTV.Checked Then
                    finalPrice = finalPrice + (diasEstadia * 2)
                End If
                If CheckBoxWebcam.Checked Then
                    finalPrice = finalPrice + (diasEstadia * 4)
                End If
            End If


        Next



        Return finalPrice
    End Function


    Private Sub addBooking()


        If DateTimePickerR1.Value < DateTimePickerA1.Value Then
            MsgBox("La fecha de retorno no puede ser anterior a la de arribo")
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

                    If datosHospedaSel.nombre_tipo_habitacion = listaReservas(index).nombre_tipo_habitacion AndAlso ((fechaArriboSelected > fechaArriboDT And fechaSalidaSelected < fechaPartidaDT) Or (fechaArriboSelected > fechaArriboDT And fechaArriboSelected < fechaPartidaDT) Or (fechaSalidaSelected < fechaPartidaDT And fechaSalidaSelected > fechaArriboDT)) Then






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



                        Dim fechaActual As String
                        Dim mesHoyFix As String
                        Dim diaHoyFix As String
                        Dim minHoyFix As String
                        Dim hrsHoyFix As String
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
                        If Now.Minute < 10 Then
                            minHoyFix = "0" & Now.Minute.ToString
                        Else
                            minHoyFix = Now.Minute.ToString
                        End If
                        If Now.Hour < 10 Then
                            hrsHoyFix = "0" & Now.Hour.ToString
                        Else
                            hrsHoyFix = Now.Hour.ToString
                        End If

                        fechaActual = Now.Year.ToString & "-" & mesHoyFix & "-" & diaHoyFix & " " & hrsHoyFix & ":" & minHoyFix & ":00"
                        Dim extrasSuite As New Int16
                        extrasSuite = 0
                        If datosHospedaSel.nombre_tipo_habitacion = "Suite" AndAlso CheckBoxDogTV.Checked AndAlso CheckBoxWebcam.Checked = False Then
                            extrasSuite = 1
                        ElseIf datosHospedaSel.nombre_tipo_habitacion = "Suite" AndAlso CheckBoxDogTV.Checked AndAlso CheckBoxWebcam.Checked Then
                            extrasSuite = 3
                        ElseIf datosHospedaSel.nombre_tipo_habitacion = "Suite" AndAlso CheckBoxDogTV.Checked = False AndAlso CheckBoxWebcam.Checked Then
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

                            Dim foundResult As Boolean




                            Dim exitoAgregado As Boolean
                            Dim sentenciaMod As String

                            exitoAgregado = False


                            Dim idMasc As Integer

                            Dim posid As Integer


                            sentenciaMod = "UPDATE `mkarszensztejn`.`hospeda` SET
                            `momento_arribo_reserva` = '" & fechaArriboFormatSQL & "', 
                            `extras_reserva` =  " & extrasSuite & " , `modalidad_pago_reserva` = " & modPag & ", 
                            `momento_partida_reserva` = '" & fechaPartidaFormatSQL & "', `precio_reserva` = " & presio & " 
                                WHERE (`num_reserva`=" & ListBox1.SelectedItem & ");
"






                            Try

                                If Guau.conk.State.Open Then
                                    Guau.conk.Close()
                                    Guau.conk.Open()

                                Else
                                    Guau.conk.Open()
                                End If
                                Dim comando As New MySqlCommand



                                comando = New MySqlCommand(sentenciaMod, Guau.conk)



                                comando.ExecuteNonQuery()
                                Guau.conk.Close()

                                exitoAgregado = True

                            Catch ex As Exception

                                MsgBox("Error en el proceso de alterar la reserva. ")
                            End Try





                            If exitoAgregado Then
                                MsgBox("La reserva se alteró de forma exitosa.")

                                Guau.conk.Close()


                                cleanFields()
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

    Private Sub ListBoxRoom_SelectedIndexChanged(sender As Object, e As EventArgs)
        If datosHospedaSel.nombre_tipo_habitacion = "Suite" Then
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