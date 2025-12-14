using System;

// Clase Estudiante
// Esta clase representa a un estudiante y almacena sus datos personales
// Incluye un arreglo (array) para guardar tres números de teléfono
public class Estudiante
{
    // Identificación del estudiante
    public string Id { get; set; }

    // Nombres del estudiante
    public string Nombres { get; set; }

    // Apellidos del estudiante
    public string Apellidos { get; set; }

    // Dirección de domicilio del estudiante
    public string Direccion { get; set; }

    // Arreglo de tipo string para almacenar tres números de teléfono
    public string[] Telefonos { get; set; }

    // Constructor de la clase
    // Inicializa el arreglo de teléfonos con tamaño 3
    public Estudiante()
    {
        Telefonos = new string[3];
    }
}

