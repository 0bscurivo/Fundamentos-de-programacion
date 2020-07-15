using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Calculadora de ecuaciones cuadraticas ");
            Console.Write("Ingrese a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());
            //Discriminante
            double dis = Math.Pow(b, 2) - 4 * a * c;
            Console.Write("dis: " + dis);
            //Posibles soluciones 
            double x1 = (-b + (Math.Sqrt(dis))) / (2 * a);
            double x2 = (-b - (Math.Sqrt(dis))) / (2 * a);


            if (dis == 0)
            {
                Console.WriteLine(" La solucion exite y es unica ");
                Console.Write(" La solucion uno es: " + x1);
                Console.Write(" La solucion dos es: " + x2);
            }
            else if (dis > 0)
            {
                Console.WriteLine("Existen dos posibles soluciones");
                Console.Write("La solucion uno es: " + x1);
                Console.Write("La solucion dos es: " + x2);
            }
            else if (dis < 0)
            {
                Console.WriteLine(" No es posible calcular la solucion!! ");
            }
        }
    }
}
