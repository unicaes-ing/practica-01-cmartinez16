using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            string empleado;
            double Iss = 0.03, renta = 0.10, AFP = 0.06;
            double sueldo = 0, Nsueldo = 0;
            Console.WriteLine("Sueldos de los empleados");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Ingrese el nombre del empleado");
            empleado = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado");
            sueldo = Convert.ToDouble(Console.ReadLine());
            Iss = sueldo * Iss;
            renta = sueldo * renta;
            AFP = sueldo * AFP;
            Nsueldo = sueldo - Iss - renta - AFP;
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Nombre del empleado: {0}", empleado);
            Console.WriteLine("El descuento del ISSS es de: {0}", Iss.ToString("C2"));
            Console.WriteLine("El descuento de la renta es de: {0}", renta.ToString("C2"));
            Console.WriteLine("El descuento de AFP es de: {0}", AFP.ToString("C2"));
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("El nuevo sueldo a pagar es de: {0}", Nsueldo.ToString("C2"));
            Console.ReadKey();
        }
    }
}
