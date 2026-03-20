// Clase Circulo que encapsula el radio y proporciona métodos para calcular área y perímetro
public class Circulo
{
    // Propiedad privada que almacena el radio del círculo
    private double radio;

    // Propiedad pública con encapsulamiento para leer y modificar el radio
    // Se asegura que el valor siempre sea positivo
    public double Radio
    {
        get { return radio; }
        set 
        { 
            if (value > 0)
                radio = value;
            else
                throw new ArgumentException("El radio debe ser un número positivo.");
        }
    }

    // Constructor que inicializa el radio del círculo
    public Circulo(double radio)
    {
        Radio = radio;
    }

    // CalcularArea es una función que devuelve un valor double.
    // Se utiliza para calcular el área de un círculo. Requiere como argumento el radio del círculo.
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve el perímetro (circunferencia) del círculo.
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}




