using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Operadores aritmeticos
             * hacen referencia a los operadores binarios: + - * / %
             * 
             */


            //suma enteros y flotantes y cadenas

            int num1 = 8;
            double num2 = 4.5;

            double resultado; // declaramos variable

            // sumamos las dos variables

            resultado = num1 + num2;

            Console.WriteLine("*****SUMA*****");

            Console.WriteLine(num1+ num2);

            Console.WriteLine("La suma entre dos numeros es: {0}", resultado);

            // concatenar

            String saludo = "Hola";

            string nombre = "Carlos";

            // sumando dos cadenas ==> concatenar

            Console.WriteLine(saludo +" "+ nombre);



            //Resta
            Console.WriteLine("***** RESTA *****");

            int a = 5;
            float b = 3.5f;
            float resta=a-b;
           
            Console.WriteLine($"La resta entre dos numeros es: {resta}");



            //Multiplicacion
            Console.WriteLine("***** MULTIPLICACION *****");

            int c = 5;
            double d = Math.PI;

            double mul = c * d;

            Console.WriteLine($"La multiplicacion entre dos numeros {c} , {d} es: {mul}");


            //Division
            Console.WriteLine("***** DIVISION *****");


            // tener encuenta, si divido numeros enteros el compilador me entrega un numero entero
            // basta con agregar un 1.0 asi hara la operacion


            Console.WriteLine(10/3.0);


            Console.WriteLine("***** Comprobacion de la presicion digitios *****");

            /*
             * Comprobacion de la presicion digitios
             * 
             * subijo d double
             * sufijo f float
             * sufijo m decimal
             */


            Console.WriteLine($" Flotantes {16.8f / 4.1f}");
            Console.WriteLine($" Double {16.8d / 4.1d}");

            Console.WriteLine($" Decimal {16.8m / 4.1m}");

            Console.WriteLine("***** Residuo o modulo *****");

            Console.WriteLine($"El residuo de {5} y {2} es: {5 % 2}");


            double f = 4.8;

            int g = 2;

            double h = f % g;

            Console.WriteLine($"El residuo entre los numero {f} y {g} es: {f % g}");

            Console.WriteLine("El residuo entre los numeros {0} y {1} es {2}", f, g, h);


            // Jerarquia de operaciones

            Console.WriteLine("***** Jerarquia de operaciones *****");


            // el orden no altera el producto
            //jerarquia multiplicacion division modulo
                // suma resta

            Console.WriteLine(5.0/2*2);


            Console.ReadKey();


        }
    }
}
