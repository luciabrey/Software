<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubBenavidez
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClubBenavidez))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttActividad = New System.Windows.Forms.Button()
        Me.bttCobranza = New System.Windows.Forms.Button()
        Me.bttSalir = New System.Windows.Forms.Button()
        Me.BttSocios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bttInicio = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Club Atletico Benavidez"
        '
        'bttActividad
        '
        Me.bttActividad.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bttActividad.Enabled = False
        Me.bttActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttActividad.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttActividad.ForeColor = System.Drawing.Color.White
        Me.bttActividad.Image = CType(resources.GetObject("bttActividad.Image"), System.Drawing.Image)
        Me.bttActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttActividad.Location = New System.Drawing.Point(49, 313)
        Me.bttActividad.Name = "bttActividad"
        Me.bttActividad.Padding = New System.Windows.Forms.Padding(15, 10, 10, 10)
        Me.bttActividad.Size = New System.Drawing.Size(203, 74)
        Me.bttActividad.TabIndex = 4
        Me.bttActividad.Text = "Actividad"
        Me.bttActividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttActividad.UseVisualStyleBackColor = False
        '
        'bttCobranza
        '
        Me.bttCobranza.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bttCobranza.Enabled = False
        Me.bttCobranza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttCobranza.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCobranza.ForeColor = System.Drawing.Color.White
        Me.bttCobranza.Image = CType(resources.GetObject("bttCobranza.Image"), System.Drawing.Image)
        Me.bttCobranza.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttCobranza.Location = New System.Drawing.Point(49, 406)
        Me.bttCobranza.Name = "bttCobranza"
        Me.bttCobranza.Padding = New System.Windows.Forms.Padding(15, 10, 10, 10)
        Me.bttCobranza.Size = New System.Drawing.Size(203, 71)
        Me.bttCobranza.TabIndex = 5
        Me.bttCobranza.Text = "Cobranza"
        Me.bttCobranza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttCobranza.UseVisualStyleBackColor = False
        '
        'bttSalir
        '
        Me.bttSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bttSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttSalir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttSalir.ForeColor = System.Drawing.Color.White
        Me.bttSalir.Image = CType(resources.GetObject("bttSalir.Image"), System.Drawing.Image)
        Me.bttSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttSalir.Location = New System.Drawing.Point(49, 610)
        Me.bttSalir.Name = "bttSalir"
        Me.bttSalir.Padding = New System.Windows.Forms.Padding(15, 10, 10, 10)
        Me.bttSalir.Size = New System.Drawing.Size(203, 69)
        Me.bttSalir.TabIndex = 6
        Me.bttSalir.Text = "Salir"
        Me.bttSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttSalir.UseVisualStyleBackColor = False
        '
        'BttSocios
        '
        Me.BttSocios.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.BttSocios.Enabled = False
        Me.BttSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttSocios.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttSocios.ForeColor = System.Drawing.Color.White
        Me.BttSocios.Image = CType(resources.GetObject("BttSocios.Image"), System.Drawing.Image)
        Me.BttSocios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BttSocios.Location = New System.Drawing.Point(49, 223)
        Me.BttSocios.Name = "BttSocios"
        Me.BttSocios.Padding = New System.Windows.Forms.Padding(15, 10, 10, 10)
        Me.BttSocios.Size = New System.Drawing.Size(203, 74)
        Me.BttSocios.TabIndex = 7
        Me.BttSocios.Text = "Socios"
        Me.BttSocios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BttSocios.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(894, 263)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(433, 416)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'bttInicio
        '
        Me.bttInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bttInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttInicio.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttInicio.ForeColor = System.Drawing.Color.White
        Me.bttInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttInicio.Location = New System.Drawing.Point(1337, 13)
        Me.bttInicio.Name = "bttInicio"
        Me.bttInicio.Padding = New System.Windows.Forms.Padding(15, 10, 10, 10)
        Me.bttInicio.Size = New System.Drawing.Size(192, 68)
        Me.bttInicio.TabIndex = 9
        Me.bttInicio.Text = "Iniciar Sesion"
        Me.bttInicio.UseVisualStyleBackColor = False
        '
        'ClubBenavidez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1542, 708)
        Me.Controls.Add(Me.bttInicio)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BttSocios)
        Me.Controls.Add(Me.bttSalir)
        Me.Controls.Add(Me.bttCobranza)
        Me.Controls.Add(Me.bttActividad)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "ClubBenavidez"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttActividad As System.Windows.Forms.Button
    Friend WithEvents bttCobranza As System.Windows.Forms.Button
    Friend WithEvents bttSalir As System.Windows.Forms.Button
    Friend WithEvents BttSocios As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bttInicio As System.Windows.Forms.Button

End Class
