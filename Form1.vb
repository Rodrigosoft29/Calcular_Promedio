Public Class Form1
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Validar()
        Dim n1, n2, n3, promedio As Double

        n1 = MaskedTextBox1.Text
        n2 = MaskedTextBox2.Text
        n3 = MaskedTextBox3.Text


        If n1 < 1.0 Or n1 > 7.0 Or n2 < 1.0 Or n2 > 7.0 Or n3 < 1.0 Or n3 > 7.0 Then

            MessageBox.Show("Ingrese nota entre 1.0 y 7.0", "Info",
                            MessageBoxButtons.OK)
        Else
            promedio = (n1 + n2 + n3) / 3
            TextBox3.Text = promedio

            If promedio < 4.0 Then

                MessageBox.Show("Alumno Reprobado", "Info",
                                MessageBoxButtons.OK)
            Else

                MessageBox.Show("Alumno Aprobado", "Info",
                                MessageBoxButtons.OK)

            End If

        End If





    End Sub

    Private Sub Validar()

        'validacion campo nombre

        If (TextBox1.Text = "") Then

            ErrorProvider1.SetError(TextBox1, "Ingrese Nombre")
            TextBox1.Focus()
            Return

        Else

            ErrorProvider1.SetError(TextBox1, "")

        End If

        'validacion campo telefono

        If (TextBox2.Text = "") Then

            ErrorProvider1.SetError(TextBox2, "Ingrese Telefono")
            TextBox2.Focus()
            Return

        Else

            ErrorProvider1.SetError(TextBox2, "")

        End If

        'validacion campo modulo

        If (ComboBox1.Text = "") Then

            ErrorProvider1.SetError(ComboBox1, "Ingrese Modulo")
            ComboBox1.Focus()
            Return

        Else

            ErrorProvider1.SetError(ComboBox1, "")

        End If


    End Sub

    Private Sub Limpiar()

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.ResetText()
        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()
        MaskedTextBox3.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Limpiar()

    End Sub


End Class
