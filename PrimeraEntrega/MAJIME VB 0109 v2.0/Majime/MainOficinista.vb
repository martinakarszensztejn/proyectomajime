Public Class MainOficinista
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10A.Click
        Me.Hide()
        CheckIn.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4A.Click
        Me.Hide()
        AgregarMascota.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1A.Click
        Me.Hide()
        VerCliente.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2A.Click
        Me.Hide()
        AgregarCliente.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3A.Click
        Me.Hide()
        VerMascota.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5A.Click
        Me.Hide()
        VerReserva.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6A.Click
        Me.Hide()
        CrearReservas.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8A.Click
        Me.Hide()
        Habitaciones.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7A.Click
        Me.Hide()
        Pagos.Show()
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto1.Click
        AgregarFotos.Show()
        Me.Hide()
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9A.Click
        Form3.rangoUsuario = ""
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12A.Click
        Me.Hide()
        AgregarVehiculos.Show()
    End Sub

    Private Sub Button5A_Click(sender As Object, e As EventArgs) Handles Button5A.Click

    End Sub
End Class