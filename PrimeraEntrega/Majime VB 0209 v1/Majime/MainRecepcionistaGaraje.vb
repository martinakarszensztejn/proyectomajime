Public Class MainRecepcionistaGaraje
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        VerReserva.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Hide()
        SalidaVehiculos.Show()
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form3.rangoUsuario = ""
        Form1.Show()
        Me.Hide()
    End Sub
End Class