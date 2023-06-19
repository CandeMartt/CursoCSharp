using System;


namespace ConversionTipoDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;
            bool Casado;
            double Sueldo;

            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            // Hace un parse y convierte el tipo de dato
            Edad = int.Parse(Console.ReadLine());
            // Se utiliza el Convert
            // Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Eres casado?: ");
            // Hace un parse y convierte el tipo de dato
            // Casado = bool.Parse(Console.ReadLine());
            // Se utiliza el Convert
            Casado = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Tu sueldo: ");
            // Hace un parse y convierte el tipo de dato
            // Sueldo = double.Parse(Console.ReadLine());
            // Se utiliza el Convert
            Sueldo = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
