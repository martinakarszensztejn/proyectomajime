Public Class VerHorarios


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Form3.rangoUsuario = Form3.rangos(0) Then
            MainGerente.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(2) Then
            MainRecepcionistaGaraje.Show()
            Me.Hide()
        ElseIf Form3.rangoUsuario = Form3.rangos(1) Then
            MainOficinista.Show()
            Me.Hide()
        End If
    End Sub
End Class