using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bienvenido a la Calculadora de IMC");
            Console.Write("Si quiere conocer cual es su IMC ");
            Console.Write("Ingrese su peso (Kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su altura (m): ");
            double estatura = double.Parse(Console.ReadLine());
            //-------------------------------------------------
            double imc = peso / Math.Pow(estatura, 2);

            if (imc < 18.5)
            {
                Console.WriteLine("Tu IMC es " + imc);
                Console.WriteLine("Estas Bajo de peso!!");
            }
            else if ( 18.5 <=imc && imc <= 24.9)
            {
                Console.WriteLine("Tu IMC es " + imc);
                Console.WriteLine("Estas Normal de peso sigue si!!");
            }
            else if (25 <= imc && imc <= 29.9)
            {
                Console.WriteLine("Tu IMC es " + imc);
                Console.WriteLine("Estas en Sobrepeso ten cuidado!!");
            }
            else if (imc > 30)
            {
                Console.WriteLine("Tu IMC es " + imc);
                Console.WriteLine("Estas  Obeso vaya al medico!!");
            }
            Console.WriteLine("Feliz dia!!");

        }
    }
}
