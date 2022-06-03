Module Conexiones

    Public Conexion As OleDb.OleDbConnection

    Public Sub abrirconexiones()

        Try
            Conexion = New OleDb.OleDbConnection
            Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0; Data Source=serviciocomunitarioBD.accdb;"
            Conexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos", vbCritical, "Error")
        End Try



    End Sub

End Module
