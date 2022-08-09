<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Programas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programas))
        Me.BtnBasesDeDatosVisual = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBigData = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DevolverseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBasesDeDatosVisual
        '
        Me.BtnBasesDeDatosVisual.Image = CType(resources.GetObject("BtnBasesDeDatosVisual.Image"), System.Drawing.Image)
        Me.BtnBasesDeDatosVisual.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBasesDeDatosVisual.Location = New System.Drawing.Point(12, 125)
        Me.BtnBasesDeDatosVisual.Name = "BtnBasesDeDatosVisual"
        Me.BtnBasesDeDatosVisual.Size = New System.Drawing.Size(103, 95)
        Me.BtnBasesDeDatosVisual.TabIndex = 0
        Me.BtnBasesDeDatosVisual.Text = "Manejo de bases de datos en Visual"
        Me.BtnBasesDeDatosVisual.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBasesDeDatosVisual.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Programas Realizados"
        '
        'BtnBigData
        '
        Me.BtnBigData.Image = CType(resources.GetObject("BtnBigData.Image"), System.Drawing.Image)
        Me.BtnBigData.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBigData.Location = New System.Drawing.Point(121, 125)
        Me.BtnBigData.Name = "BtnBigData"
        Me.BtnBigData.Size = New System.Drawing.Size(103, 95)
        Me.BtnBigData.TabIndex = 2
        Me.BtnBigData.Text = "Big Data"
        Me.BtnBigData.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBigData.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DevolverseToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(458, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DevolverseToolStripMenuItem
        '
        Me.DevolverseToolStripMenuItem.Name = "DevolverseToolStripMenuItem"
        Me.DevolverseToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.DevolverseToolStripMenuItem.Text = "Devolverse"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(230, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 95)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ingles"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(339, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 95)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Medio Ambiente"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Programas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(458, 339)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnBigData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBasesDeDatosVisual)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Programas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBasesDeDatosVisual As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBigData As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DevolverseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
