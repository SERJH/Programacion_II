using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2 
{

    class Ejercicio_2
    {

        static void Main(string[] args) 
        {

            int numero;
            int cuadrado;
            int cubo;
            string dato;

            Console.Title = "Ejercicio numero 2";

            Console.Write("Ingrese un numero: ");
            dato = Console.ReadLine();

            while ((!int.TryParse(dato, out numero)) || (numero <= 0)) {

                    Console.Write("Entrada invalida. Reingrese: ");
                    dato = Console.ReadLine();

            }

            cuadrado = numero * numero;
            cubo = cuadrado * numero;

            Console.WriteLine();
            Console.WriteLine("El cuadrado de {0} es: {1}", numero, cuadrado);
            Console.WriteLine("El cubo de {0} es: {1}", numero, cubo);
            Console.Read();

        }

    }

}
