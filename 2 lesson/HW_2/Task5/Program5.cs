/* Сафин Дмитрий
5.
а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program5
    {

        //Метод расчета ИМТ
        static double IMT (double w, double h)
        { return w / (h * h); }

        static void Main(string[] args)
        {
            // Ввод данных пользователем
            Console.Write("Введите вес в килограммах: "); 
            double m = double.Parse(Console.ReadLine()); 

            Console.Write("Введите рост в метрах: ");
            double v = double.Parse(Console.ReadLine());


            // Условие недостатка веса
            if (IMT(m, v) < 18.5)
            {
                Console.WriteLine("Ваш вес ниже нормы. Рекоммендуется набрать вес.");

                //Расчет и вывод недостающего веса

                Console.WriteLine("Необходимо набрать минимум {0} килограмм", 18.5 * (v * v) - m);
            }

            // Условие нормального веса
            else if (IMT(m, v) >= 18.5 & IMT(m, v) <= 25) Console.WriteLine("Ваш вес в норме.");

            // Условие избыточного веса
            else
            {
                Console.WriteLine("Ваш вес выше нормы. Рекоммендуется похудеть");

             // Расчет и вывод значения лишнего веса
                Console.WriteLine("Необходимо похудеть минимум на {0} килограмм", m - (25 * (v * v)));
            }

                Console.ReadLine();

        }
    }
}

