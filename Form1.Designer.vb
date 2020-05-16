<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos del Alumno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Modulo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Notas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nota 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nota 2:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nota 3:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(252, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Promedio:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(323, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(124, 111)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 20)
        Me.TextBox2.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Taller de Proframacion .Net", "Fundamentos de programacion"})
        Me.ComboBox1.Location = New System.Drawing.Point(124, 160)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(323, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(124, 283)
        Me.MaskedTextBox1.Mask = "0.0"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(36, 20)
        Me.MaskedTextBox1.TabIndex = 12
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(124, 335)
        Me.MaskedTextBox2.Mask = "0.0"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(36, 20)
        Me.MaskedTextBox2.TabIndex = 13
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(124, 391)
        Me.MaskedTextBox3.Mask = "0.0"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(36, 20)
        Me.MaskedTextBox3.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(380, 226)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(67, 20)
        Me.TextBox3.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(273, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 55)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Promedio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(273, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 57)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Promedio por Alumno y Modulo"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button2 As Button
End Class
