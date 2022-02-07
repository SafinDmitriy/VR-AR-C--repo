/* Сафин Дмитрий
 * 2. а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечётных положительных чисел. 
 * Сами числа и сумму вывести на экран, используя tryParse.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program2
    {

        static int Input()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Вы ввели не число. Пожалуйста, повторите ввод: ");
                else return x;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа, каждое с новой строки, для завершения введите 0: ");

            
            int sum = 0;    
            while (true)
            {
                int number = Input();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 != 0)
                {
                    Console.WriteLine("Вами введены следующие нечетные положительные числа: " + number +", ");
                    sum+=number;
                }
            }

            Console.WriteLine("Сумма нечетных положительных чисел равна: " + sum);

            Console.ReadKey();
        }

    }
    }

