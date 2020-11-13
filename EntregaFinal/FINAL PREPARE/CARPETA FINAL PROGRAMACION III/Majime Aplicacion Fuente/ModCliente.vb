Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class ModCliente
    Private fieldsLoaded As Boolean
    Private datosClient As Cliente
    Private idQueryToMod As Integer
    Private Sub ModReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fieldsLoaded = False
        Dim allClientes() As Cliente = getClientes()
        ListBox1.Items.Clear()

        For index = 0 To allClientes.Length - 2
            ListBox1.Items.Add(allClientes(index).ci_cliente)
        Next



        ''''''''''''''''''''
        cleanForm()




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If

    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If fieldsLoaded Then
            cleanForm()
        Else
            loadFields()
        End If
    End Sub

    Private Sub loadFields()


        Button3.Text = "Descargar  "

        idQueryToMod = ListBox1.SelectedItem


        datosClient = GetClienteByID(idQueryToMod)

        TextBoxNom.Text = datosClient.nombre_cliente
        TextBoxCel.Text = datosClient.celular_cliente
        TextBoxTel.Text = datosClient.telefono_cliente
        TextBoxDir.Text = datosClient.direccion_cliente
        TextBoxEm.Text = datosClient.email_cliente




        fieldsLoaded = True

        TextBoxNom.Enabled = True
        TextBoxCel.Enabled = True
        TextBoxTel.Enabled = True
        TextBoxDir.Enabled = True
        TextBoxEm.Enabled = True

        ListBox1.Enabled = False







    End Sub












    Private Sub cleanForm()

        fieldsLoaded = False

        TextBoxNom.Enabled = False
        TextBoxCel.Enabled = False
        TextBoxTel.Enabled = False
        TextBoxDir.Enabled = False
        TextBoxEm.Enabled = False

        ListBox1.Enabled = True

        TextBoxTel.Text = ""
        TextBoxDir.Text = ""
        TextBoxEm.Text = ""
        TextBoxNom.Text = ""
        TextBoxEm.Text = ""
        ListBox1.Enabled = True




        idQueryToMod = 0
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxNom.Text <> "" OrElse TextBoxCel.Text <> "" OrElse TextBoxDir.Text <> "" Then

            If Not Regex.IsMatch(TextBoxTel.Text, "^[0-9 ]+$") And Not TextBoxTel.Text.ToString = String.Empty Then
                MsgBox("El valor de teléfono es inválido")
            Else
                If Not Regex.IsMatch(TextBoxCel.Text, "^[0-9 ]+$") Then
                    MsgBox("El valor de celular es inválido")
                Else
                    If (TextBoxEm.Text <> String.Empty And TextBoxEm.Text.IndexOf("@") = -1) Or (TextBoxEm.Text <> String.Empty And TextBoxEm.Text.IndexOf(".") = -1) Then
                        MsgBox("El valor del email no es válido.")
                    Else




                        Dim sentencia As String


                        Try

                            sentencia = "UPDATE `mkarszensztejn`.`cliente` SET
                            `nombre_cliente` = '" & TextBoxNom.Text & "', `telefono_cliente` = " & TextBoxTel.Text & ",
                            `celular_cliente` = " & TextBoxCel.Text & ", `direccion_cliente` = '" & TextBoxDir.Text & "',
                            `email_cliente` = '" & TextBoxEm.Text & "' WHERE (`ci_cliente` = " & idQueryToMod & ");"

                            Dim comando As New MySqlCommand



                            comando = New MySqlCommand(sentencia, Guau.conk)



                            comando.ExecuteNonQuery()



                            MsgBox("Se modificó exitosamente al cliente.")
                            cleanForm()
                        Catch ex As Exception

                            MsgBox("Ocurrió un error en el ingreso de datos." & ex.Message)



                        End Try
                    End If

                End If
            End If


        Else
            MsgBox("No se pueden dejar campos vacíos")
        End If
    End Sub
End Class