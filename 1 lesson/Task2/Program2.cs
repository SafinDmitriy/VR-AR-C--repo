/* Сафин Дмитрий
 * 2.	Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вес в килограммах: "); //запрос на ввод данных
            float m = float.Parse(Console.ReadLine()); //ввод пользователем запрашиваемых данных, конвертация типа данных из строки в число и прсвоение значения  

            Console.Write("Введите рост в метрах: ");
            float h = float.Parse(Console.ReadLine());

            float I = m / (h * h); //вычисление индекса массы тела

            Console.WriteLine("Индекс массы тела (ИМТ): {0}", I); //Вывод полученного результата в консоль
            
            Console.ReadLine();
        }
    }
}