Imports MySql.Data.MySqlClient

Public Class Form3
    Public rangoUsuario As String
    Public userUsuario As String
    Public rangos() As String = {"Gerente", "Oficinista", "Recepcionista de Garaje"}
    Public clavesDeRangoPrivadas() As String = {"c4zzu", "tr1", "n1ck1"}


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim consulta As String
        consulta = "Select * From majime.empleado Where usuario = '" & TBUser.Text & "' And password = '" & TBPass.Text & "';"


        Dim comando As New MySqlCommand(consulta, Form1.connk)




        Dim drd As MySqlDataReader





        drd = comando.ExecuteReader

        Dim exito As Boolean


        exito = False
        Try
            If drd.Read() Then
                exito = True
                rangoUsuario = drd.Item("rango").ToString
                userUsuario = drd.Item("usuario").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If exito Then
            If Me.rangoUsuario = Me.rangoUsuario(0) Then
                MainGerente.Show()
                Me.Hide()
            ElseIf Me.rangoUsuario = Me.rangoUsuario(2) Then
                MainRecepcionistaGaraje.Show()
                Me.Hide()
            ElseIf Me.rangoUsuario = Me.rangoUsuario(1) Then
                MsgBox("WIP - Página no disponible")
                'MainOficinista.Show()
                Me.Hide()

            End If


        Else
            MsgBox("Error en el inicio de sesión")

        End If
        drd.Close()
        drd.Dispose()
        comando.Dispose()
        Form1.connk.Close()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class