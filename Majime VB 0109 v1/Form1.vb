Imports MySql.Data.MySqlClient
Public Class Form1
    Public connnn As New MySqlConnectionStringBuilder
    Public connk As New MySqlConnection



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connnn As New MySqlConnectionStringBuilder()
            connnn.UserID = "root"
            connnn.Server = "localhost"
            connnn.Database = "majime"
            connnn.Password = "password"
            connk = New MySqlConnection(connnn.ToString)
            If connk.State = ConnectionState.Open Then
                connk.Close()
            Else
                connk.Open()
            End If

        Catch ex As Exception

        End Try
    End Sub


End Class
