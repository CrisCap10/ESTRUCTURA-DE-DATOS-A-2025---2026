using System;
using System.Collections.Generic;

namespace Practico_3_Conjuntos_Mapas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conjunto para evitar códigos duplicados
            HashSet<string> codigosLibros = new HashSet<string>();

            // Diccionario para almacenar código y título
            Dictionary<string, string> biblioteca = new Dictionary<string, string>();

            int opcion;

            do
            {
                Console.WriteLine("\n--- SISTEMA DE REGISTRO DE LIBROS ---");
                Console.WriteLine("1. Registrar libro");
                Console.WriteLine("2. Consultar libro");
                Console.WriteLine("3. Mostrar todos los libros");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Registro de libro
                        Console.Write("Ingrese código del libro: ");
                        string codigo = Console.ReadLine();

                        // Validamos que no esté repetido usando el HashSet
                        if (codigosLibros.Add(codigo))
                        {
                            Console.Write("Ingrese título del libro: ");
                            string titulo = Console.ReadLine();

                            // Guardamos en el diccionario
                            biblioteca.Add(codigo, titulo);

                            Console.WriteLine("Libro registrado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("El código ya existe. No se permiten duplicados.");
                        }
                        break;

                    case 2:
                        // Consulta por código
                        Console.Write("Ingrese código a consultar: ");
                        string buscar = Console.ReadLine();

                        if (biblioteca.ContainsKey(buscar))
                        {
                            Console.WriteLine("Título: " + biblioteca[buscar]);
                        }
                        else
                        {
                            Console.WriteLine("Libro no encontrado.");
                        }
                        break;

                    case 3:
                        // Mostrar todos los libros
                        foreach (var libro in biblioteca)
                        {
                            Console.WriteLine("Código: " + libro.Key + " - Título: " + libro.Value);
                        }
                        break;
                }

            } while (opcion != 4);
        }
    }
}


