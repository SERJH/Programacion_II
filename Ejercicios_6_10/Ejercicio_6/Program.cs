using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6 
{

    class Ejercicio_6 
    {

        static void Main(string[] args) 
        {

            int year;
            bool esBisiesto = false;
            string dato;

            Console.Title = "Ejercicio numero 6";

            Console.Write("Ingrese un año: ");
            dato = Console.ReadLine();

            while (!int.TryParse(dato, out year) || year < 1) {

                Console.Write("Entrada invalida. Reingrese: ");
                dato = Console.ReadLine();

            }

            if ((year % 4) == 0) {

                esBisiesto = true;

                if ((year % 100) == 0 && (year % 400) == 0) {

                    esBisiesto = true;

                } else {

                    esBisiesto = false;

                }


            }

            if (esBisiesto) {

                Console.Write("\nEl año {0} es bisiesto", year);

            } else {

                Console.Write("\nEl año {0} no es bisiesto", year);

            }

            Console.Read();

        }

    }

}
