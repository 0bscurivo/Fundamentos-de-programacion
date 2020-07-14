using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01_04
{
    class Program
    {
        static void Main()
        {
            // Entradas para encontrar el valor del triangulo
            Console.Write("Ingrese b°: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.Write("Ingrese z: ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());

            double bRad = bGrados * (Math.PI / 180.0);

            double cRad = Math.Atan2(z, y);
            double eRad = Math.PI - cRad;
            double dRad = Math.PI - eRad - bRad;
           
            double sobre = z / Math.Tan(dRad);
            double resultado =(sobre - y) ;

            // Salida valor solicitado
            Console.WriteLine("El valor solicitado de b es: " + bGrados);
            Console.WriteLine("El valor solicitado de resu es: " + resultado);

        }
    }
}
