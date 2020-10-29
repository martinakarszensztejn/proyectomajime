Imports MySql.Data.MySqlClient

Public Class Habitaciones
    Dim consulta As String
    Private num_prec_for_suite As Int16 = 0
    Private num_prec_for_juniorsuite As Int16 = 0
    Private num_prec_for_minisuite As Int16 = 0
    Private num_prec_for_estandar As Int16 = 0

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If
    End Sub





    Private Sub Habitaciones_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Guau.rangoUsuario = Guau.rangos(1) Then

            TextBox3JS.ReadOnly = True
            TextBox3S.ReadOnly = True
            TextBox1S.ReadOnly = True
            TextBox2S.ReadOnly = True
            TextBox2JS.ReadOnly = True
            TextBox1JS.ReadOnly = True
            TextBox3MS.ReadOnly = True
            TextBox2MS.ReadOnly = True
            TextBox1MS.ReadOnly = True
            TextBox3E.ReadOnly = True
            TextBox2E.ReadOnly = True
            TextBox1E.ReadOnly = True
            Button1.Visible = False
            Button2.Visible = False

        ElseIf Guau.rangoUsuario = Guau.rangos(0) Then

            TextBox2JS.ReadOnly = False
            TextBox1JS.ReadOnly = False
            TextBox3MS.ReadOnly = False
            TextBox2MS.ReadOnly = False
            TextBox1MS.ReadOnly = False
            TextBox3E.ReadOnly = False
            TextBox2E.ReadOnly = False
            TextBox1E.ReadOnly = False
            TextBox3JS.ReadOnly = False
            TextBox3S.ReadOnly = False
            TextBox1S.ReadOnly = False
            TextBox2S.ReadOnly = False
            Button1.Visible = True
            Button2.Visible = True
        End If
    End Sub

    Private Sub Habitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getPrices()
    End Sub

    Private Sub getPrices()

        consulta = "SELECT cuesta.nombre_tipo_habitacion, precio.precio_1m , precio.precio_2m , precio.precio_3m, precio.num_precio FROM cuesta
JOIN precio ON precio.num_precio = cuesta.num_precio ORDER BY precio_1m DESC, nombre_tipo_habitacion ;"

        Dim comando As New MySqlCommand(consulta, Guau.conk)

        Dim drd As MySqlDataReader

        If Guau.conk.State.Open Then
            Guau.conk.Close()
            Guau.conk.Open()

        Else
            Guau.conk.Open()
        End If
        drd = comando.ExecuteReader



        Try
            While drd.HasRows()


                While drd.Read()


                    If drd.GetString(0) = "Suite" Then
                        TextBox1S.Text = drd.GetDouble(1).ToString
                        TextBox2S.Text = drd.GetDouble(2).ToString
                        TextBox3S.Text = drd.GetDouble(3).ToString
                        num_prec_for_suite = drd.GetInt16(4)

                    ElseIf drd.GetString(0) = "Junior Suite" Then
                        TextBox1JS.Text = drd.GetDouble(1).ToString
                        TextBox2JS.Text = drd.GetDouble(2).ToString
                        TextBox3JS.Text = drd.GetDouble(3).ToString
                        num_prec_for_juniorsuite = drd.GetInt16(4)
                    ElseIf drd.GetString(0) = "Mini Suite" Then
                        TextBox1MS.Text = drd.GetDouble(1).ToString
                        TextBox2MS.Text = drd.GetDouble(2).ToString
                        TextBox3MS.Text = drd.GetDouble(3).ToString
                        num_prec_for_minisuite = drd.GetInt16(4)
                    ElseIf drd.GetString(0) = "Estandar" Then
                        TextBox1E.Text = drd.GetDouble(1).ToString
                        TextBox2E.Text = drd.GetDouble(2).ToString
                        TextBox3E.Text = drd.GetDouble(3).ToString


                        num_prec_for_estandar = drd.GetInt16(4)
                    Else
                        Throw New ArgumentException("Error obteniendo precio.")
                    End If



                End While

                drd.NextResult()

            End While
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado. Intente más tarde. " & ex.Message)
        End Try




        drd.Close()
    End Sub
    Private Sub modifyPrices()
        If Guau.rangoUsuario = Guau.rangos(1) Then
            MsgBox("Usted no está autorizado para esta acción.")
        ElseIf Guau.rangoUsuario = Guau.rangos(0) Then


            Try



                If num_prec_for_suite <> 0 Then


                    Dim sqlSent1 As String = "UPDATE `precio` SET `precio_1m` = '" & TextBox1S.Text & "', `precio_2m` = '" & TextBox2S.Text & "', `precio_3m` = '" & TextBox3S.Text & "' WHERE  (`num_precio` = " & num_prec_for_suite & ");"
                    Dim comandoUpdPrecio1 As MySqlCommand
                    comandoUpdPrecio1 = New MySqlCommand(sqlSent1, Guau.conk)
                    comandoUpdPrecio1.ExecuteNonQuery()
                End If
                If num_prec_for_juniorsuite <> 0 Then
                    Dim sqlSent2 As String = "UPDATE `precio` SET `precio_1m` = '" & TextBox1JS.Text & "', `precio_2m` = '" & TextBox2JS.Text & "', `precio_3m` = '" & TextBox3JS.Text & "' WHERE (`num_precio` = " & num_prec_for_juniorsuite & ");"
                    Dim comandoUpdPrecio2 As MySqlCommand
                    comandoUpdPrecio2 = New MySqlCommand(sqlSent2, Guau.conk)
                    comandoUpdPrecio2.ExecuteNonQuery()
                End If
                If num_prec_for_minisuite <> 0 Then
                    Dim sqlSent3 As String = "UPDATE `precio` SET `precio_1m` = '" & TextBox1MS.Text & "', `precio_2m` = '" & TextBox2MS.Text & "', `precio_3m` = '" & TextBox3MS.Text & "' WHERE  (`num_precio` = " & num_prec_for_minisuite & ");"
                    Dim comandoUpdPrecio3 As MySqlCommand
                    comandoUpdPrecio3 = New MySqlCommand(sqlSent3, Guau.conk)
                    comandoUpdPrecio3.ExecuteNonQuery()
                End If
                If num_prec_for_estandar <> 0 Then
                    Dim sqlSent4 As String = "UPDATE `precio` SET `precio_1m` = '" & TextBox1E.Text & "', `precio_2m` = '" & TextBox2E.Text & "', `precio_3m` = '" & TextBox3E.Text & "' WHERE (`num_precio` = " & num_prec_for_estandar & ");"
                    Dim comandoUpdPrecio4 As MySqlCommand
                    comandoUpdPrecio4 = New MySqlCommand(sqlSent4, Guau.conk)
                    comandoUpdPrecio4.ExecuteNonQuery()
                End If
                If num_prec_for_estandar = 0 Or num_prec_for_juniorsuite = 0 Or num_prec_for_minisuite = 0 Or num_prec_for_suite = 0 Then
                    Throw New ArgumentException("Error obteniendo ID de habitaciones")
                Else
                    MsgBox("Los precios fueron actualizados de forma exitosa.")
                End If
            Catch ex As Exception
                MsgBox("Ocurrió un error en el proceso de modificar los precios. Lo sentimos. " & ex.Message)



            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        modifyPrices()
    End Sub
End Class