using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicializar_variables
{
    class Program
    {
        static void Main(string[] args)
        {

            //Entero
            int numeroLibros = 500;

            // declaramos 3 variables tipo entero
            int numerosLibros = 20, librosNiños = 5, librosMatematicas = 10;

            // declaro una variable tipo double y asigno un valor

            double promedioFinal = 4.8;


            //char un solo caracter

            char salon = 'A';

            // String conjunto caracteres usa comillas dobles

            string saludo = "Hola";

            // booleanos

            bool x = true;


            //float,decimal le agrega letra como sufijo para que el compitador lo entienda

            decimal promedioExamenes = 8.5M;

            float promedio = 4.325F;



            /*
             * 
             * Mostrar valor de las variables en consola
             */


            //declaramos una variable tipo string

            String saludar = "Hola";
            char caracter = 'a';
            double i = 5.5445;

            Console.WriteLine(saludo+' '+caracter+' '+i);


            //cadena de formato y lista de variables., indices inicia de cero

            double precioCamisa = 399;
            Console.WriteLine("El precio de la camisa es: {0}", precioCamisa);

            //mostrar multiples variables

            string colorCamisa = "azul";

            Console.WriteLine("El precio de la camisa es {0} y su color es {1} ", precioCamisa, colorCamisa);


            //cambiando la posicion de nuestras variables
            Console.WriteLine("El precio de la camisa es {0} y su color es {1} ", colorCamisa, precioCamisa);

            // mostrar dos veces la primera variable
            Console.WriteLine("El precio de la camisa es {0} y su color es {0} ", colorCamisa, precioCamisa);

            Console.ReadKey(); // en el caso que estemos depurando
     

        }
    }
}
