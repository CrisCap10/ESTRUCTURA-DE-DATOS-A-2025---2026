using System;

namespace AgendaTelefonica
{
    // Clase que representa un contacto de la agenda
    public class Contacto
    {
        // Propiedades del contacto
        // Se inicializan para evitar valores null
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}



