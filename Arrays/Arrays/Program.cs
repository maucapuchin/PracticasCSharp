using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        // este es un comentario de prueba un comentario mas
        static void Main(string[] args)
        {
            string[] pilotos = new string[4] { "alonso", "Hamilton", "verse", "sainz" };
            Console.WriteLine(pilotos[2]);
            Console.WriteLine();
            pilotos[2] = "verse";
            foreach (string piloto in pilotos)
            {
                Console.WriteLine(piloto);
            }
            Console.ReadKey();
        }
    }
}
