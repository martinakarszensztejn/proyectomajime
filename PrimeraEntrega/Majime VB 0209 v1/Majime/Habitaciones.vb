Public Class Habitaciones
    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

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

    Private Sub Habitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form3.userUsuario = Form3.rangos(0) Then
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            Label11.Visible = False
            Label12.Visible = False
            Label13.Visible = False
            Label14.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = False
            TextBox8.Visible = False
            TextBox9.Visible = False
            TextBox10.Visible = False
            TextBox11.Visible = False
            TextBox12.Visible = False
        ElseIf Form3.userUsuario = Form3.rangos(1) Then
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class