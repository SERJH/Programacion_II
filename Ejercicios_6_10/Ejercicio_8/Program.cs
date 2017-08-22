using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8 
{

    class Ejercicio_8
    {

        static void Main(string[] args) 
        {

            string[] nombres = { };
            int[] valoresHora = { };
            int[] antiguedades = { };
            int[] cantHorasMes = { };
            int cantidad;
            int i;
            float[] importesACobrarBruto = { };
            float[] importesACobrarNeto = { };
            float descuento = 0.87f;
            string dato;

            Console.Title = "Ejercicio numero 8";

            Console.Write("Ingrese la cantidad de empleados que se ingresaran: ");
            dato = Console.ReadLine();

            while (!int.TryParse(dato, out cantidad) || cantidad < 1) {

                Console.Write("Entrada invalida. Reingrese: ");
                dato = Console.ReadLine();

            }

            for (i = 0; i < cantidad; i++) {

                Console.Write("Ingrese el nombre del empleado numero {0}: ", (i + 1));
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese el valor hora de :", (nombres[i]));
                dato = Console.ReadLine();

                while (!int.TryParse(dato, out valoresHora[i]) || valoresHora[i] < 1) {

                    Console.Write("Entrada invalida. Reingrese: ");
                    dato = Console.ReadLine();

                }

                Console.Write("Ingrese la antiguedad de :", (nombres[i]));
                dato = Console.ReadLine();

                while (!int.TryParse(dato, out antiguedades[i]) || antiguedades[i] < 1) {

                    Console.Write("Entrada invalida. Reingrese: ");
                    dato = Console.ReadLine();

                }

                Console.Write("Ingrese las horas trabajadas en el mes de :", (nombres[i]));
                dato = Console.ReadLine();

                while (!int.TryParse(dato, out cantHorasMes[i]) || cantHorasMes[i] < 1) {

                    Console.Write("Entrada invalida. Reingrese: ");
                    dato = Console.ReadLine();

                }     

            }

            for (i = 0; i < cantidad; i++) {

                importesACobrarBruto[i] = (valoresHora[i] * cantHorasMes[i]);
                importesACobrarBruto[i] += (antiguedades[i] * 150);
                importesACobrarNeto[i] = importesACobrarBruto[i] * descuento;

                Console.WriteLine("NOMBRE\tANTIGUEDAD\tVALOR HORA\tCOBRO BRUTO\tDESCUENTOS\tCOBRO NETO\n");
                Console.Write("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", nombres[i], antiguedades[i], valoresHora[i], importesACobrarBruto[i], "13%", importesACobrarNeto[i]);

            }

            Console.Read();

        }

    }

}
