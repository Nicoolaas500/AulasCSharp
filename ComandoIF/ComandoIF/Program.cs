using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoIF
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 7;

            // INICIO DO COMANDO IF
            if (num > 7) // SE
            {
                Console.WriteLine("O número é maior a 7");
            }
            // FIM DO COMANDO IF
            else if (num < 7) { // SENÃO SE
                Console.WriteLine("O número é menor que 7");
            }
            else
            {
                Console.WriteLine("O número é igual a 7");
            }

            Console.ReadKey();
        }
    }
}
