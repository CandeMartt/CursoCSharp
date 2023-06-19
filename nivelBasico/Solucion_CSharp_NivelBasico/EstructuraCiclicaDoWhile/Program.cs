using System;


namespace EstructuraCiclicaDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Numero = 0;

            do
            {
                Console.WriteLine("El valor de la variable Numero es: " + Numero);
                // Para que incremente
                // Numero = Numero + 1;
                Numero++;
            } while (Numero <= 10);

            Console.ReadKey();
        }
    }
}
