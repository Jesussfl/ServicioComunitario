Imports System.Data.OleDb
Public Class Agregarprofesores

#Region "TEXTBOX NUMERICOS"
    Private Sub tbtelefono__KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbtelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
        End If
    End Sub

    Private Sub tbcedula__KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbcedula.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
        End If
    End Sub
#End Region

#Region "BOTONES"
    Private Sub btbguardar_Click(sender As Object, e As EventArgs) Handles btbguardar.Click

        If Len(Trim(tbcedula.Text)) = 0 Or Len(Trim(tbnombre.Text)) = 0 Or Len(Trim(tb1apellido.Text)) = 0 Or Len(Trim(tb2apellido.Text)) = 0 Or Len(Trim(tbcorreo.Text)) = 0 Or Len(Trim(tbtelefono.Text)) = 0 Then
            MsgBox("Rellene todos los campos obligatorios", MsgBoxStyle.Information)

        Else
            abrirconexiones()

            Dim str As String
            str = "insert into profesores ([cedula], [primernombre], [segundonombre], [primerapellido]," _
                            & "[segundoapellido], [correo], [telefono]) values (?, ?, ?, ?, ?, ?, ?)"

            Dim cmd As OleDbCommand = New OleDbCommand(str, Conexion)
            cmd.Parameters.Add(New OleDbParameter("cedula", CType(tbcedula.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("primernombre", CType(tbnombre.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("segundonombre", CType(tb2nombre.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("primerapellido", CType(tb1apellido.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("segundoapellido", CType(tb2apellido.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("correo", CType(tbcorreo.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("telefono", CType(tbtelefono.Text, String)))

            Try
                cmd.ExecuteNonQuery()
                MsgBox("El profesor ha sido registrado correctamente!", MsgBoxStyle.Information)
                Profesores.Close()
                Index.abrirformulario(New Profesores)
                Me.Close()

            Catch ex As Exception
                MsgBox("La cedula de identidad ingresada ya se encuentra registrada en otro ususario", MsgBoxStyle.Information)
            End Try

            Conexion.Close()

        End If

    End Sub

#End Region

End Class