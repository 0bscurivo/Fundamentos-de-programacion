using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01_04_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el angulo b y los lados z, y");
            double c = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
          

            //Lados del triangulo pequeno
            double z = t * Math.Sin(c);
            double y = t * Math.Cos(c);

            //Angulo d
            double d = Math.Asin(z / w); //no paso a radianes porque son dos lados 

            //Lado x
            double x = ((Math.Cos(d) * w) - y);

            Console.WriteLine("El valor del lado x es:" + x);




        }
    }
}
