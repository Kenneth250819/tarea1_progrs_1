using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kenneth_asignacion1
{
    internal class Program
    {
        static string[] estudiantes;
        static void Main(string[] args)
        {
            bool salir = false;

            while(!salir)
            {
                Console.WriteLine("------Menu Principal-------");
                Console.WriteLine("1. Ingreso de Estudiantes.");
                Console.WriteLine("2. Opcion 2");
                Console.WriteLine("3. Salir.");

                string opcion = Console.ReadLine();

                switch (opcion)
                {

                    case "1": 
                        Console.WriteLine("Selecciono el Ingreso de estudiantes");
                        IngresodeNombres();
                        break;
                    case "2":
                        Console.WriteLine("Imprimir Array de estudiantes.");
                        ImprimirArray();
                        break;
                    case "3":
                        Console.WriteLine("Saliendo del programa...");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion Invalida");
                        break;
                }

                Console.WriteLine();

            }

            Console.WriteLine("--El programa ha terminado");
            Console.ReadKey();

        }
        static String ImprimirArray() {
            if (estudiantes == null || estudiantes.Length == 0)
            {
                Console.WriteLine("No se han ingresado estudiantes.");
            }
            else
            {
                foreach (string str in estudiantes)
                {
                    Console.WriteLine($"{str}");
                }
            }
            return "";
        }

        static string[] IngresodeNombres(){
            Console.WriteLine(" Ingrese la cantidad de estudiantes: ");
            int cantidad = int.Parse(Console.ReadLine());

            estudiantes = new string[cantidad];

            for (int i = 0;i < cantidad; i++)
            {
                Console.WriteLine(" Nombre {0}: ", i+1);
                estudiantes[i] = Console.ReadLine();   

            }
          
            return estudiantes;
        }

    }
}
