Public Class frmCalculadora
    Private dblResultado As Double = 0
    Private dblNumero As Double = 0
    Private strOperador As String = String.Empty
    Private strNumero As String = "1"
    Private blnLimpa As Boolean = True
    Private blnDecimal As Boolean = False
    Private blnOperador As Boolean = False

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        dblNumero = 0
        dblResultado = 0
        txtResultado.Text = "0,00"
        strOperador = String.Empty
        blnDecimal = False
        blnLimpa = True
        strNumero = "1"
    End Sub
    ' CONFIGURANDO OS BOTÕES DOS NÚMEROS
    ' Botão Zero
    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If blnLimpa = True Then
            txtResultado.Text = "0"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "0"
        End If
    End Sub
    ' Botão Um
    Private Sub btnUm_Click(sender As Object, e As EventArgs) Handles btnUm.Click
        If blnLimpa = True Then
            txtResultado.Text = "1"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "1"
        End If
    End Sub
    ' Botão Dois
    Private Sub btnDois_Click(sender As Object, e As EventArgs) Handles btnDois.Click
        If blnLimpa = True Then
            txtResultado.Text = "2"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "2"
        End If
    End Sub
    ' Botão Três
    Private Sub btnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        If blnLimpa = True Then
            txtResultado.Text = "3"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "3"
        End If
    End Sub
    ' Botão Quatro
    Private Sub btnQuatro_Click(sender As Object, e As EventArgs) Handles btnQuatro.Click
        If blnLimpa = True Then
            txtResultado.Text = "4"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "4"
        End If
    End Sub
    ' Botão Cinco
    Private Sub btnCinco_Click(sender As Object, e As EventArgs) Handles btnCinco.Click
        If blnLimpa = True Then
            txtResultado.Text = "5"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "5"
        End If
    End Sub
    ' Botão Seis
    Private Sub btnSeis_Click(sender As Object, e As EventArgs) Handles btnSeis.Click
        If blnLimpa = True Then
            txtResultado.Text = "6"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "6"
        End If
    End Sub
    ' Botão Sete
    Private Sub btnSete_Click(sender As Object, e As EventArgs) Handles btnSete.Click
        If blnLimpa = True Then
            txtResultado.Text = "7"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "7"
        End If
    End Sub
    ' Botão Oito
    Private Sub btnOito_Click(sender As Object, e As EventArgs) Handles btnOito.Click
        If blnLimpa = True Then
            txtResultado.Text = "8"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "8"
        End If
    End Sub
    ' Botão Nove
    Private Sub btnNove_Click(sender As Object, e As EventArgs) Handles btnNove.Click
        If blnLimpa = True Then
            txtResultado.Text = "9"
            blnLimpa = False
        Else
            txtResultado.Text = txtResultado.Text & "9"
        End If
    End Sub
    ' CONFIGURANDO AS AÇÕES DOS BOTÕES DE CÁLCULO
    ' CONFIGURANDO BOTÃO DE SOMA
    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado + dblNumero
            txtResultado.Text = dblResultado
            dblResultado = 0
        End If
        blnLimpa = True
        blnDecimal = False
        strOperador = "+"
        blnOperador = False
    End Sub
    ' CONFIGURANDO BOTÃO DE SUBTRAÇÃO
    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado - dblNumero
            txtResultado.Text = dblResultado
            dblResultado = 0
        End If
        blnLimpa = True
        blnDecimal = False
        strOperador = "-"
        blnOperador = False
    End Sub
    ' CONFIGURANDO BOTÃO DE MULTIPLICAÇÃO
    Private Sub btnMultiplicação_Click(sender As Object, e As EventArgs) Handles btnMultiplicação.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado * dblNumero
            txtResultado.Text = dblResultado
            dblResultado = 0
        End If
        blnLimpa = True
        blnDecimal = False
        strOperador = "*"
        blnOperador = False
    End Sub
    ' CONFIGURANDO BOTÃO DE DIVISÃO
    Private Sub btnDivisao_Click(sender As Object, e As EventArgs) Handles btnDivisao.Click
        If strNumero = "1" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            strNumero = "2"
        ElseIf strNumero = "2" And blnOperador = True Then
            dblResultado = Convert.ToDouble(txtResultado.Text)
            dblResultado = dblResultado / dblNumero
            txtResultado.Text = dblResultado
            dblResultado = 0
        End If
        blnLimpa = True
        blnDecimal = False
        strOperador = "/"
        blnOperador = False
    End Sub
    ' CONFIGURANDO BOTÃO DE VÍRGULA
    Private Sub btnVirgula_Click(sender As Object, e As EventArgs) Handles btnVirgula.Click
        If blnDecimal = False Then
            txtResultado.Text = txtResultado.Text & ","
            blnDecimal = True
        End If
    End Sub
    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        If strOperador = "+" And dblNumero = 0 Then
            dblResultado = dblResultado + Convert.ToInt32(txtResultado.Text)
        ElseIf strOperador = "-" And dblNumero = 0 Then
            dblResultado = dblResultado - Convert.ToInt32(txtResultado.Text)
        ElseIf strOperador = "*" And dblNumero = 0 Then
            dblResultado = dblResultado * Convert.ToInt32(txtResultado.Text)
        ElseIf strOperador = "/" And dblNumero = 0 Then
            dblResultado = dblResultado / Convert.ToInt32(txtResultado.Text)
        End If

        txtResultado.Text = dblResultado
        blnLimpa = True
        blnOperador = False
    End Sub
End Class
