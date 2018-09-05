using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeraSenha
{
    public partial class Form1 : Form
    {
        // DEFINIMOS O TAMANHO MÁXIMO DE SENHAS GERADAS
        int numSenhas = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";

            // VERIFICANDO SE OS CKECKBOX ESTÃO MARCADOS
            // CHECKBOX MAIÚSCULAS
            if (cbMaiusculas.Checked)
                chars += "ABCDEFGHIJKLMNOPQWXYZ";

            // CHECKBOX NÚMEROS
            if (cbNumeros.Checked)
                chars += "0123456789";

            // CHECKBOX SÍMBOLOS
            if (cbSimbolos.Checked)
                chars += "#/$!?=-+\"";

            /* TODA VEZ QUE CLICAMOS NO GERAR
               A LISTA É APAGADA E COMEÇAMOS UMA DO 0 */
            listaSenhas.Items.Clear();

            Random rnd = new Random();

            for (int n = 1; n <= numSenhas; n++)
            {

                StringBuilder str = new StringBuilder();
                for (int m = 1; m <= count_chars.Value; m++)
                {
                    // ESTAMOS CRIADO UMA VARIÁVEL CHAMADA POS(POSIÇÃO)
                    // PARA VERIFICAR O TAMANHO DE CARACTERES QUE TEMOS ALI
                    // ELE VAI VERIFICAR NA VARIÁVEL CHARS
                    int pos = rnd.Next(0, chars.Length);
                    str.Append(chars[pos].ToString());
                }
                    listaSenhas.Items.Add(str.ToString());
            }
        }
    }
}
