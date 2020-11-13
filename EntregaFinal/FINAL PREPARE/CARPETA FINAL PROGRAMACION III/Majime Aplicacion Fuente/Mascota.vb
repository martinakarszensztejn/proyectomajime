Public Class Mascota
    Public num_mascota As Int16
    Public nombre_mascota As String
    Public raza_mascota As String
    Public sexo_mascota As Char
    Public peso_mascota As Int16
    Public fnac_mascota As Date
    Public vacunas_mascota As String

    Public Sub New(num_mascota As Short, nombre_mascota As String, raza_mascota As String, sexo_mascota As Char, peso_mascota As Short, fnac_mascota As Date, vacunas_mascota As String)
        Me.num_mascota = num_mascota
        Me.nombre_mascota = nombre_mascota
        Me.raza_mascota = raza_mascota
        Me.sexo_mascota = sexo_mascota
        Me.peso_mascota = peso_mascota
        Me.fnac_mascota = fnac_mascota
        Me.vacunas_mascota = vacunas_mascota
    End Sub
End Class
