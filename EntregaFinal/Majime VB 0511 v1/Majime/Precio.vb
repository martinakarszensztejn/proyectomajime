Public Class Precio
    Public num_precio As Integer
    Public precio_1m As Double
    Public precio_2m As Double
    Public precio_3m As Double

    Public Sub New(num_precio As Integer, precio_1m As Double, precio_2m As Double, precio_3m As Double)
        Me.num_precio = num_precio
        Me.precio_1m = precio_1m
        Me.precio_2m = precio_2m
        Me.precio_3m = precio_3m
    End Sub
End Class
