using System;

namespace UD4E16
{
    class Program
    {
        static void Main(string[] args)
        {
            double IVA = 0.21;

            String texto = "Introduce el precio de un producto";

            double precio = Convert.ToDouble(texto);

            double precioFinal = precio + (precio * IVA);

            Console.WriteLine(precioFinal);
        }
    }
}
