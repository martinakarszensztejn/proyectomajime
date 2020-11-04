Public Class AgregarFotos



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
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

    Private Sub AgregarFotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class