/*Сафин Дмитрий
2. Написать метод подсчета количества цифр числа.
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
		static int AmNum(int x)
		{
			int i;
			
			if (x == 0)            // условие для ситуации ввода числа 0
				
				{ i = 1; }
			
			else
			
				// цикл со счетчиком - оперцие деления откидываем по одному разряду введенного числа и считаем разряды, пока число не закончится (не получим ноль при делении)

				for (i=0; x!=0; i++)
			
				{
					x=x/10;  
				}
			return i;
		}

		static void Main(string[] args)
        {

			int a;
			Console.WriteLine("Введите число:");
			a = Convert.ToInt32(Console.ReadLine());
						
			Console.WriteLine("Введенное число состоит из: {0} цифр", AmNum(a));


			Console.ReadLine();

		}
    }
}
