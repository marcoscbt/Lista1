using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nota1;
            int nota2;
            int nota3;
            int nota4;
            int media;

            Console.Write("Digite quanto foi a primeira nota: ");

            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite quanto foi a segunda nota: ");

            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite quanto foi a terceira nota: ");

            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite quanto foi a quarta nota: ");

            nota4 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            media = (nota1 + nota2 + nota3 + nota4) / 4;
           
            Console.Write("A média final do aluno foi: ");
            Console.WriteLine(media);

            Console.WriteLine();
        }
    }
}
