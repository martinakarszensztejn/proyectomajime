Public Class SalidaVehiculos
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Form3.rangoUsuario = Form3.rangos(0) Then
            MainGerente.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(2) Then
            MainRecepcionistaGaraje.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(1) Then
            MsgBox("WIP - Página no disponible")
            ' MainOficinista.Show()
            Me.Hide()

        End If

    End Sub


    Private Sub SalidaVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "HH:mm"
        DateTimePicker2.CustomFormat = "HH:mm"
        DateTimePicker1.ShowUpDown = True

        DateTimePicker2.ShowUpDown = True
    End Sub
End Class