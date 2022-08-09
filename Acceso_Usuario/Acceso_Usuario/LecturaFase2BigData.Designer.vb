<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LecturaFase2BigData
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LecturaFase2BigData))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"A la hora de crear proyectos Big Data que detecten, consuman, gestionen, organice" &
                "n y ", "presenten dichos datos de una manera optimizada y de forma que aporten algo a ", "nuestro negocio generalmente nos enfrentamos a las siguientes preguntas:", "• ¿De dónde obtengo los datos?", "• ¿Qué datos aportan más información a mi negocio?", "• ¿Qué datos hay disponibles fuera de mi organización que me pueden ayudar?", "• ¿Qué volumen de datos tenemos que manejar?", "• ¿Qué formato tienen?", "• ¿Con qué frecuencia los utilizo?", "• ¿Cómo integrarlos en nuestro sistema de gestión?", "Aunque todas estas preguntas son importantes, la más importante de todas es:", "• ¿Qué problema quiero resolver?", "Si no tenemos claro el problema, no podemos plantearnos empezar a trabajar con da" &
                "tos ", "para encontrar una solución. ", "Cuando hayamos localizado el problema que queremos resolver podremos plantearnos " &
                "las ", "preguntas iniciales y extraer información. El proceso de obtención de la misma a " &
                "partir de los ", "datos está reflejado en la famosa pirámide DIKW o pirámide del conocimiento, que " &
                "relaciona ", "cuatro componentes: Data, Information, Knowledge y Wisdow (Datos, Información, ", "Conocimiento y Sabiduría)."})
        Me.ListBox1.Location = New System.Drawing.Point(23, 46)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(706, 404)
        Me.ListBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(241, 471)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.ListBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(46, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 2338)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos de datos en Big Data: Clasificacion por Categoría y por origen"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(161, 2058)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(412, 268)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 21
        Me.ListBox3.Items.AddRange(New Object() {"Tipos de datos por origen", "Aunque no existe un criterio único para categorizar los tipos de datos lo más ext" &
                "endido es ", "dividirlos en 5 grupos:", "• Web y Redes Sociales", "o Información sobre clicks en vínculos y elementos", "o Búsquedas en Google", "o RRSS (fuentes de datos de Twitter, publicaciones en Facebook, otras RRSS)", "o Contenido Web (páginas, imágenes, enlaces, etc.)", "• Comunicación entre máquinas", "o Lecturas RFID", "o Señales GPS", "o Otros sensores (parquímetros, máquinas expendedoras, cajeros, etc.)", "• Transacciones", "o Registros de comunicaciones (llamadas, mensajería, VoIP, etc.)", "o Registros de facturación (pagos con tarjeta, pago online, etc.)", "• Biométricos", "o Reconocimiento facial", "o Información genética (ADN)", "• Generados por personas", "o Grabaciones a operadores de atención al cliente", "o E-mail", "o Registros médicos electrónicos"})
        Me.ListBox3.Location = New System.Drawing.Point(23, 1556)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(706, 487)
        Me.ListBox3.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(206, 1311)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(411, 219)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 21
        Me.ListBox2.Items.AddRange(New Object() {"Tipos de datos de Big Data", "La categorización de los datos es importante para cualquier proyecto, y en especi" &
                "al cuando", " vamos a trabajar con grandes volúmenes (Big Data). ", "Dos de las categorizaciones más utilizadas en Big Data suelen ser las que relacio" &
                "nan la ", "estructura de los datos y las que dependen del origen de los mismos:", "Tipos de datos por categorías", "Los tipos de datos se suelen organizar en 2 categorías principales:", "• Estructurados:", "o Creados: datos generados por nuestros sistemas de una manera predefinida (regis" &
                "tros ", "en tablas, ficheros XML asociados a un esquema)", "o Provocados: datos creados de manera indirecta a partir de una acción previa (va" &
                "loraciones", " de restaurantes, películas, empresas (Yelp, TripAdvisor, …)", "o Dirigido por transacciones: datos que resultan al finalizar una acción previa d" &
                "e manera ", "correcta (facturas autogeneradas al realizar una compra, recibo de un cajero auto" &
                "mático ", "al realizar una retirada de efectivo, …)", "o Compilados: resúmenes de datos de empresa, servicios públicos de interés grupal" &
                ". Entre ", "ellos nos encontramos con el censo electoral, vehículos matriculados, viviendas p" &
                "úblicas, …)", "o Experimentales: datos generados como parte de pruebas o simulaciones que permit" &
                "irán ", "validar si existe una oportunidad de negocio.", "• No estructurados:", "o Capturados: datos creados a partir del comportamiento de un usuario (informació" &
                "n ", "biométrica de pulseras de movimiento, aplicaciones de seguimiento de actividades " &
                "", "(carrera, ciclismo, natación, …), posición GPS)", "o Generados por usuarios: datos que especifica un usuario (publicaciones en redes" &
                " sociales,", " vídeos reproducidos en Youtube, búsquedas en Google, …)", "• Multi-estructurados o híbridos:", "o Datos de mercados emergentes", "o E-commerce", "o Datos meteorológicos"})
        Me.ListBox2.Location = New System.Drawing.Point(23, 666)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(706, 613)
        Me.ListBox2.TabIndex = 2
        '
        'LecturaFase2BigData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(841, 686)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LecturaFase2BigData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lectura Fase 2 BigData"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ListBox2 As ListBox
End Class
