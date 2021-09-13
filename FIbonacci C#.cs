using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, limite, i, auxiliar, numero;
            bool primo = false;
 

            Console.WriteLine("Ingrese el número de numeros de Fibonacci que desea mostrar");
            limite = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for (i = 0; i < limite; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);

            }
            Console.ReadKey();

            numero = Convert.ToInt32(limite);
            for (int t = 2; t < numero; t++)
            {
                if (numero % t == 0)
                {
                    primo = true;
                    break;
                }
            }
            if (primo)
            {
                Console.WriteLine("{0} no es primo", numero);
            }
            else
            {
                Console.WriteLine("{0} es primo", numero);
            }
        }
    }
}
