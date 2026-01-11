using System;
using System.Collections.Generic;
using System.Linq;

namespace SEMANA_5 // Debe coincidir exactamente con el csproj
{
    public class LogicaEjercicios
    {
        // Ejercicio 1: Lista de asignaturas
        public void Ejercicio1()
        {
            List<string> materias = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
            Console.WriteLine("Asignaturas:");
            materias.ForEach(m => Console.WriteLine($"- {m}"));
        }

        // Ejercicio 2: Mensaje personalizado
        public void Ejercicio2()
        {
            List<string> materias = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
            foreach (string m in materias) Console.WriteLine($"Yo estudio {m}");
        }

        // Ejercicio 3: Notas de asignaturas
        public void Ejercicio3()
        {
            string[] materias = { "Matemáticas", "Física", "Química" };
            List<string> notas = new List<string>();
            foreach (var m in materias) {
                Console.Write($"¿Qué nota sacaste en {m}?: ");
                notas.Add(Console.ReadLine());
            }
            for (int i = 0; i < materias.Length; i++) 
                Console.WriteLine($"En {materias[i]} has sacado {notas[i]}");
        }

        // Ejercicio 4: Lotería ordenada
        public void Ejercicio4()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Introduce 6 números ganadores:");
            for (int i = 0; i < 6; i++) {
                Console.Write($"N{i+1}: ");
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            numeros.Sort();
            Console.WriteLine("Ordenados: " + string.Join(", ", numeros));
        }

        // Ejercicio 5: Números en orden inverso
        public void Ejercicio5()
        {
            List<int> lista = Enumerable.Range(1, 10).ToList();
            lista.Reverse();
            Console.WriteLine("Orden inverso: " + string.Join(", ", lista));
        }
    }
}
