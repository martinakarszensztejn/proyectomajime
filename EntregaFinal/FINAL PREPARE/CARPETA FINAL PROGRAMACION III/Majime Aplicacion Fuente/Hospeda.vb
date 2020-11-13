Public Class Hospeda
    Public nombre_tipo_habitacion As String
    Public num_hab As Int32
    Public num_masc As Int32
    Public momento_reserva As DateTime
    Public momento_arribo_reserva As DateTime
    Public momento_partida_reserva As DateTime
    Public num_reserva As Int32
    Public ci_oficinista As Int32
    Public estado_reserva As String
    Public extras_reserva As Int32
    Public modalidad_pago_reserva As Boolean
    Public precio_reserva As Int32

    Public Sub New(nombre_tipo_habitacion As String, num_hab As Integer, num_masc As Integer, momento_reserva As Date, momento_arribo_reserva As Date, momento_partida_reserva As Date, num_reserva As Integer, ci_oficinista As Integer, estado_reserva As String, extras_reserva As Integer, modalidad_pago_reserva As Boolean, precio_reserva As Integer)
        Me.nombre_tipo_habitacion = nombre_tipo_habitacion
        Me.num_hab = num_hab
        Me.num_masc = num_masc
        Me.momento_reserva = momento_reserva
        Me.momento_arribo_reserva = momento_arribo_reserva
        Me.momento_partida_reserva = momento_partida_reserva
        Me.num_reserva = num_reserva
        Me.ci_oficinista = ci_oficinista
        Me.estado_reserva = estado_reserva
        Me.extras_reserva = extras_reserva
        Me.modalidad_pago_reserva = modalidad_pago_reserva
        Me.precio_reserva = precio_reserva
    End Sub
End Class
