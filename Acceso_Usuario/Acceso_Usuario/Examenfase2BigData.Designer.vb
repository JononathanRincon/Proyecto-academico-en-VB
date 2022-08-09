<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Examenfase2BigData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Examenfase2BigData))
        Me.BtnNuevaOportunidad = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Aprobar = New System.Windows.Forms.Label()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.TxtTemposizador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnInicia = New System.Windows.Forms.Button()
        Me.BtnTerminar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNuevaOportunidad
        '
        Me.BtnNuevaOportunidad.Enabled = False
        Me.BtnNuevaOportunidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNuevaOportunidad.Location = New System.Drawing.Point(177, 13)
        Me.BtnNuevaOportunidad.Name = "BtnNuevaOportunidad"
        Me.BtnNuevaOportunidad.Size = New System.Drawing.Size(162, 27)
        Me.BtnNuevaOportunidad.TabIndex = 59
        Me.BtnNuevaOportunidad.Text = "Nueva oportunidad"
        Me.BtnNuevaOportunidad.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(345, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 27)
        Me.Button4.TabIndex = 58
        Me.Button4.Text = "Devolver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(434, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 27)
        Me.Button3.TabIndex = 57
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Aprobar
        '
        Me.Aprobar.AutoSize = True
        Me.Aprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aprobar.Location = New System.Drawing.Point(23, 385)
        Me.Aprobar.Name = "Aprobar"
        Me.Aprobar.Size = New System.Drawing.Size(69, 20)
        Me.Aprobar.TabIndex = 56
        Me.Aprobar.Text = "mensaje"
        '
        'imagen
        '
        Me.imagen.Enabled = False
        Me.imagen.Location = New System.Drawing.Point(237, 319)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(113, 54)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 55
        Me.imagen.TabStop = False
        '
        'TxtTemposizador
        '
        Me.TxtTemposizador.Location = New System.Drawing.Point(131, 319)
        Me.TxtTemposizador.Name = "TxtTemposizador"
        Me.TxtTemposizador.Size = New System.Drawing.Size(100, 20)
        Me.TxtTemposizador.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Resultados"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 322)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Temporizador"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 349)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 51
        '
        'BtnInicia
        '
        Me.BtnInicia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnInicia.Location = New System.Drawing.Point(7, 13)
        Me.BtnInicia.Name = "BtnInicia"
        Me.BtnInicia.Size = New System.Drawing.Size(75, 27)
        Me.BtnInicia.TabIndex = 50
        Me.BtnInicia.Text = "Iniciar"
        Me.BtnInicia.UseVisualStyleBackColor = True
        '
        'BtnTerminar
        '
        Me.BtnTerminar.Enabled = False
        Me.BtnTerminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTerminar.Location = New System.Drawing.Point(88, 13)
        Me.BtnTerminar.Name = "BtnTerminar"
        Me.BtnTerminar.Size = New System.Drawing.Size(83, 27)
        Me.BtnTerminar.TabIndex = 49
        Me.BtnTerminar.Text = "Terminar"
        Me.BtnTerminar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.RadioButton10)
        Me.GroupBox4.Controls.Add(Me.RadioButton11)
        Me.GroupBox4.Controls.Add(Me.RadioButton12)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 179)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(413, 114)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "2. ¿ En la categoria de datos estructurados, con tipo de datos trabaja?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "C."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "B."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 18)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "A."
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Enabled = False
        Me.RadioButton10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton10.Location = New System.Drawing.Point(35, 34)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(264, 17)
        Me.RadioButton10.TabIndex = 4
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "creados, provocados, transaccionales, compilados"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Enabled = False
        Me.RadioButton11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton11.Location = New System.Drawing.Point(35, 57)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton11.Size = New System.Drawing.Size(195, 17)
        Me.RadioButton11.TabIndex = 5
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "Capturados y generados por usuario"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Enabled = False
        Me.RadioButton12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton12.Location = New System.Drawing.Point(35, 80)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(260, 17)
        Me.RadioButton12.TabIndex = 6
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "mercados emergentes, E-commerce, meteorologia"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 109)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1. ¿Tipos de Big Data?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "C."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "B."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "A."
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton3.Location = New System.Drawing.Point(35, 78)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "E-commerce"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton2.Location = New System.Drawing.Point(35, 55)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(175, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Datos de mercados emergentes"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton1.Location = New System.Drawing.Point(35, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(311, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Estructurados, no estructurados, multi estructurado y hidridos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Examenfase2BigData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(534, 423)
        Me.Controls.Add(Me.BtnNuevaOportunidad)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Aprobar)
        Me.Controls.Add(Me.imagen)
        Me.Controls.Add(Me.TxtTemposizador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnInicia)
        Me.Controls.Add(Me.BtnTerminar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Examenfase2BigData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examen fase 2 Big Data"
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNuevaOportunidad As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Aprobar As Label
    Friend WithEvents imagen As PictureBox
    Friend WithEvents TxtTemposizador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnInicia As Button
    Friend WithEvents BtnTerminar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
