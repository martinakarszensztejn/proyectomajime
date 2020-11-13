Imports MySql.Data.MySqlClient

Public Class VerReserva
    Public GlobIdQueryToMod As Integer


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

            btnVer.Location = puntoVerAdd
            btnVolver.Location = puntoBackAdd

            btnBorrar.Location = puntoDelAdd
            btnAgregar.Location = puntoNormAdd

        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            btnAgregar.Visible = False
            btnBorrar.Visible = False


            btnVer.Location = puntoVisRec
            btnVolver.Location = puntoBackRec


        End If
    End Sub



    Private Sub UpdateList()
        Dim reservas() As Hospeda = getReservas()
        ListBox1.Items.Clear()

        For index = 0 To reservas.Length - 2
            ListBox1.Items.Add(reservas(index).num_reserva)
        Next
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            If ListBox1.Items.Count = 0 Then
                MsgBox("Lo sentimos pero no hay ítems disponibles.")
            Else
                If ListBox1.SelectedItem = Nothing Then
                    MsgBox("Debe seleccionar un ítem!")
                Else


                    Dim seleccionprev As String
                    seleccionprev = ListBox1.SelectedItem

                    Dim sentenciaBorrarUno As String = "DELETE FROM `hospeda` WHERE (`num_reserva` = " & seleccionprev & ");"
                    Dim comandoUno As New MySqlCommand
                    comandoUno = New MySqlCommand(sentenciaBorrarUno, Guau.conk)
                    comandoUno.ExecuteNonQuery()
                    MsgBox("Exito en el borrado")
                    UpdateList()







                End If
            End If
        Catch ex As Exception
            MsgBox("Error en el borrado. Intente más tarde." & ex.Message)
        End Try
    End Sub

    Private Sub VerReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateList()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs)
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un item.")
        Else


            Guau.AbrirFormEnPanel(New ModReserva)

        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Guau.AbrirFormEnPanel(New CrearReservas)
    End Sub
End Class