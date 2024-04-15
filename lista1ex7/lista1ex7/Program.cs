using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transforme km's em milhas marítimas:");

            double km;
            double resultado;

            Console.Write("Escreva quantos quilomêtros são da sua casa até a faculdade: ");
            km = double.Parse(Console.ReadLine());

            resultado = km * 1.852;
            
            Console.WriteLine();

            Console.WriteLine("A distância em milhas maritimas é igual a: {0}", resultado);

            Console.WriteLine();


            
        }
    }
}
