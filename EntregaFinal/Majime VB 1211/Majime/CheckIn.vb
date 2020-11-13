Public Class CheckIn


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.Items.Count = 0 Then
            MsgBox("Lo sentimos pero no hay mascotas disponibles.")
        Else
            If ListBox1.SelectedItem = Nothing Then
                MsgBox("Debe seleccionar una mascota!")
            Else
                If ListBox2.Items.Count = 0 Then
                    MsgBox("Lo sentimos pero no hay empleados disponibles.")
                Else
                    If ListBox2.SelectedItem = Nothing Then
                        MsgBox("Debe seleccionar un empleado!")
                    Else
                        MsgBox("Lo sentimos. Esta funcionalidad aún no fue implementada, sin embargo, todos los campos fueron verificados.")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class