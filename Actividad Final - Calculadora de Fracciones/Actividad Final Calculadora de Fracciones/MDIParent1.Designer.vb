<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SumaDiferenciaMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionProductoMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrayFraccionesMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AllowMerge = False
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumaDiferenciaMI, Me.DivisionProductoMI, Me.ArrayFraccionesMI, Me.SalirMI})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'SumaDiferenciaMI
        '
        Me.SumaDiferenciaMI.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumaDiferenciaMI.Name = "SumaDiferenciaMI"
        Me.SumaDiferenciaMI.Size = New System.Drawing.Size(107, 20)
        Me.SumaDiferenciaMI.Text = "Suma/Diferencia"
        '
        'DivisionProductoMI
        '
        Me.DivisionProductoMI.Name = "DivisionProductoMI"
        Me.DivisionProductoMI.Size = New System.Drawing.Size(115, 20)
        Me.DivisionProductoMI.Text = "División/Producto"
        '
        'ArrayFraccionesMI
        '
        Me.ArrayFraccionesMI.Name = "ArrayFraccionesMI"
        Me.ArrayFraccionesMI.Size = New System.Drawing.Size(142, 20)
        Me.ArrayFraccionesMI.Text = "Conjunto de fracciones"
        '
        'SalirMI
        '
        Me.SalirMI.Name = "SalirMI"
        Me.SalirMI.Size = New System.Drawing.Size(41, 20)
        Me.SalirMI.Text = "&Salir"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora de Fracciones"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents SumaDiferenciaMI As ToolStripMenuItem
    Friend WithEvents DivisionProductoMI As ToolStripMenuItem
    Friend WithEvents ArrayFraccionesMI As ToolStripMenuItem
    Friend WithEvents SalirMI As ToolStripMenuItem
End Class
