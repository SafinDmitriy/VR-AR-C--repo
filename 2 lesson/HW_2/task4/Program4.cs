/* Сафин Дмитрий
 * 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program4
    {

		// Метод для сравнение введенных данных с эталонными
		static bool auth (string L, string P)
        {
			if (L == "root" & P == "GeekBrains") return true;
			else return false;
        }

		static void Main(string[] args)
		{
			uint attempt = 0;

			do {
				
				// Ввод данных
				Console.Write("Введите логин: ");
				string Login = Console.ReadLine();

				Console.Write("Введите пароль: ");
				string Password = Console.ReadLine();

				// Условие успешной авторизации
				if (auth (Login, Password)) { Console.WriteLine("Успешная авторизация, выполняется программа");
					
				// Тело условной программы	
					Console.Write("Введите имя: "); 
					string Name = Console.ReadLine(); 

					Console.Write("Введите фамилию: ");
					string Surname = Console.ReadLine();

					Console.WriteLine("Имя: " + Name + "; Фамилия: " + Surname);

					break;
				}
				// Условие неуспешной авторизации. Проверка достижения 3 неуспешных попыток.
				else {
					attempt++; 
					if (attempt < 3) Console.WriteLine("Неверный логин или пароль, попробуйте ещё раз");
					else Console.WriteLine("Вы использовали 3 попытки авторизации. Для закрытия программы нажните Enter.");

				}

			}
			while (attempt != 3);
			
			Console.ReadLine();
		}
	}
}
