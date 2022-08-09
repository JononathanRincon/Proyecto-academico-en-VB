Public Class ProgramaBD
    Private Sub DatosEmpleadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DatosEmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BasesDeDatosVisualDataSet)

    End Sub

    Private Sub ProgramaBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasesDeDatosVisualDataSet.DatosEmpleados' Puede moverla o quitarla según sea necesario.
        Me.DatosEmpleadosTableAdapter.Fill(Me.BasesDeDatosVisualDataSet.DatosEmpleados)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not IsNumeric(TxtId.Text) Then
            ErrorProvider1.SetError(TxtId, "ingrese valores numericos")
            TxtId.Clear()
            TxtId.Select()
            Return
        Else
            ErrorProvider1.SetError(TxtId, "")
        End If

        If Not Char.IsLetter(TxtNombre.Text) Then
            ErrorProvider1.SetError(TxtNombre, "ingrese solo caracteres")
            TxtNombre.Clear()
            TxtNombre.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtNombre, "")

        If Not Char.IsLetter(TxtApellido.Text) Then
            ErrorProvider1.SetError(TxtApellido, "ingrese solo caracteres")
            TxtApellido.Clear()
            TxtApellido.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtApellido, "")

        If Not Char.IsLetter(txtprofesion.Text) Then
            ErrorProvider1.SetError(txtprofesion, "ingrese solo caracteres")
            txtprofesion.Clear()
            txtprofesion.Select()
            Return
        End If
        ErrorProvider1.SetError(txtprofesion, "")

        If Not IsNumeric(txtcedula.Text) Then
            ErrorProvider1.SetError(txtcedula, "ingrese valores numericos")
            txtcedula.Clear()
            txtcedula.Select()
            Return
        End If
        ErrorProvider1.SetError(txtcedula, "")

        If Not Char.IsLetter(txtcorreo.Text) Then
            ErrorProvider1.SetError(txtcorreo, "ingrese solo vales caracteres")
            txtcorreo.Clear()
            txtcorreo.Select()
            Return
        End If
        ErrorProvider1.SetError(txtcorreo, "")


        Me.DatosEmpleadosTableAdapter.InsertQuery(TxtId.Text, TxtNombre.Text, TxtApellido.Text,
                                                  txtprofesion.Text, txtcedula.Text, txtcorreo.Text)
        Me.DatosEmpleadosTableAdapter.Fill(Me.BasesDeDatosVisualDataSet.DatosEmpleados)
        limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TxtId.Text.Length = 0 Then
            ErrorProvider1.SetError(TxtId, "ingrese el id del trabajador que se va a eliminar")
            TxtId.Select()
            Return
        End If
        ErrorProvider1.SetError(TxtId, "")

        Me.DatosEmpleadosTableAdapter.DeleteQuery(Convert.ToInt32(TxtId.Text))
        Me.DatosEmpleadosTableAdapter.Fill(Me.BasesDeDatosVisualDataSet.DatosEmpleados)
        limpiar()
    End Sub

    Private Sub limpiar()
        TxtApellido.Clear()
        txtcedula.Clear()
        txtcorreo.Clear()
        TxtId.Clear()
        TxtNombre.Clear()
        txtprofesion.Clear()
        TxtId.Select()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.Validate()
            Me.DatosEmpleadosBindingSource.EndEdit()
            Me.DatosEmpleadosTableAdapter.Update(Me.BasesDeDatosVisualDataSet.DatosEmpleados)
            Me.DatosEmpleadosBindingNavigatorSaveItem_Click(sender, e)

            MessageBox.Show("Datos Registrados", "Registrar datos")
        Catch ex As Exception
            MessageBox.Show("no fue registrado", "registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BasesDeDatos.Show()
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub
End Class