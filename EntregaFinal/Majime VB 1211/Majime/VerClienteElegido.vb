Public Class VerClienteElegido
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If
    End Sub

    Private Sub VerClienteElegido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clientesList = getClientes()

        Dim datos(5) As String
        For index = 0 To clientesList.Length - 2
            datos(0) = clientesList(index).ci_cliente.ToString
            datos(1) = clientesList(index).nombre_cliente.ToString.ToUpper
            datos(2) = clientesList(index).telefono_cliente.ToString
            datos(3) = clientesList(index).celular_cliente.ToString
            datos(4) = clientesList(index).email_cliente.ToString
            datos(5) = clientesList(index).direccion_cliente.ToString.ToUpper

            DataGridView1.Rows.Add(datos)
        Next




















    End Sub
End Class