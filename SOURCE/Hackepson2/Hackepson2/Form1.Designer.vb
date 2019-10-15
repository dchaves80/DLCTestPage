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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxPrinterFiscal1 = New AxEPSON_Impresora_Fiscal.AxPrinterFiscal()
        CType(Me.AxPrinterFiscal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxPrinterFiscal1
        '
        Me.AxPrinterFiscal1.Enabled = True
        Me.AxPrinterFiscal1.Location = New System.Drawing.Point(12, 21)
        Me.AxPrinterFiscal1.Name = "AxPrinterFiscal1"
        Me.AxPrinterFiscal1.OcxState = CType(resources.GetObject("AxPrinterFiscal1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxPrinterFiscal1.Size = New System.Drawing.Size(32, 32)
        Me.AxPrinterFiscal1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.AxPrinterFiscal1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxPrinterFiscal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxPrinterFiscal1 As AxEPSON_Impresora_Fiscal.AxPrinterFiscal
End Class
