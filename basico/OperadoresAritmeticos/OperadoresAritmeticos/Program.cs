using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * MAIOR PRECEDENCIA
             * *   Multiplicação
             * /   Divisão
             * %   Resto da Divisão
             */

            /*
             * MENOR PRECEDENCIA
             * +   Adição
             * -   Subtração
             */

            int a = 1;
            int b = -3;
            int c = -4;
            int resultado = 0;
            int resto = 0;
            double resultado2 = 0;

            resultado = a + b * c;

            /*
             * resultado = 3 + (4 *2) = 11
             */

            Console.WriteLine(resultado);


            /*
             * Para quebrar a precedencia você deve espeficar entre parenteses qual operação deve ser feita 
             * primeiro
             */

            resultado = (a + b) * 2; //(3+4) * 2;
            Console.WriteLine(resultado);

            /*
             * Mod = % = Resto da divisao
             */

            resto = resultado % 3; //2
            Console.WriteLine(resto);

            resultado2 = (a * b * c) / 5;
            Console.WriteLine(resultado2);

            //resultado correto após fazer o casting ou conversao explicita
            resultado2 = (double)(a * b * c)/5;
            Console.WriteLine(resultado2);

            /*
             *  Formula de Bhaskara
             */

            double delta = Math.Pow(b, 2) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta) )/(2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            Console.ReadLine();
            
        }
    }
}
