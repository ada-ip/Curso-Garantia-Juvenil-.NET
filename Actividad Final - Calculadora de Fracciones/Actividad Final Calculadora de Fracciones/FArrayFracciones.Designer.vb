<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FArrayFracciones
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
        Me.lblNumFracciones = New System.Windows.Forms.Label()
        Me.txtNumFracciones = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblErrorNum = New System.Windows.Forms.Label()
        Me.lblErrorDatos = New System.Windows.Forms.Label()
        Me.lblFracciones = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblError0 = New System.Windows.Forms.Label()
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
        'lblNumFracciones
        '
        Me.lblNumFracciones.AutoSize = True
        Me.lblNumFracciones.Location = New System.Drawing.Point(70, 75)
        Me.lblNumFracciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumFracciones.Name = "lblNumFracciones"
        Me.lblNumFracciones.Size = New System.Drawing.Size(218, 16)
        Me.lblNumFracciones.TabIndex = 1
        Me.lblNumFracciones.Text = "¿Cuántas fracciones quieres crear?"
        '
        'txtNumFracciones
        '
        Me.txtNumFracciones.Location = New System.Drawing.Point(300, 72)
        Me.txtNumFracciones.Name = "txtNumFracciones"
        Me.txtNumFracciones.Size = New System.Drawing.Size(100, 22)
        Me.txtNumFracciones.TabIndex = 2
        Me.txtNumFracciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(420, 67)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(83, 32)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblErrorNum
        '
        Me.lblErrorNum.AutoSize = True
        Me.lblErrorNum.ForeColor = System.Drawing.Color.Red
        Me.lblErrorNum.Location = New System.Drawing.Point(630, 75)
        Me.lblErrorNum.Name = "lblErrorNum"
        Me.lblErrorNum.Size = New System.Drawing.Size(258, 16)
        Me.lblErrorNum.TabIndex = 10
        Me.lblErrorNum.Text = "Introduzca un número válido de fracciones"
        Me.lblErrorNum.Visible = False
        '
        'lblErrorDatos
        '
        Me.lblErrorDatos.AutoSize = True
        Me.lblErrorDatos.ForeColor = System.Drawing.Color.Red
        Me.lblErrorDatos.Location = New System.Drawing.Point(200, 128)
        Me.lblErrorDatos.Name = "lblErrorDatos"
        Me.lblErrorDatos.Size = New System.Drawing.Size(315, 16)
        Me.lblErrorDatos.TabIndex = 11
        Me.lblErrorDatos.Text = "Introduzca un número válido en todas las fracciones"
        Me.lblErrorDatos.Visible = False
        '
        'lblFracciones
        '
        Me.lblFracciones.AutoSize = True
        Me.lblFracciones.Location = New System.Drawing.Point(80, 130)
        Me.lblFracciones.Name = "lblFracciones"
        Me.lblFracciones.Size = New System.Drawing.Size(81, 16)
        Me.lblFracciones.TabIndex = 12
        Me.lblFracciones.Text = "Fracciones: "
        Me.lblFracciones.Visible = False
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(520, 67)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(83, 32)
        Me.btnBorrar.TabIndex = 13
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblError0
        '
        Me.lblError0.AutoSize = True
        Me.lblError0.ForeColor = System.Drawing.Color.Red
        Me.lblError0.Location = New System.Drawing.Point(271, 128)
        Me.lblError0.Name = "lblError0"
        Me.lblError0.Size = New System.Drawing.Size(158, 16)
        Me.lblError0.TabIndex = 14
        Me.lblError0.Text = "No se puede dividir por 0"
        Me.lblError0.Visible = False
        '
        'FArrayFracciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 80)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.lblError0)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblFracciones)
        Me.Controls.Add(Me.lblErrorDatos)
        Me.Controls.Add(Me.lblErrorNum)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtNumFracciones)
        Me.Controls.Add(Me.lblNumFracciones)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FArrayFracciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Conjunto de Fracciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VolverMI As ToolStripMenuItem
    Friend WithEvents SalirMI As ToolStripMenuItem
    Friend WithEvents lblNumFracciones As Label
    Friend WithEvents txtNumFracciones As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblErrorNum As Label
    Friend WithEvents lblErrorDatos As Label
    Friend WithEvents lblFracciones As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblError0 As Label
End Class
