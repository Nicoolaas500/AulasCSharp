using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RecebeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, estCivil, cidade, endereco, bairro, pais ;
            int idade, qtdFilhos;
            double salario;
            char sexo;

            // RECEBENDO OS VALORES QUE DEVEM SER DIGITADOS PELO USUÁRIO
            // TRABALHANDO COM A VARIÁVEL X - STRING
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu estado civil: ");
            estCivil = Console.ReadLine();

            Console.Write("Digite a cidade onde mora: ");
            cidade = Console.ReadLine();

            Console.Write("Digite o endereço onde mora: ");
            endereco = Console.ReadLine();

            Console.Write("Digite o bairro de sua casa: ");
            bairro = Console.ReadLine();

            Console.Write("Digite em que país mora: ");
            pais = Console.ReadLine();

            // TRABALHANDO COM A VARIÁVEL Y - INTEIRO
            // O método int.Parse() é usado para converter
            // uma representação de string de um número em um inteiro.
            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite quantos filhos tem: ");
            qtdFilhos = int.Parse(Console.ReadLine());

            // TRABALHANDO COM A VARIÁVEL Z - DOUBLE
            Console.Write("Digite o salário: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // TRABALHANDO COM A VARIÁVEL W - char
            Console.Write("Digite o seu sexo(M/F): ");
            sexo = char.Parse(Console.ReadLine());

            // APRESENTANDO OS VALORES DIGITADOS
            Console.WriteLine();
            Console.WriteLine("RESULTADO");
            Console.WriteLine("O nome digitado foi: " + nome);
            Console.WriteLine("A idade informada foi: " + idade );
            Console.WriteLine("O salário informado foi de: R$ " + salario);
            Console.WriteLine("O sexo informado foi: " + sexo);
            Console.WriteLine("O meliante é: " + estCivil);
            Console.WriteLine("Na cidade de: " + cidade);
            Console.WriteLine("Endereço da casa é: " + endereco);
            Console.WriteLine("No bairro: " + bairro);
            Console.WriteLine("No país: " + pais);
            Console.WriteLine("E tem" + qtdFilhos);

            Console.ReadLine();
        }
    }
}
