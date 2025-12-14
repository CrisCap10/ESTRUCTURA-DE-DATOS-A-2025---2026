using System;
using RegistroEstudiante;

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();

        Console.Write("ID: ");
        estudiante.Id = int.Parse(Console.ReadLine());

        Console.Write("Nombres: ");
        estudiante.Nombres = Console.ReadLine();

        Console.Write("Apellidos: ");
        estudiante.Apellidos = Console.ReadLine();

        Console.Write("Dirección: ");
        estudiante.Direccion = Console.ReadLine();

        for (int i = 0; i < estudiante.Telefonos.Length; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            estudiante.Telefonos[i] = Console.ReadLine();
        }

        estudiante.MostrarDatos();
        Console.ReadKey();
    }
}





