using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double dis = 0;
            Console.WriteLine("Inserte la distancia recorrida");
            dis = double.Parse(Console.ReadLine());
            double vel = dis / 6;
            Console.WriteLine("La velocidad será de: " + vel);
            if (vel > 100)
            {
                Console.WriteLine("El vehiculo se está desplazando a mayor velocidad");
            }
            else
            {
                Console.WriteLine("El vehiculo se está desplazando a una velocidad moderada");
            }
            Console.ReadLine();
        }
    }
}
