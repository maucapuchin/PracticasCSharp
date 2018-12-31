using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.hablar();
            p.setNombre("Mauricio Mascorro");
            Console.WriteLine("El nombre: " + p.getNombre() + " ha sido modificado"); 
            Console.ReadKey();
        }


    }
}
