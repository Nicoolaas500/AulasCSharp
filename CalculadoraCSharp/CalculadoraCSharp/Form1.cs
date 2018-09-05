using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public partial class Form1 : Form
    {
        // DECLARANDO AS VARIÁVEIS DO MEU SISTEMA
        double valor01;
        double valor02;

        public Form1()
        {
            InitializeComponent();
        }

        private void operacaoClick(object sender, EventArgs e)
        {
            valor01 = Double.Parse(txtUm.Text);
            valor02 = Double.Parse(txtDois.Text);

            // PODEMOS VERIFICAR QUAL A OPERAÇÃO QUE O NOSSO USUÁRIO ESTÁ EXECUTANDO
            string tipo_operacao = (sender as Button).Text;

            // MOSTRANDO A OPERAÇÃO DENTRO DE UMA MESSAGE BOX
            // SÓ VAI FUNCIONAR SE O USUÁRIO DIGITAR ALGO
            // MessageBox.Show(tipo_operacao);

            // MOSTRANDO O RESULTADO NA LABEL
            lbResultado.Text = String.Format("{0} {1} {2} = {3}", valor01.ToString(), tipo_operacao, valor02.ToString(), operacao(tipo_operacao));
        }
        private string operacao(string tipo)
        {
            double resultado = 0;

            switch (tipo)
            {
                case "+":
                    resultado = valor01 + valor02;
                    break;
                case "-":
                    resultado = valor01 - valor02;
                    break;
                case "x":
                    resultado = valor01 * valor02;
                    break;
                case ":":
                    resultado = valor01 / valor02;
                    break;
            }

            return resultado.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbResultado.Text = "";
        }
    }
}
