using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarifaSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su Salario: ");
            double Salario = double.Parse(Console.ReadLine());
            Console.WriteLine(" Usted es : 1. Dependiente o 2. Independiente");
            double Mensual = Salario * 40 / 100;
            double eps = Mensual * 4 / 100;
            double pension = Mensual * 4 / 100;
            double total = Mensual - eps - pension;
            double anual = Mensual - eps - pension + Salario;

            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Mensual" + Mensual);
                Console.WriteLine("EPS" + eps);
                Console.WriteLine("Pension" + pension);
                Console.WriteLine("Anual" + anual);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("riesgo de 1 a 5");
                int riesgo = int.Parse(Console.ReadLine());
                double eps2 = Mensual * 16 / 100;
                double pension2 = Mensual * 12.5 / 100;


                double arl1 = (Salario / 0.00522);
                double arl2 = (Salario / 0.01044);
                double arl3 = (Salario / 0.02436);
                double arl4 = (Salario / 0.04350);
                double arl5 = (Salario / 0.06960);
                double totalc1 = Mensual - eps2 - pension2 - arl1;
                double totalc2 = Mensual - eps2 - pension2 - arl2;
                double totalc3 = Mensual - eps2 - pension2 - arl3;
                double totalc4 = Mensual - eps2 - pension2 - arl4;
                double totalc5 = Mensual - eps2 - pension2 - arl5;

                switch (riesgo)
                {
                    case 1:
                        Console.WriteLine("Mensual" + totalc1);
                        Console.WriteLine("EPS" + eps2);
                        Console.WriteLine("ARL" + arl1);
                        Console.WriteLine("Pension" + pension2);
                        break;
                    case 2:
                        Console.WriteLine("Mensual" + totalc2);
                        Console.WriteLine("EPS" + eps2);
                        Console.WriteLine("ARL" + arl2);
                        Console.WriteLine("Pension" + pension2);
                        break;
                    case 3:
                        Console.WriteLine("Mensual" + totalc3);
                        Console.WriteLine("EPS" + eps2);
                        Console.WriteLine("ARL" + arl3);
                        Console.WriteLine("Pension" + pension2);
                        break;
                    case 4:
                        Console.WriteLine("Mensual" + totalc4);
                        Console.WriteLine("EPS" + eps2);
                        Console.WriteLine("ARL" + arl4);
                        Console.WriteLine("Pension" + pension2);
                        break;
                    case 5:
                        Console.WriteLine("Mensual" + totalc5);
                        Console.WriteLine("EPS" + eps2);
                        Console.WriteLine("ARL" + arl5);
                        Console.WriteLine("Pension" + pension2);
                        break;
                }
            }
        }
    }
}
