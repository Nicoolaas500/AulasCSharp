using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorPoupança
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorPoupancaTexto;
            float valorPoupanca;

            Console.WriteLine("Digite o valor que você possui na sua conta: ");
            valorPoupancaTexto = Console.ReadLine();
            valorPoupanca = float.Parse(valorPoupancaTexto);

            if (valorPoupanca > 100000)
            {
                Console.WriteLine("Você é um cliente VIP, dessa maneira possui taxas especiais!");
            }
            else if ( valorPoupanca > 50000 ) {
                Console.WriteLine("Você é um cliente ESPECIAL, com taxas de juros de 0,2% a.a. ");
            }
            else
            {
                Console.WriteLine("Você é um cliente especial, mas as suas taxas são normais!");
            }
            Console.ReadLine();
        }
    }
}
