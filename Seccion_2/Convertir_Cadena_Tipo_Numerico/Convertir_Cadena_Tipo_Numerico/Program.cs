using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertir_Cadena_Tipo_Numerico
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Pedimos al usuario que ingrese un numero para reailizar una operacion
            */

            String numero;

            Console.Write("Por favor ingresar un numero: ");

            int num1 = 10, num2, num3, resultado, resultado2 ;

            float num4, num5;

            numero = Console.ReadLine();
            num2 = Convert.ToInt32(numero);
            resultado = num1 +num2;
            Console.WriteLine("La suma de los numeros es {0}", resultado);


            // Estructura tipo de valor

            num3 = Int32.Parse(numero);

            resultado2 = num3 + num1;

            Console.WriteLine("La suma entre dos numeros es: {0}",resultado2);


            /*
             * A partir clase y metodo converir a diferentes tipos de numero
             * 
             *  Convert.ToDouble
             *  Convert.ToSingle  ===> Float
             *  COnvert.ToDecimal
             *  
             */

            /*
                A partir de una estructura de datos Parse

            Int32.Parse()  =>int

            Single.Parce
            Double.Parce....



             */


            num4 = Convert.ToSingle(numero);

            num5 = Single.Parse(numero);

            Console.WriteLine(num5+10.4 + num4);
            


          




        }
    }
}
