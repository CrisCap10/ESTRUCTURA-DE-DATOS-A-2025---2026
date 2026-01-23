using System;
using System.Collections.Generic;

namespace Practico_2_Pilas_Colas
{
    // Clase que representa a una persona
    class Persona
    {
        public string Nombre { get; set; }
        public int NumeroAsiento { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
            NumeroAsiento = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Se crea la cola para simular el orden de llegada
            Queue<Persona> colaPersonas = new Queue<Persona>();

            // Registro de 30 personas
            for (int i = 1; i <= 30; i++)
            {
                colaPersonas.Enqueue(new Persona("Persona " + i));
            }

            Console.WriteLine("Asignación de asientos en orden de llegada:\n");

            int asiento = 1;

            // Asignación de asientos respetando FIFO
            while (colaPersonas.Count > 0)
            {
                Persona personaActual = colaPersonas.Dequeue();
                personaActual.NumeroAsiento = asiento;

                Console.WriteLine(
                    personaActual.Nombre + " ocupa el asiento " + personaActual.NumeroAsiento
                );

                asiento++;
            }

            Console.WriteLine("\nTodos los asientos han sido asignados correctamente.");
            Console.ReadKey();
        }
    }
}




