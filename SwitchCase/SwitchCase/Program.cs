﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;

            Console.WriteLine("Introduzca el nombre del mes");
            mes = Console.ReadLine();

            switch (mes)
            {
                case "enero":
                case "marzo":
                case "mayo":
                case "julio":
                case "agosto":
                case "octubre":
                case "diciembre":
                    Console.WriteLine("Este mes tiene 31 dias");
                    break;

                case "febrero":
                    Console.WriteLine("Este mes tiene 28 dias");
                    break;

                default:
                    Console.WriteLine("Este mes tiene 30 dias");
                    break;

                    Console.ReadKey();
            }
        }
    }
}
