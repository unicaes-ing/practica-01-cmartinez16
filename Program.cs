using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            string nombre, especie;
            int edad;
            System.Console.Write("Ingrese el nombre de su mascota: ");
            nombre = Console.ReadLine();
            System.Console.Write("Ingrese la especie a la que pertenece su mascota: ");
            especie = Console.ReadLine();
            System.Console.Write("Ingrese la edad de su mascota: ");
            edad = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("El nombre de su mascota es {0} , pertenece a la especia de {1} y tiene {2} años", nombre, especie, edad);
            System.Console.ReadKey();
        }
    }
}
