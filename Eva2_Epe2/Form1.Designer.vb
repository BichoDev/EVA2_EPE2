<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnBuscar = New Button()
        btnModificar = New Button()
        btnEliminar = New Button()
        btnGuardar = New Button()
        cmbComuna = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtRUT = New TextBox()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtCiudad = New TextBox()
        txtObservaciones = New TextBox()
        GroupBox1 = New GroupBox()
        rbtnNoEspecifica = New RadioButton()
        rbtnFemenino = New RadioButton()
        rbtnMasculino = New RadioButton()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(229, 33)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 0
        btnBuscar.Text = "Buscar Rut"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(453, 187)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(75, 23)
        btnModificar.TabIndex = 1
        btnModificar.Text = "Modificar Usuario"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(453, 237)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(110, 23)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "Eliminar Usuario"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(266, 289)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 3
        btnGuardar.Text = "Guardar SQL"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' cmbComuna
        ' 
        cmbComuna.FormattingEnabled = True
        cmbComuna.Location = New Point(138, 245)
        cmbComuna.Name = "cmbComuna"
        cmbComuna.Size = New Size(121, 23)
        cmbComuna.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 15)
        Label1.TabIndex = 5
        Label1.Text = "Rut:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 6
        Label2.Text = "Nombres"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 7
        Label3.Text = "Apellidos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(37, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 8
        Label4.Text = "Comuna"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 289)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 9
        Label5.Text = "Ciudad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(37, 332)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 15)
        Label6.TabIndex = 10
        Label6.Text = "Observaciones"
        ' 
        ' txtRUT
        ' 
        txtRUT.Location = New Point(103, 34)
        txtRUT.Name = "txtRUT"
        txtRUT.Size = New Size(100, 23)
        txtRUT.TabIndex = 11
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(103, 80)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 12
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(103, 122)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 13
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(138, 286)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(100, 23)
        txtCiudad.TabIndex = 14
        ' 
        ' txtObservaciones
        ' 
        txtObservaciones.Location = New Point(138, 332)
        txtObservaciones.Name = "txtObservaciones"
        txtObservaciones.Size = New Size(100, 23)
        txtObservaciones.TabIndex = 15
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbtnNoEspecifica)
        GroupBox1.Controls.Add(rbtnFemenino)
        GroupBox1.Controls.Add(rbtnMasculino)
        GroupBox1.Location = New Point(37, 151)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(370, 91)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sexo"
        ' 
        ' rbtnNoEspecifica
        ' 
        rbtnNoEspecifica.AutoSize = True
        rbtnNoEspecifica.Location = New Point(244, 44)
        rbtnNoEspecifica.Name = "rbtnNoEspecifica"
        rbtnNoEspecifica.Size = New Size(96, 19)
        rbtnNoEspecifica.TabIndex = 2
        rbtnNoEspecifica.TabStop = True
        rbtnNoEspecifica.Text = "No Especifica"
        rbtnNoEspecifica.UseVisualStyleBackColor = True
        ' 
        ' rbtnFemenino
        ' 
        rbtnFemenino.AutoSize = True
        rbtnFemenino.Location = New Point(123, 44)
        rbtnFemenino.Name = "rbtnFemenino"
        rbtnFemenino.Size = New Size(78, 19)
        rbtnFemenino.TabIndex = 1
        rbtnFemenino.TabStop = True
        rbtnFemenino.Text = "Femenino"
        rbtnFemenino.UseVisualStyleBackColor = True
        ' 
        ' rbtnMasculino
        ' 
        rbtnMasculino.AutoSize = True
        rbtnMasculino.Location = New Point(6, 44)
        rbtnMasculino.Name = "rbtnMasculino"
        rbtnMasculino.Size = New Size(80, 19)
        rbtnMasculino.TabIndex = 0
        rbtnMasculino.TabStop = True
        rbtnMasculino.Text = "Masculino"
        rbtnMasculino.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(txtObservaciones)
        Controls.Add(txtCiudad)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(txtRUT)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbComuna)
        Controls.Add(btnGuardar)
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(btnBuscar)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRUT As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnNoEspecifica As RadioButton
    Friend WithEvents rbtnFemenino As RadioButton
    Friend WithEvents rbtnMasculino As RadioButton

End Class
