<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregarprofesores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregarprofesores))
        Me.tbcorreo = New System.Windows.Forms.TextBox()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.tbtelefono = New System.Windows.Forms.TextBox()
        Me.tb2apellido = New System.Windows.Forms.TextBox()
        Me.tb1apellido = New System.Windows.Forms.TextBox()
        Me.tb2nombre = New System.Windows.Forms.TextBox()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.tbcedula = New System.Windows.Forms.TextBox()
        Me.lbltelefono = New System.Windows.Forms.Label()
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
        Me.tbcorreo.Location = New System.Drawing.Point(24, 270)
        Me.tbcorreo.Name = "tbcorreo"
        Me.tbcorreo.Size = New System.Drawing.Size(155, 26)
        Me.tbcorreo.TabIndex = 63
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorreo.Location = New System.Drawing.Point(21, 247)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(63, 20)
        Me.lblcorreo.TabIndex = 62
        Me.lblcorreo.Text = "Correo*"
        '
        'tbtelefono
        '
        Me.tbtelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtelefono.Location = New System.Drawing.Point(209, 270)
        Me.tbtelefono.Name = "tbtelefono"
        Me.tbtelefono.Size = New System.Drawing.Size(155, 26)
        Me.tbtelefono.TabIndex = 59
        '
        'tb2apellido
        '
        Me.tb2apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb2apellido.Location = New System.Drawing.Point(209, 209)
        Me.tb2apellido.Name = "tb2apellido"
        Me.tb2apellido.Size = New System.Drawing.Size(155, 26)
        Me.tb2apellido.TabIndex = 58
        '
        'tb1apellido
        '
        Me.tb1apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb1apellido.Location = New System.Drawing.Point(24, 209)
        Me.tb1apellido.Name = "tb1apellido"
        Me.tb1apellido.Size = New System.Drawing.Size(155, 26)
        Me.tb1apellido.TabIndex = 57
        '
        'tb2nombre
        '
        Me.tb2nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb2nombre.Location = New System.Drawing.Point(209, 149)
        Me.tb2nombre.Name = "tb2nombre"
        Me.tb2nombre.Size = New System.Drawing.Size(155, 26)
        Me.tb2nombre.TabIndex = 56
        '
        'tbnombre
        '
        Me.tbnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnombre.Location = New System.Drawing.Point(24, 149)
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.Size = New System.Drawing.Size(155, 26)
        Me.tbnombre.TabIndex = 55
        '
        'tbcedula
        '
        Me.tbcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcedula.Location = New System.Drawing.Point(92, 86)
        Me.tbcedula.Name = "tbcedula"
        Me.tbcedula.Size = New System.Drawing.Size(155, 26)
        Me.tbcedula.TabIndex = 54
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.Location = New System.Drawing.Point(206, 247)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(77, 20)
        Me.lbltelefono.TabIndex = 52
        Me.lbltelefono.Text = "Telefono*"
        '
        'lbl2apellido
        '
        Me.lbl2apellido.AutoSize = True
        Me.lbl2apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2apellido.Location = New System.Drawing.Point(206, 186)
        Me.lbl2apellido.Name = "lbl2apellido"
        Me.lbl2apellido.Size = New System.Drawing.Size(140, 20)
        Me.lbl2apellido.TabIndex = 48
        Me.lbl2apellido.Text = "Segundo Apellido*"
        '
        'lbl1apellido
        '
        Me.lbl1apellido.AutoSize = True
        Me.lbl1apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1apellido.Location = New System.Drawing.Point(21, 186)
        Me.lbl1apellido.Name = "lbl1apellido"
        Me.lbl1apellido.Size = New System.Drawing.Size(120, 20)
        Me.lbl1apellido.TabIndex = 47
        Me.lbl1apellido.Text = "Primer Apellido*"
        '
        'lbl2nombre
        '
        Me.lbl2nombre.AutoSize = True
        Me.lbl2nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2nombre.Location = New System.Drawing.Point(206, 126)
        Me.lbl2nombre.Name = "lbl2nombre"
        Me.lbl2nombre.Size = New System.Drawing.Size(134, 20)
        Me.lbl2nombre.TabIndex = 46
        Me.lbl2nombre.Text = "Segundo Nombre"
        '
        'lbl1nombre
        '
        Me.lbl1nombre.AutoSize = True
        Me.lbl1nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1nombre.Location = New System.Drawing.Point(21, 126)
        Me.lbl1nombre.Name = "lbl1nombre"
        Me.lbl1nombre.Size = New System.Drawing.Size(120, 20)
        Me.lbl1nombre.TabIndex = 45
        Me.lbl1nombre.Text = "Primer Nombre*"
        '
        'lblcedula
        '
        Me.lblcedula.AutoSize = True
        Me.lblcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcedula.Location = New System.Drawing.Point(21, 92)
        Me.lblcedula.Name = "lblcedula"
        Me.lblcedula.Size = New System.Drawing.Size(65, 20)
        Me.lblcedula.TabIndex = 44
        Me.lblcedula.Text = "Cedula*"
        '
        'btbguardar
        '
        Me.btbguardar.BackgroundImage = Global.ServicioComunitario.My.Resources.Resources.Iconodisquete
        Me.btbguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btbguardar.FlatAppearance.BorderSize = 0
        Me.btbguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btbguardar.Location = New System.Drawing.Point(314, 309)
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
        'Agregarprofesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 371)
        Me.Controls.Add(Me.btbguardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbcorreo)
        Me.Controls.Add(Me.lblcorreo)
        Me.Controls.Add(Me.tbtelefono)
        Me.Controls.Add(Me.tb2apellido)
        Me.Controls.Add(Me.tb1apellido)
        Me.Controls.Add(Me.tb2nombre)
        Me.Controls.Add(Me.tbnombre)
        Me.Controls.Add(Me.tbcedula)
        Me.Controls.Add(Me.lbltelefono)
        Me.Controls.Add(Me.lbl2apellido)
        Me.Controls.Add(Me.lbl1apellido)
        Me.Controls.Add(Me.lbl2nombre)
        Me.Controls.Add(Me.lbl1nombre)
        Me.Controls.Add(Me.lblcedula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregarprofesores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Profesor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btbguardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbcorreo As TextBox
    Friend WithEvents lblcorreo As Label
    Friend WithEvents tbtelefono As TextBox
    Friend WithEvents tb2apellido As TextBox
    Friend WithEvents tb1apellido As TextBox
    Friend WithEvents tb2nombre As TextBox
    Friend WithEvents tbnombre As TextBox
    Friend WithEvents tbcedula As TextBox
    Friend WithEvents lbltelefono As Label
    Friend WithEvents lbl2apellido As Label
    Friend WithEvents lbl1apellido As Label
    Friend WithEvents lbl2nombre As Label
    Friend WithEvents lbl1nombre As Label
    Friend WithEvents lblcedula As Label
End Class
