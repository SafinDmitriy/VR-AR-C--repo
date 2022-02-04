using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: "); //запрос на ввод данных
            string nameInput = Console.ReadLine(); //ввод пользователем запрашиваемых данных

            Console.Write("Введите фамилию: ");
            string surnameInput = Console.ReadLine();

            Console.Write("Введите город проживания: ");
            string cityInput = Console.ReadLine();

            Console.Clear();
            OutputHelpers.PrintInCenter($"{ surnameInput} { nameInput}, г. { cityInput}");
            OutputHelpers.Pause();
        }
    }
}
