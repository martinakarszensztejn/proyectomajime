Public Class MainRecepcionistaGaraje
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Guau.AbrirFormEnPanel(New VerReserva)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Guau.AbrirFormEnPanel(New SalidaVehiculos)
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Guau.rangoUsuario = ""
        Guau.AbrirFormEnPanel(New MenuInicio)
    End Sub
End Class