using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nombres = { "angel", "paty", "Luis", "Maria" };
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            Console.ReadKey();
        }
        
    }
}
