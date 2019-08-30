using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingrese un numero entero positivo");
            numero = Convert.ToInt32(Console.ReadLine());
            Math.Sqrt(numero);
            Console.WriteLine("------------------------------");
            Console.WriteLine("La raiz cuadrada de {0} es : {1}", numero, Math.Sqrt(numero));
            Console.ReadKey();
        }
    }
}
