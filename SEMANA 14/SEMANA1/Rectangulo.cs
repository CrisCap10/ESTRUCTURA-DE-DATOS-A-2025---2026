
// Clase Rectangulo que encapsula su ancho y alto; incluye métodos para calcular área y perímetro
public class Rectangulo
{
    // Campos privados
    private double ancho;
    private double alto;

    // Propiedad Ancho con validación
    public double Ancho
    {
        get { return ancho; }
        set
        {
            if (value > 0)
                ancho = value;
            else
                throw new ArgumentException("El ancho debe ser un número positivo.");
        }
    }

    // Propiedad Alto con validación
    public double Alto
    {
        get { return alto; }
        set
        {
            if (value > 0)
                alto = value;
            else
                throw new ArgumentException("El alto debe ser un número positivo.");
        }
    }

    // Constructor que inicializa alto y ancho
    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    // CalcularArea devuelve el área del rectángulo.
    public double CalcularArea()
    {
        return ancho * alto;
    }

    // CalcularPerimetro devuelve el perímetro del rectángulo.
    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto);
    }
}




