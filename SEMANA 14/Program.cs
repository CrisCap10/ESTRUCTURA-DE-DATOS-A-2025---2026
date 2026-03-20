using System;

class Program
{
    static void Main()
    {
        ArbolBST arbol = new ArbolBST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n--- MENU BST ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Inorden");
            Console.WriteLine("5. Preorden");
            Console.WriteLine("6. Postorden");
            Console.WriteLine("7. Minimo");
            Console.WriteLine("8. Maximo");
            Console.WriteLine("9. Altura");
            Console.WriteLine("10. Limpiar");
            Console.WriteLine("0. Salir");

            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Raiz = arbol.Insertar(arbol.Raiz, valor);
                    break;

                case 2:
                    Console.Write("Buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(arbol.Raiz, valor) ? "SI EXISTE" : "NO EXISTE");
                    break;

                case 3:
                    Console.Write("Eliminar: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Raiz = arbol.Eliminar(arbol.Raiz, valor);
                    break;

                case 4:
                    arbol.InOrden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 5:
                    arbol.PreOrden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 6:
                    arbol.PostOrden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 7:
                    if (arbol.Raiz != null)
                        Console.WriteLine("Minimo: " + arbol.Minimo(arbol.Raiz).Valor);
                    break;

                case 8:
                    if (arbol.Raiz != null)
                        Console.WriteLine("Maximo: " + arbol.Maximo(arbol.Raiz).Valor);
                    break;

                case 9:
                    Console.WriteLine("Altura: " + arbol.Altura(arbol.Raiz));
                    break;

                case 10:
                    arbol.Limpiar();
                    Console.WriteLine("Arbol limpio");
                    break;
            }

        } while (opcion != 0);
    }
}



