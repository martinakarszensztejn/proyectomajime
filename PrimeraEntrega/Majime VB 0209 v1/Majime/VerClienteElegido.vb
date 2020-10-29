Public Class VerClienteElegido
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Form3.rangoUsuario = Form3.rangos(0) Then
            VerCliente.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(2) Then
            VerCliente.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(1) Then
            VerCliente.Show()
            Me.Hide()
        End If
    End Sub
End Class