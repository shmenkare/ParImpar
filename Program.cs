using System;
using System.Collections.Generic;
using System.Text;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Ingrse un numero");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} es par", num);
            }
            else
            {
                Console.WriteLine("{0} es impar", num);
            }
            Console.ReadKey();

        }
    }
}
