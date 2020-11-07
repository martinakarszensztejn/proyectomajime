Public Class Habitacion
    Public nombre_tipo_hab As String
    Public cant_hab As Int32
    Private met_ext_hab As Int32
    Private met_int_hab As Int32
    Public lim_peso_hab As Int32
    Private calefaccion_hab As Boolean
    Private sonda_hab As Boolean
    Private ac_hab As Boolean
    Private musica_hab As Boolean
    Private zonacomun_hab As Boolean
    Public dogtv_hab As Boolean
    Public webcam_hab As Boolean

    Public Sub New(nombre_tipo_hab As String, cant_hab As Integer, met_ext_hab As Integer, met_int_hab As Integer, lim_peso_hab As Integer, calefaccion_hab As Boolean, sonda_hab As Boolean, ac_hab As Boolean, musica_hab As Boolean, zonacomun_hab As Boolean, dogtv_hab As Boolean, webcam_hab As Boolean)
        Me.nombre_tipo_hab = nombre_tipo_hab
        Me.cant_hab = cant_hab
        Me.met_ext_hab = met_ext_hab
        Me.met_int_hab = met_int_hab
        Me.lim_peso_hab = lim_peso_hab
        Me.calefaccion_hab = calefaccion_hab
        Me.sonda_hab = sonda_hab
        Me.ac_hab = ac_hab
        Me.musica_hab = musica_hab
        Me.zonacomun_hab = zonacomun_hab
        Me.dogtv_hab = dogtv_hab
        Me.webcam_hab = webcam_hab
    End Sub
End Class
