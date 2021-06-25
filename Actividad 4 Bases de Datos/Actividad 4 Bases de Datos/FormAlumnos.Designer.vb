<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlumnos
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
        Me.DataGridViewA = New System.Windows.Forms.DataGridView()
        Me.TextBoxA = New System.Windows.Forms.TextBox()
        Me.ButtonBuscarA = New System.Windows.Forms.Button()
        Me.ComboBoxA = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AñadirRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarTablaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridViewA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewA
        '
        Me.DataGridViewA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewA.Location = New System.Drawing.Point(27, 82)
        Me.DataGridViewA.Name = "DataGridViewA"
        Me.DataGridViewA.Size = New System.Drawing.Size(683, 325)
        Me.DataGridViewA.TabIndex = 0
        '
        'TextBoxA
        '
        Me.TextBoxA.Location = New System.Drawing.Point(322, 40)
        Me.TextBoxA.Name = "TextBoxA"
        Me.TextBoxA.Size = New System.Drawing.Size(103, 20)
        Me.TextBoxA.TabIndex = 1
        '
        'ButtonBuscarA
        '
        Me.ButtonBuscarA.Location = New System.Drawing.Point(441, 37)
        Me.ButtonBuscarA.Name = "ButtonBuscarA"
        Me.ButtonBuscarA.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscarA.TabIndex = 2
        Me.ButtonBuscarA.Text = "Buscar"
        Me.ButtonBuscarA.UseVisualStyleBackColor = True
        '
        'ComboBoxA
        '
        Me.ComboBoxA.FormattingEnabled = True
        Me.ComboBoxA.Location = New System.Drawing.Point(185, 40)
        Me.ComboBoxA.Name = "ComboBoxA"
        Me.ComboBoxA.Size = New System.Drawing.Size(115, 21)
        Me.ComboBoxA.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Elige el campo en el que buscar: "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirRegistroToolStripMenuItem, Me.ActualizarTablaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 5
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
        'FormAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(734, 431)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxA)
        Me.Controls.Add(Me.ButtonBuscarA)
        Me.Controls.Add(Me.TextBoxA)
        Me.Controls.Add(Me.DataGridViewA)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alumnos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridViewA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewA As DataGridView
    Friend WithEvents TextBoxA As TextBox
    Friend WithEvents ButtonBuscarA As Button
    Friend WithEvents ComboBoxA As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AñadirRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarTablaToolStripMenuItem As ToolStripMenuItem
End Class
