using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Caso3
{
    class Program
    {
        static void Main(string[] args)
        {
			// Ejercicio Tercer Caso se conoce Angulo c , z.

			Console.Write("Ingrese c°: ");
			double c = double.Parse(Console.ReadLine());
			Console.Write("Ingrese z: ");
			double z = double.Parse(Console.ReadLine());
			double rad_c = c * Math.PI / 180;
			double t = z / rad_c;
			Console.WriteLine("T es igual a: " + t);
			double y = Math.Sqrt(Math.Pow(t, 2) - Math.Pow(z, 2));
			Console.WriteLine("Y es igual a: " + y);
			double Angulo_a = 180 - 90 - c;
			Console.WriteLine("El angulo de a es: " + Angulo_a);

		}
	}
}
