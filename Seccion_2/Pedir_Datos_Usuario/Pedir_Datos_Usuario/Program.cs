using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedir_Datos_Usuario
{
    class Program
    {
        static void Main(string[] args)
        {

            // declaramos una variable tipo String sin inicializarla

            String nombre;

            Console.Write("¿Como te llamas? ");

            nombre = Console.ReadLine();

            Console.WriteLine("Hola {0}, encantado de conocerte", nombre);

        }
    }
}
