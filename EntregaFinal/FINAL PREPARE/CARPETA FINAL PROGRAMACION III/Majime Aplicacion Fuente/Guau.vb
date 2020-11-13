Imports MySql.Data.MySqlClient
Public Class Guau

    Public rangos() As String = {"Gerente", "Oficinista", "Recepcionista de Garaje"}
    Public rangoUsuario As String
    Public ci_usuario As String
    Public clavesDeRangoPrivadas() As String = {"*31PYE9puo7PW470IJkAZq*t", "5mZ&sd$&wBU9@0YV1OXNx1Qn", "n1ck1"}

    Public connnn As New MySqlConnectionStringBuilder
    Public conk As New MySqlConnection


    Public Sub AbrirFormEnPanel(ByVal FormHijo As Object)
        If Me.Panel1.Controls.Count > 0 Then
            Me.Panel1.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(FormHijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        fh.MdiParent = Me.MdiParent
        Me.Panel1.Controls.Add(fh)
        Me.Panel1.Tag = fh
        fh.Show()

    End Sub



    Private Sub Guau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormEnPanel(New MenuInicio)

        Dim connnn As New MySqlConnectionStringBuilder()
        connnn.UserID = "root"
        connnn.Server = "127.0.0.1"
        connnn.Database = "mkarszensztejn"
        connnn.Password = "password"
        Dim connk As New MySqlConnection(connnn.ToString)
        conk = connk








    End Sub
End Class