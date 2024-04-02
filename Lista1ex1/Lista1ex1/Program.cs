using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;
           
            
            Console.Write("Digite o valor da base: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite o valor da altura: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();

            area = b * a;

            Console.Write("A área é igual a: ");
            Console.Write(area) ;
            Console.Write("m³");
            Console.WriteLine();



        }
    }
}
