<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarestudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modificarestudiante))
        Me.tbcorreo = New System.Windows.Forms.TextBox()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.cbsexo = New System.Windows.Forms.ComboBox()
        Me.tbedad = New System.Windows.Forms.TextBox()
        Me.tbtelefono = New System.Windows.Forms.TextBox()
        Me.tb2apellido = New System.Windows.Forms.TextBox()
        Me.tb1apellido = New System.Windows.Forms.TextBox()
        Me.tb2nombre = New System.Windows.Forms.TextBox()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.tbcedula = New System.Windows.Forms.TextBox()
        Me.lbledad = New System.Windows.Forms.Label()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lblsexo = New System.Windows.Forms.Label()
        Me.lblescuela = New System.Windows.Forms.Label()
        Me.Cbescuela = New System.Windows.Forms.ComboBox()
        Me.lbl2apellido = New System.Windows.Forms.Label()
        Me.lbl1apellido = New System.Windows.Forms.Label()
        Me.lbl2nombre = New System.Windows.Forms.Label()
        Me.lbl1nombre = New System.Windows.Forms.Label()
        Me.lblcedula = New System.Windows.Forms.Label()
        Me.btbguardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'tbcorreo
        '
        Me.tbcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcorreo.Location = New System.Drawing.Point(25, 378)
        Me.tbcorreo.Name = "tbcorreo"
        Me.tbcorreo.Size = New System.Drawing.Size(222, 26)
        Me.tbcorreo.TabIndex = 63
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorreo.Location = New System.Drawing.Point(21, 355)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(63, 20)
        Me.lblcorreo.TabIndex = 62
        Me.lblcorreo.Text = "Correo*"
        '
        'cbsexo
        '
        Me.cbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsexo.FormattingEnabled = True
        Me.cbsexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cbsexo.Location = New System.Drawing.Point(209, 320)
        Me.cbsexo.Name = "cbsexo"
        Me.cbsexo.Size = New System.Drawing.Size(155, 28)
        Me.cbsexo.TabIndex = 61
        '
        'tbedad
        '
        Me.tbedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbedad.Location = New System.Drawing.Point(25, 321)
        Me.tbedad.Name = "tbedad"
        Me.tbedad.Size = New System.Drawing.Size(155, 26)
        Me.tbedad.TabIndex = 60
        '
        'tbtelefono
        '
        Me.tbtelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtelefono.Location = New System.Drawing.Point(209, 260)
        Me.tbtelefono.Name = "tbtelefono"
        Me.tbtelefono.Size = New System.Drawing.Size(155, 26)
        Me.tbtelefono.TabIndex = 59
        '
        'tb2apellido
        '
        Me.tb2apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb2apellido.Location = New System.Drawing.Point(209, 203)
        Me.tb2apellido.Name = "tb2apellido"
        Me.tb2apellido.Size = New System.Drawing.Size(155, 26)
        Me.tb2apellido.TabIndex = 58
        '
        'tb1apellido
        '
        Me.tb1apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb1apellido.Location = New System.Drawing.Point(24, 203)
        Me.tb1apellido.Name = "tb1apellido"
        Me.tb1apellido.Size = New System.Drawing.Size(155, 26)
        Me.tb1apellido.TabIndex = 57
        '
        'tb2nombre
        '
        Me.tb2nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb2nombre.Location = New System.Drawing.Point(209, 143)
        Me.tb2nombre.Name = "tb2nombre"
        Me.tb2nombre.Size = New System.Drawing.Size(155, 26)
        Me.tb2nombre.TabIndex = 56
        '
        'tbnombre
        '
        Me.tbnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnombre.Location = New System.Drawing.Point(24, 143)
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.Size = New System.Drawing.Size(155, 26)
        Me.tbnombre.TabIndex = 55
        '
        'tbcedula
        '
        Me.tbcedula.Enabled = False
        Me.tbcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcedula.Location = New System.Drawing.Point(92, 80)
        Me.tbcedula.Name = "tbcedula"
        Me.tbcedula.Size = New System.Drawing.Size(155, 26)
        Me.tbcedula.TabIndex = 54
        '
        'lbledad
        '
        Me.lbledad.AutoSize = True
        Me.lbledad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbledad.Location = New System.Drawing.Point(21, 298)
        Me.lbledad.Name = "lbledad"
        Me.lbledad.Size = New System.Drawing.Size(53, 20)
        Me.lbledad.TabIndex = 53
        Me.lbledad.Text = "Edad*"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.Location = New System.Drawing.Point(206, 237)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(77, 20)
        Me.lbltelefono.TabIndex = 52
        Me.lbltelefono.Text = "Telefono*"
        '
        'lblsexo
        '
        Me.lblsexo.AutoSize = True
        Me.lblsexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsexo.Location = New System.Drawing.Point(206, 298)
        Me.lblsexo.Name = "lblsexo"
        Me.lblsexo.Size = New System.Drawing.Size(51, 20)
        Me.lblsexo.TabIndex = 51
        Me.lblsexo.Text = "Sexo*"
        '
        'lblescuela
        '
        Me.lblescuela.AutoSize = True
        Me.lblescuela.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblescuela.Location = New System.Drawing.Point(21, 237)
        Me.lblescuela.Name = "lblescuela"
        Me.lblescuela.Size = New System.Drawing.Size(72, 20)
        Me.lblescuela.TabIndex = 50
        Me.lblescuela.Text = "Escuela*"
        '
        'Cbescuela
        '
        Me.Cbescuela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbescuela.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbescuela.FormattingEnabled = True
        Me.Cbescuela.Items.AddRange(New Object() {"Sistemas (47)"})
        Me.Cbescuela.Location = New System.Drawing.Point(24, 260)
        Me.Cbescuela.Name = "Cbescuela"
        Me.Cbescuela.Size = New System.Drawing.Size(155, 28)
        Me.Cbescuela.TabIndex = 49
        '
        'lbl2apellido
        '
        Me.lbl2apellido.AutoSize = True
        Me.lbl2apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2apellido.Location = New System.Drawing.Point(206, 180)
        Me.lbl2apellido.Name = "lbl2apellido"
        Me.lbl2apellido.Size = New System.Drawing.Size(140, 20)
        Me.lbl2apellido.TabIndex = 48
        Me.lbl2apellido.Text = "Segundo Apellido*"
        '
        'lbl1apellido
        '
        Me.lbl1apellido.AutoSize = True
        Me.lbl1apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1apellido.Location = New System.Drawing.Point(21, 180)
        Me.lbl1apellido.Name = "lbl1apellido"
        Me.lbl1apellido.Size = New System.Drawing.Size(120, 20)
        Me.lbl1apellido.TabIndex = 47
        Me.lbl1apellido.Text = "Primer Apellido*"
        '
        'lbl2nombre
        '
        Me.lbl2nombre.AutoSize = True
        Me.lbl2nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2nombre.Location = New System.Drawing.Point(206, 120)
        Me.lbl2nombre.Name = "lbl2nombre"
        Me.lbl2nombre.Size = New System.Drawing.Size(134, 20)
        Me.lbl2nombre.TabIndex = 46
        Me.lbl2nombre.Text = "Segundo Nombre"
        '
        'lbl1nombre
        '
        Me.lbl1nombre.AutoSize = True
        Me.lbl1nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1nombre.Location = New System.Drawing.Point(21, 120)
        Me.lbl1nombre.Name = "lbl1nombre"
        Me.lbl1nombre.Size = New System.Drawing.Size(120, 20)
        Me.lbl1nombre.TabIndex = 45
        Me.lbl1nombre.Text = "Primer Nombre*"
        '
        'lblcedula
        '
        Me.lblcedula.AutoSize = True
        Me.lblcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcedula.Location = New System.Drawing.Point(21, 86)
        Me.lblcedula.Name = "lblcedula"
        Me.lblcedula.Size = New System.Drawing.Size(59, 20)
        Me.lblcedula.TabIndex = 44
        Me.lblcedula.Text = "Cedula"
        '
        'btbguardar
        '
        Me.btbguardar.BackgroundImage = Global.ServicioComunitario.My.Resources.Resources.Iconodisquete
        Me.btbguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btbguardar.FlatAppearance.BorderSize = 0
        Me.btbguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btbguardar.Location = New System.Drawing.Point(314, 359)
        Me.btbguardar.Name = "btbguardar"
        Me.btbguardar.Size = New System.Drawing.Size(50, 50)
        Me.btbguardar.TabIndex = 65
        Me.btbguardar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ServicioComunitario.My.Resources.Resources.PSMbanner
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 64)
        Me.Panel1.TabIndex = 64
        '
        'modificarestudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 421)
        Me.Controls.Add(Me.btbguardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbcorreo)
        Me.Controls.Add(Me.lblcorreo)
        Me.Controls.Add(Me.cbsexo)
        Me.Controls.Add(Me.tbedad)
        Me.Controls.Add(Me.tbtelefono)
        Me.Controls.Add(Me.tb2apellido)
        Me.Controls.Add(Me.tb1apellido)
        Me.Controls.Add(Me.tb2nombre)
        Me.Controls.Add(Me.tbnombre)
        Me.Controls.Add(Me.tbcedula)
        Me.Controls.Add(Me.lbledad)
        Me.Controls.Add(Me.lbltelefono)
        Me.Controls.Add(Me.lblsexo)
        Me.Controls.Add(Me.lblescuela)
        Me.Controls.Add(Me.Cbescuela)
        Me.Controls.Add(Me.lbl2apellido)
        Me.Controls.Add(Me.lbl1apellido)
        Me.Controls.Add(Me.lbl2nombre)
        Me.Controls.Add(Me.lbl1nombre)
        Me.Controls.Add(Me.lblcedula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "modificarestudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Estudiante"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btbguardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbcorreo As TextBox
    Friend WithEvents lblcorreo As Label
    Friend WithEvents cbsexo As ComboBox
    Friend WithEvents tbedad As TextBox
    Friend WithEvents tbtelefono As TextBox
    Friend WithEvents tb2apellido As TextBox
    Friend WithEvents tb1apellido As TextBox
    Friend WithEvents tb2nombre As TextBox
    Friend WithEvents tbnombre As TextBox
    Friend WithEvents tbcedula As TextBox
    Friend WithEvents lbledad As Label
    Friend WithEvents lbltelefono As Label
    Friend WithEvents lblsexo As Label
    Friend WithEvents lblescuela As Label
    Friend WithEvents Cbescuela As ComboBox
    Friend WithEvents lbl2apellido As Label
    Friend WithEvents lbl1apellido As Label
    Friend WithEvents lbl2nombre As Label
    Friend WithEvents lbl1nombre As Label
    Friend WithEvents lblcedula As Label
End Class
