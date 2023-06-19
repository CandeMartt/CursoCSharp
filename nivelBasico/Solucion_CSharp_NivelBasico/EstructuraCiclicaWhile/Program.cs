using System;

namespace EstructuraCiclicaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Correlativo;
            Correlativo = 0;

            Console.WriteLine("La tabla numero 5");

            while (Correlativo <= 12)
            {
                Console.WriteLine("5 x " + Correlativo + " = " + (5 * Correlativo));
                Correlativo++;
            }

            Console.ReadKey();
        }
    }
}
