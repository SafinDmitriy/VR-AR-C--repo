/* Сафин Дмитрий
 * 3.	Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
 *      б) Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3b
{
    internal class Program3b
    {
            static void Main(string[] args)
            {
                Console.Write("координату x1: "); //запрос на ввод данных координаты х первой точки
                double x1 = double.Parse(Console.ReadLine()); //ввод пользователем запрашиваемых данных, конвертация типа данных из строки в число и присвоение значения переменной

                Console.Write("координату y1: "); //запрос на ввод данных координаты y первой точки
                double y1 = double.Parse(Console.ReadLine()); //ввод пользователем запрашиваемых данных, конвертация типа данных из строки в число и присвоение значения переменной

                Console.Write("координату x2: "); //запрос на ввод данных координаты х второй точки
                 double x2 = double.Parse(Console.ReadLine()); //ввод пользователем запрашиваемых данных, конвертация типа данных из строки в число и присвоение значения переменной

                Console.Write("координату y2: "); //запрос на ввод данных координаты х второй точки
                double y2 = double.Parse(Console.ReadLine()); //ввод пользователем запрашиваемых данных, конвертация типа данных из строки в число и присвоение значения переменной

                Console.WriteLine("Расстояние между заданными точками: r= {0:F2}", Length(x1, y1, x2, y2)); //Вывод полученного расстояния междй точками в консоль

                Console.ReadLine();
            }

        static double Length(double a1, double b1, double a2, double b2) // Метод для вычисления расстояния между точками
        {
            return Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
        }

    }


}
