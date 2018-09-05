Public Class Form1
    Private Sub Limpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        ' PARA LIMPAR AS CAIXAS DE TEXTO(TEXTBOX) DEVEMOS DECLARAR
        ' O NOME DA CAIXA DE TEXTO E ATRIBUIR UM VALOR EM BRANCO
        ' PARA ISSO UTILIZAMOS AS "" (ABRIMOS E FECHAMOS ASPAS)

        TxtNome.Text = ""
        TxtSobrenome.Text = ""
        TxtCEP.Text = ""
        TxtCPF.Text = ""
        TxtEndereço.Text = ""
        TxtMãe.Text = ""
        TxtPai.Text = ""
        TxtObs.Text = ""
        TxtRG.Text = ""
        TxtSexo.Text = ""

        ' PARA LIMPAR OS RÁDIO BUTTONS 
        ' UTILIZAMOS A SEGUINTE SINTAXE
        ' nomeDoRadioButton.Checked = fase
        ' AI SIM CONSEGUIMOS DESMARCAR OS RADIO BUTTONS

        rdbFeminino.Checked = False
        rdbMasculino.Checked = False
    End Sub
End Class
