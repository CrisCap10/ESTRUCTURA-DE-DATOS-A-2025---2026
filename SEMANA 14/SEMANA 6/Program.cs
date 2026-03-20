using System;

// Nodo de la lista enlazada
class Nodo
{
    public double Dato;
    public Nodo Siguiente;

    public Nodo(double dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

// Lista enlazada
class ListaEnlazada
{
    private Nodo cabeza;

    public void Agregar(double dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
                actual = actual.Siguiente;

            actual.Siguiente = nuevo;
        }
    }

    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    public double Promedio()
    {
        double suma = 0;
        int contador = 0;
        Nodo actual = cabeza;

        while (actual != null)
        {
            suma += actual.Dato;
            contador++;
            actual = actual.Siguiente;
        }

        return suma / contador;
    }

    public Nodo ObtenerCabeza()
    {
        return cabeza;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("SEMANA 6 - LISTAS ENLAZADAS");
        Console.WriteLine("1. Ejercicio 8");
        Console.WriteLine("2. Ejercicio 9");
        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
            Ejercicio8();
        else
            Ejercicio9();
    }

    // 🔹 EJERCICIO 8
    static void Ejercicio8()
    {
        ListaEnlazada principal = new ListaEnlazada();
        ListaEnlazada menores = new ListaEnlazada();
        ListaEnlazada mayores = new ListaEnlazada();

        Console.Write("Ingrese la cantidad de datos: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Dato {i + 1}: ");
            double dato = double.Parse(Console.ReadLine());
            principal.Agregar(dato);
        }

        double promedio = principal.Promedio();
        Nodo actual = principal.ObtenerCabeza();

        while (actual != null)
        {
            if (actual.Dato <= promedio)
                menores.Agregar(actual.Dato);
            else
                mayores.Agregar(actual.Dato);

            actual = actual.Siguiente;
        }

        Console.WriteLine("\nLista principal:");
        principal.Mostrar();

        Console.WriteLine("Promedio: " + promedio);

        Console.WriteLine("Menores o iguales al promedio:");
        menores.Mostrar();

        Console.WriteLine("Mayores al promedio:");
        mayores.Mostrar();
    }

    // 🔹 EJERCICIO 9
    static void Ejercicio9()
    {
        ListaEnlazada lista1 = new ListaEnlazada();
        ListaEnlazada lista2 = new ListaEnlazada();

        Console.Write("Cantidad de datos para ambas listas: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese datos de la Lista 1:");
        for (int i = 0; i < n; i++)
            lista1.Agregar(int.Parse(Console.ReadLine()));

        Console.WriteLine("Ingrese datos de la Lista 2:");
        for (int i = 0; i < n; i++)
            lista2.Agregar(int.Parse(Console.ReadLine()));

        Nodo a = lista1.ObtenerCabeza();
        Nodo b = lista2.ObtenerCabeza();

        bool iguales = true;

        while (a != null && b != null)
        {
            if (a.Dato != b.Dato)
            {
                iguales = false;
                break;
            }
            a = a.Siguiente;
            b = b.Siguiente;
        }

        if (iguales)
            Console.WriteLine("Las listas son iguales en tamaño y contenido.");
        else
            Console.WriteLine("Las listas tienen el mismo tamaño pero distinto contenido.");
    }
}


