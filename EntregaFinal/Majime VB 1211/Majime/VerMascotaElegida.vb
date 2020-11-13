Public Class VerMascotaElegida
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If
    End Sub

    Private Sub VerMascotaElegida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim petList = GetAllPets()

        Dim datos(6) As String
        For index = 0 To petList.Length - 2
            datos(0) = petList(index).num_mascota.ToString
            datos(1) = petList(index).nombre_mascota.ToString.ToUpper
            datos(2) = petList(index).raza_mascota.ToString
            datos(3) = petList(index).sexo_mascota.ToString
            datos(4) = petList(index).peso_mascota.ToString
            datos(5) = petList(index).fnac_mascota.ToString.ToUpper
            datos(6) = petList(index).vacunas_mascota.ToString

            DataGridView1.Rows.Add(datos)
        Next
    End Sub
End Class