Public Class Index
#Region "GLOBALES"

    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ocultarsubmenu()

    End Sub

    Private Sub ocultarsubmenu()

        submenuregistro.Visible = False

    End Sub

    Private Sub mostrarsubmenu(submenu As Panel)

        If submenu.Visible = False Then
            ocultarsubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private currentForm As Form = Nothing
    Public Sub abrirformulario(childForm As Form)

        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub
#End Region

#Region "PANEL LATERAL"
    Private Sub btnregistro_Click(sender As Object, e As EventArgs) Handles btnregistro.Click

        mostrarsubmenu(submenuregistro)

    End Sub

#Region "SUBMENU"
    Private Sub btnestudiantes_Click(sender As Object, e As EventArgs) Handles btnestudiantes.Click

        abrirformulario(New Estudiantes)

    End Sub

    Private Sub btnprofesores_Click(sender As Object, e As EventArgs) Handles btnprofesores.Click

        abrirformulario(New Profesores)

    End Sub
#End Region

    Private Sub btnservcomunitario_Click(sender As Object, e As EventArgs) Handles btnservcomunitario.Click

        abrirformulario(New Serviciocomunitario)
        ocultarsubmenu()

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        ocultarsubmenu()

    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        ocultarsubmenu()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnsalir.Click

        Application.Exit()

    End Sub

    Private Sub nombreusuario_Click(sender As Object, e As EventArgs) Handles nombreusuario.Click

    End Sub
#End Region

End Class