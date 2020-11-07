Imports MySql.Data.MySqlClient

Module AccessDataModule
    Public Function GetAllPets() As Mascota()

        Dim consulta As String
        consulta = "Select * From mascota;"

        Dim comando As New MySqlCommand(consulta, Guau.conk)

        Dim drd As MySqlDataReader

        If Guau.conk.State.Open Then
            Guau.conk.Close()
            Guau.conk.Open()

        Else
            Guau.conk.Open()
        End If
        drd = comando.ExecuteReader

        Dim datosMascota(0) As Mascota
        Try



            While drd.HasRows()


                While drd.Read()

                    datosMascota(datosMascota.Length - 1) = New Mascota(drd.GetInt16(0), drd.GetString(1), drd.GetString(2), drd.GetChar(3), drd.GetInt16(4), drd.GetDateTime(5), drd.GetString(6))
                    ReDim Preserve datosMascota(datosMascota.Length)

                End While

                drd.NextResult()

            End While
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado. Intente más tarde." & ex.Message)
        End Try


        drd.Close()

        Return datosMascota
    End Function

    Public Function getHorarios() As Horario()
        Dim consulta As String
        consulta = "Select * From horario_hotel;"

        Dim comando As New MySqlCommand(consulta, Guau.conk)

        Dim drd As MySqlDataReader

        If Guau.conk.State.Open Then
            Guau.conk.Close()
            Guau.conk.Open()

        Else
            Guau.conk.Open()
        End If
        drd = comando.ExecuteReader

        Dim datosHorario(0) As Horario
        Try



            While drd.HasRows()


                While drd.Read()

                    datosHorario(datosHorario.Length - 1) = New Horario(drd.GetInt32(0), drd.GetString(1), drd.GetString(2))


                    ReDim Preserve datosHorario(datosHorario.Length)
                End While

                drd.NextResult()

            End While
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado. Intente más tarde." & ex.Message)
        End Try


        drd.Close()

        Return datosHorario

    End Function


    Public Function getHabitacion() As Habitacion()
        Dim consulta As String
        consulta = "Select * From tipo_habitacion;"

        Dim comando As New MySqlCommand(consulta, Guau.conk)

        Dim drd As MySqlDataReader

        If Guau.conk.State.Open Then
            Guau.conk.Close()
            Guau.conk.Open()

        Else
            Guau.conk.Open()
        End If
        drd = comando.ExecuteReader

        Dim datosHabitacion(0) As Habitacion
        Try



            While drd.HasRows()


                While drd.Read()
                    If drd.GetString(0) = "Mini Suite" Then
                        datosHabitacion(datosHabitacion.Length - 1) = New Habitacion(drd.GetString(0), drd.GetInt32(1), drd.GetInt32(2), drd.GetInt32(3), drd.GetInt32(4), drd.GetInt16(5), drd.GetInt16(6), drd.GetInt16(7), drd.GetInt16(8), drd.GetInt16(9), drd.GetInt16(10), drd.GetInt16(11))
                    Else
                        datosHabitacion(datosHabitacion.Length - 1) = New Habitacion(drd.GetString(0), drd.GetInt32(1), drd.GetInt32(2), drd.GetInt32(3), drd.GetInt32(4), drd.GetInt16(5), drd.GetInt16(6), drd.GetInt16(7), drd.GetInt16(8), drd.GetInt16(9), drd.GetInt16(10), Nothing)
                    End If
                    ReDim Preserve datosHabitacion(datosHabitacion.Length)
                End While

                drd.NextResult()

            End While
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado. Intente más tarde." & ex.Message)
        End Try


        drd.Close()
        Return datosHabitacion

    End Function


End Module
