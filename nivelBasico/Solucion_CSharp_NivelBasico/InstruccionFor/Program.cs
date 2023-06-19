using System;

namespace InstruccionFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NEntero;
            NEntero = 0;

            Console.Write("Ingrese un numero para definir la tabla de multiplicar: ");
            NEntero = Convert.ToInt32(Console.ReadLine());

            for (int a = 0; a <= 12; a++)
            {
                Console.WriteLine(NEntero + " x " + a + " = "+ (NEntero * a));
            }

            Console.ReadKey();
        }
    }
}
