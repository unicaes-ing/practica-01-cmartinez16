using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            double v1 = 0, v2 = 0, v3 = 0, v4 = 0;
            double promedio;
            Console.WriteLine("Promedio de ventas del año pasado");
            Console.WriteLine("######################################");
            Console.WriteLine("Ingrese el total de ventas correspondientes al primer trimestre");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el total de ventas correspondientes al segundo trimestre");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el total de ventas correspondientes al tercer trimestre");
            v3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el total de ventas correspondientes al cuarto trimestre");
            v4 = Convert.ToDouble(Console.ReadLine());
            promedio = (v1 + v2 + v3 + v4) / 4;
            Console.WriteLine("Ventas primer trimestre: {0}", v1);
            Console.WriteLine("Ventas segundo trimestre: {0}", v2);
            Console.WriteLine("Ventas tercer trimestre: {0}", v3);
            Console.WriteLine("Ventas cuarto trimestre: {0}", v4);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("El promedio de ventas del año pasado es de: {0}", promedio.ToString("C2"));
            Console.ReadKey();
        }
    }  
}
