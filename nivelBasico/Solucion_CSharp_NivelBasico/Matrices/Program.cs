using System;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Persona = new string[3, 2];
            Persona[0, 0] = "Candela";
            Persona[0, 1] = "Martinez";

            Persona[1, 0] = "Carlos";
            Persona[1, 1] = "Ramirez";
            
            Persona[2, 0] = "Ana";
            Persona[2, 1] = "Arias";

            for (int a = 0; a< 3; a++)
            {
                Console.WriteLine("Persona [" + a + "] = " + Persona[a, 0] + " "+ Persona[a,1]);
            }

            // Console.WriteLine("El valor de la matriz persona en [0,0] = " + Persona[0,0]);
            Console.ReadKey();
        }
    }
}
