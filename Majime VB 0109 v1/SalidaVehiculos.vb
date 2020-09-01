Public Class SalidaVehiculos
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Form3.rangoUsuario = Form3.rangoUsuario(0) Then
            MainGerente.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangoUsuario(2) Then
            MainRecepcionistaGaraje.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangoUsuario(1) Then
            MsgBox("WIP - Página no disponible")
            ' MainOficinista.Show()
            Me.Hide()

        End If

    End Sub
End Class