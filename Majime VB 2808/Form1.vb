Imports MySql.Data.MySqlClient
Public Class Form1
    Public connnn As New MySqlConnectionStringBuilder
    Public conGlob As New MySqlConnection

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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
            Dim conn As New MySqlConnection(connnn.ToString)
            conGlob = conn

            conn.Open()

        Catch ex As Exception

        End Try
    End Sub
End Class
