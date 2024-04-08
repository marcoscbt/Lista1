using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Digite o tamanho da diagonal do quadrado: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();

            b = a * a;
            c = b / 2;

            Console.Write("A área desse quadrado é: ");
            Console.Write(c);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
