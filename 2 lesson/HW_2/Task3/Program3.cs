/* Сафин Дмитрий
 * 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program3
    {

        static int sumPE ()
        {
        int a, sum = 0;
            
            // цикл ввода чисел, пока не введен ноль
            do
            {
                Console.WriteLine("Введите любое число (при вводе 0, будет подсчитана сумма всех введенных нечетных положительных чисел):");
                a = Convert.ToInt32(Console.ReadLine());

                // условие проверки введенного числа на положительность и четность и суммирование таких чисел

                if (a >0 & a%2==0) 
                { sum += a; }
            }
                while (a != 0);

                return sum; // возврат результата выполнения метода в виде суммы 
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Сумма всех введенных нечетных положительных чисел: {0}", sumPE());
            Console.ReadLine();

        }
    }
}

