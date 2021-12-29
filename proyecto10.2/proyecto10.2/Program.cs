using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int posicion;
                int sumatoria = 0;
                double promedio = 0;

                for (int i = 0; i < 10; i++)
                {
                    posicion = i + 1;
                    Console.Write("Introduzca el valor #" + posicion + ": ");
                    sumatoria = sumatoria + int.Parse(Console.ReadLine());
                }

                promedio = sumatoria / 10;
                Console.WriteLine("La sumatoria de los numeros es "+sumatoria+" y su promedio es "+promedio);
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
    }
}
