using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Si declaro la variable de control "i" existe fuera del for
            int i;
            double num, acum, prom;

            //inicialización de acumulador
            acum= 0;
            
            //De otra maneta for(int i = 1; i<=10; i++) 
            //Existe i solo para el for
            //En este caso i tiene alcanze fuera del for.

            for (i = 1; i<=10; i++)
            {
                Console.WriteLine("Ingrese un número");
                num=Convert.ToDouble(Console.ReadLine());

                //Acumular forma abreviada "Aprendiendo otros modos"
                acum += num;
            }
            prom = acum / 10;

            Console.WriteLine($"El promedio de los 10 números es: {prom}");
            
        }
    }
}
