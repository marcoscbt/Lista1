using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int area;

            Console.Write("Digite o tamanho da aresta de um quadrado: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();

            area = a * a;

            Console.Write("A área do quadrado é: ");
            Console.Write(area);
            Console.Write("m³");

            Console.WriteLine();
            Console.WriteLine();




        }
    }
}
