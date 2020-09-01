Public Class VerMascotaElegida
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Form3.rangoUsuario = Form3.rangos(0) Then
            VerMascota.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(2) Then
            VerMascota.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(1) Then
            VerMascota.Show()
            Me.Hide()
        End If
    End Sub
End Class