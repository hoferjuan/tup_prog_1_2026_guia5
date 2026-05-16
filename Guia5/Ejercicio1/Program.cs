using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaro e inicializo variables
            int numFinal, i;
            double acum;
            acum = 0;
            i = 0;
            //Solicitar y leer número final
            Console.WriteLine("Ingrese el número limite");
            numFinal = Convert.ToInt32(Console.ReadLine());
            
            //Ciclo para la suma de números
            for (i = 1; i <= numFinal; i++)
            {
                acum = acum + i;
            }
            Console.WriteLine($"El resultado es {acum}");
        }
    }
}
