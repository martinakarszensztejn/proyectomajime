Imports MySql.Data.MySqlClient

Public Class Form3
    Public rangoUsuario As String
    Public userUsuario As String
    Public rangos() As String = {"Gerente", "Oficinista", "Recepcionista de Garaje"}
    Public clavesDeRangoPrivadas() As String = {"c4zzu", "tr1", "n1ck1"}




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        rangoUsuario = ""

        Dim consulta As String
        consulta = "Select * From majime.empleado Where usuario = '" & TBUser.Text & "' And password = '" & TBPass.Text & "';"

        ' Dim comando As New MySqlCommand(consulta, Form1.conk)



        ' Dim drd As MySqlDataReader






        ' If Form1.conk.State.Open Then
        ' Form1.conk.Close()
        ' Form1.conk.Open()

        '  Else

        ' End If
        ' drd = comando.ExecuteReader

        Dim exito As Boolean


        exito = False
        Try
            '    If drd.Read() Then
            For index = 0 To (Form2.provCIReg.Length) - 1
                If Form2.provCIReg(index) = TBUser.Text AndAlso Form2.provPassReg(index) = TBPass.Text Then
                    exito = True
                    If exito Then
                        rangoUsuario = Form2.provRangoReg(index).ToString
                    End If

                End If
            Next
            'exito = True
            '      rangoUsuario = drd.Item("rango").ToString
            '  userUsuario = drd.Item("usuario").ToString
            '  End If
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado. Intente más tarde.")
        End Try

        If exito Then

            If Me.rangoUsuario = Me.rangos(0) Then
                MainGerente.Show()
                Me.Hide()
            ElseIf Me.rangoUsuario = Me.rangos(2) Then
                MainRecepcionistaGaraje.Show()
                Me.Hide()
            ElseIf Me.rangoUsuario = Me.rangos(1) Then

                MainOficinista.Show()
                Me.Hide()

            End If


        Else
            MsgBox("Error en el inicio de sesión")

        End If

        TBUser.Text = ""
        TBPass.Text = ""

    End Sub








    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class