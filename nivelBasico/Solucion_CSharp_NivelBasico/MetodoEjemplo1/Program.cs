using System;


namespace MetodoEjemplo1
{
    internal class Program
    {
        // Metodo Main
        static void Main(string[] args)
        {
            // Llamamos los metodos
            IngresoDatos();
            Console.ReadKey();
        }

        // Metodo ejemplo 1
        static void IngresoDatos()
        {
            string Nombre;
            Console.Write("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es: " + Nombre);
        }
    }
}
