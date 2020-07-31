using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            int carta = 0, total = 0, jugador = 0, max = 0, n = 0;
            Random aleatorio = new Random();
            string continuar = "s";

            Console.WriteLine("ingrese el numero de jugadores, min 2 y max 5");
            n = int.Parse(Console.ReadLine());

            while (n < 2 || 5 > n)
            {
                Console.WriteLine("ingrese el numero de jugadores, min 2 y max 5");
                n = int.Parse(Console.ReadLine());
            }
            while (jugador > n)
            {
                if (total > max) max = total;
                jugador++;
                Console.WriteLine("Bienvenido jugador" + jugador);

                while (true)
                {
                    carta = aleatorio.Next(1, 11);
                    if (total > 21)
                    {
                        Console.WriteLine("perdiste");
                        break;
                    }
                    else
                    {
                        total += carta;
                        if (total == 21)
                        {
                            Console.WriteLine("ganaste");
                            break;
                        }
                        Console.WriteLine("total: " + total);
                        Console.WriteLine("desea continuar (s/n): ");
                        continuar = Console.ReadLine();
                        if (continuar == "n") break;
                        while (continuar != "s" && continuar != "n" && total < 21)
                        {
                            Console.WriteLine("error, responda solo con s/n");
                            Console.WriteLine("desea continuar (s/n): ");
                            Console.ReadLine();
                        }
                        if (continuar == "n") break;
                    }
                }
                Console.WriteLine("Maximo: " + max);
                Console.WriteLine("su total fue: " + total + "puntos");
                Console.WriteLine("Gracias por jugar");
            }
        }
    }
}
