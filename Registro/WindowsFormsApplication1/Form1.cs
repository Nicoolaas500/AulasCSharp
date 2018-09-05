using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
//
// TXT NOME
//
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
//
// TXT SOBRENOME
//

            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
//
// TXT IDADE
//
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
//
// TXT DATA DE NASCIMENTO
//
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&[
                !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
//
// TXT EMAIL
//
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&[
                !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
//
// TXT CIDADE
//
            if (!char.IsControl(e.KeyChar) &&
                    !char.IsLetter(e.KeyChar) &&
                    !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
//
// TXT ESTADO
//
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
