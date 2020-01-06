Imports MySql.Data.MySqlClient
Friend Class MY_CONNECTION

    Public Class MY_CONNECTION

        ' first we need to download the mysql connector & add it to our project
        ' https://dev.mysql.com/downloads/connector/net/8.0.html
        ' open xampp
        ' create the mysql database using phpmyadmin
        ' create the database and name it "vbnet_users_db"
        ' create a table and name it "users"
        ' create the connection

        Private connection As New MySqlConnection("datasource=remotemysql.com;port=3306;username=7ypUckro3p;password=gZGpuHlCvA;database=7ypUckro3p")

        ' return the connection
        ReadOnly Property getConnection() As MySqlConnection
            Get
                Return connection
            End Get
        End Property

        ' open the connection
        Sub openConnection()

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

        End Sub

        ' close the connection
        Sub closeConnection()

            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

        End Sub

    End Class

    Friend Function getConnection() As Object
        Throw New NotImplementedException()
    End Function
End Class
