using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2Cuadratica
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
            double dis = Math.Pow(b, 2) -4*a*c;
            Console.Write(" El Discriminante es: " + dis);


            // me toco divinir en pedazos para que funcionara 
            double raiz = Math.Sqrt(dis);
            //Console.WriteLine("raiz: " + raiz);
            double num1 = -(b) + raiz;
            //Console.WriteLine("numerador1: " + num1);
            double num2 = -(b) - raiz;
            //Console.WriteLine("numerador2: " + num2);
            double deno = 2*a;
            //Console.WriteLine("denominador: " + deno);

            //Posibles soluciones 
            double x1 = num1 / deno;
            double x2 = num2 / deno;     
            
            if (dis == 0)
            {
                Console.WriteLine(" La solucion exite y es unica " );
                Console.Write(" La solucion uno es: " + x1   );
                Console.Write(" La solucion dos es: " + x2   );
            }
            else if (dis > 0)
            {
                Console.WriteLine("Existen dos posibles soluciones" );
                Console.Write("La solucion uno es: " + x1     );
                Console.Write("La solucion dos es: " + x2     );
            }
            else if (dis < 0)
            {
                Console.WriteLine(" No es posible calcular la solucion!! " );
            }
        }
    }
}
