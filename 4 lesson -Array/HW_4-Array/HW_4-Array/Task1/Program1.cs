/*Сафин Дмитрий

1.Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами. 
Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
В данной задаче под парой подразумевается два подряд идущих элемента массива.
Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program1
    {


        static int GetNumberOfPairs(int[] Array01, int n01) //Метод подсчёта количества пар элементов массива, в которых только одно число делится на 3
        {
            int number = 0;
            for (int i = 0; i < n01 - 1; i++)
            {
                if ((Array01[i] % 3 == 0 & Array01[i + 1] % 3 != 0) || (Array01[i] % 3 != 0 & Array01[i + 1] % 3 == 0))
                {
                    number++;
                }
            }
            return number;
        }
        static void Main(string[] args)
        {
            int n = 20;
            int[] Array = new int[n];
            Random rnd = new Random();

            Console.Write("В массиве: ");

            for (int i = 0; i < n; i++) { 
            Array[i] = rnd.Next(-10000, 10000);
            Console.Write(Array[i] + ", "); 
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Количество пар: {GetNumberOfPairs(Array, n)}");

            Console.ReadLine();
        }
    }
}

