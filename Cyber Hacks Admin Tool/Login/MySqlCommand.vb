Imports System.Data.SqlClient
Imports Cyber_Hacks_Admin_Tool

Friend Class MySqlCommand
    Private p As Object
    Private v As String

    Public Sub New(v As String, p As Object)
        Me.v = v
        Me.p = p
    End Sub

    Friend Function Parameters() As Object
        Throw New NotImplementedException()
    End Function

    Public Shared Widening Operator CType(v As MySqlCommand) As SqlCommand
        Throw New NotImplementedException()
    End Operator
End Class
