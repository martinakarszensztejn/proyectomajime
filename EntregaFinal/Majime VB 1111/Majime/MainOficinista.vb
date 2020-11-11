Public Class MainOficinista
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10A.Click
        Guau.AbrirFormEnPanel(New CheckIn)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4A.Click
        Guau.AbrirFormEnPanel(New AgregarMascota)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1A.Click
        Guau.AbrirFormEnPanel(New VerCliente)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2A.Click
        Guau.AbrirFormEnPanel(New AgregarCliente)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3A.Click
        Guau.AbrirFormEnPanel(New VerMascota)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5A.Click
        Guau.AbrirFormEnPanel(New VerReserva)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6A.Click
        Guau.AbrirFormEnPanel(New CrearReservas)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8A.Click
        Guau.AbrirFormEnPanel(New Habitaciones)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7A.Click
        Guau.AbrirFormEnPanel(New Pagos)
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto1.Click
        Guau.AbrirFormEnPanel(New AgregarFotos)
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9A.Click
        Guau.rangoUsuario = ""
        Guau.AbrirFormEnPanel(New Form1)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12A.Click
        Guau.AbrirFormEnPanel(New AgregarVehiculos)
    End Sub


End Class