Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class AgregarMascota
    Public clientesCI(0) As Integer
    Public clientesNom(0) As String
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

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

    Private Sub AgregarMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"

        ''''''''''''''''''''


        Dim consulta As String
        consulta = "Select * From majime.cliente;"

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

                    sentencia = "INSERT INTO `majime`.`mascota` (`nombre_mascota`, `raza_mascota`, `sexo_mascota`, `peso_mascota`, `fecha_nac_mascota`, `vacunas_mascota`, `toma_medicacion_mascota`, `medicacion_mascota`, `dosis_medicacion_mascota`, `horario_medicacion_mascota`, `complementos_mascota`) VALUES ('" & TextBoxNom.Text.ToLower & "', '" & TextBoxRaza.Text.ToLower & "', '" & sexoanimal & "', " & TextBoxPeso.Text & ", '" & fnacc & "', '" & TextBoxVac.Text.ToLower & "'," & tomamedicamentos & ",'" & TextBoxMed.Text.ToLower & "','" & TextBoxDos.Text.ToLower & "','" & TextBoxHor.Text.ToLower & "','" & TextBoxCA.Text.ToLower & "' );"

                    Dim comando As New MySqlCommand



                    comando = New MySqlCommand(sentencia, Guau.conk)



                    comando.ExecuteNonQuery()



                    MsgBox("Se agregó exitosamente al animal.")

                Catch ex As Exception

                    MsgBox("Ocurrió un error en el ingreso de datos." & ex.Message)



                End Try





            End If
        End If
    End Sub
End Class