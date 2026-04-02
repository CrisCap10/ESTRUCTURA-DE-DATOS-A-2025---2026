using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

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

    // Método principal que construye el grafo desde un archivo
    static void ConstruirGrafo(string nombreArchivo)
    {
        // Usamos un diccionario para representar la lista de adyacencia
        // Decidimos en equipo usar esta estructura por su eficiencia
        Dictionary<string, List<string>> grafo = new Dictionary<string, List<string>>();

        try
        {
            // Construimos la ruta correcta hacia el archivo
            // Esto asegura que funcione aunque el programa esté en bin/Debug
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\", nombreArchivo);

            // Validamos si el archivo existe antes de leerlo
            if (!File.Exists(ruta))
            {
                Console.WriteLine("❌ No se encontró el archivo: " + nombreArchivo);
                return;
            }

            // Leemos todas las líneas del archivo
            string[] lineas = File.ReadAllLines(ruta);

            // Recorremos cada línea del archivo
            foreach (string linea in lineas)
            {
                // Evitamos procesar líneas vacías
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                // Separamos los nodos usando "-"
                string[] partes = linea.Split('-');

                // Validamos que tenga formato correcto (nodo1-nodo2)
                if (partes.Length != 2)
                {
                    Console.WriteLine("⚠ Línea inválida: " + linea);
                    continue;
                }

                // Limpiamos espacios en los nodos
                string origen = partes[0].Trim();
                string destino = partes[1].Trim();

                // Agregamos el nodo origen si no existe
                if (!grafo.ContainsKey(origen))
                    grafo[origen] = new List<string>();

                // Agregamos el nodo destino si no existe
                if (!grafo.ContainsKey(destino))
                    grafo[destino] = new List<string>();

                // Como decidimos trabajar con grafo NO dirigido,
                // agregamos la conexión en ambos sentidos
                grafo[origen].Add(destino);
                grafo[destino].Add(origen);
            }

            // Mostramos el grafo en consola
            MostrarGrafo(grafo);

            // Mostramos el total de nodos
            Console.WriteLine("Total de nodos: " + grafo.Count);

            // Generamos la representación gráfica con Graphviz
            GenerarGrafico(grafo, nombreArchivo.Replace(".txt", ""));
        }
        catch (Exception ex)
        {
            // Capturamos errores generales del sistema
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    // Método para mostrar el grafo en consola
    static void MostrarGrafo(Dictionary<string, List<string>> grafo)
    {
        // Recorremos cada nodo del diccionario
        foreach (var nodo in grafo)
        {
            // Mostramos el nodo y sus conexiones
            Console.Write(nodo.Key + " -> ");
            Console.WriteLine(string.Join(", ", nodo.Value));
        }
    }

    // Método para generar el grafo visual usando Graphviz
    static void GenerarGrafico(Dictionary<string, List<string>> grafo, string nombreArchivo)
    {
        // Creamos el contenido del archivo .dot
        List<string> dot = new List<string>();

        // Indicamos que es un grafo no dirigido
        dot.Add("graph G {");

        // Usamos HashSet para evitar duplicar conexiones
        HashSet<string> conexiones = new HashSet<string>();

        foreach (var nodo in grafo)
        {
            foreach (var vecino in nodo.Value)
            {
                string conexion = nodo.Key + "-" + vecino;
                string inversa = vecino + "-" + nodo.Key;

                // Evitamos duplicar conexiones (porque es no dirigido)
                if (!conexiones.Contains(conexion) && !conexiones.Contains(inversa))
                {
                    dot.Add($"    \"{nodo.Key}\" -- \"{vecino}\";");
                    conexiones.Add(conexion);
                }
            }
        }

        dot.Add("}");

        // Guardamos el archivo .dot
        string archivoDot = nombreArchivo + ".dot";
        File.WriteAllLines(archivoDot, dot);

        // Ejecutamos Graphviz para generar imagen PNG
        string comando = $"dot -Tpng {archivoDot} -o {nombreArchivo}.png";

        Process.Start(new ProcessStartInfo
        {
            FileName = "cmd",
            Arguments = "/c " + comando,
            CreateNoWindow = true,
            UseShellExecute = false
        });

        Console.WriteLine("✔ Imagen generada: " + nombreArchivo + ".png");
    }
}
