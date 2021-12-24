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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDiv = New System.Windows.Forms.PictureBox()
        Me.btnMult = New System.Windows.Forms.PictureBox()
        Me.btnResta = New System.Windows.Forms.PictureBox()
        Me.btnSuma = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnDiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnResta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSuma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDiv, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMult, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnResta, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSuma, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(260, 237)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnDiv
        '
        Me.btnDiv.Image = Global.CalculadoraV2.My.Resources.Resources.entre
        Me.btnDiv.Location = New System.Drawing.Point(133, 121)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(114, 99)
        Me.btnDiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDiv.TabIndex = 3
        Me.btnDiv.TabStop = False
        '
        'btnMult
        '
        Me.btnMult.Image = Global.CalculadoraV2.My.Resources.Resources.por
        Me.btnMult.Location = New System.Drawing.Point(3, 121)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(114, 99)
        Me.btnMult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMult.TabIndex = 2
        Me.btnMult.TabStop = False
        '
        'btnResta
        '
        Me.btnResta.Image = Global.CalculadoraV2.My.Resources.Resources.menos
        Me.btnResta.Location = New System.Drawing.Point(133, 3)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(114, 99)
        Me.btnResta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnResta.TabIndex = 1
        Me.btnResta.TabStop = False
        '
        'btnSuma
        '
        Me.btnSuma.Image = Global.CalculadoraV2.My.Resources.Resources.mas
        Me.btnSuma.Location = New System.Drawing.Point(3, 3)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(114, 99)
        Me.btnSuma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSuma.TabIndex = 0
        Me.btnSuma.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora V2"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.btnDiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnResta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSuma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDiv As PictureBox
    Friend WithEvents btnMult As PictureBox
    Friend WithEvents btnResta As PictureBox
    Friend WithEvents btnSuma As PictureBox
End Class
