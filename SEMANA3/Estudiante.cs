using System;

namespace RegistroEstudiante
{
    class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; }

        // Constructor
        public Estudiante()
        {
            Nombres = "";
            Apellidos = "";
            Direccion = "";
            Telefonos = new string[3];
        }

        public void MostrarDatos()
        {
            Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");

            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }
}



