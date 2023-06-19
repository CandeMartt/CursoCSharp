using System;

namespace MetodoEjemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            double PagoxDia;
            int Dias;
            

            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("¿Cuánto te pagan por día trabajado?: ");
            PagoxDia = Convert.ToDouble(Console.ReadLine());

            Console.Write("¿Cuántos dias trabajó?: ");
            Dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El dinero obtenido por los dias trabajados es: " + CalcularTotal(PagoxDia, Dias));

            Console.ReadKey();
        }


        // Metodo para obtener el total de dinero ganado por trabajo
        static double CalcularTotal(double P1, int P2)
        {
            double Total;
            Total = (P1 * P2);
            return Total;
        }

    }
}
