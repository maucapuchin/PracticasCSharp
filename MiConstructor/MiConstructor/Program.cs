using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.nombre = "Mauricio Mascorro";
            p.ojos = 2;
            p.brazos = 2;
            p.piernas = 2;
            p.Color_Ojos ="castaño";
            p.Color_Ojos ="Moreno";
            Console.WriteLine("Mi nombre es: " + p.nombre + "\n" + " y tengo: " + p.ojos + " ojos" + "\n" + "y ademas tengo: " + p.brazos +  " brazos " + "\n"  + p.piernas + " piernas " + "\n" + p.Color_Ojos + "\n" + " y color de pelo " +  p.Color_Pelo +  "\n");
            Console.ReadKey();
        }
    }
}
