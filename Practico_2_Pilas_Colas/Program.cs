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
            // Cola para almacenar a las personas según su llegada (FIFO)
            Queue<Persona> colaPersonas = new Queue<Persona>();

            int asiento = 1;
            int limiteAsientos = 30;

            Console.WriteLine("ASIGNACIÓN DE ASIENTOS (MÁXIMO 30)");
            Console.WriteLine("Presione cualquier tecla para ingresar una persona...\n");

            // Mientras no se alcance el límite de asientos
            while (asiento <= limiteAsientos)
            {
                Console.ReadKey(true); // Espera que el operador presione una tecla

                Persona nuevaPersona = new Persona("Persona " + asiento);
                colaPersonas.Enqueue(nuevaPersona);

                Persona personaActual = colaPersonas.Dequeue();
                personaActual.NumeroAsiento = asiento;

                Console.WriteLine(
                    personaActual.Nombre + " ocupa el asiento " + personaActual.NumeroAsiento
                );

                asiento++;
            }

            Console.WriteLine("\n⚠️ Límite de 30 asientos alcanzado.");
            Console.WriteLine("No se pueden asignar más asientos.");
            Console.ReadKey();
        }
    }
}

