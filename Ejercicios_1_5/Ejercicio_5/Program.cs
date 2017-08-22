using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5 
{

    class Ejercicio_5
    {

        static void Main(string[] args) 
        {

            int i;
            int j;
            int numero;
            int sumaIzquierda = 0;
            int sumaDerecha = 0;
            int centro;
            string dato;

            Console.Title = "Ejercicio numero 5";

            Console.Write("Ingrese un numero: ");
            dato = Console.ReadLine();

            while (!int.TryParse(dato, out numero) || numero <= 0) {

                Console.Write("Entrada invalida. Reingrese: ");
                dato = Console.ReadLine();

            }

            Console.WriteLine("\nCentros numericos hasta el numero ingresado:\n");

            for (i = 1; i <= numero; i++) {

                sumaIzquierda += i;
                centro = i+1;

                for (j = i+2; sumaDerecha <= sumaIzquierda; j++) {

                    sumaDerecha += j;

                    if (sumaIzquierda == sumaDerecha) {

                        Console.Write("{0} ", centro);

                    }

                }

                sumaDerecha = 0;

            }

            Console.Read();

        }

    }

}
