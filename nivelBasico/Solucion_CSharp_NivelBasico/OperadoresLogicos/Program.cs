using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            bool Resualtado;

            a = 10;
            b = 2;
            c = 0;
            d = 250;
            Resualtado = !(a == b);

            Console.WriteLine("¿Cual es el resultado de !(a == b)? " + Resualtado);
            Console.ReadKey();
        }
    }
}
