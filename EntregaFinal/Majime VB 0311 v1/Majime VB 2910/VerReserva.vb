Public Class VerReserva

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If

    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click

        Guau.AbrirFormEnPanel(New VerReservaElegida)
    End Sub

    Private Sub VerReserva_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim puntoVisRec As New Point(319, 337)
        Dim puntoBackRec As New Point(410, 337)
        Dim puntoNormAdd As New Point(177, 294)
        Dim puntoVerAdd As New Point(270, 294)
        Dim puntoModAdd As New Point(366, 294)
        Dim puntoDelAdd As New Point(464, 294)
        Dim puntoBackAdd As New Point(557, 294)





        If Guau.rangoUsuario = Guau.rangos(0) Or Guau.rangoUsuario = Guau.rangos(1) Then
            btnAgregar.Visible = True
            btnBorrar.Visible = True
            btnModificar.Visible = True
            btnVer.Location = puntoVerAdd
            btnVolver.Location = puntoBackAdd
            btnModificar.Location = puntoModAdd
            btnBorrar.Location = puntoDelAdd
            btnAgregar.Location = puntoNormAdd

        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            btnAgregar.Visible = False
            btnBorrar.Visible = False
            btnModificar.Visible = False

            btnVer.Location = puntoVisRec
            btnVolver.Location = puntoBackRec


        End If
    End Sub


End Class