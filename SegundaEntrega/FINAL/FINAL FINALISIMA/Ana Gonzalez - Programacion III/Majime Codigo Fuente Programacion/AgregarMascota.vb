Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class AgregarMascota
    Public clientesCI(0) As Integer
    Public clientesNom(0) As String


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Guau.rangoUsuario = Guau.rangos(0) Then
            Guau.AbrirFormEnPanel(New MainGerente)
        ElseIf Guau.rangoUsuario = Guau.rangos(2) Then
            Guau.AbrirFormEnPanel(New MainRecepcionistaGaraje)
        ElseIf Guau.rangoUsuario = Guau.rangos(1) Then
            Guau.AbrirFormEnPanel(New MainOficinista)
        End If
    End Sub

    Private Sub AgregarMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"

        ''''''''''''''''''''


        Dim consulta As String
        consulta = "Select * From cliente;"

        Dim comando As New MySqlCommand(consulta, Guau.conk)

        Dim drd As MySqlDataReader

        If Guau.conk.State.Open Then
            Guau.conk.Close()
            Guau.conk.Open()

        Else

        End If
        drd = comando.ExecuteReader

        Dim exito As Boolean

        exito = False
        Dim valorlong As Integer
        Try
            While drd.HasRows()


                While drd.Read()

                    exito = True
                    clientesCI(clientesCI.Length() - 1) = drd.GetString(0)
                    clientesNom(clientesNom.Length() - 1) = drd.GetString(1)

                    valorlong = clientesCI.Length
                    ReDim Preserve clientesCI(valorlong)
                    ReDim Preserve clientesNom(valorlong)

                End While

                drd.NextResult()

            End While
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado. Intente más tarde.")
        End Try

        If exito Then

            ListBox1.Items.Clear()
            For index = 0 To (clientesCI.Length - 2)
                ListBox1.Items.Add(clientesCI(index).ToString & " - " & clientesNom(index).ToString.ToUpper)
            Next




        End If


        drd.Close()





        ''''''''''''''

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBoxNom.Text = ""
        TextBoxRaza.Text = ""
        TextBoxVac.Text = ""
        TextBoxPeso.Text = ""
        TextBoxMed.Text = ""
        TextBoxDos.Text = ""
        TextBoxHor.Text = ""
        TextBoxCA.Text = ""
        RadioButtonM.Checked = False
        RadioButtonF.Checked = False
        RadioButtonSi.Checked = False
        RadioButtonNo.Checked = False
        ListBox1.SelectedItem = 1
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSi.CheckedChanged
        If RadioButtonSi.Checked Then
            Label7.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            TextBoxMed.Visible = True
            TextBoxDos.Visible = True
            TextBoxHor.Visible = True
        Else
            Label7.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            TextBoxMed.Visible = False
            TextBoxDos.Visible = False
            TextBoxHor.Visible = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNo.CheckedChanged
        If RadioButtonSi.Checked Then
            Label7.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            TextBoxMed.Visible = True
            TextBoxDos.Visible = True
            TextBoxHor.Visible = True
        Else
            Label7.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            TextBoxMed.Visible = False
            TextBoxDos.Visible = False
            TextBoxHor.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Guau.AbrirFormEnPanel(New AgregarCliente)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxNom.Text <> "" OrElse TextBoxPeso.Text <> "" OrElse (RadioButtonSi.Checked = False AndAlso RadioButtonNo.Checked = False) Then
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
                        If RadioButtonSi.Checked = True Then
                            tomamedicamentos = 1

                        ElseIf RadioButtonNo.Checked = True Then
                            tomamedicamentos = 0

                        End If

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
                            sentencia = "INSERT INTO `mascota` (`nombre_mascota`, `raza_mascota`, `sexo_mascota`, `peso_mascota`, `fnac_mascota`, `vacunas_mascota`,`complementos_mascota`) VALUES ('" & TextBoxNom.Text.ToLower & "', '" & TextBoxRaza.Text.ToLower & "', '" & sexoanimal & "', " & TextBoxPeso.Text & ", '" & fnacc & "', '" & TextBoxVac.Text.ToLower & "','" & TextBoxCA.Text.ToLower & "' );"

                            Dim comando As New MySqlCommand



                            comando = New MySqlCommand(sentencia, Guau.conk)



                            comando.ExecuteNonQuery()

                            ciowner = 0
                            ciowner = dueño.Chars(0)
                            ciowner = ciowner & dueño.Chars(1)
                            ciowner = ciowner & dueño.Chars(2)
                            ciowner = ciowner & dueño.Chars(3)
                            ciowner = ciowner & dueño.Chars(4)
                            ciowner = ciowner & dueño.Chars(5)
                            ciowner = ciowner & dueño.Chars(6)


                            Try
                                If dueño.Chars(7) = " " Then
                                    ciownerInt = Integer.Parse(ciowner)
                                ElseIf dueño.Chars(8) = " " Then
                                    ciowner = ciowner & dueño.Chars(7)
                                    ciownerInt = Integer.Parse(ciowner)
                                End If
                                Dim sentenciaRel As String = "INSERT INTO `pertenece` (`num_mascota`,`ci_cliente`) VALUES((Select num_mascota FROM `mascota` ORDER BY num_mascota DESC LIMIT 1 ),(" & ciownerInt & "));"


                                Dim comandoRel As New MySqlCommand
                                comandoRel = New MySqlCommand(sentenciaRel, Guau.conk)
                                comandoRel.ExecuteNonQuery()
                            Catch ex As Exception
                                Throw New ArgumentException("RelacionError")
                            End Try




                            Try
                                Dim sentenciaMedic As String = "INSERT INTO `medicacion` (`nombre_medicacion`,`dosis_medicacion`,`horario_medicacion`) VALUES( '" & TextBoxMed.Text & "', '" & TextBoxDos.Text & "', '" & TextBoxHor.Text & "');"


                                Dim comandoMedic As New MySqlCommand
                                comandoMedic = New MySqlCommand(sentenciaMedic, Guau.conk)
                                comandoMedic.ExecuteNonQuery()




                                Dim sentenciaRelMed As String = "INSERT INTO `consume` (`num_mascota`,`num_medicacion`) VALUES((Select num_mascota FROM `mascota` ORDER BY num_mascota DESC LIMIT 1 ),(Select num_medicacion FROM `medicacion` ORDER BY num_medicacion DESC LIMIT 1));"


                                Dim comandoRelMed As New MySqlCommand
                                comandoRelMed = New MySqlCommand(sentenciaRelMed, Guau.conk)
                                comandoRelMed.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox("Error ingresando los datos de medicacion.")

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
                    MsgBox("Se agregó exitosamente al animal.")


                End If

            End If
        End If
    End Sub


End Class


