Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta As String
        consulta = "Select * From majime.empleado Where usuario = '" & TBUser.Text & "' And password = '" & TBPass.Text & "';"
        Console.WriteLine(consulta)
        Dim comando As New MySqlCommand(consulta, Form1.conGlob)
        Dim drd As MySqlDataReader
        drd = comando.ExecuteReader
        Dim exito As Boolean
        Dim rangoUsuario As String
        Dim userUsuario As String
        exito = False
        If drd.Read() Then
            exito = True
            rangoUsuario = drd.Item("rango").ToString
            userUsuario = drd.Item("usuario").ToString
        End If
        If exito Then
            MainGerente.Show()
            Me.Hide()
        Else
            MsgBox("Error en el inicio de sesión")

        End If
    End Sub
End Class