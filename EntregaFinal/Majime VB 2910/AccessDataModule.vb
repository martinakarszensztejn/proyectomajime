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
End Module
