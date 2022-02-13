/* Сафин Дмитрий
 * 1. Создать программу, которая будет проверять корректность ввода логина. 
 * Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
 * при этом цифра не может быть первой:

б) **с использованием регулярных выражений.
 */

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task1b
{
    internal class Program1b
    {
        static void Main(string[] args)
        {

            Console.Write("Введите логин: ");
            string Login = Console.ReadLine();
            Console.WriteLine("Проверка корректности логина...");
            Console.WriteLine();

/*            bool check1 = true, check2 = true, check3 = true;*/

            Regex login_regex = new Regex("^[a-zA-Z][a-zA-Z0-9]{2,9}$");

            if (login_regex.IsMatch(Login))
            {

                Console.WriteLine("Логин корректен! Вы можете его использовать");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Логин некорректен:");
                Console.WriteLine();

                if (!Regex.IsMatch(Login, ".{2,9}$"))
                    Console.WriteLine("- длина логина должна быть от 2 до 10 символов");
                if (Regex.IsMatch(Login, "^[0-9]"))
                    Console.WriteLine("- цифра не может быть первым сиволом");
                if (!Regex.IsMatch(Login, "[a-z|A-Z|0-9]"))
                    Console.WriteLine("- можно использовать только латинские буквы и цифры");

                Console.ReadKey();


                /*                if (!Regex.IsMatch(Login, "[a-z|A-Z|0-9]"))
                                    check3 = false;
                                if (Regex.IsMatch(Login, "^[0-9]"))
                                    check2 = false;
                                if (!Regex.IsMatch(Login, ".{2,9}$"))
                                    check1 = false;*/

                /*            if (!Regex.IsMatch(Login, @"^[a-zA-Z0-9]+${2,10}"))
                                check3 = false;*/

                /*bool check1 = true, check2 = true, check3 = true;

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
                    *//*if (!Char.IsLetterOrDigit(Login[i]))*//*
                    if (!(Login[i] >= 65 && Login[i] <= 90) && !(Login[i] >= 97 && Login[i] <= 122) && !Char.IsDigit(Login[i]))
                    {
                        check3 = false;
                        break;
                    }
                }*/

                /*           if (!check1 || !check2 || !check3)
                           {
                               Console.WriteLine("Логин некорректен:");*/

                /*  if (!check1)
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
                  }*/

                /*}
                else Console.WriteLine("Логин корректен! Вы можете его использовать");*/
                /*Console.ReadKey();*/
            }
        }
    }
}
