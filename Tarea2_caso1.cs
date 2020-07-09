using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_Triangulos_01
{
    class Program
    {
		public static void Main()
		{

			// Ejercicio Primer caso se conoce y, z.
			Console.Write("Ingrese y: ");
			double y = double.Parse(Console.ReadLine());
			Console.Write("Ingrese z: ");
			double z = double.Parse(Console.ReadLine());
			double hipotenusa = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));
			Console.WriteLine("hipotenusa es: " + hipotenusa);
			double arcsen_c = Math.Asin(z / hipotenusa);
			double Angulo_c = arcsen_c * (180.0 / Math.PI);
			Console.WriteLine("c en radianes: " + arcsen_c);
			Console.WriteLine("Angulo de c: " + Angulo_c);
			double Angulo_a = 180 - 90 - Angulo_c;
			Console.WriteLine("Angulo de a: " + Angulo_a);

			

		}

	}
}
