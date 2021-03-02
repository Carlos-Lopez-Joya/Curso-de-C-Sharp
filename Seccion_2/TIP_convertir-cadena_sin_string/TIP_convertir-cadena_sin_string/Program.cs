using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIP_convertir_cadena_sin_string
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 5, num2, resultado;


            //Convetir una cadena de texto en un entero sin usar String para no declarar mas variables


            Console.Write("Por favor ingrese un numero entero: ");
            // convertimos el numero que ingresa el usuario
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("La suma de dos numeros es {0}", resultado);

            Console.WriteLine("**********A partir de una estructura************");
            int num3;
            Console.Write("Por favor ingrese un numero entero: ");
            num3 = Int32.Parse(Console.ReadLine());

            
            resultado = num1 + num3;

            Console.WriteLine("La suma de dos numeros es {0}", resultado);



        }
    }
}
