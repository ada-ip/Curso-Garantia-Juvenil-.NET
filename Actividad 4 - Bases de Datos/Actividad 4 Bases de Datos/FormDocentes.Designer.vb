<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDocentes
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
        Me.AñadirRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarTablaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxD = New System.Windows.Forms.ComboBox()
        Me.ButtonBuscarD = New System.Windows.Forms.Button()
        Me.TextBoxD = New System.Windows.Forms.TextBox()
        Me.DataGridViewD = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridViewD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirRegistroToolStripMenuItem, Me.ActualizarTablaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AñadirRegistroToolStripMenuItem
        '
        Me.AñadirRegistroToolStripMenuItem.Name = "AñadirRegistroToolStripMenuItem"
        Me.AñadirRegistroToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.AñadirRegistroToolStripMenuItem.Text = "Añadir registro"
        '
        'ActualizarTablaToolStripMenuItem
        '
        Me.ActualizarTablaToolStripMenuItem.Name = "ActualizarTablaToolStripMenuItem"
        Me.ActualizarTablaToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ActualizarTablaToolStripMenuItem.Text = "Actualizar tabla"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Elige el campo en el que buscar: "
        '
        'ComboBoxD
        '
        Me.ComboBoxD.FormattingEnabled = True
        Me.ComboBoxD.Location = New System.Drawing.Point(184, 42)
        Me.ComboBoxD.Name = "ComboBoxD"
        Me.ComboBoxD.Size = New System.Drawing.Size(115, 21)
        Me.ComboBoxD.TabIndex = 8
        '
        'ButtonBuscarD
        '
        Me.ButtonBuscarD.Location = New System.Drawing.Point(440, 39)
        Me.ButtonBuscarD.Name = "ButtonBuscarD"
        Me.ButtonBuscarD.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscarD.TabIndex = 7
        Me.ButtonBuscarD.Text = "Buscar"
        Me.ButtonBuscarD.UseVisualStyleBackColor = True
        '
        'TextBoxD
        '
        Me.TextBoxD.Location = New System.Drawing.Point(321, 42)
        Me.TextBoxD.Name = "TextBoxD"
        Me.TextBoxD.Size = New System.Drawing.Size(103, 20)
        Me.TextBoxD.TabIndex = 6
        '
        'DataGridViewD
        '
        Me.DataGridViewD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewD.Location = New System.Drawing.Point(26, 84)
        Me.DataGridViewD.Name = "DataGridViewD"
        Me.DataGridViewD.Size = New System.Drawing.Size(683, 325)
        Me.DataGridViewD.TabIndex = 5
        '
        'FormDocentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(734, 431)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxD)
        Me.Controls.Add(Me.ButtonBuscarD)
        Me.Controls.Add(Me.TextBoxD)
        Me.Controls.Add(Me.DataGridViewD)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormDocentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Docentes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridViewD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AñadirRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarTablaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxD As ComboBox
    Friend WithEvents ButtonBuscarD As Button
    Friend WithEvents TextBoxD As TextBox
    Friend WithEvents DataGridViewD As DataGridView
End Class
