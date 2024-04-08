using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bas;
            int alt;
            int area;
            int resultado;

            Console.Write("Digite o tamanho da base do triangulo: ");

            bas = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite a altura do triangulo: ");

            alt = int.Parse(Console.ReadLine());

            area = bas * alt;
            resultado = area / 2;

            Console.WriteLine();

            Console.Write("A area do triangulo é igual a: ");
            Console.WriteLine(resultado);

            Console.WriteLine();

        }
    }
}
