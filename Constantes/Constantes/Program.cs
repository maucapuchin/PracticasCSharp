using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double radio;

            Console.WriteLine("Introduzca un valor");
            radio = Convert.ToDouble(Console.ReadLine());

            double areaCirculo = pi * radio * radio;

            Console.WriteLine("El radio es: {0}, y el area del circulo es: {1}", radio, areaCirculo);
            Console.ReadKey();
        }
    }
}
