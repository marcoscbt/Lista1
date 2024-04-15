using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double celsius;
            double fahr;

            Console.WriteLine("Calculadora de Celsius em Fahrenheit:");

            Console.Write("Escreva a temperatura em graus Celsius: ");

            celsius = Double.Parse(Console.ReadLine());

            fahr = celsius * 1.8 + 32;

            Console.WriteLine("A temperatura em Fahrenheit é igual a: {0}", fahr);

            Console.WriteLine();
        }
    }
}
