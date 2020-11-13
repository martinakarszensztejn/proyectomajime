Public Class Camioneta
    Public matricula As String
    Private marca As String
    Private modelo As String
    Public capacidad As Integer

    Public Sub New(matricula As String, marca As String, modelo As String, capacidad As Short)
        Me.matricula = matricula
        Me.marca = marca
        Me.modelo = modelo
        Me.capacidad = capacidad
    End Sub
End Class
