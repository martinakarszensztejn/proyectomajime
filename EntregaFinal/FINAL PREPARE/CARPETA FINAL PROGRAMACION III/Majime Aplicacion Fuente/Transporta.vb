Public Class Transporta
    Public num_mascota As Integer
    Public momento_creado_transporte As DateTime
    Public matricula_camioneta As String
    Public momento_inicio_transporte As DateTime
    Public momento_fin_transporte As DateTime

    Public Sub New(num_mascota As Integer, momento_creado_transporte As Date, matricula_camioneta As String, momento_inicio_transporte As Date, momento_fin_transporte As Date)
        Me.num_mascota = num_mascota
        Me.momento_creado_transporte = momento_creado_transporte
        Me.matricula_camioneta = matricula_camioneta
        Me.momento_inicio_transporte = momento_inicio_transporte
        Me.momento_fin_transporte = momento_fin_transporte
    End Sub
End Class
