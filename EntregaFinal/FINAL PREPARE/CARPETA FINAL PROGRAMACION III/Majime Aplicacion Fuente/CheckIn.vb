Imports MySql.Data.MySqlClient

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
            If ListBox1.SelectedItem = -1 Then
                MsgBox("Debe seleccionar una mascota!")
            Else
                Dim sent As String
                Dim fechaActual As String
                Dim mesHoyFix As String
                Dim diaHoyFix As String
                Dim minHoyFix As String
                Dim hrsHoyFix As String
                If Now.Month < 10 Then
                    mesHoyFix = "0" & Now.Month.ToString
                Else
                    mesHoyFix = Now.Month.ToString
                End If
                If Now.Day < 10 Then
                    diaHoyFix = "0" & Now.Day.ToString
                Else
                    diaHoyFix = Now.Day.ToString
                End If
                If Now.Minute < 10 Then
                    minHoyFix = "0" & Now.Minute.ToString
                Else
                    minHoyFix = Now.Minute.ToString
                End If
                If Now.Hour < 10 Then
                    hrsHoyFix = "0" & Now.Hour.ToString
                Else
                    hrsHoyFix = Now.Hour.ToString
                End If
                fechaActual = Now.Year.ToString & "-" & mesHoyFix & "-" & diaHoyFix & " " & Now.Hour & ":" & Now.Minute & ":0"

                If Guau.rangoUsuario = Guau.rangos(1) Then
                    sent = "INSERT INTO `mkarszensztejn`.`recibe` (`num_mascota`, `momento_checkin`, `ci_oficinista`) VALUES ('" & ListBox1.SelectedItem.ToString & "', '" & fechaActual & "', " & Guau.ci_usuario & ");
"
                Else
                    sent = "INSERT INTO `mkarszensztejn`.`recibe` (`num_mascota`, `momento_checkin`, `ci_oficinista`) VALUES ('" & ListBox1.SelectedItem.ToString & "', '" & fechaActual & "', '11111111');
"
                End If
                Try

                    Dim comando As New MySqlCommand



                    comando = New MySqlCommand(sent, Guau.conk)



                    comando.ExecuteNonQuery()



                    MsgBox("Se agregó exitosamente el check in.")
                    ListBox1.SelectedIndex = -1
                Catch ex As Exception

                    MsgBox("Ocurrió un error en el ingreso de datos." & ex.Message)



                End Try


            End If
        End If
    End Sub

    Private Sub CheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pets = GetAllPets()
        For index = 0 To pets.Length - 2
            ListBox1.Items.Add(pets(index).num_mascota)
        Next

    End Sub
End Class