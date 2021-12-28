using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Operadores Logicos
             * && - E
             * || - OU
             * ! - NOT
             */

            int a = 2;
            int b = 3;
            int c = 4;
            int d = 5;

            // 2 > 3  E 4!=5
            bool c1 = (a > b) && (c != d);
            Console.WriteLine("(2 > 3) && (4 != 5): ");
            Console.WriteLine((c1 ? "verdadeiro" : "falso"));
            int value = 34;

            //2 == 3 OU 4 < 5
            bool c2 = (a == b) || (c < d);
            Console.WriteLine("(2  == 3) || (4 < 5): ");
            Console.WriteLine(c2 ? "verddeiro" : "falso");

            bool c3 = !(c < d); //verdadeiro
            Console.WriteLine(c3);

            /*
             * A precedencia do && é maior que a do ||
             * Caso queira que o || seja executado primeiro deve colocar parentenses.
             */
            bool c4 = c1 || c2 && c3;
            Console.WriteLine(c4); //verdadeiro

            bool c5 = (c1 || c2) && c3;
            Console.WriteLine(c5);

            Console.ReadLine();
        }
    }
}
