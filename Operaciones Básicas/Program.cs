using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double res;
            Console.WriteLine("Introduce el Primer numero:");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el Segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            res = numero1 + numero2;
            Console.WriteLine("Resultado de la Suma: " + res);
            res = numero1 - numero2;
            Console.WriteLine("Resultado de la Resta: " + res);
            res = numero1 / numero2;
            Console.WriteLine("Resultado de la Division: " + res);
            res = numero1 * numero2;
            Console.WriteLine("Resultado de la Multiplicacion: " + res);
            Console.ReadKey();
        }
    }
}