using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Olá amigos, estou muito feliz por estar aqui com vocês!";
            String palavra = "feliz";
            String texto01 = "Silvio Santos Ipsum  namoro ou amizadeemm? Boca sujuam... sem vergonhuamm. Ma o Silvio Santos Ipsum  muitoam interesanteam. Com ele ma voc vai gerar textuans ha haae. Valendo um milho de reaisammm. Um, dois trs, quatro, PIM, entendeuam?  por sua conta e riscoamm? Ma vai pra l. Ma.";
            String palavra01 = "ha";

            // DESCOBRINDO O TAMANHO DO MEU TEXTO
            Console.WriteLine("O tamanho do texto é de: " + texto.Length);
            Console.WriteLine("O tamanho do texto é de: " + texto01.Length);

            // LOCALIZANDO UMA PALAVRA INDICADA
            Console.WriteLine("O texto foi localizado na posição: " + texto.IndexOf(palavra));
            Console.WriteLine("O segundo texto foi localizado na posição: " + texto01.IndexOf(palavra01));

            // LOCALIZANDO A POSIÇÃO DO ÚLTIMO CARACTERE
            Console.WriteLine("O último caractere foi localizado na posição: " + texto.LastIndexOf(palavra));

            // IMPEDINDO O FECHAMENTO DO SISTEMA
            Console.ReadLine();
        }
    }
}
