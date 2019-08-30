using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            string nombre, cargo,correo;
            int edad;
            decimal sueldo;
            DateTime fecha;
            Console.WriteLine("Datos de los empleados");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el cargo que ejerce el empleado");
            cargo = Console.ReadLine();
            Console.WriteLine("Ingrese el correo del empleado");
            correo = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del empleado");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo del empleado");
            sueldo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de contratacion del empleado");
            fecha = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Los datos ingresados fueron los siguientes: ");
            Console.WriteLine("Nombre del empleado: {0}", nombre);
            Console.WriteLine("Cargo que ejerce: {0}", cargo);
            Console.WriteLine("Correo electronico: {0}", correo);
            Console.WriteLine("Edad: {0}", edad);
            Console.WriteLine("Sueldo: ${0}", sueldo);
            Console.WriteLine("Fecha de contratacion: {0} " ,fecha.ToString("dd:MM:yyyy"));
            Console.ReadKey();



        }
            
    }
}

