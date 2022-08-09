<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnGuardad = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCedula1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtUsuario1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GbxModificar = New System.Windows.Forms.GroupBox()
        Me.Labelid = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.TxtPNombre = New System.Windows.Forms.TextBox()
        Me.TxtSNombre = New System.Windows.Forms.TextBox()
        Me.TxtPApellido = New System.Windows.Forms.TextBox()
        Me.TxtSApellido = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtReContraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GbxModificar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Usuario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 20)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Cedula"
        '
        'BtnGuardad
        '
        Me.BtnGuardad.Location = New System.Drawing.Point(203, 355)
        Me.BtnGuardad.Name = "BtnGuardad"
        Me.BtnGuardad.Size = New System.Drawing.Size(93, 30)
        Me.BtnGuardad.TabIndex = 13
        Me.BtnGuardad.Text = "Modificar"
        Me.BtnGuardad.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Primer Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Segundo Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Correo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Repetir Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Segundo Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Primer Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(375, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 42)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Modificar Datos"
        '
        'TxtCedula1
        '
        Me.TxtCedula1.Location = New System.Drawing.Point(98, 71)
        Me.TxtCedula1.Name = "TxtCedula1"
        Me.TxtCedula1.Size = New System.Drawing.Size(276, 26)
        Me.TxtCedula1.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 20)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Usuario"
        '
        'TxtUsuario1
        '
        Me.TxtUsuario1.Location = New System.Drawing.Point(98, 35)
        Me.TxtUsuario1.Name = "TxtUsuario1"
        Me.TxtUsuario1.Size = New System.Drawing.Size(276, 26)
        Me.TxtUsuario1.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 20)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Cedula"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(174, 113)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 29)
        Me.BtnBuscar.TabIndex = 44
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtUsuario1)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtCedula1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 159)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Usuario"
        '
        'GbxModificar
        '
        Me.GbxModificar.Controls.Add(Me.Labelid)
        Me.GbxModificar.Controls.Add(Me.TxtUsuario)
        Me.GbxModificar.Controls.Add(Me.TxtCedula)
        Me.GbxModificar.Controls.Add(Me.TxtPNombre)
        Me.GbxModificar.Controls.Add(Me.TxtSNombre)
        Me.GbxModificar.Controls.Add(Me.TxtPApellido)
        Me.GbxModificar.Controls.Add(Me.TxtSApellido)
        Me.GbxModificar.Controls.Add(Me.TxtCorreo)
        Me.GbxModificar.Controls.Add(Me.TxtContraseña)
        Me.GbxModificar.Controls.Add(Me.TxtReContraseña)
        Me.GbxModificar.Controls.Add(Me.Label2)
        Me.GbxModificar.Controls.Add(Me.Label3)
        Me.GbxModificar.Controls.Add(Me.Label10)
        Me.GbxModificar.Controls.Add(Me.Label4)
        Me.GbxModificar.Controls.Add(Me.Label5)
        Me.GbxModificar.Controls.Add(Me.Label9)
        Me.GbxModificar.Controls.Add(Me.Label6)
        Me.GbxModificar.Controls.Add(Me.Label7)
        Me.GbxModificar.Controls.Add(Me.Label8)
        Me.GbxModificar.Controls.Add(Me.BtnGuardad)
        Me.GbxModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxModificar.Location = New System.Drawing.Point(449, 66)
        Me.GbxModificar.Name = "GbxModificar"
        Me.GbxModificar.Size = New System.Drawing.Size(490, 411)
        Me.GbxModificar.TabIndex = 46
        Me.GbxModificar.TabStop = False
        Me.GbxModificar.Text = "Modificar"
        '
        'Labelid
        '
        Me.Labelid.AutoSize = True
        Me.Labelid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelid.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Labelid.Location = New System.Drawing.Point(106, 12)
        Me.Labelid.Name = "Labelid"
        Me.Labelid.Size = New System.Drawing.Size(52, 15)
        Me.Labelid.TabIndex = 48
        Me.Labelid.Text = "Label13"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(186, 199)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(276, 26)
        Me.TxtUsuario.TabIndex = 8
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(186, 163)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(276, 26)
        Me.TxtCedula.TabIndex = 7
        '
        'TxtPNombre
        '
        Me.TxtPNombre.Location = New System.Drawing.Point(186, 29)
        Me.TxtPNombre.Name = "TxtPNombre"
        Me.TxtPNombre.Size = New System.Drawing.Size(276, 26)
        Me.TxtPNombre.TabIndex = 3
        '
        'TxtSNombre
        '
        Me.TxtSNombre.Location = New System.Drawing.Point(185, 63)
        Me.TxtSNombre.Name = "TxtSNombre"
        Me.TxtSNombre.Size = New System.Drawing.Size(276, 26)
        Me.TxtSNombre.TabIndex = 4
        '
        'TxtPApellido
        '
        Me.TxtPApellido.Location = New System.Drawing.Point(185, 97)
        Me.TxtPApellido.Name = "TxtPApellido"
        Me.TxtPApellido.Size = New System.Drawing.Size(276, 26)
        Me.TxtPApellido.TabIndex = 5
        '
        'TxtSApellido
        '
        Me.TxtSApellido.Location = New System.Drawing.Point(186, 128)
        Me.TxtSApellido.Name = "TxtSApellido"
        Me.TxtSApellido.Size = New System.Drawing.Size(276, 26)
        Me.TxtSApellido.TabIndex = 6
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(186, 234)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(276, 26)
        Me.TxtCorreo.TabIndex = 9
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(186, 269)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.TxtContraseña.Size = New System.Drawing.Size(276, 26)
        Me.TxtContraseña.TabIndex = 10
        '
        'TxtReContraseña
        '
        Me.TxtReContraseña.Location = New System.Drawing.Point(185, 309)
        Me.TxtReContraseña.Name = "TxtReContraseña"
        Me.TxtReContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.TxtReContraseña.Size = New System.Drawing.Size(276, 26)
        Me.TxtReContraseña.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 232)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(396, 245)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(864, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Devolver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(783, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(963, 489)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GbxModificar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbxModificar.ResumeLayout(False)
        Me.GbxModificar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnGuardad As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCedula1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtUsuario1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GbxModificar As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtPNombre As TextBox
    Friend WithEvents TxtSNombre As TextBox
    Friend WithEvents TxtPApellido As TextBox
    Friend WithEvents TxtSApellido As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtReContraseña As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Labelid As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
