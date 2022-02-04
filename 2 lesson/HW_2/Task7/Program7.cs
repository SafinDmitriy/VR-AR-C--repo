/*Сафин Дммитрий

7.
a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program7
    {
        static void Main(string[] args)
        {
            // Ввод значений

            Console.Write("Введите первое число: a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число, большее чем a: b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Все числа от a до b:");
            Digits(a, b); // вызов рекурсивного метода, выводящего значения между заданными числами
            Console.WriteLine();
                
                Console.Write("Сумма всех числе от a до b равна: " + Sum(a, b)); // вывод в консоль значения суммы всех чисел между заданными, посчитанной в рекусивном методе
                Console.ReadLine();
        }

        /* а) Рекурсивный метод, выводящий в консоль все числа от a до b*/
        static void Digits(int n1, int n2)
        {
            if (n1 <= n2)
            {
                Console.Write(n1 + " ");
                n1++;
                Digits(n1, n2);
            }
        }

        /* б) Рекурсивный метод для расчета суммы всех чисел от a до b*/
        static int Sum(int n1, int n2)
        {
            if (n1 <= n2)  
                return n2 + Sum(n1, n2 - 1);
            else return 0;
        }
    }
}
