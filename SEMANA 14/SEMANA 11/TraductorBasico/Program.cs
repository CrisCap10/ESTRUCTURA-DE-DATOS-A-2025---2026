using System;
using System.Collections.Generic;
using System.Linq;

namespace TraductorBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diccionario Inglés -> Español
            Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                {"time", "tiempo"},
                {"person", "persona"},
                {"year", "año"},
                {"way", "camino"},
                {"day", "día"},
                {"thing", "cosa"},
                {"man", "hombre"},
                {"world", "mundo"},
                {"life", "vida"},
                {"hand", "mano"},
                {"part", "parte"},
                {"child", "niño"},
                {"eye", "ojo"},
                {"woman", "mujer"},
                {"place", "lugar"},
                {"work", "trabajo"},
                {"week", "semana"},
                {"case", "caso"},
                {"point", "punto"},
                {"government", "gobierno"},
                {"company", "empresa"}
            };

            int opcion;

            do
            {
                Console.WriteLine("\n==================== MENÚ ====================");
                Console.WriteLine("1. Traducir una frase");
                Console.WriteLine("2. Agregar palabras al diccionario");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        TraducirFrase(diccionario);
                        break;

                    case 2:
                        AgregarPalabra(diccionario);
                        break;

                    case 0:
                        Console.WriteLine("👋 Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("❌ Opción inválida");
                        break;
                }

            } while (opcion != 0);
        }

        static void TraducirFrase(Dictionary<string, string> diccionario)
        {
            Console.Write("\nIngrese la frase: ");
            string frase = Console.ReadLine();

            string[] palabras = frase.Split(' ');

            List<string> resultado = new List<string>();

            foreach (var palabra in palabras)
            {
                // Limpia signos de puntuación
                string limpia = palabra.Trim(',', '.', ';', ':', '¡', '!', '¿', '?');

                // Busca traducción
                var traduccion = diccionario
                    .FirstOrDefault(x => x.Value.Equals(limpia, StringComparison.OrdinalIgnoreCase));

                if (!string.IsNullOrEmpty(traduccion.Key))
                    resultado.Add(traduccion.Key);
                else
                    resultado.Add(palabra);
            }

            Console.WriteLine("\nTraducción parcial:");
            Console.WriteLine(string.Join(" ", resultado));
        }

        static void AgregarPalabra(Dictionary<string, string> diccionario)
        {
            Console.Write("\nIngrese palabra en inglés: ");
            string ingles = Console.ReadLine().ToLower();

            Console.Write("Ingrese traducción en español: ");
            string espanol = Console.ReadLine().ToLower();

            if (!diccionario.ContainsKey(ingles))
            {
                diccionario.Add(ingles, espanol);
                Console.WriteLine("✅ Palabra agregada correctamente");
            }
            else
            {
                Console.WriteLine("⚠️ La palabra ya existe en el diccionario");
            }
        }
    }
}
