using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4 
{

    class Ejercicio_4
    {

        static void Main(string[] args) 
        {

            int i;
            int j;
            int perfectos = 0;
            int suma = 0;

            Console.Title = "Ejercicio numero 4";

            Console.WriteLine("Los primeros cuatro numeros perfectos son:\n");

            while (perfectos < 4) {

                for (i = 2; i < 10000; i++) {

                    for (j = 1; j < i; j++) {

                        if ((i % j) == 0) {

                            suma += j;

                        }

                    }

                    if (suma == i) {

                        Console.Write("{0} ", i);
                        perfectos++;

                    }

                    suma = 0;

                }

            }

            Console.Read();       

        }

    }

}
