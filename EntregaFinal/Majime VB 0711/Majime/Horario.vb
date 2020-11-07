Public Class Horario
    Public num_periodo As Int32
    Public hora_inicio As DateTime
    Public hora_fin As DateTime

    Public Sub New(num_periodo As Integer, hora_inicio As Date, hora_fin As Date)
        Me.num_periodo = num_periodo
        Me.hora_inicio = hora_inicio
        Me.hora_fin = hora_fin
    End Sub
End Class
