using System;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Edad;

            try
            {
                Console.Write("Ingrese su edad: ");
                Edad = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            Console.ReadKey();
        }
    }
}
