using System;


namespace DatosPrimitivos
{
    // Clase
    internal class Program
    {
        // Metodo
        static void Main(string[] args)
        {
            // int edad;
            // string nombre;
            // double sueldo;
            // bool casado;

            // string nombre = "Candela";
            // edad = 22;
            // sueldo = 1025.45;
            // casado = false;
            // Console.WriteLine("Mi nombre es: " + nombre);
            // Console.WriteLine("Mi edad es: " + edad);
            // Console.WriteLine("Mi sueldo es: " + sueldo);
            // Console.WriteLine("¿Estás casado?: " + casado);

            // Console.Write("¿Cuál es tu nombre?: " );
            // nombre = Console.ReadLine();

            // Console.Write("Ingresa tu edad: ");
            // edad = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Ingresa tu sueldo: ");
            // sueldo = Convert.ToDouble(Console.ReadLine());

            // Console.Write("¿Casado?: ");
            // casado = Convert.ToBoolean(Console.ReadLine());

            // Console.WriteLine("Tu nombre es " + nombre + " y tu edad es " + edad + " años.");
            // Console.WriteLine("Tu sueldo es de " + sueldo + " y la consulta de casado es " + casado);
            // Console.ReadKey();

            // Variables
            string Nombre;
            int Edad;

            // Variables constantes
            const double Sueldo = 2500;

            // Variable dinamica
            // No definimos en si que tipo de variable es
            dynamic Contenido;
            Contenido = "Bienvenido a mi sistema";

            Nombre = "Candela";
            Edad = 22;
            // Sueldo = 2500;

            // Cambio el contenido de la variable sueldo. Aca estamos alterando la variable
            // Sueldo = Sueldo + 100;
            // Para que la variable no pueda ser alterada le agregamos la palabra const cuando la definimo
            Console.WriteLine("Contenido: " + Contenido);
            Console.WriteLine("Mi nombre es " + Nombre + " y mi edad es " + Edad + " y teniendo el sueldo de " + Sueldo);
            Console.ReadKey();

        }
    }
}
