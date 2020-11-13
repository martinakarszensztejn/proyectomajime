Public Class MainGerente


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Guau.AbrirFormEnPanel(New CheckIn)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Guau.AbrirFormEnPanel(New AgregarMascota)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Guau.AbrirFormEnPanel(New VerCliente)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Guau.AbrirFormEnPanel(New AgregarCliente)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Guau.AbrirFormEnPanel(New VerMascota)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Guau.AbrirFormEnPanel(New VerReserva)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Guau.AbrirFormEnPanel(New CrearReservas)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Guau.AbrirFormEnPanel(New Habitaciones)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) 
        Guau.AbrirFormEnPanel(New Pagos)
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) 
        Guau.AbrirFormEnPanel(New VerMedicacion)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Guau.AbrirFormEnPanel(New SalidaVehiculos)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Guau.rangoUsuario = ""
        Guau.AbrirFormEnPanel(New MenuInicio)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Guau.AbrirFormEnPanel(New AgregarVehiculos)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Guau.AbrirFormEnPanel(New VerHorarios)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Guau.AbrirFormEnPanel(New ModReserva)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Guau.AbrirFormEnPanel(New ModCliente)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Guau.AbrirFormEnPanel(New ModMascota)
    End Sub
End Class