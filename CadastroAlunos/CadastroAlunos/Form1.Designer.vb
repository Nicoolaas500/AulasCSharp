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
        Me.cadastroAlunos = New System.Windows.Forms.Label()
        Me.Nome = New System.Windows.Forms.Label()
        Me.NomePai = New System.Windows.Forms.Label()
        Me.NomeMae = New System.Windows.Forms.Label()
        Me.Idade = New System.Windows.Forms.Label()
        Me.dataNascimento = New System.Windows.Forms.Label()
        Me.Turma = New System.Windows.Forms.Label()
        Me.Professor = New System.Windows.Forms.Label()
        Me.DataEscola = New System.Windows.Forms.Label()
        Me.NotaDois = New System.Windows.Forms.Label()
        Me.NotaUm = New System.Windows.Forms.Label()
        Me.Media = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.Label()
        Me.Saude = New System.Windows.Forms.Label()
        Me.Observações = New System.Windows.Forms.Label()
        Me.NotaQuatro = New System.Windows.Forms.Label()
        Me.NotaTres = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtMédia = New System.Windows.Forms.TextBox()
        Me.txtNotaQuatro = New System.Windows.Forms.TextBox()
        Me.txtNotaTres = New System.Windows.Forms.TextBox()
        Me.txtNotaDois = New System.Windows.Forms.TextBox()
        Me.txtNotaUm = New System.Windows.Forms.TextBox()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.txtProfessor = New System.Windows.Forms.TextBox()
        Me.txtTurma = New System.Windows.Forms.TextBox()
        Me.txtDataNascimento = New System.Windows.Forms.TextBox()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.txtNomeMae = New System.Windows.Forms.TextBox()
        Me.txtNomePai = New System.Windows.Forms.TextBox()
        Me.txtSaúde = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtNotas = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cadastroAlunos
        '
        Me.cadastroAlunos.AutoSize = True
        Me.cadastroAlunos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadastroAlunos.Location = New System.Drawing.Point(283, 38)
        Me.cadastroAlunos.Name = "cadastroAlunos"
        Me.cadastroAlunos.Size = New System.Drawing.Size(319, 25)
        Me.cadastroAlunos.TabIndex = 0
        Me.cadastroAlunos.Text = "Sistemas de cadastro de alunos"
        '
        'Nome
        '
        Me.Nome.AutoSize = True
        Me.Nome.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome.Location = New System.Drawing.Point(160, 115)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(60, 18)
        Me.Nome.TabIndex = 1
        Me.Nome.Text = "Nome:"
        '
        'NomePai
        '
        Me.NomePai.AutoSize = True
        Me.NomePai.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomePai.Location = New System.Drawing.Point(105, 148)
        Me.NomePai.Name = "NomePai"
        Me.NomePai.Size = New System.Drawing.Size(115, 18)
        Me.NomePai.TabIndex = 2
        Me.NomePai.Text = "Nome do Pai:"
        '
        'NomeMae
        '
        Me.NomeMae.AutoSize = True
        Me.NomeMae.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeMae.Location = New System.Drawing.Point(96, 181)
        Me.NomeMae.Name = "NomeMae"
        Me.NomeMae.Size = New System.Drawing.Size(126, 18)
        Me.NomeMae.TabIndex = 3
        Me.NomeMae.Text = "Nome da Mãe:"
        '
        'Idade
        '
        Me.Idade.AutoSize = True
        Me.Idade.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idade.Location = New System.Drawing.Point(160, 215)
        Me.Idade.Name = "Idade"
        Me.Idade.Size = New System.Drawing.Size(58, 18)
        Me.Idade.TabIndex = 4
        Me.Idade.Text = "Idade:"
        '
        'dataNascimento
        '
        Me.dataNascimento.AutoSize = True
        Me.dataNascimento.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataNascimento.Location = New System.Drawing.Point(43, 248)
        Me.dataNascimento.Name = "dataNascimento"
        Me.dataNascimento.Size = New System.Drawing.Size(179, 18)
        Me.dataNascimento.TabIndex = 5
        Me.dataNascimento.Text = "Data de Nascimento:"
        '
        'Turma
        '
        Me.Turma.AutoSize = True
        Me.Turma.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Turma.Location = New System.Drawing.Point(156, 281)
        Me.Turma.Name = "Turma"
        Me.Turma.Size = New System.Drawing.Size(62, 18)
        Me.Turma.TabIndex = 6
        Me.Turma.Text = "Turma:"
        '
        'Professor
        '
        Me.Professor.AutoSize = True
        Me.Professor.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Professor.Location = New System.Drawing.Point(129, 314)
        Me.Professor.Name = "Professor"
        Me.Professor.Size = New System.Drawing.Size(90, 18)
        Me.Professor.TabIndex = 7
        Me.Professor.Text = "Professor:"
        '
        'DataEscola
        '
        Me.DataEscola.AutoSize = True
        Me.DataEscola.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataEscola.Location = New System.Drawing.Point(73, 347)
        Me.DataEscola.Name = "DataEscola"
        Me.DataEscola.Size = New System.Drawing.Size(146, 18)
        Me.DataEscola.TabIndex = 8
        Me.DataEscola.Text = "Data de Entrada:"
        '
        'NotaDois
        '
        Me.NotaDois.AutoSize = True
        Me.NotaDois.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotaDois.Location = New System.Drawing.Point(520, 182)
        Me.NotaDois.Name = "NotaDois"
        Me.NotaDois.Size = New System.Drawing.Size(68, 18)
        Me.NotaDois.TabIndex = 9
        Me.NotaDois.Text = "Nota 2:"
        '
        'NotaUm
        '
        Me.NotaUm.AutoSize = True
        Me.NotaUm.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotaUm.Location = New System.Drawing.Point(520, 149)
        Me.NotaUm.Name = "NotaUm"
        Me.NotaUm.Size = New System.Drawing.Size(68, 18)
        Me.NotaUm.TabIndex = 10
        Me.NotaUm.Text = "Nota 1:"
        '
        'Media
        '
        Me.Media.AutoSize = True
        Me.Media.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Media.Location = New System.Drawing.Point(526, 276)
        Me.Media.Name = "Media"
        Me.Media.Size = New System.Drawing.Size(62, 18)
        Me.Media.TabIndex = 11
        Me.Media.Text = "Média:"
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(523, 309)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(65, 18)
        Me.Status.TabIndex = 12
        Me.Status.Text = "Status:"
        '
        'Saude
        '
        Me.Saude.AutoSize = True
        Me.Saude.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Saude.Location = New System.Drawing.Point(450, 340)
        Me.Saude.Name = "Saude"
        Me.Saude.Size = New System.Drawing.Size(138, 18)
        Me.Saude.TabIndex = 13
        Me.Saude.Text = "Saúde do aluno:"
        '
        'Observações
        '
        Me.Observações.AutoSize = True
        Me.Observações.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observações.Location = New System.Drawing.Point(403, 404)
        Me.Observações.Name = "Observações"
        Me.Observações.Size = New System.Drawing.Size(119, 18)
        Me.Observações.TabIndex = 14
        Me.Observações.Text = "Observações:"
        '
        'NotaQuatro
        '
        Me.NotaQuatro.AutoSize = True
        Me.NotaQuatro.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotaQuatro.Location = New System.Drawing.Point(520, 245)
        Me.NotaQuatro.Name = "NotaQuatro"
        Me.NotaQuatro.Size = New System.Drawing.Size(68, 18)
        Me.NotaQuatro.TabIndex = 15
        Me.NotaQuatro.Text = "Nota 4:"
        '
        'NotaTres
        '
        Me.NotaTres.AutoSize = True
        Me.NotaTres.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotaTres.Location = New System.Drawing.Point(520, 215)
        Me.NotaTres.Name = "NotaTres"
        Me.NotaTres.Size = New System.Drawing.Size(68, 18)
        Me.NotaTres.TabIndex = 16
        Me.NotaTres.Text = "Nota 3:"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(226, 108)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(122, 27)
        Me.txtNome.TabIndex = 0
        '
        'txtMédia
        '
        Me.txtMédia.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMédia.Location = New System.Drawing.Point(594, 272)
        Me.txtMédia.Name = "txtMédia"
        Me.txtMédia.Size = New System.Drawing.Size(122, 27)
        Me.txtMédia.TabIndex = 12
        '
        'txtNotaQuatro
        '
        Me.txtNotaQuatro.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaQuatro.Location = New System.Drawing.Point(594, 239)
        Me.txtNotaQuatro.Name = "txtNotaQuatro"
        Me.txtNotaQuatro.Size = New System.Drawing.Size(122, 27)
        Me.txtNotaQuatro.TabIndex = 11
        '
        'txtNotaTres
        '
        Me.txtNotaTres.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaTres.Location = New System.Drawing.Point(594, 206)
        Me.txtNotaTres.Name = "txtNotaTres"
        Me.txtNotaTres.Size = New System.Drawing.Size(122, 27)
        Me.txtNotaTres.TabIndex = 10
        '
        'txtNotaDois
        '
        Me.txtNotaDois.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaDois.Location = New System.Drawing.Point(594, 173)
        Me.txtNotaDois.Name = "txtNotaDois"
        Me.txtNotaDois.Size = New System.Drawing.Size(122, 27)
        Me.txtNotaDois.TabIndex = 9
        '
        'txtNotaUm
        '
        Me.txtNotaUm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaUm.Location = New System.Drawing.Point(594, 140)
        Me.txtNotaUm.Name = "txtNotaUm"
        Me.txtNotaUm.Size = New System.Drawing.Size(122, 27)
        Me.txtNotaUm.TabIndex = 8
        '
        'txtEntrada
        '
        Me.txtEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrada.Location = New System.Drawing.Point(226, 340)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(122, 27)
        Me.txtEntrada.TabIndex = 7
        '
        'txtProfessor
        '
        Me.txtProfessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfessor.Location = New System.Drawing.Point(226, 307)
        Me.txtProfessor.Name = "txtProfessor"
        Me.txtProfessor.Size = New System.Drawing.Size(122, 27)
        Me.txtProfessor.TabIndex = 6
        '
        'txtTurma
        '
        Me.txtTurma.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTurma.Location = New System.Drawing.Point(226, 274)
        Me.txtTurma.Name = "txtTurma"
        Me.txtTurma.Size = New System.Drawing.Size(122, 27)
        Me.txtTurma.TabIndex = 5
        '
        'txtDataNascimento
        '
        Me.txtDataNascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataNascimento.Location = New System.Drawing.Point(226, 241)
        Me.txtDataNascimento.Name = "txtDataNascimento"
        Me.txtDataNascimento.Size = New System.Drawing.Size(122, 27)
        Me.txtDataNascimento.TabIndex = 4
        '
        'txtIdade
        '
        Me.txtIdade.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdade.Location = New System.Drawing.Point(226, 206)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(122, 27)
        Me.txtIdade.TabIndex = 3
        '
        'txtNomeMae
        '
        Me.txtNomeMae.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeMae.Location = New System.Drawing.Point(226, 174)
        Me.txtNomeMae.Name = "txtNomeMae"
        Me.txtNomeMae.Size = New System.Drawing.Size(122, 27)
        Me.txtNomeMae.TabIndex = 2
        '
        'txtNomePai
        '
        Me.txtNomePai.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomePai.Location = New System.Drawing.Point(226, 141)
        Me.txtNomePai.Name = "txtNomePai"
        Me.txtNomePai.Size = New System.Drawing.Size(122, 27)
        Me.txtNomePai.TabIndex = 1
        '
        'txtSaúde
        '
        Me.txtSaúde.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaúde.Location = New System.Drawing.Point(594, 338)
        Me.txtSaúde.Name = "txtSaúde"
        Me.txtSaúde.Size = New System.Drawing.Size(122, 27)
        Me.txtSaúde.TabIndex = 14
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(594, 305)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(122, 27)
        Me.txtStatus.TabIndex = 13
        '
        'txtNotas
        '
        Me.txtNotas.AutoSize = True
        Me.txtNotas.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotas.Location = New System.Drawing.Point(567, 108)
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(149, 18)
        Me.txtNotas.TabIndex = 32
        Me.txtNotas.Text = "Notas e Situação"
        '
        'txtObs
        '
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(216, 437)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(490, 145)
        Me.txtObs.TabIndex = 15
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(735, 437)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(92, 46)
        Me.btnLimpar.TabIndex = 16
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 691)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtSaúde)
        Me.Controls.Add(Me.txtNomePai)
        Me.Controls.Add(Me.txtNomeMae)
        Me.Controls.Add(Me.txtIdade)
        Me.Controls.Add(Me.txtDataNascimento)
        Me.Controls.Add(Me.txtTurma)
        Me.Controls.Add(Me.txtProfessor)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.txtNotaUm)
        Me.Controls.Add(Me.txtNotaDois)
        Me.Controls.Add(Me.txtNotaTres)
        Me.Controls.Add(Me.txtNotaQuatro)
        Me.Controls.Add(Me.txtMédia)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.NotaTres)
        Me.Controls.Add(Me.NotaQuatro)
        Me.Controls.Add(Me.Observações)
        Me.Controls.Add(Me.Saude)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Media)
        Me.Controls.Add(Me.NotaUm)
        Me.Controls.Add(Me.NotaDois)
        Me.Controls.Add(Me.DataEscola)
        Me.Controls.Add(Me.Professor)
        Me.Controls.Add(Me.Turma)
        Me.Controls.Add(Me.dataNascimento)
        Me.Controls.Add(Me.Idade)
        Me.Controls.Add(Me.NomeMae)
        Me.Controls.Add(Me.NomePai)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.cadastroAlunos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cadastroAlunos As Label
    Friend WithEvents Nome As Label
    Friend WithEvents NomePai As Label
    Friend WithEvents NomeMae As Label
    Friend WithEvents Idade As Label
    Friend WithEvents dataNascimento As Label
    Friend WithEvents Turma As Label
    Friend WithEvents Professor As Label
    Friend WithEvents DataEscola As Label
    Friend WithEvents NotaDois As Label
    Friend WithEvents NotaUm As Label
    Friend WithEvents Media As Label
    Friend WithEvents Status As Label
    Friend WithEvents Saude As Label
    Friend WithEvents Observações As Label
    Friend WithEvents NotaQuatro As Label
    Friend WithEvents NotaTres As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtMédia As TextBox
    Friend WithEvents txtNotaQuatro As TextBox
    Friend WithEvents txtNotaTres As TextBox
    Friend WithEvents txtNotaDois As TextBox
    Friend WithEvents txtNotaUm As TextBox
    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents txtProfessor As TextBox
    Friend WithEvents txtTurma As TextBox
    Friend WithEvents txtDataNascimento As TextBox
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents txtNomeMae As TextBox
    Friend WithEvents txtNomePai As TextBox
    Friend WithEvents txtSaúde As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtNotas As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents btnLimpar As Button
End Class
