using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число, большее чем a: b = ");
            int b = int.Parse(Console.ReadLine());


            Console.Write(Sum(a, b));
            Console.ReadLine();

        }


        static int Sum(int n1, int n2)
        {
            int s = 0;
            if (n1 <= n2)
            {
                s = n2 + Sum(n1, n2 - 1);
                return s;
                
            }
            else return 0;
           


        }
    }
}
