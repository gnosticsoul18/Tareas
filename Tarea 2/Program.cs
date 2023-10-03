using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1 - Ejercicio #1");
                Console.WriteLine("2 - Ejercicio #2"); 
                Console.WriteLine("3 - Ejercicio #3");
                Console.WriteLine("4 - Salir"); 
                Console.WriteLine("Digite una opción: ");
                opcion = int.Parse(Console.ReadLine()); // Leer dato como integer

                switch (opcion)
                {
                    case 1:
                        Ejercicio1(); // Llamada al método Ejercicio1
                        break;
                    case 2:
                        Ejercicio2(); // Se llama al método Ejercicio2
                        break;
                    case 3:
                        // Llamar al método del ejercicio #3
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 4); // Se hace el proceso mientras sea diferente de 4
        }

        public static void Ejercicio1()
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("Digite el precio de la camisa: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de camisas: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"Total a pagar = {cantidad * precio}");
            }
            else if (cantidad > 1 && cantidad < 6)
            {
                total = precio * 0.15f;
                total = precio - total;
                total = total * cantidad;
                Console.WriteLine($"Total a pagar: {total} con descuento de 15%");
            }
            else if (cantidad >= 6)
            {
                total = precio * 0.20f;
                total = precio - total;
                total = total * cantidad;
                Console.WriteLine($"Total a pagar: {total} con descuento de 20%");
            }
            else
            {
                Console.WriteLine("Cantidad no válida.");
            }
        }
         public static void Ejercicio2()
         {
            // Se declaran las variables
            string carnet, nombre;
            float quiz1, quiz2, quiz3, tarea1, tarea2, tarea3, examen1, examen2, examen3;

            // Leer datos del estudiante
            Console.WriteLine("Ingrese el carnet del estudiante:");
            carnet = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del estudiante:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del Quiz 1:");
            quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Quiz 2:");
            quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Quiz 3:");
            quiz3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la Tarea 1:");
            tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la Tarea 2:");
            tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la Tarea 3:");
            tarea3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Examen 1:");
            examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Examen 2:");
            examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Examen 3:");
            examen3 = float.Parse(Console.ReadLine());

            // Calcular porcentajes
            float porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * (25f / 100f);
            float porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * (30f / 100f);
            float porcentajeExamenes = (examen1 + examen2 + examen3) / 3 * (45f / 100f);

            // Calcular promedio final
            float promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            // Determinar la condición del estudiante
            string condicion;
            if (promedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (promedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }

            // Mostrar resultados
            Console.WriteLine("Resultados del estudiante:");
            Console.WriteLine("Carnet: " + carnet);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Porcentaje de Quices: " + porcentajeQuices +"%");
            Console.WriteLine("Porcentaje de Tareas: " + porcentajeTareas + "%");
            Console.WriteLine("Porcentaje de Examenes: " + porcentajeExamenes + "%");
            Console.WriteLine("Promedio Final: " + promedioFinal + "%");
            Console.WriteLine("Condición: " + condicion);
        }
        public static void Ejercicio3()
        {
            // se declaran las variables
            int cantidad = 0;int precio = 0; int total = 0;
            
            
            // Leer la cantidad de artículos comprados
            Console.WriteLine("Ingrese la cantidad de artículos comprados:");
            cantidad = int.Parse(Console.ReadLine());
            
            // Determinar el precio por artículo
            if (cantidad <= 10)
            {
                precio = 20; // Precio por artículo si se compran 10 o menos
            }
            else
            {
                precio = 15; // Precio por artículo si se compran más de 10
            }
            
            // Calcular el total
            total = cantidad * precio;
            
            // Mostrar resultados
            Console.WriteLine($"Precio por artículo: ${precio}");
            Console.WriteLine($"Total a pagar: ${total}");    
        }
    }
}
