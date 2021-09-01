using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "";

            Console.WriteLine("Por favor ingrese un texto");

            texto = Console.ReadLine();
            if (texto == "")
                {
                Console.WriteLine("Debe escribir algo...!!");
            } 

            Console.WriteLine("Usted acaba de escribir: " + texto);

            Console.ReadKey();
            
           
        }
    }
}
