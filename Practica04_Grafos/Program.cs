using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Como equipo iniciamos mostrando los dos grafos desde archivos
        Console.WriteLine("===== GRAFO 1: CIUDADES =====");
        ConstruirGrafo("grafo1.txt");

        Console.WriteLine("\n");

        Console.WriteLine("===== GRAFO 2: ESTUDIANTES =====");
        ConstruirGrafo("grafo2.txt");
    }

    // Método principal que construye el grafo
    static void ConstruirGrafo(string nombreArchivo)
    {
        // Usamos diccionario como lista de adyacencia
        Dictionary<string, List<string>> grafo = new Dictionary<string, List<string>>();

        try
        {
            // Ruta profesional: apunta siempre a la carpeta del proyecto
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", nombreArchivo);

            // Mostramos la ruta para verificar (esto ayuda en depuración)
            //Console.WriteLine("Leyendo archivo desde: " + ruta);

            // Validamos existencia del archivo
            if (!File.Exists(ruta))
            {
                Console.WriteLine("❌ No se encontró el archivo: " + nombreArchivo);
                return;
            }

            // Leemos todas las líneas
            string[] lineas = File.ReadAllLines(ruta);

            // Recorremos cada línea
            foreach (string linea in lineas)
            {
                // Evitamos líneas vacías
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                // Dividimos la línea (Ej: Quito-Guayaquil)
                string[] partes = linea.Split('-');

                // Validamos formato correcto
                if (partes.Length != 2)
                {
                    Console.WriteLine("⚠ Línea inválida: " + linea);
                    continue;
                }

                string origen = partes[0].Trim();
                string destino = partes[1].Trim();

                // Agregamos nodos si no existen
                if (!grafo.ContainsKey(origen))
                    grafo[origen] = new List<string>();

                if (!grafo.ContainsKey(destino))
                    grafo[destino] = new List<string>();

                // Grafo no dirigido (decisión del equipo)
                grafo[origen].Add(destino);
                grafo[destino].Add(origen);
            }

            // Mostramos resultados
            MostrarGrafo(grafo);

            // Reporte adicional
            Console.WriteLine("Total de nodos: " + grafo.Count);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    // Método para imprimir el grafo
    static void MostrarGrafo(Dictionary<string, List<string>> grafo)
    {
        // Recorremos cada nodo
        foreach (var nodo in grafo)
        {
            Console.Write(nodo.Key + " -> ");
            Console.WriteLine(string.Join(", ", nodo.Value));
        }
    }
}
