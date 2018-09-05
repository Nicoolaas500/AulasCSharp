using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média
{
    class Program
    {
        static void Main(string[] args)
        {
            string nota;
            int media = 7;
            int menor = 5;

            Console.Write("Digite a nota do aluno: ");
            nota = Console.ReadLine();

            if (media >= 7)
            {
                Console.WriteLine("O aluno está aprovado");
            }
            else if (menor < 5)
            {
                Console.WriteLine("O aluno está reprovado");
            }
            else
            {
                Console.WriteLine("O aluno está de recuperação");
            }
            Console.ReadLine();
        }
    }
}
