using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
	using System;

	public class Program
	{
		public static void Main()
		{
			// Entrada del usuario de la variable X1
			Console.Write("Ingrese X1: ");
			double x1 = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable Y1
			Console.Write("Ingrese Y1: ");
			double y1 = double.Parse(Console.ReadLine());

			Console.Write("ingrese X2: ");
			double x2 = double.Parse(Console.ReadLine());

			Console.Write("ingrese Y2: ");
			double y2 = double.Parse(Console.ReadLine());

			double m = (y2 - y1) / (x2 - x1);
			Console.WriteLine("La pendiente es: " + m);

			double b = y1 - m * x1;
			Console.WriteLine("El intercepto es: " + b);

			double d = (x2 - x1) + (y2 - y1);
			double s = Math.Sqrt(d);
			Console.WriteLine("La distancia entre el punto 1 y el punto 2 es: " + s);

			// Math.sqrt(a) Encontrar la distancia
			// Entrada del usuario de las variables restantes
			// ...
		}
	}
}