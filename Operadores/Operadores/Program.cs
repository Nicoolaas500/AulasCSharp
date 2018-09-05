using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // ATRIBUIÇÃO SIMPLES AO DECLARAR UMA VARIÁVEL
            int valorA = 10;

            // ATRIBUIÇÃO COM A SOMA
            // ESTAMOS RESUMINDO O SEGUINTE COMANDO
            // valorA = valorA - 10
            valorA += 10;

            // ATRIBUIÇÃO COM A SUBTRAÇÃO
            // ESTAMOS RESUMINDO O SEGUINTE COMANDO
            valorA -= 10;

            // ATRIBUIÇÃO COM A MULTIPLICAÇÃO
            // ESTAMOS RESUMINDO O SEGUINTE COMANDO
            // valorA = valor A * 3
            valorA *= 3;

            // ATRIBUIÇÃO COM Divisão
            // ESTAMOS RESUMINDO O SEGUINTE COMANDO
            // valorA = valorA / 3;
            valorA /= 10

            // ATRIBUIÇÃO COM DIVISÃO
            // ESTAMOS RESUMINDO O SEGUINTE COMANDO
            // valorA = valorA % 4;
            valorA %= 4
            */

            Console.WriteLine(10 == 10);
            Console.WriteLine(11 == 10);

            if (10 == 10)
            {
                Console.WriteLine("10 é igual à 10");
            }

            // OU

            if (10 == 1)
            {
                Console.WriteLine("Os valores não são iguais");
            }
            else
            {
                Console.WriteLine("Os números não são iguais");
            }

            // ------------------------------------------------

            // VERIFICAÇÃO SIMPLES SE OS VALORES SÃO MAIORES OU MENORES
            Console.WriteLine(10 > 9);
            Console.WriteLine(10 < 9);

            // VERIFICAÇÃO SIMPLES SE OS VALORES SÃO MAIORES OU IGUAIS, MENORES OU IGUAIS
            Console.WriteLine(9 >= 9);
            Console.WriteLine(10 < 9);

            // VERIFICAÇÃO SIMPLES SE OS VALORES SÃO DIFERENTES
            Console.WriteLine(10 != 10);

            Console.ReadLine();
        }
    }
}
