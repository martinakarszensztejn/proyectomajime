Public Class VerReservaElegida
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Form3.rangoUsuario = Form3.rangos(0) Then
            VerReserva.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(2) Then
            VerReserva.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(1) Then
            VerReserva.Show()
            Me.Hide()
        End If
    End Sub
End Class