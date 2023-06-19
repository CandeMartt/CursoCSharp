using System;


namespace EstructuraSelectiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Dia;
            
            Console.Write("Ingrese el dia en numero: ");
            Dia = Convert.ToInt32(Console.ReadLine());

            switch(Dia)
            {
                case 1:
                    Console.WriteLine("ES LUNES");
                    break;
                case 2:
                    Console.WriteLine("ES MARTES");
                    break;
                case 3:
                    Console.WriteLine("ES MIERCOLES");
                    break;
                case 4:
                    Console.WriteLine("ES JUEVES");
                    break;
                case 5:
                    Console.WriteLine("ES VIERNES");
                    break;
                case 6:
                    Console.WriteLine("ES SABADO");
                    break;
                case 7:
                    Console.WriteLine("ES DOMINGO");
                    break;

                default:
                    Console.WriteLine("El número de día ingresado no es válido.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
