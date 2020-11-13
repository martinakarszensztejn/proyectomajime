Public Class VerReservaElegida
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If
    End Sub

    Private Sub VerReservaElegida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reservasLista = getReservas()

        Dim datos(12) As String
        For index = 0 To reservasLista.Length - 2
            datos(0) = reservasLista(index).num_reserva
            datos(1) = reservasLista(index).nombre_tipo_habitacion.ToString
            datos(2) = reservasLista(index).num_hab.ToString
            datos(3) = Integer.Parse(reservasLista(index).num_masc)
            datos(4) = reservasLista(index).momento_reserva.ToString
            datos(5) = reservasLista(index).momento_arribo_reserva.ToString
            datos(6) = reservasLista(index).momento_partida_reserva.ToString
            datos(7) = Integer.Parse(reservasLista(index).ci_oficinista)

            datos(8) = reservasLista(index).estado_reserva.ToString
            Dim extra As Integer
            extra = Integer.Parse(reservasLista(index).extras_reserva)
            Dim extrasBien As String
            If extra = 0 Then
                extrasBien = "Ninguno"
            ElseIf extra = 1 Then
                extrasBien = "DogTV"
            ElseIf extra = 2 Then
                extrasBien = "WebCam"
            ElseIf extra = 3 Then
                extrasBien = "DogTV + WebCam"
            Else
                extrasBien = "No registrado"
            End If
            datos(9) = extrasBien
            Dim modalidadPagoBien As String
            Dim modPag = reservasLista(index).modalidad_pago_reserva.ToString

            If modPag = False Then
                modalidadPagoBien = "Contado"
            ElseIf modPag = True Then
                modalidadPagoBien = "Tarjeta"
            Else
                modalidadPagoBien = "No registrado"
            End If
            datos(10) = modalidadPagoBien
            datos(11) = "US$" & reservasLista(index).precio_reserva.ToString


            DataGridView1.Rows.Add(datos)
        Next
    End Sub
End Class