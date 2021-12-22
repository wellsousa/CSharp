using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace outputConsolePractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brasil");
            Console.Write("Eu ");
            Console.Write(" moro ");
            Console.Write(" no ");
            Console.Write(" Brasil ");

            char gender = 'M';
            string firstName = "Paulo";
            string lastName = "de Abreu";
            int age = 32;
            double amount = 234.236789;

            Console.WriteLine(gender);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(amount.ToString("F2"));


            /*
             * Format Provider 
             * CultureInfo.InvariantCulture: desconsidera qualquer formatação especifica de uma nacionalidade
             */

            Console.WriteLine(amount.ToString("F2", CultureInfo.InvariantCulture));

            /*
             * Placeholder
             */

            Console.WriteLine("{0} {1} com idade de {2} tem {3:F2} de saldo", firstName, lastName, age, amount);

            /*
             *  Interpolação
             */

            Console.WriteLine($"{firstName} {lastName} com idade de {age} tem {amount:F2} de saldo");

            /*
             * Concatenação
             */


            Console.WriteLine(firstName + " " + lastName + " com idade de " + age + " tem " + amount.ToString("F2", CultureInfo.InvariantCulture) + " de saldo");

            string product1 = "computador";
            double product1_age = 5.567895;
            int id_1 = 5120;
            char saled_1 = 'N'; //(Y)es ou (N)ot
            double price1 = 2382.47;

            string product2 = "mesa de escritório";
            double product2_age = 15.78954465;
            int id_2 = 5121;
            char saled_2 = 'Y';
            double price2 = 769.89;

            Console.WriteLine($"Produto: {product1}, cujo preço é {price1:F2} tem tempo de uso estimado em {product1_age:F4} anos, vendido: {saled_1}");
            Console.WriteLine($"Produto: {product2}, cujo preço é {price2:F2} tem tempo de uso estimado em {product2_age:F4} anos, vendido: {saled_2}");
            Console.ReadLine();
        }

    }
}
