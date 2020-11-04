Public Class Cliente
    Public ci_cliente As Integer
    Public nombre_cliente As String
    Private telefono_cliente As String
    Private celular_cliente As String
    Private direccion_cliente As String
    Private email_cliente As String

    Public Sub New(ci_cliente As Integer, nombre_cliente As String, telefono_cliente As String, celular_cliente As String, direccion_cliente As String, email_cliente As String)
        Me.ci_cliente = ci_cliente
        Me.nombre_cliente = nombre_cliente
        Me.telefono_cliente = telefono_cliente
        Me.celular_cliente = celular_cliente
        Me.direccion_cliente = direccion_cliente
        Me.email_cliente = email_cliente
    End Sub

End Class
