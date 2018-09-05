using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculeData
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // DateTime.Now.Year - Pega a data do meu sistema operacional
            // DateTimePicker1 - é o meu elemento
            // .Value - eu indico para o sistema o calor que eu quero
            // .Year - eu pego o valor ANO
            int idade = DateTime.Now.Year - dateTimePicker1.Value.Year;
            MessageBox.Show("Tem " + idade + " anos de idade!");

            if (DateTime.Now.Year < dateTimePicker1.Value.DayOfYear) idade--;
            
            // Verificar se é menor de idade
            // Verificar se a idade é maior que 18 e menor que 55
            // Se for maior que 55 é a melhor idade

            if(idade < 18)
            {
                MessageBox.Show("Você é menor de idade");
            }
            else if(idade > 18 && idade < 55)
            {
                MessageBox.Show("Você é maior de idade");
            }
            else
            {
                MessageBox.Show("Você está mt Rogério");
            }
        }
    }
}
