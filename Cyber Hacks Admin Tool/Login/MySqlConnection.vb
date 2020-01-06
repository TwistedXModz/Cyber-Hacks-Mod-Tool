Imports System.Data.SqlClient
Imports Cyber_Hacks_Admin_Tool

Public Class MySqlConnection
    Friend ReadOnly State As ConnectionState
    Private v As String

    Public Sub New(v As String)
        Me.v = v
    End Sub

    Public Shared Widening Operator CType(v As SqlConnection) As MySqlConnection
        Throw New NotImplementedException()
    End Operator

    Friend Sub Close()
        Throw New NotImplementedException()
    End Sub

    Friend Sub Open()
        Throw New NotImplementedException()
    End Sub

    Friend Function ConnectionString() As String
        Throw New NotImplementedException()
    End Function

    Friend Sub Dispose()
        Throw New NotImplementedException()
    End Sub
End Class
