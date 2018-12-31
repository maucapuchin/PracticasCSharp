using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCondicionalIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 8;

            Console.WriteLine("Que nota saco el alumno?");
            media = Convert.ToDouble(Console.ReadLine());

            if (media >= 7){
                Console.WriteLine("El alumno aprobo examen");
            }

            else if(media < 7 && media > 5)
            {
                Console.WriteLine("El alumno debe ir a repesca");

            }else
            {
                Console.WriteLine("El alumno ha suspendido");
            }
            Console.ReadKey();
        }
    }
}
