using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxTorNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* IsControl FAZ MENÇÃO AS TECLAS DE CONTROLE, NESSE CASO, QUEREMOS QUE
             * AS TECLAS DE CONTROLE FUNCIONEM
             * NESSE CASO A BACKSPACE QUE QUEREMOS */

            /* IsDigit FAZ REFERÊNCIA AS TECLAS DE 0 ATÉ 9*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* isControl - TECLAS DE CONTROLE
             * IsLetter - LETRAS
             * IsLetter - LETRAS
             * IsWhiteSpace - BARRA DE ESPAÇO OU ESPAÇO EM BRANCO
             */
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
