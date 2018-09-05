<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculadora))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnDois = New System.Windows.Forms.Button()
        Me.btnUm = New System.Windows.Forms.Button()
        Me.btnQuatro = New System.Windows.Forms.Button()
        Me.btnTres = New System.Windows.Forms.Button()
        Me.btnOito = New System.Windows.Forms.Button()
        Me.btnSete = New System.Windows.Forms.Button()
        Me.btnSeis = New System.Windows.Forms.Button()
        Me.btnCinco = New System.Windows.Forms.Button()
        Me.btnNove = New System.Windows.Forms.Button()
        Me.btnMultiplicação = New System.Windows.Forms.Button()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnSoma = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnPorcentagem = New System.Windows.Forms.Button()
        Me.btnDivisao = New System.Windows.Forms.Button()
        Me.btnQuadrado = New System.Windows.Forms.Button()
        Me.btnVirgula = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculadora"
        '
        'btnZero
        '
        Me.btnZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.Location = New System.Drawing.Point(142, 396)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(111, 42)
        Me.btnZero.TabIndex = 1
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'btnDois
        '
        Me.btnDois.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDois.Location = New System.Drawing.Point(142, 348)
        Me.btnDois.Name = "btnDois"
        Me.btnDois.Size = New System.Drawing.Size(111, 42)
        Me.btnDois.TabIndex = 2
        Me.btnDois.Text = "2"
        Me.btnDois.UseVisualStyleBackColor = True
        '
        'btnUm
        '
        Me.btnUm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUm.Location = New System.Drawing.Point(25, 348)
        Me.btnUm.Name = "btnUm"
        Me.btnUm.Size = New System.Drawing.Size(111, 42)
        Me.btnUm.TabIndex = 3
        Me.btnUm.Text = "1"
        Me.btnUm.UseVisualStyleBackColor = True
        '
        'btnQuatro
        '
        Me.btnQuatro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuatro.Location = New System.Drawing.Point(25, 300)
        Me.btnQuatro.Name = "btnQuatro"
        Me.btnQuatro.Size = New System.Drawing.Size(111, 42)
        Me.btnQuatro.TabIndex = 4
        Me.btnQuatro.Text = "4"
        Me.btnQuatro.UseVisualStyleBackColor = True
        '
        'btnTres
        '
        Me.btnTres.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTres.Location = New System.Drawing.Point(259, 348)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(111, 42)
        Me.btnTres.TabIndex = 5
        Me.btnTres.Text = "3"
        Me.btnTres.UseVisualStyleBackColor = True
        '
        'btnOito
        '
        Me.btnOito.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOito.Location = New System.Drawing.Point(142, 252)
        Me.btnOito.Name = "btnOito"
        Me.btnOito.Size = New System.Drawing.Size(111, 42)
        Me.btnOito.TabIndex = 8
        Me.btnOito.Text = "8"
        Me.btnOito.UseVisualStyleBackColor = True
        '
        'btnSete
        '
        Me.btnSete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSete.Location = New System.Drawing.Point(25, 252)
        Me.btnSete.Name = "btnSete"
        Me.btnSete.Size = New System.Drawing.Size(111, 42)
        Me.btnSete.TabIndex = 9
        Me.btnSete.Text = "7"
        Me.btnSete.UseVisualStyleBackColor = True
        '
        'btnSeis
        '
        Me.btnSeis.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeis.Location = New System.Drawing.Point(259, 300)
        Me.btnSeis.Name = "btnSeis"
        Me.btnSeis.Size = New System.Drawing.Size(111, 42)
        Me.btnSeis.TabIndex = 10
        Me.btnSeis.Text = "6"
        Me.btnSeis.UseVisualStyleBackColor = True
        '
        'btnCinco
        '
        Me.btnCinco.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCinco.Location = New System.Drawing.Point(142, 300)
        Me.btnCinco.Name = "btnCinco"
        Me.btnCinco.Size = New System.Drawing.Size(111, 42)
        Me.btnCinco.TabIndex = 11
        Me.btnCinco.Text = "5"
        Me.btnCinco.UseVisualStyleBackColor = True
        '
        'btnNove
        '
        Me.btnNove.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNove.Location = New System.Drawing.Point(259, 252)
        Me.btnNove.Name = "btnNove"
        Me.btnNove.Size = New System.Drawing.Size(111, 42)
        Me.btnNove.TabIndex = 12
        Me.btnNove.Text = "9"
        Me.btnNove.UseVisualStyleBackColor = True
        '
        'btnMultiplicação
        '
        Me.btnMultiplicação.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicação.Location = New System.Drawing.Point(376, 252)
        Me.btnMultiplicação.Name = "btnMultiplicação"
        Me.btnMultiplicação.Size = New System.Drawing.Size(111, 42)
        Me.btnMultiplicação.TabIndex = 13
        Me.btnMultiplicação.Text = "x"
        Me.btnMultiplicação.UseVisualStyleBackColor = True
        '
        'btnMenos
        '
        Me.btnMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenos.Location = New System.Drawing.Point(376, 300)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(111, 42)
        Me.btnMenos.TabIndex = 14
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnSoma
        '
        Me.btnSoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoma.Location = New System.Drawing.Point(376, 348)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Size = New System.Drawing.Size(111, 42)
        Me.btnSoma.TabIndex = 15
        Me.btnSoma.Text = "+"
        Me.btnSoma.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(376, 396)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(111, 42)
        Me.btnIgual.TabIndex = 16
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'btnPorcentagem
        '
        Me.btnPorcentagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPorcentagem.Location = New System.Drawing.Point(259, 204)
        Me.btnPorcentagem.Name = "btnPorcentagem"
        Me.btnPorcentagem.Size = New System.Drawing.Size(111, 42)
        Me.btnPorcentagem.TabIndex = 17
        Me.btnPorcentagem.Text = "%"
        Me.btnPorcentagem.UseVisualStyleBackColor = True
        '
        'btnDivisao
        '
        Me.btnDivisao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivisao.Location = New System.Drawing.Point(376, 204)
        Me.btnDivisao.Name = "btnDivisao"
        Me.btnDivisao.Size = New System.Drawing.Size(111, 42)
        Me.btnDivisao.TabIndex = 18
        Me.btnDivisao.Text = "/"
        Me.btnDivisao.UseVisualStyleBackColor = True
        '
        'btnQuadrado
        '
        Me.btnQuadrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuadrado.Location = New System.Drawing.Point(142, 204)
        Me.btnQuadrado.Name = "btnQuadrado"
        Me.btnQuadrado.Size = New System.Drawing.Size(111, 42)
        Me.btnQuadrado.TabIndex = 19
        Me.btnQuadrado.Text = "x²"
        Me.btnQuadrado.UseVisualStyleBackColor = True
        '
        'btnVirgula
        '
        Me.btnVirgula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVirgula.Location = New System.Drawing.Point(25, 204)
        Me.btnVirgula.Name = "btnVirgula"
        Me.btnVirgula.Size = New System.Drawing.Size(111, 42)
        Me.btnVirgula.TabIndex = 20
        Me.btnVirgula.Text = ","
        Me.btnVirgula.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Arial Narrow", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(25, 141)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(616, 58)
        Me.txtResultado.TabIndex = 23
        Me.txtResultado.Text = "0,00"
        Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnLimpar
        '
        Me.btnLimpar.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(493, 204)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(148, 234)
        Me.btnLimpar.TabIndex = 24
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'frmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 538)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnVirgula)
        Me.Controls.Add(Me.btnQuadrado)
        Me.Controls.Add(Me.btnDivisao)
        Me.Controls.Add(Me.btnPorcentagem)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.btnSoma)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.btnMultiplicação)
        Me.Controls.Add(Me.btnNove)
        Me.Controls.Add(Me.btnCinco)
        Me.Controls.Add(Me.btnSeis)
        Me.Controls.Add(Me.btnSete)
        Me.Controls.Add(Me.btnOito)
        Me.Controls.Add(Me.btnTres)
        Me.Controls.Add(Me.btnQuatro)
        Me.Controls.Add(Me.btnUm)
        Me.Controls.Add(Me.btnDois)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCalculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnZero As Button
    Friend WithEvents btnDois As Button
    Friend WithEvents btnUm As Button
    Friend WithEvents btnQuatro As Button
    Friend WithEvents btnTres As Button
    Friend WithEvents btnOito As Button
    Friend WithEvents btnSete As Button
    Friend WithEvents btnSeis As Button
    Friend WithEvents btnCinco As Button
    Friend WithEvents btnNove As Button
    Friend WithEvents btnMultiplicação As Button
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnSoma As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnPorcentagem As Button
    Friend WithEvents btnDivisao As Button
    Friend WithEvents btnQuadrado As Button
    Friend WithEvents btnVirgula As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnLimpar As Button
End Class
