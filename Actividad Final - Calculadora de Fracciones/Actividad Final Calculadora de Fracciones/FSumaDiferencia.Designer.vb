<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FSumaDiferencia
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolverMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFraccion1 = New System.Windows.Forms.Label()
        Me.lblNumerador1 = New System.Windows.Forms.Label()
        Me.txtNumerador1 = New System.Windows.Forms.TextBox()
        Me.lblDenominador1 = New System.Windows.Forms.Label()
        Me.txtDenominador1 = New System.Windows.Forms.TextBox()
        Me.lblFraccion2 = New System.Windows.Forms.Label()
        Me.lblNumerador2 = New System.Windows.Forms.Label()
        Me.txtNumerador2 = New System.Windows.Forms.TextBox()
        Me.lblDenominador2 = New System.Windows.Forms.Label()
        Me.txtDenominador2 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblSuma = New System.Windows.Forms.Label()
        Me.lblResta = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtNumeradorSuma = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDenominadorSuma = New System.Windows.Forms.TextBox()
        Me.txtNumeradorResta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDenominadorResta = New System.Windows.Forms.TextBox()
        Me.lblError0 = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverMI, Me.SalirMI})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VolverMI
        '
        Me.VolverMI.Name = "VolverMI"
        Me.VolverMI.Size = New System.Drawing.Size(51, 20)
        Me.VolverMI.Text = "&Volver"
        '
        'SalirMI
        '
        Me.SalirMI.Name = "SalirMI"
        Me.SalirMI.Size = New System.Drawing.Size(41, 20)
        Me.SalirMI.Text = "&Salir"
        '
        'lblFraccion1
        '
        Me.lblFraccion1.AutoSize = True
        Me.lblFraccion1.Location = New System.Drawing.Point(70, 70)
        Me.lblFraccion1.Name = "lblFraccion1"
        Me.lblFraccion1.Size = New System.Drawing.Size(235, 16)
        Me.lblFraccion1.TabIndex = 1
        Me.lblFraccion1.Text = "- Introduzca los datos de la 1º fracción:"
        '
        'lblNumerador1
        '
        Me.lblNumerador1.AutoSize = True
        Me.lblNumerador1.Location = New System.Drawing.Point(150, 110)
        Me.lblNumerador1.Name = "lblNumerador1"
        Me.lblNumerador1.Size = New System.Drawing.Size(82, 16)
        Me.lblNumerador1.TabIndex = 2
        Me.lblNumerador1.Text = "Numerador: "
        '
        'txtNumerador1
        '
        Me.txtNumerador1.Location = New System.Drawing.Point(270, 107)
        Me.txtNumerador1.Name = "txtNumerador1"
        Me.txtNumerador1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumerador1.Size = New System.Drawing.Size(100, 22)
        Me.txtNumerador1.TabIndex = 3
        Me.txtNumerador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDenominador1
        '
        Me.lblDenominador1.AutoSize = True
        Me.lblDenominador1.Location = New System.Drawing.Point(150, 150)
        Me.lblDenominador1.Name = "lblDenominador1"
        Me.lblDenominador1.Size = New System.Drawing.Size(96, 16)
        Me.lblDenominador1.TabIndex = 4
        Me.lblDenominador1.Text = "Denominador: "
        '
        'txtDenominador1
        '
        Me.txtDenominador1.Location = New System.Drawing.Point(270, 147)
        Me.txtDenominador1.Name = "txtDenominador1"
        Me.txtDenominador1.Size = New System.Drawing.Size(100, 22)
        Me.txtDenominador1.TabIndex = 5
        Me.txtDenominador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFraccion2
        '
        Me.lblFraccion2.AutoSize = True
        Me.lblFraccion2.Location = New System.Drawing.Point(550, 70)
        Me.lblFraccion2.Name = "lblFraccion2"
        Me.lblFraccion2.Size = New System.Drawing.Size(238, 16)
        Me.lblFraccion2.TabIndex = 6
        Me.lblFraccion2.Text = "- Introduzca los datos de la 2º fracción: "
        '
        'lblNumerador2
        '
        Me.lblNumerador2.AutoSize = True
        Me.lblNumerador2.Location = New System.Drawing.Point(630, 110)
        Me.lblNumerador2.Name = "lblNumerador2"
        Me.lblNumerador2.Size = New System.Drawing.Size(82, 16)
        Me.lblNumerador2.TabIndex = 7
        Me.lblNumerador2.Text = "Numerador: "
        '
        'txtNumerador2
        '
        Me.txtNumerador2.Location = New System.Drawing.Point(750, 107)
        Me.txtNumerador2.Name = "txtNumerador2"
        Me.txtNumerador2.Size = New System.Drawing.Size(100, 22)
        Me.txtNumerador2.TabIndex = 8
        Me.txtNumerador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDenominador2
        '
        Me.lblDenominador2.AutoSize = True
        Me.lblDenominador2.Location = New System.Drawing.Point(630, 150)
        Me.lblDenominador2.Name = "lblDenominador2"
        Me.lblDenominador2.Size = New System.Drawing.Size(96, 16)
        Me.lblDenominador2.TabIndex = 9
        Me.lblDenominador2.Text = "Denominador: "
        '
        'txtDenominador2
        '
        Me.txtDenominador2.Location = New System.Drawing.Point(750, 147)
        Me.txtDenominador2.Name = "txtDenominador2"
        Me.txtDenominador2.Size = New System.Drawing.Size(100, 22)
        Me.txtDenominador2.TabIndex = 10
        Me.txtDenominador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(410, 210)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(83, 32)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblSuma
        '
        Me.lblSuma.AutoSize = True
        Me.lblSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuma.Location = New System.Drawing.Point(200, 325)
        Me.lblSuma.Name = "lblSuma"
        Me.lblSuma.Size = New System.Drawing.Size(49, 16)
        Me.lblSuma.TabIndex = 12
        Me.lblSuma.Text = "Suma: "
        '
        'lblResta
        '
        Me.lblResta.AutoSize = True
        Me.lblResta.Location = New System.Drawing.Point(680, 325)
        Me.lblResta.Name = "lblResta"
        Me.lblResta.Size = New System.Drawing.Size(47, 16)
        Me.lblResta.TabIndex = 13
        Me.lblResta.Text = "Resta:"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(390, 260)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(229, 16)
        Me.lblError.TabIndex = 14
        Me.lblError.Text = "Por favor introduzca números enteros"
        Me.lblError.Visible = False
        '
        'txtNumeradorSuma
        '
        Me.txtNumeradorSuma.Location = New System.Drawing.Point(270, 300)
        Me.txtNumeradorSuma.Name = "txtNumeradorSuma"
        Me.txtNumeradorSuma.Size = New System.Drawing.Size(100, 22)
        Me.txtNumeradorSuma.TabIndex = 15
        Me.txtNumeradorSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "                                       "
        '
        'txtDenominadorSuma
        '
        Me.txtDenominadorSuma.Location = New System.Drawing.Point(270, 345)
        Me.txtDenominadorSuma.Name = "txtDenominadorSuma"
        Me.txtDenominadorSuma.Size = New System.Drawing.Size(100, 22)
        Me.txtDenominadorSuma.TabIndex = 17
        Me.txtDenominadorSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumeradorResta
        '
        Me.txtNumeradorResta.Location = New System.Drawing.Point(750, 300)
        Me.txtNumeradorResta.Name = "txtNumeradorResta"
        Me.txtNumeradorResta.Size = New System.Drawing.Size(100, 22)
        Me.txtNumeradorResta.TabIndex = 18
        Me.txtNumeradorResta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(738, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "                                      "
        '
        'txtDenominadorResta
        '
        Me.txtDenominadorResta.Location = New System.Drawing.Point(750, 345)
        Me.txtDenominadorResta.Name = "txtDenominadorResta"
        Me.txtDenominadorResta.Size = New System.Drawing.Size(100, 22)
        Me.txtDenominadorResta.TabIndex = 20
        Me.txtDenominadorResta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblError0
        '
        Me.lblError0.AutoSize = True
        Me.lblError0.ForeColor = System.Drawing.Color.Red
        Me.lblError0.Location = New System.Drawing.Point(420, 150)
        Me.lblError0.Name = "lblError0"
        Me.lblError0.Size = New System.Drawing.Size(158, 16)
        Me.lblError0.TabIndex = 21
        Me.lblError0.Text = "No se puede dividir por 0"
        Me.lblError0.Visible = False
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(510, 210)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(83, 32)
        Me.btnBorrar.TabIndex = 22
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'FSumaDiferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblError0)
        Me.Controls.Add(Me.txtDenominadorResta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumeradorResta)
        Me.Controls.Add(Me.txtDenominadorSuma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumeradorSuma)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblResta)
        Me.Controls.Add(Me.lblSuma)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtDenominador2)
        Me.Controls.Add(Me.lblDenominador2)
        Me.Controls.Add(Me.txtNumerador2)
        Me.Controls.Add(Me.lblNumerador2)
        Me.Controls.Add(Me.lblFraccion2)
        Me.Controls.Add(Me.txtDenominador1)
        Me.Controls.Add(Me.lblDenominador1)
        Me.Controls.Add(Me.txtNumerador1)
        Me.Controls.Add(Me.lblNumerador1)
        Me.Controls.Add(Me.lblFraccion1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FSumaDiferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Suma y Diferencia de Fracciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VolverMI As ToolStripMenuItem
    Friend WithEvents SalirMI As ToolStripMenuItem
    Friend WithEvents lblFraccion1 As Label
    Friend WithEvents lblNumerador1 As Label
    Friend WithEvents txtNumerador1 As TextBox
    Friend WithEvents lblDenominador1 As Label
    Friend WithEvents txtDenominador1 As TextBox
    Friend WithEvents lblFraccion2 As Label
    Friend WithEvents lblNumerador2 As Label
    Friend WithEvents txtNumerador2 As TextBox
    Friend WithEvents lblDenominador2 As Label
    Friend WithEvents txtDenominador2 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblSuma As Label
    Friend WithEvents lblResta As Label
    Friend WithEvents lblError As Label
    Friend WithEvents txtNumeradorSuma As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDenominadorSuma As TextBox
    Friend WithEvents txtNumeradorResta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDenominadorResta As TextBox
    Friend WithEvents lblError0 As Label
    Friend WithEvents btnBorrar As Button
End Class
