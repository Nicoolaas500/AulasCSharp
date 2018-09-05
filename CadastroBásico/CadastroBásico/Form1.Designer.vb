<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.sistema = New System.Windows.Forms.Label()
        Me.Nome = New System.Windows.Forms.Label()
        Me.DepoisdoNome = New System.Windows.Forms.Label()
        Me.CEP = New System.Windows.Forms.Label()
        Me.Endereço = New System.Windows.Forms.Label()
        Me.RG = New System.Windows.Forms.Label()
        Me.CPF = New System.Windows.Forms.Label()
        Me.Pai = New System.Windows.Forms.Label()
        Me.Mãe = New System.Windows.Forms.Label()
        Me.Obs = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtCPF = New System.Windows.Forms.TextBox()
        Me.TxtRG = New System.Windows.Forms.TextBox()
        Me.TxtEndereço = New System.Windows.Forms.TextBox()
        Me.TxtCEP = New System.Windows.Forms.TextBox()
        Me.TxtSobrenome = New System.Windows.Forms.TextBox()
        Me.TxtMãe = New System.Windows.Forms.TextBox()
        Me.TxtPai = New System.Windows.Forms.TextBox()
        Me.TxtSexo = New System.Windows.Forms.Label()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.rdbFeminino = New System.Windows.Forms.RadioButton()
        Me.TxtObs = New System.Windows.Forms.TextBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'sistema
        '
        Me.sistema.AutoSize = True
        Me.sistema.Font = New System.Drawing.Font("Arial Narrow", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sistema.Location = New System.Drawing.Point(35, 9)
        Me.sistema.Name = "sistema"
        Me.sistema.Size = New System.Drawing.Size(459, 46)
        Me.sistema.TabIndex = 0
        Me.sistema.Text = "Sistema de Cadastro Básico"
        '
        'Nome
        '
        Me.Nome.AutoSize = True
        Me.Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome.Location = New System.Drawing.Point(100, 101)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(67, 22)
        Me.Nome.TabIndex = 1
        Me.Nome.Text = "Nome:"
        '
        'DepoisdoNome
        '
        Me.DepoisdoNome.AutoSize = True
        Me.DepoisdoNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepoisdoNome.Location = New System.Drawing.Point(46, 133)
        Me.DepoisdoNome.Name = "DepoisdoNome"
        Me.DepoisdoNome.Size = New System.Drawing.Size(117, 22)
        Me.DepoisdoNome.TabIndex = 2
        Me.DepoisdoNome.Text = "Sobrenome:"
        '
        'CEP
        '
        Me.CEP.AutoSize = True
        Me.CEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEP.Location = New System.Drawing.Point(107, 165)
        Me.CEP.Name = "CEP"
        Me.CEP.Size = New System.Drawing.Size(56, 22)
        Me.CEP.TabIndex = 3
        Me.CEP.Text = "CEP:"
        '
        'Endereço
        '
        Me.Endereço.AutoSize = True
        Me.Endereço.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Endereço.Location = New System.Drawing.Point(62, 197)
        Me.Endereço.Name = "Endereço"
        Me.Endereço.Size = New System.Drawing.Size(101, 22)
        Me.Endereço.TabIndex = 4
        Me.Endereço.Text = "Endereço:"
        '
        'RG
        '
        Me.RG.AutoSize = True
        Me.RG.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RG.Location = New System.Drawing.Point(118, 229)
        Me.RG.Name = "RG"
        Me.RG.Size = New System.Drawing.Size(45, 22)
        Me.RG.TabIndex = 5
        Me.RG.Text = "RG:"
        '
        'CPF
        '
        Me.CPF.AutoSize = True
        Me.CPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPF.Location = New System.Drawing.Point(108, 261)
        Me.CPF.Name = "CPF"
        Me.CPF.Size = New System.Drawing.Size(55, 22)
        Me.CPF.TabIndex = 6
        Me.CPF.Text = "CPF:"
        '
        'Pai
        '
        Me.Pai.AutoSize = True
        Me.Pai.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pai.Location = New System.Drawing.Point(118, 293)
        Me.Pai.Name = "Pai"
        Me.Pai.Size = New System.Drawing.Size(45, 22)
        Me.Pai.TabIndex = 7
        Me.Pai.Text = "Pai:"
        '
        'Mãe
        '
        Me.Mãe.AutoSize = True
        Me.Mãe.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mãe.Location = New System.Drawing.Point(110, 325)
        Me.Mãe.Name = "Mãe"
        Me.Mãe.Size = New System.Drawing.Size(53, 22)
        Me.Mãe.TabIndex = 8
        Me.Mãe.Text = "Mãe:"
        '
        'Obs
        '
        Me.Obs.AutoSize = True
        Me.Obs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Obs.Location = New System.Drawing.Point(35, 417)
        Me.Obs.Name = "Obs"
        Me.Obs.Size = New System.Drawing.Size(133, 22)
        Me.Obs.TabIndex = 9
        Me.Obs.Text = "Observações:"
        '
        'TxtNome
        '
        Me.TxtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(169, 97)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(158, 26)
        Me.TxtNome.TabIndex = 0
        '
        'TxtCPF
        '
        Me.TxtCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCPF.Location = New System.Drawing.Point(169, 257)
        Me.TxtCPF.Name = "TxtCPF"
        Me.TxtCPF.Size = New System.Drawing.Size(158, 26)
        Me.TxtCPF.TabIndex = 5
        '
        'TxtRG
        '
        Me.TxtRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRG.Location = New System.Drawing.Point(169, 225)
        Me.TxtRG.Name = "TxtRG"
        Me.TxtRG.Size = New System.Drawing.Size(158, 26)
        Me.TxtRG.TabIndex = 4
        '
        'TxtEndereço
        '
        Me.TxtEndereço.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEndereço.Location = New System.Drawing.Point(169, 193)
        Me.TxtEndereço.Name = "TxtEndereço"
        Me.TxtEndereço.Size = New System.Drawing.Size(119, 26)
        Me.TxtEndereço.TabIndex = 3
        '
        'TxtCEP
        '
        Me.TxtCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCEP.Location = New System.Drawing.Point(169, 161)
        Me.TxtCEP.Name = "TxtCEP"
        Me.TxtCEP.Size = New System.Drawing.Size(158, 26)
        Me.TxtCEP.TabIndex = 2
        '
        'TxtSobrenome
        '
        Me.TxtSobrenome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSobrenome.Location = New System.Drawing.Point(169, 129)
        Me.TxtSobrenome.Name = "TxtSobrenome"
        Me.TxtSobrenome.Size = New System.Drawing.Size(158, 26)
        Me.TxtSobrenome.TabIndex = 1
        '
        'TxtMãe
        '
        Me.TxtMãe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMãe.Location = New System.Drawing.Point(169, 321)
        Me.TxtMãe.Name = "TxtMãe"
        Me.TxtMãe.Size = New System.Drawing.Size(158, 26)
        Me.TxtMãe.TabIndex = 7
        '
        'TxtPai
        '
        Me.TxtPai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPai.Location = New System.Drawing.Point(169, 289)
        Me.TxtPai.Name = "TxtPai"
        Me.TxtPai.Size = New System.Drawing.Size(158, 26)
        Me.TxtPai.TabIndex = 6
        '
        'TxtSexo
        '
        Me.TxtSexo.AutoSize = True
        Me.TxtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSexo.Location = New System.Drawing.Point(102, 358)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(61, 22)
        Me.TxtSexo.TabIndex = 23
        Me.TxtSexo.Text = "Sexo:"
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMasculino.Location = New System.Drawing.Point(169, 359)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(89, 21)
        Me.rdbMasculino.TabIndex = 8
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'rdbFeminino
        '
        Me.rdbFeminino.AutoSize = True
        Me.rdbFeminino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFeminino.Location = New System.Drawing.Point(264, 359)
        Me.rdbFeminino.Name = "rdbFeminino"
        Me.rdbFeminino.Size = New System.Drawing.Size(83, 21)
        Me.rdbFeminino.TabIndex = 9
        Me.rdbFeminino.TabStop = True
        Me.rdbFeminino.Text = "Feminino"
        Me.rdbFeminino.UseVisualStyleBackColor = True
        '
        'TxtObs
        '
        Me.TxtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObs.Location = New System.Drawing.Point(40, 445)
        Me.TxtObs.Multiline = True
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.Size = New System.Drawing.Size(401, 113)
        Me.TxtObs.TabIndex = 10
        '
        'btnLimpar
        '
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(459, 445)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(98, 35)
        Me.btnLimpar.TabIndex = 0
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 586)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.TxtObs)
        Me.Controls.Add(Me.rdbFeminino)
        Me.Controls.Add(Me.rdbMasculino)
        Me.Controls.Add(Me.TxtSexo)
        Me.Controls.Add(Me.TxtPai)
        Me.Controls.Add(Me.TxtMãe)
        Me.Controls.Add(Me.TxtSobrenome)
        Me.Controls.Add(Me.TxtCEP)
        Me.Controls.Add(Me.TxtEndereço)
        Me.Controls.Add(Me.TxtRG)
        Me.Controls.Add(Me.TxtCPF)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.Obs)
        Me.Controls.Add(Me.Mãe)
        Me.Controls.Add(Me.Pai)
        Me.Controls.Add(Me.CPF)
        Me.Controls.Add(Me.RG)
        Me.Controls.Add(Me.Endereço)
        Me.Controls.Add(Me.CEP)
        Me.Controls.Add(Me.DepoisdoNome)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.sistema)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sistema As Label
    Friend WithEvents Nome As Label
    Friend WithEvents DepoisdoNome As Label
    Friend WithEvents CEP As Label
    Friend WithEvents Endereço As Label
    Friend WithEvents RG As Label
    Friend WithEvents CPF As Label
    Friend WithEvents Pai As Label
    Friend WithEvents Mãe As Label
    Friend WithEvents Obs As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtCPF As TextBox
    Friend WithEvents TxtRG As TextBox
    Friend WithEvents TxtEndereço As TextBox
    Friend WithEvents TxtCEP As TextBox
    Friend WithEvents TxtSobrenome As TextBox
    Friend WithEvents TxtMãe As TextBox
    Friend WithEvents TxtPai As TextBox
    Friend WithEvents TxtSexo As Label
    Friend WithEvents rdbMasculino As RadioButton
    Friend WithEvents rdbFeminino As RadioButton
    Friend WithEvents TxtObs As TextBox
    Friend WithEvents btnLimpar As Button
End Class
