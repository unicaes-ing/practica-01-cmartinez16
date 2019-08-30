using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            decimal num1, num2;
            decimal suma, resta, div, mult;
            Console.WriteLine("Ingrese el primer numero decimal");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero decimal");
            num2 = Convert.ToDecimal(Console.ReadLine());
            suma = num1 + num2;
            resta = num1 - num2;
            div = num1 / num2;
            mult = num1 * num2;
            Console.WriteLine("La suma de {0} + {1} es igual a {2}", num1, num2, suma);
            Console.WriteLine("La resta de {0} - {1} es igual a {2}", num1, num2, resta);
            Console.WriteLine("La divison de {0} / {1} es igual a {2}", num1, num2, div);
            Console.WriteLine("La multiplicacion de {0} * {1} es igual a {2}", num1, num2, mult);
            Console.ReadKey();
        }
    }
}
