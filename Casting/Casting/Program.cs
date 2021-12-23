using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
             * conversao implicita de float para double
             */

            float x = 4.5f;
            double y = x;

            float a = 5;
            double b = 7.3;
            /*
             * essa conversao implicita não é possivel porque double tem 8 bytes
             * enquanto float tem 4 bytes 
             * a = b;
             * 
             * para resolver isso é necessario fazer um casting explicito para o tipo desejado
             * como abaixo.
             */
            a = (float)b;
            /*
             * Os valores fracionados serão truncados
             */
            int c = (int)a;

            Console.WriteLine(a);

            Console.WriteLine(c);

            int d = 5;
            int e = 2;
            double resultado = d / e;
            /*
             * O compilador faz uma divisao inteira entre 'd' e 'e' e retorna 2
             * para resolver isso é necessario fazer um casting explicito informando que
             * voce deseja uma opeção de numeros reais
             */
            Console.WriteLine(resultado);

            resultado = (double)d / e;
            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}
