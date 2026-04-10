using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n, c;

            Console.Write("ingrese nombre: ");
            n = Console.ReadLine();
            Console.Write("ingrese carrera: ");
            c = Console.ReadLine();

            Console.WriteLine("\n------IMPRESION CON + ------");
            Console.WriteLine(n + ",BIENVENIDO AL CURSO FA DE LA CARRERA " + c);

            Console.WriteLine("\n------IMPRESION CON $ ------");
            Console.WriteLine($"{n}, BIENVENIDO AL CURSO FA DE LA CARRERA {c}");
            Console.ReadKey();

        }
    }
}

