<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Index
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Index))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nombreusuario = New System.Windows.Forms.Label()
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnservcomunitario = New System.Windows.Forms.Button()
        Me.submenuregistro = New System.Windows.Forms.Panel()
        Me.btnprofesores = New System.Windows.Forms.Button()
        Me.btnestudiantes = New System.Windows.Forms.Button()
        Me.btnregistro = New System.Windows.Forms.Button()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.PanelSideMenu.SuspendLayout()
        Me.submenuregistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.nombreusuario)
        Me.Panel1.Location = New System.Drawing.Point(283, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 72)
        Me.Panel1.TabIndex = 8
        '
        'nombreusuario
        '
        Me.nombreusuario.AutoSize = True
        Me.nombreusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreusuario.ForeColor = System.Drawing.Color.White
        Me.nombreusuario.Location = New System.Drawing.Point(23, 19)
        Me.nombreusuario.Name = "nombreusuario"
        Me.nombreusuario.Size = New System.Drawing.Size(211, 25)
        Me.nombreusuario.TabIndex = 0
        Me.nombreusuario.Text = "Nombre de usuario"
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.AutoSize = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.btnsalir)
        Me.PanelSideMenu.Controls.Add(Me.btn2)
        Me.PanelSideMenu.Controls.Add(Me.btn1)
        Me.PanelSideMenu.Controls.Add(Me.btnservcomunitario)
        Me.PanelSideMenu.Controls.Add(Me.submenuregistro)
        Me.PanelSideMenu.Controls.Add(Me.btnregistro)
        Me.PanelSideMenu.Controls.Add(Me.panelLogo)
        Me.PanelSideMenu.Location = New System.Drawing.Point(-3, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(286, 561)
        Me.PanelSideMenu.TabIndex = 7
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnsalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnsalir.FlatAppearance.BorderSize = 0
        Me.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(0, 511)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnsalir.Size = New System.Drawing.Size(286, 50)
        Me.btnsalir.TabIndex = 9
        Me.btnsalir.Text = "  Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btn2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2.Location = New System.Drawing.Point(0, 389)
        Me.btn2.Name = "btn2"
        Me.btn2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn2.Size = New System.Drawing.Size(286, 50)
        Me.btn2.TabIndex = 8
        Me.btn2.Text = "---"
        Me.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btn1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1.Location = New System.Drawing.Point(0, 339)
        Me.btn1.Name = "btn1"
        Me.btn1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn1.Size = New System.Drawing.Size(286, 50)
        Me.btn1.TabIndex = 6
        Me.btn1.Text = "---"
        Me.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btnservcomunitario
        '
        Me.btnservcomunitario.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnservcomunitario.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnservcomunitario.FlatAppearance.BorderSize = 0
        Me.btnservcomunitario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnservcomunitario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnservcomunitario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnservcomunitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnservcomunitario.ForeColor = System.Drawing.Color.White
        Me.btnservcomunitario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnservcomunitario.Location = New System.Drawing.Point(0, 289)
        Me.btnservcomunitario.Name = "btnservcomunitario"
        Me.btnservcomunitario.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnservcomunitario.Size = New System.Drawing.Size(286, 50)
        Me.btnservcomunitario.TabIndex = 5
        Me.btnservcomunitario.Text = "Servicio Comunitario"
        Me.btnservcomunitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnservcomunitario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnservcomunitario.UseVisualStyleBackColor = False
        '
        'submenuregistro
        '
        Me.submenuregistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.submenuregistro.Controls.Add(Me.btnprofesores)
        Me.submenuregistro.Controls.Add(Me.btnestudiantes)
        Me.submenuregistro.Dock = System.Windows.Forms.DockStyle.Top
        Me.submenuregistro.Location = New System.Drawing.Point(0, 189)
        Me.submenuregistro.Name = "submenuregistro"
        Me.submenuregistro.Size = New System.Drawing.Size(286, 100)
        Me.submenuregistro.TabIndex = 2
        '
        'btnprofesores
        '
        Me.btnprofesores.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnprofesores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnprofesores.FlatAppearance.BorderSize = 0
        Me.btnprofesores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnprofesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnprofesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprofesores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprofesores.ForeColor = System.Drawing.Color.White
        Me.btnprofesores.Location = New System.Drawing.Point(0, 50)
        Me.btnprofesores.Name = "btnprofesores"
        Me.btnprofesores.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnprofesores.Size = New System.Drawing.Size(286, 50)
        Me.btnprofesores.TabIndex = 1
        Me.btnprofesores.Text = "Profesores"
        Me.btnprofesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnprofesores.UseVisualStyleBackColor = False
        '
        'btnestudiantes
        '
        Me.btnestudiantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnestudiantes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnestudiantes.FlatAppearance.BorderSize = 0
        Me.btnestudiantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnestudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnestudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnestudiantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnestudiantes.ForeColor = System.Drawing.Color.White
        Me.btnestudiantes.Location = New System.Drawing.Point(0, 0)
        Me.btnestudiantes.Name = "btnestudiantes"
        Me.btnestudiantes.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnestudiantes.Size = New System.Drawing.Size(286, 50)
        Me.btnestudiantes.TabIndex = 0
        Me.btnestudiantes.Text = "Estudiantes"
        Me.btnestudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnestudiantes.UseVisualStyleBackColor = False
        '
        'btnregistro
        '
        Me.btnregistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnregistro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnregistro.FlatAppearance.BorderSize = 0
        Me.btnregistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnregistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistro.ForeColor = System.Drawing.Color.White
        Me.btnregistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregistro.Location = New System.Drawing.Point(0, 139)
        Me.btnregistro.Name = "btnregistro"
        Me.btnregistro.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnregistro.Size = New System.Drawing.Size(286, 50)
        Me.btnregistro.TabIndex = 1
        Me.btnregistro.Text = "Registro"
        Me.btnregistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnregistro.UseVisualStyleBackColor = False
        '
        'panelLogo
        '
        Me.panelLogo.BackgroundImage = Global.ServicioComunitario.My.Resources.Resources.PSMlogo
        Me.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(286, 139)
        Me.panelLogo.TabIndex = 0
        '
        'PanelChildForm
        '
        Me.PanelChildForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelChildForm.BackgroundImage = Global.ServicioComunitario.My.Resources.Resources.PSMsede
        Me.PanelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelChildForm.Location = New System.Drawing.Point(283, 70)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(655, 491)
        Me.PanelChildForm.TabIndex = 9
        '
        'Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de registro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelSideMenu.ResumeLayout(False)
        Me.submenuregistro.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents nombreusuario As Label
    Private WithEvents PanelSideMenu As Panel
    Private WithEvents btnsalir As Button
    Private WithEvents btn2 As Button
    Private WithEvents btn1 As Button
    Private WithEvents btnservcomunitario As Button
    Private WithEvents submenuregistro As Panel
    Private WithEvents btnprofesores As Button
    Private WithEvents btnestudiantes As Button
    Private WithEvents btnregistro As Button
    Private WithEvents panelLogo As Panel
    Friend WithEvents PanelChildForm As Panel
End Class
