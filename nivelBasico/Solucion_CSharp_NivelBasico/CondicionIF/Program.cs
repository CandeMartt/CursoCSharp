using System;


namespace CondicionIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            double Sueldo;

            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese su sueldo: ");
            Sueldo = Convert.ToDouble(Console.ReadLine());

            // El sueldo minimo en Perú es 1024 soles
            // Si el sueldo es mayor a 1024 y menor e igaul a 2000 tu sueldo es rentable
            // Si el sueldo que se ingresa es mayor a 2000 soles, tu sieldo es generoso

            if (Sueldo <= 1024)
            {
                Console.WriteLine(Nombre + ", el sueldo que tu tienes es igual o menor al Minimo Vital en Perú.");
            }
            else if ((Sueldo > 1024) && (Sueldo <= 2000))
            {
                Console.WriteLine(Nombre + ", tu sueldo es rentable.");
            }
            else
            {          
                Console.WriteLine(Nombre + ", el sueldo generoso.");
            }

            Console.ReadLine();
        }
    }
}
