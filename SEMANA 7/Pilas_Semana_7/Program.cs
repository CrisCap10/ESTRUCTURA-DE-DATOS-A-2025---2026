using System;
using System.Collections.Generic;

namespace Pilas_Semana_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SEMANA 7 - PILAS");
            Console.WriteLine("1. Verificación de paréntesis balanceados");
            Console.WriteLine("2. Torres de Hanoi");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("\nVERIFICACIÓN DE PARÉNTESIS BALANCEADOS\n");

                string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
                Console.WriteLine("Expresión: " + expresion);

                if (ParentesisBalanceados(expresion))
                    Console.WriteLine("Resultado: Fórmula balanceada ✅");
                else
                    Console.WriteLine("Resultado: Fórmula NO balanceada ❌");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("\nTORRES DE HANOI\n");

                int discos = 3;

                Stack<int> origen = new Stack<int>();
                Stack<int> auxiliar = new Stack<int>();
                Stack<int> destino = new Stack<int>();

                for (int i = discos; i >= 1; i--)
                    origen.Push(i);

                TorresHanoi(discos, origen, auxiliar, destino, "Origen", "Auxiliar", "Destino");
            }
            else
            {
                Console.WriteLine("Opción inválida");
            }

            Console.ReadKey();
        }

        static bool ParentesisBalanceados(string expresion)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char c in expresion)
            {
                if (c == '(' || c == '{' || c == '[')
                    pila.Push(c);
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Count == 0)
                        return false;

                    char tope = pila.Pop();
                    if (!Coinciden(tope, c))
                        return false;
                }
            }
            return pila.Count == 0;
        }

        static bool Coinciden(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') ||
                   (apertura == '{' && cierre == '}') ||
                   (apertura == '[' && cierre == ']');
        }

        static void TorresHanoi(int n, Stack<int> origen, Stack<int> auxiliar, Stack<int> destino,
                                string nombreOrigen, string nombreAuxiliar, string nombreDestino)
        {
            if (n == 1)
            {
                int disco = origen.Pop();
                destino.Push(disco);
                Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
                return;
            }

            TorresHanoi(n - 1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);

            int discoActual = origen.Pop();
            destino.Push(discoActual);
            Console.WriteLine($"Mover disco {discoActual} de {nombreOrigen} a {nombreDestino}");

            TorresHanoi(n - 1, auxiliar, origen, destino, nombreAuxiliar, nombreOrigen, nombreDestino);
        }
    }
}

