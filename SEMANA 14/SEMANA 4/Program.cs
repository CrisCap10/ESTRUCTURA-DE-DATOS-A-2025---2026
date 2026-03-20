using System;
using AgendaTelefonica;

namespace AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arreglo (estructura de datos estática)
            Contacto[] agenda = new Contacto[50];
            int cantidad = 0;
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("   AGENDA TELEFÓNICA - SEMANA 4");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Ver contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.WriteLine("=================================");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        if (cantidad < agenda.Length)
                        {
                            Contacto nuevo = new Contacto();

                            Console.Write("Nombre: ");
                            nuevo.Nombre = Console.ReadLine();

                            Console.Write("Teléfono: ");
                            nuevo.Telefono = Console.ReadLine();

                            Console.Write("Email: ");
                            nuevo.Email = Console.ReadLine();

                            agenda[cantidad] = nuevo;
                            cantidad++;

                            Console.WriteLine("\nContacto agregado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("La agenda está llena.");
                        }
                        break;

                    case "2":
                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay contactos registrados.");
                        }
                        else
                        {
                            Console.WriteLine("---- LISTA DE CONTACTOS ----");
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine($"ID: {i + 1}");
                                Console.WriteLine($"Nombre: {agenda[i].Nombre}");
                                Console.WriteLine($"Teléfono: {agenda[i].Telefono}");
                                Console.WriteLine($"Email: {agenda[i].Email}");
                                Console.WriteLine("----------------------------");
                            }
                        }
                        break;

                    case "3":
                        Console.Write("Ingrese el nombre a buscar: ");
                        string buscar = Console.ReadLine().ToLower();
                        bool encontrado = false;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (agenda[i].Nombre.ToLower().Contains(buscar))
                            {
                                Console.WriteLine("\nContacto encontrado:");
                                Console.WriteLine($"Nombre: {agenda[i].Nombre}");
                                Console.WriteLine($"Teléfono: {agenda[i].Telefono}");
                                Console.WriteLine($"Email: {agenda[i].Email}");
                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No se encontró el contacto.");
                        }
                        break;

                    case "4":
                        continuar = false;
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione ENTER para continuar...");
                    Console.ReadLine();
                }
            }
        }
    }
}



