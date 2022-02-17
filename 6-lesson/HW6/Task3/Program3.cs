/*Сафин Дмитрйи
 3. Переделать программу Пример использования коллекций для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента;
 */

using System;
using System.Collections;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        int numOfStud5 = 0;
        int numOfStud6 = 0;
        // Создадим необобщенный список
        ArrayList list = new ArrayList();
        // Запомним время в начале обработки данных
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("..\\..\\students.csv");
        int[] a = new int[6];
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
                list.Add(s[1] + " " + s[0]);// Добавляем склееные имя и фамилию
                if (int.Parse(s[6]) == 5) numOfStud5++;
                else
                {
                    if (int.Parse(s[6]) == 6) numOfStud6++;
                }

                //Считаем студентов 18-20, записываем в массив количество соответственно номеру курса


                
                if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20) a[int.Parse(s[6])]++;

            }
            catch
            {


        }
    }
        sr.Close();
        list.Sort();
        /*Console.WriteLine("Всего студентов:{0}", list.Count);*/
        Console.WriteLine("Студентов на 5 курсе:{0}", numOfStud5, "человек");
        Console.WriteLine("Студентов на 6 курсе:{0}", numOfStud6, "человек");

        //цикл для определения количества студентов на курсе соответствующий возрасту

        for (int i = 0; i<=5; i++)
        {
            Console.WriteLine("На: " + (i+1) + " курсе учатся " + a[i] + " студентов в возрасте от 18 до 20 лет");
            
        }




       /*foreach (var v in list) Console.WriteLine(v);*/
        // Вычислим время обработки данных
        Console.WriteLine(DateTime.Now - dt);
        Console.ReadKey();
    }
}
