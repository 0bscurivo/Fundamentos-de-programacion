using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01_04_2
{
    class Program
    {
        static void Main()
        {
            // Entradas para encontrar el valor del triangulo
            Console.Write("Ingrese d°: ");
            double dGrados = double.Parse(Console.ReadLine());
            Console.Write("Ingrese b°: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.Write("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());
            double eGrados= 180 - dGrados - bGrados;
            double cGrados = 180 - eGrados;
            
            double cRad = cGrados * (Math.PI / 180.0);      
            //double eRad = Math.PI - cRad;
            //double dRad = Math.PI - eRad - bRad;

            double z = y * Math.Tan(cRad);



            // Salida valor solicitado         
            Console.WriteLine("El valor solicitado de z es: " + z);
        }
    }
}
