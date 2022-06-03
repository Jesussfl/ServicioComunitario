Imports System.Data.OleDb
Public Class modificarestudiante
    Private Sub btbguardar_Click(sender As Object, e As EventArgs) Handles btbguardar.Click
        If Len(Trim(tbcedula.Text)) = 0 Or Len(Trim(tbnombre.Text)) = 0 Or Len(Trim(tb1apellido.Text)) = 0 _
            Or Len(Trim(tb2apellido.Text)) = 0 Or Len(Trim(tbcorreo.Text)) = 0 Or Len(Trim(tbtelefono.Text)) = 0 _
            Or Len(Trim(tbedad.Text)) = 0 Or Len(Trim(Cbescuela.Text)) = 0 Or Len(Trim(cbsexo.Text)) = 0 Then

            MsgBox("Rellene todos los campos obligatorios", MsgBoxStyle.Information)

        Else

            abrirconexiones()

            Dim str As String
            str = "Update estudiante Set primernombre='" & tbnombre.Text & "', segundonombre='" & tb2nombre.Text & "'," _
            & "primerapellido='" & tb1apellido.Text & "',segundoapellido='" & tb2apellido.Text & "', " _
            & "escuela='" & Cbescuela.Text & "', telefono='" & tbtelefono.Text & "',correo='" & tbcorreo.Text & "'," _
            & "edad='" & tbedad.Text & "', sexo='" & cbsexo.Text & "' Where cedula='" & tbcedula.Text & "'"

            Dim cmd As OleDbCommand = New OleDbCommand(str, Conexion)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("El registro ha sido modificado correctamente", MsgBoxStyle.Information)
                Estudiantes.Close()
                Index.abrirformulario(New Estudiantes)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Conexion.Close()
            Me.Close()
        End If

    End Sub

End Class