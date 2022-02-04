/*
 * Сафин Дмитрий 
1. Написать метод, возвращающий минимальное из трёх чисел.
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
			int a, b, c;
			Console.WriteLine("Введите первое число:");
			a = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите второе число:");
			b = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите третье число:");
			c = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Наименьшее введенное число: {0}", MinNum(a, b, c));


			Console.ReadLine();
		}

		static int MinNum(int x, int y, int z)
		{
			int min = 0;
			if (x <= y & x <= z)
			{
				min = x;
			}
			else
			{
				if (y <= x & y <= z)
				{
					min = y;
				}
				else
					min = z;
			};


			return min;
		}


	}
}
