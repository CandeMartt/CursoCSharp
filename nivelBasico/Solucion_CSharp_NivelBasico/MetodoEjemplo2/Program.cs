using System;


namespace MetodoEjemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string OperacionMatematica;
            int NOperacion;

            Console.Write("¿Quieres realizar la tabla de Sumar o Multiplicar: ");
            OperacionMatematica = Console.ReadLine();

            Console.Write("¿Qué numero de tabla desea que se muestre?: ");
            NOperacion = Convert.ToInt32(Console.ReadLine());

            if (OperacionMatematica == "Sumar")
            {
                Sumar(NOperacion);
            }
            else if (OperacionMatematica == "Multiplicar")
            {
                Multiplicar(NOperacion);    
            }
            else
            {
                Console.WriteLine("Operacion matemática no valida");
            }

            Console.ReadKey();
        }

        // Metodo de la tabla de Sumar
        static void Sumar(int Numero)
        {
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(Numero + " + " + a + " = " + ( Numero + a));
            }
        }

        // Metodo de la tabla de Multiplicar
        static void Multiplicar(int Numero)
        {
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(Numero + " x " + a + " = " + (Numero * a));
            }
        }
        
    }
}
