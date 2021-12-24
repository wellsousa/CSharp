using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleKeyboardInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("A frase que voce escreveu é: {0}", frase);

            /*
             * Recebendo um vetor de strings com um separador
             */
            Console.WriteLine("Escreva uma lista com 3 itens separadas por um espaço em branco: ");
            string itens = Console.ReadLine();
            string[] vet = itens.Split(' ');
            Console.WriteLine($"Os itens que você digitou são: {vet[0]}, {vet[1]}, {vet[2]}");


            /*
             * Lendo numeros do teclado
             */
            Console.WriteLine("Digite um numero inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);

            Console.WriteLine("Digite um numero real: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(n2.ToString("F3", CultureInfo.InvariantCulture));


            /*
             * Ler um conjunto de dados de uma string separada por espaços em granco
             */
            Console.WriteLine("Digite o nome, sexo, idade e altura separados por um espaço: ");
            String[] vet2 = Console.ReadLine().Split(' ');
            string nome = vet2[0];
            char sexo = char.Parse(vet2[1]);
            int idade = int.Parse(vet2[2]);
            double altura = double.Parse(vet2[3]);

            Console.WriteLine($"{nome} do sexo {sexo} tem {idade} anos e altura de {altura}m.");

            Console.ReadLine();

        }

    }
}
