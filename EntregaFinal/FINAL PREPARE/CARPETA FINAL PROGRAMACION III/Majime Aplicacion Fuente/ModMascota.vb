Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class ModMascota
    Private fieldsLoaded As Boolean
    Private datosMasc As Mascota
    Private idQueryToMod As Integer
    Private Sub ModReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fieldsLoaded = False
        Dim mascotas() As Mascota = GetAllPets()
        ListBox1.Items.Clear()

        For index = 0 To mascotas.Length - 2
            ListBox1.Items.Add(mascotas(index).num_mascota)
        Next

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"

        ''''''''''''''''''''
        cleanForm()




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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


        datosMasc = GetPetByID(idQueryToMod)

        TextBoxNom.Text = datosMasc.nombre_mascota
        TextBoxRaza.Text = datosMasc.raza_mascota
        TextBoxPeso.Text = datosMasc.peso_mascota

        TextBoxVac.Text = datosMasc.vacunas_mascota
        DateTimePicker1.Value = datosMasc.fnac_mascota

        Dim allClientes = getClientes()
        ListBoxOw.Items.Clear()

        For index = 0 To allClientes.Length - 2
            ListBoxOw.Items.Add(allClientes(index).ci_cliente)
        Next
        If datosMasc.sexo_mascota = "F" Then
            RadioButtonF.Select()
            RadioButtonM.Checked = False
        ElseIf datosMasc.sexo_mascota = "M" Then
            RadioButtonM.Select()
            RadioButtonF.Checked = False
        End If
        fieldsLoaded = True
        ListBoxOw.Enabled = True
        RadioButtonM.Enabled = True
        DateTimePicker1.Enabled = True
        TextBoxPeso.Enabled = True
        TextBoxRaza.Enabled = True
        TextBoxVac.Enabled = True
        TextBoxNom.Enabled = True
        RadioButtonF.Enabled = True
        ListBox1.Enabled = False







    End Sub










    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Guau.AbrirFormEnPanel(New AgregarCliente)
    End Sub




    Private Sub cleanForm()
        Button3.Text = "Cargar"
        fieldsLoaded = False
        ListBoxOw.Enabled = False
        RadioButtonM.Enabled = False
        DateTimePicker1.Enabled = False
        TextBoxPeso.Enabled = False
        TextBoxRaza.Enabled = False
        TextBoxVac.Enabled = False
        TextBoxNom.Enabled = False
        RadioButtonF.Enabled = False
        ListBox1.Enabled = True

        ListBoxOw.SelectedIndex = -1
        RadioButtonM.Checked = False
        DateTimePicker1.Value = Now
        TextBoxPeso.Text = ""
        TextBoxRaza.Text = ""
        TextBoxVac.Text = ""
        TextBoxNom.Text = ""
        RadioButtonF.Checked = False
        ListBox1.Enabled = True




        idQueryToMod = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If fieldsLoaded = False Then
            MsgBox("Debe seleccionar y cargar un item.")
        Else


            If TextBoxNom.Text <> "" OrElse TextBoxPeso.Text <> "" Then
                If Not Regex.IsMatch(TextBoxPeso.Text, "^[0-9 ]+$") And Not TextBoxPeso.Text.ToString = String.Empty Then
                    MsgBox("El valor de peso es inválido")
                Else
                    Dim edadAnimalConfir As Int16 = DateTime.Compare(DateTimePicker1.Value, Now)

                    If edadAnimalConfir >= 0 Then
                        MsgBox("La fecha de nacimiento ingresada no es correcta.")
                    Else

                        Dim sentencia As String

                        Try
                            Dim sexoanimal As Char
                            If RadioButtonF.Checked = True Then
                                sexoanimal = "F"
                            ElseIf RadioButtonM.Checked = True Then
                                sexoanimal = "M"
                            Else
                                sexoanimal = ""
                            End If

                            Dim tomamedicamentos As Integer

                            Dim fnacc As String
                            fnacc = DateTimePicker1.Value.Year
                            fnacc = fnacc & "-" & DateTimePicker1.Value.Month
                            fnacc = fnacc & "-" & DateTimePicker1.Value.Day
                            Dim dueño As String
                            Dim ciowner As String
                            Dim ciownerInt As Integer
                            dueño = ListBox1.SelectedItem.ToString
                            If dueño = String.Empty Then
                                MsgBox("Debe seleccionar un dueño para la mascota.")
                            Else


                                sentencia = "UPDATE `mkarszensztejn`.`mascota` SET 
                                `nombre_mascota` = '" & TextBoxNom.Text.ToLower & "', 
                                `raza_mascota` = '" & TextBoxRaza.Text.ToLower & "', `sexo_mascota` = '" & sexoanimal & "',
                                `peso_mascota` = " & TextBoxPeso.Text & ", `fnac_mascota` = '" & fnacc & "',
                                `vacunas_mascota` = '" & TextBoxVac.Text.ToLower & "'
                                WHERE (`num_mascota` = " & idQueryToMod & ");"
                                Dim comando As New MySqlCommand



                                comando = New MySqlCommand(sentencia, Guau.conk)



                                comando.ExecuteNonQuery()

                                ciowner = ListBoxOw.SelectedItem


                                Try

                                    Dim sentenciaRel As String
                                    sentenciaRel = "UPDATE `mkarszensztejn`.`pertenece` SET 
                                `ci_cliente` = '" & ciowner & "' WHERE (`num_mascota` = '" & idQueryToMod & "');
"

                                    Dim comandoRel As New MySqlCommand
                                    comandoRel = New MySqlCommand(sentenciaRel, Guau.conk)
                                    comandoRel.ExecuteNonQuery()
                                Catch ex As Exception
                                    Throw New ArgumentException("RelacionError")
                                End Try







                            End If

                        Catch exs As Exception
                            If (exs.Message = "RelacionError") Then
                                MsgBox("Ocurrio un error. Lo sentimos.")
                            ElseIf (exs.Message = "ERRMED") Then
                                MsgBox("Si selecciona que la mascota consume medicación, debe ingresar sus detalles.")
                            Else
                                MsgBox("Ocurrió un error en el ingreso de datos." & exs.Message)
                            End If




                        End Try
                        MsgBox("Se modificó exitosamente al animal.")
                        cleanForm()


                    End If
                End If
            End If
        End If
    End Sub
End Class