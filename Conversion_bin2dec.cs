using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_bin2dec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" !Para convertir tu numero de Bin a Dec debes de ingresar numero por numero de izq a der!     ");

            Console.Write("Ingrese el 1er numero: ");
            int b4 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el 2do numero: ");
            int b3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el 3er numero: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el 4to numero: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el 5to numero: ");
            int b0 = int.Parse(Console.ReadLine());
            Console.WriteLine("El Numero Que ingreso es: " + b4 + b3 + b2 + b1 + b0);

            double Resultado = b4 * Math.Pow(2, 4) + b3 * Math.Pow(2, 3) + b2 * Math.Pow(2, 2) + b1 * Math.Pow(2, 1) + b0 * Math.Pow(2, 0);
            Console.WriteLine("El Numero convertido es: " + Resultado);
        }
    }
}
