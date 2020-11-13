
Public Class MenuInicio






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Guau.AbrirFormEnPanel(New Login)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Guau.AbrirFormEnPanel(New Registro)
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim findError As Boolean

        cargar()





    End Sub
    Public Function cargar() As Boolean
        Dim resultCarga As Boolean
        resultCarga = False
        Try
            Guau.conk.Open()
            resultCarga = True
        Catch ex As Exception


        End Try
        Return resultCarga
    End Function
End Class
