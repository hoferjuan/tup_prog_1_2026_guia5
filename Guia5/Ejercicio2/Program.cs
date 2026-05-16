using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Línea superior
            for (int x = 5; x <= 75; x++)
            {
                Console.SetCursorPosition(x, 2);
                Console.Write("*");
            }

            // Línea inferior
            for (int x = 5; x <= 75; x++)
            {
                Console.SetCursorPosition(x, 22);
                Console.Write("*");
            }

            // Lado izquierdo
            for (int y = 2; y <= 22; y++)
            {
                Console.SetCursorPosition(5, y);
                Console.Write("*");
            }

            // Lado derecho
            for (int y = 2; y <= 22; y++)
            {
                Console.SetCursorPosition(75, y);
                Console.Write("*");
            }

            Console.SetCursorPosition(0, 24);
            Console.ReadKey();
        }
    }
}
