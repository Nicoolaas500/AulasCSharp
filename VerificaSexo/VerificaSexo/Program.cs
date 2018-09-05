using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaSexo
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo;

            Console.Write("Digite o seu gênero (M/F): ");
            sexo = char.Parse(Console.ReadLine());

            if (sexo == 'M'){
                Console.WriteLine("É bem macho");
            } else {
                Console.WriteLine("É uma garotinha");
            }

            Console.ReadLine();
        }
    }
}
