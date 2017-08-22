using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3 
{

    class Ejercicio_3
    {

        static void Main(string[] args) 
        {

            int numero;
            int i;
            int j;
            int cantDivisores = 0;
            string dato;

            Console.Title = "Ejercicio numero 3";

            Console.Write("Ingrese un numero: ");
            dato = Console.ReadLine();

            while (!int.TryParse(dato, out numero) || numero <= 0) {

                Console.Write("Entrada invalida. Reingrese: ");
                dato = Console.ReadLine();

            }

            Console.WriteLine("\nCantidad de numeros primos desde 1 hasta {0}:\n", numero);

            for (i = 1; i <= numero; i++) {

                for (j = 1; j <= i; j++) {

                    if ((i % j) == 0) {

                        cantDivisores++;

                    }

                }


                if (i == 1 || cantDivisores == 2) {

                    Console.Write("{0} ", i);

                }

                cantDivisores = 0;

            }

            Console.Read();

        }

    }

}
