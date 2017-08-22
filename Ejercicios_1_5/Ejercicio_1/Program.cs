using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Ejercicio_1
    {
        static void Main(string[] args) {

            int numero;
            int i;
            int cantidad = 5;
            int mayor = 0;
            int menor = 0;
            int suma = 0;
            float promedio;
            string dato;

            Console.Title = "Ejercicio numero 1";

            for (i = 0; i < cantidad; i++) {

                Console.Write("Ingrese el numero " + (i + 1) + ": ");

                dato = Console.ReadLine();

                while (!int.TryParse(dato, out numero)) {

                    Console.WriteLine("Entrada invalida. Reingrese: ");
                    dato = Console.ReadLine();

                }

                if (i == 0) {

                    mayor = numero;
                    menor = numero;

                } else if (numero > mayor) {

                    mayor = numero;

                } else if (numero < menor) {

                    menor = numero;

                }

                suma += numero;

            }

            promedio = ((float)suma / cantidad);

            Console.WriteLine();
            Console.WriteLine("El mayor fue: " + mayor);
            Console.WriteLine("El menor fue: " + menor);
            Console.WriteLine("El promedio fue: {0:N3}", promedio);
            Console.Read();

        }
    }
}
