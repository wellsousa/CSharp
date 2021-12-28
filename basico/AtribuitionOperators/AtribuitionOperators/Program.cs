using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtribuitionOperators
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int num1 = 10;
            Console.WriteLine(num1);

            /*
             * Operadores de atribuição negativa
             */

            num1 += 4;
            Console.WriteLine(num1);

            num1 -= 7;

            Console.WriteLine(num1);

            num1 *= 8;
            Console.WriteLine(num1);

            num1 /= 2;
            Console.WriteLine(num1);

            //o resto da divisao
            num1 %= 3;
            Console.WriteLine(num1);

            string nome = "Jose";
            Console.WriteLine(nome);

            nome += " Antunes";
            nome += " de";
            nome += " melo";
            Console.WriteLine(nome);

            Console.ReadLine();
        }
    }

}
