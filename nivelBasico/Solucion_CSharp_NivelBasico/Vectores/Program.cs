using System;

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = { "Candela", "Carlos", "Ana", "Luis", "Jorge" };

            for (int x=0; x<Nombres.Length; x++)
            {
                Console.WriteLine("Contenido del Vector Nombres en el indice " + x + " es: " + Nombres[x]);
            }

            // Console.WriteLine("La cantidad de elementos que tiene tu vector es: " + Nombres.Length);
            // Console.WriteLine("El nombre del vector en el indice 3 es: " + Nombres[3]);
            Console.ReadKey();
        }
    }
}
