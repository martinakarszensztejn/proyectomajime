Public Class AgregarFotos



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
    End Sub
End Class