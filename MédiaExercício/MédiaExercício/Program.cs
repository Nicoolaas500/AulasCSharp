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
            int nota1, nota2, nota3, nota4;
            int media;
           

            Console.WriteLine("Digite a primeira nota do aluno: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota do aluno: ");
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota do aluno: ");
            nota4 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("O aluno está aprovado");
            }
            else if (media >= 5)
            {
                Console.WriteLine("O aluno está de recuperação");
            }
            else
            {
                Console.WriteLine("O aluno está reprovado");
            }

            Console.ReadLine();
        }
    }
}
