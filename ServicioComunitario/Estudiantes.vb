Imports System.Data.OleDb
Public Class Estudiantes

#Region "GLOBALES"
    Private Sub Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        abrirconexiones()
        cargargrid()
        definircolumnas()

    End Sub

    Public Sub cargargrid()

        Dim da As New OleDb.OleDbDataAdapter("select * from estudiante", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If

    End Sub


#Region "nombre de columnas+"
    Public Sub definircolumnas()

        If (DataGridView1.Columns.Count = 0) Then

        Else
            DataGridView1.Columns(0).HeaderText = "Cedula de Identidad"
            DataGridView1.Columns(1).HeaderText = "Primer Nombre"
            DataGridView1.Columns(2).HeaderText = "Segundo Nombre"
            DataGridView1.Columns(3).HeaderText = "Primer Apellido"
            DataGridView1.Columns(4).HeaderText = "Segundo Apellido"
            DataGridView1.Columns(5).HeaderText = "Escuela"
            DataGridView1.Columns(6).HeaderText = "Telefono"
            DataGridView1.Columns(7).HeaderText = "Correo Electronico"
            DataGridView1.Columns(8).HeaderText = "Edad"
            DataGridView1.Columns(9).HeaderText = "Sexo"

            DataGridView1.Columns(5).Width = 35
            DataGridView1.Columns(8).Width = 15
            DataGridView1.Columns(9).Width = 30
        End If


    End Sub
#End Region
#End Region

#Region "BOTONES"

    Private Sub btncerrarpestaña_Click(sender As Object, e As EventArgs) Handles btncerrarpestaña.Click

        Me.Close()

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        If MsgBox("Deseas eliminar el estudiante seleccionado?", CType(vbQuestion + vbYesNo, MsgBoxStyle),
                  "Eliminar registro") = vbNo Then Exit Sub

        abrirconexiones()

        Dim str As String

        str = "Delete from estudiante Where cedula= '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, Conexion)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("El estudiante ha sido eliminado correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cargargrid()
        Conexion.Close()

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Agregarestudiante.Show()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        modificarestudiante.Show()
        modificarestudiante.tbcedula.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        modificarestudiante.tbnombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        modificarestudiante.tb2nombre.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        modificarestudiante.tb1apellido.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        modificarestudiante.tb2apellido.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        modificarestudiante.tbtelefono.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        modificarestudiante.tbcorreo.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        modificarestudiante.tbedad.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()

    End Sub

#End Region

End Class