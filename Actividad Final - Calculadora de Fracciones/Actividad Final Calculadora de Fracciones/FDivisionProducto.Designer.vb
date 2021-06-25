<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDivisionProducto
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolverMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFraccion1 = New System.Windows.Forms.Label()
        Me.lblNumerador1 = New System.Windows.Forms.Label()
        Me.lblDenominador1 = New System.Windows.Forms.Label()
        Me.txtNumerador1 = New System.Windows.Forms.TextBox()
        Me.txtDenominador1 = New System.Windows.Forms.TextBox()
        Me.lblFraccion2 = New System.Windows.Forms.Label()
        Me.lblNumerador2 = New System.Windows.Forms.Label()
        Me.lblDenominador2 = New System.Windows.Forms.Label()
        Me.txtNumerador2 = New System.Windows.Forms.TextBox()
        Me.txtDenominador2 = New System.Windows.Forms.TextBox()
        Me.lblError0 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.txtNumeradorDiv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDenominadorDiv = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.txtNumeradorProd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDenominadorProd = New System.Windows.Forms.TextBox()
        Me.lblError0_2 = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverMI, Me.SalirMI})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
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
        Me.lblFraccion1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        'lblDenominador1
        '
        Me.lblDenominador1.AutoSize = True
        Me.lblDenominador1.Location = New System.Drawing.Point(150, 150)
        Me.lblDenominador1.Name = "lblDenominador1"
        Me.lblDenominador1.Size = New System.Drawing.Size(96, 16)
        Me.lblDenominador1.TabIndex = 3
        Me.lblDenominador1.Text = "Denominador: "
        '
        'txtNumerador1
        '
        Me.txtNumerador1.Location = New System.Drawing.Point(270, 107)
        Me.txtNumerador1.Name = "txtNumerador1"
        Me.txtNumerador1.Size = New System.Drawing.Size(100, 22)
        Me.txtNumerador1.TabIndex = 4
        Me.txtNumerador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'lblDenominador2
        '
        Me.lblDenominador2.AutoSize = True
        Me.lblDenominador2.Location = New System.Drawing.Point(630, 150)
        Me.lblDenominador2.Name = "lblDenominador2"
        Me.lblDenominador2.Size = New System.Drawing.Size(96, 16)
        Me.lblDenominador2.TabIndex = 8
        Me.lblDenominador2.Text = "Denominador: "
        '
        'txtNumerador2
        '
        Me.txtNumerador2.Location = New System.Drawing.Point(750, 107)
        Me.txtNumerador2.Name = "txtNumerador2"
        Me.txtNumerador2.Size = New System.Drawing.Size(100, 22)
        Me.txtNumerador2.TabIndex = 9
        Me.txtNumerador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDenominador2
        '
        Me.txtDenominador2.Location = New System.Drawing.Point(750, 147)
        Me.txtDenominador2.Name = "txtDenominador2"
        Me.txtDenominador2.Size = New System.Drawing.Size(100, 22)
        Me.txtDenominador2.TabIndex = 10
        Me.txtDenominador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblError0
        '
        Me.lblError0.AutoSize = True
        Me.lblError0.ForeColor = System.Drawing.Color.Red
        Me.lblError0.Location = New System.Drawing.Point(420, 150)
        Me.lblError0.Name = "lblError0"
        Me.lblError0.Size = New System.Drawing.Size(158, 16)
        Me.lblError0.TabIndex = 11
        Me.lblError0.Text = "No se puede dividir por 0"
        Me.lblError0.Visible = False
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(410, 210)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(83, 32)
        Me.btnCalcular.TabIndex = 12
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(390, 260)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(229, 16)
        Me.lblError.TabIndex = 13
        Me.lblError.Text = "Por favor introduzca números enteros"
        Me.lblError.Visible = False
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Location = New System.Drawing.Point(190, 325)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(62, 16)
        Me.lblDivision.TabIndex = 14
        Me.lblDivision.Text = "Division: "
        '
        'txtNumeradorDiv
        '
        Me.txtNumeradorDiv.Location = New System.Drawing.Point(270, 300)
        Me.txtNumeradorDiv.Name = "txtNumeradorDiv"
        Me.txtNumeradorDiv.Size = New System.Drawing.Size(100, 22)
        Me.txtNumeradorDiv.TabIndex = 15
        Me.txtNumeradorDiv.Text = "                                       "
        Me.txtNumeradorDiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'txtDenominadorDiv
        '
        Me.txtDenominadorDiv.Location = New System.Drawing.Point(270, 345)
        Me.txtDenominadorDiv.Name = "txtDenominadorDiv"
        Me.txtDenominadorDiv.Size = New System.Drawing.Size(100, 22)
        Me.txtDenominadorDiv.TabIndex = 17
        Me.txtDenominadorDiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(665, 325)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(68, 16)
        Me.lblProducto.TabIndex = 18
        Me.lblProducto.Text = "Producto: "
        '
        'txtNumeradorProd
        '
        Me.txtNumeradorProd.Location = New System.Drawing.Point(750, 300)
        Me.txtNumeradorProd.Name = "txtNumeradorProd"
        Me.txtNumeradorProd.Size = New System.Drawing.Size(100, 22)
        Me.txtNumeradorProd.TabIndex = 19
        Me.txtNumeradorProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(738, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "                                      "
        '
        'txtDenominadorProd
        '
        Me.txtDenominadorProd.Location = New System.Drawing.Point(750, 345)
        Me.txtDenominadorProd.Name = "txtDenominadorProd"
        Me.txtDenominadorProd.Size = New System.Drawing.Size(100, 22)
        Me.txtDenominadorProd.TabIndex = 21
        Me.txtDenominadorProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblError0_2
        '
        Me.lblError0_2.AutoSize = True
        Me.lblError0_2.ForeColor = System.Drawing.Color.Red
        Me.lblError0_2.Location = New System.Drawing.Point(390, 349)
        Me.lblError0_2.Name = "lblError0_2"
        Me.lblError0_2.Size = New System.Drawing.Size(158, 16)
        Me.lblError0_2.TabIndex = 22
        Me.lblError0_2.Text = "No se puede dividir por 0"
        Me.lblError0_2.Visible = False
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(510, 210)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(83, 32)
        Me.btnBorrar.TabIndex = 23
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'FDivisionProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblError0_2)
        Me.Controls.Add(Me.txtDenominadorProd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumeradorProd)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.txtDenominadorDiv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumeradorDiv)
        Me.Controls.Add(Me.lblDivision)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblError0)
        Me.Controls.Add(Me.txtDenominador2)
        Me.Controls.Add(Me.txtNumerador2)
        Me.Controls.Add(Me.lblDenominador2)
        Me.Controls.Add(Me.lblNumerador2)
        Me.Controls.Add(Me.lblFraccion2)
        Me.Controls.Add(Me.txtDenominador1)
        Me.Controls.Add(Me.txtNumerador1)
        Me.Controls.Add(Me.lblDenominador1)
        Me.Controls.Add(Me.lblNumerador1)
        Me.Controls.Add(Me.lblFraccion1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FDivisionProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "División y Producto de Fracciones"
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
    Friend WithEvents lblDenominador1 As Label
    Friend WithEvents txtNumerador1 As TextBox
    Friend WithEvents txtDenominador1 As TextBox
    Friend WithEvents lblFraccion2 As Label
    Friend WithEvents lblNumerador2 As Label
    Friend WithEvents lblDenominador2 As Label
    Friend WithEvents txtNumerador2 As TextBox
    Friend WithEvents txtDenominador2 As TextBox
    Friend WithEvents lblError0 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblError As Label
    Friend WithEvents lblDivision As Label
    Friend WithEvents txtNumeradorDiv As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDenominadorDiv As TextBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents txtNumeradorProd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDenominadorProd As TextBox
    Friend WithEvents lblError0_2 As Label
    Friend WithEvents btnBorrar As Button
End Class
