using System;

// Clase principal del programa
class Program
{
    // Método Main: punto de entrada del programa
    static void Main(string[] args)
    {
        // Crear un objeto de la clase Estudiante
        Estudiante estudiante = new Estudiante();

        // Solicitar y leer el ID del estudiante
        Console.Write("ID: ");
        estudiante.Id = Console.ReadLine();

        // Solicitar y leer los nombres del estudiante
        Console.Write("Nombres: ");
        estudiante.Nombres = Console.ReadLine();

        // Solicitar y leer los apellidos del estudiante
        Console.Write("Apellidos: ");
        estudiante.Apellidos = Console.ReadLine();

        // Solicitar y leer la dirección del estudiante
        Console.Write("Dirección: ");
        estudiante.Direccion = Console.ReadLine();

        // Ciclo for para ingresar los tres números de teléfono
        for (int i = 0; i < estudiante.Telefonos.Length; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            estudiante.Telefonos[i] = Console.ReadLine();
        }

        // Mostrar los datos ingresados
        Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
        Console.WriteLine($"ID: {estudiante.Id}");
        Console.WriteLine($"Nombres: {estudiante.Nombres}");
        Console.WriteLine($"Apellidos: {estudiante.Apellidos}");
        Console.WriteLine($"Dirección: {estudiante.Direccion}");

        // Mostrar los números de teléfono almacenados en el arreglo
        for (int i = 0; i < estudiante.Telefonos.Length; i++)
        {
            Console.WriteLine($"Teléfono {i + 1}: {estudiante.Telefonos[i]}");
        }
    }
}



