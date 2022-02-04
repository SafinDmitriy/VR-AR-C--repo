/* Сафин Дмитрий
 * 1.	Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите имя: "); //запрос на ввод данных
            string Name = Console.ReadLine(); //ввод пользователем запрашиваемых данных

            Console.Write("Введите фамилию: ");
            string Surname = Console.ReadLine();

            Console.Write("Введите возраст: ");
            string Age = Console.ReadLine();

            Console.Write("Введите рост: ");
            string Height = Console.ReadLine();

            Console.Write("Введите вес: ");
            string Weight = Console.ReadLine();

            Console.WriteLine("Имя: " + Name + "; Фамилия: " + Surname + "; Возраст: " + Age + "; Рост: " + Height + "; Вес: " + Weight); //Вывод данных склейкой
            Console.WriteLine("Имя: {0}; Фамилия: {1}; Возраст: {2}; Рост: {3}; Вес: {4}", Name, Surname, Age, Height, Weight); //Форматированный вывод данных
            Console.WriteLine($"Имя: {Name}; Фамилия: {Surname}; Возраст: {Age}; Рост: {Height}; Вес: {Weight}"); //Вывод данных через интерполяцию строк

            Console.ReadLine();
        }
    }
}