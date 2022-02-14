/* Сафин Дмитрий
 * 1. Создать программу, которая будет проверять корректность ввода логина. 
 * Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
 * при этом цифра не может быть первой:
 а) без использования регулярных выражений;
б) **с использованием регулярных выражений.
 */

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите логин: ");
            string Login = Console.ReadLine();
            Console.WriteLine("Проверка корректности логина...");
            Console.WriteLine();

            bool check1 = true, check2 = true, check3 = true;

            // проверка правильности длины

            if (Login.Length < 2 || Login.Length > 10)
            {
                check1 = false;
            }
            
            // проверка первого символа (не цифра)
            
            if (Char.IsDigit(Login[0]))
            {
                 check2 = false;
            }

            // проверка символов - латинские буквы или цифры?

            for (int i = 0; i < Login.Length; i++)
            {
                /*if (!Char.IsLetterOrDigit(Login[i]))*/
                if (!(Login[i] >= 65 && Login[i] <= 90) && !(Login[i] >= 97 && Login[i] <= 122) && !Char.IsDigit(Login[i]))
                {
                    check3 = false;
                    break;
                }
            }

            if (!check1 || !check2 || !check3)
            {
                Console.WriteLine("Логин некорректен:");

                if (!check1)
                {
                    Console.WriteLine("- длина логина должна быть от 2 до 10 символов");
                }
                if (!check2)
                {
                    Console.WriteLine("- цифра не может быть первым сиволом");
                }
                if (!check3)
                {
                    Console.WriteLine("- можно использовать только латинские буквы и цифры");
                }

            }
            else Console.WriteLine("Логин корректен! Вы можете его использовать");
            Console.ReadKey();
        }
    }
}


