using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Caso2
{
    class Program
    {
        static void Main(string[] args)
        {
			//Ejercicio Segundo caso se conoce Angulo t, a.

			Console.Write("Ingrese t: ");
			double t = double.Parse(Console.ReadLine());
			Console.Write("Ingrese a°: ");
			double a = double.Parse(Console.ReadLine());
			double rad_a = a * Math.PI / 180;
			double y = t * rad_a;
			Console.WriteLine("Y es igual a: " + y);
			double z = Math.Sqrt(Math.Pow(t, 2) - Math.Pow(y, 2));
			Console.WriteLine("Z es igual a: " + z);
			double Angulo_c = 180 - 90 - a;
			Console.WriteLine("El angulo de a es: " + Angulo_c);


		}
	}
}
