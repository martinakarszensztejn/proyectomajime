Imports MySql.Data.MySqlClient
Public Class Form1
    'PROVISORIO Public connnn As New MySqlConnectionStringBuilder
    'PROVISORIO Public conk As New MySqlConnection
    Public rangoUsuario As String
    Public userUsuario As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'PROVISORIO  Dim connnn As New MySqlConnectionStringBuilder()
            'PROVISORIO  connnn.UserID = "root"
            'PROVISORIO  connnn.Server = "localhost"
            'PROVISORIO  connnn.Database = "majime"
            'PROVISORIO  connnn.Password = "password"
            'PROVISORIO  Dim connk As New MySqlConnection(connnn.ToString)
            'PROVISORIO  conk = connk

            'PROVISORIO  If Me.conk.State = ConnectionState.Open Then
            'PROVISORIO  Me.conk.Close()
            'PROVISORIO  Me.conk.Open()
            'PROVISORIO  Else
            'PROVISORIO  Me.conk.Open()
            'PROVISORIO  End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
