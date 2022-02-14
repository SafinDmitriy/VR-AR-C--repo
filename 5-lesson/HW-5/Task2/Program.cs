using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine(); ;
            /*Console.ReadLine();*/

            Console.WriteLine("Введите максимальную длину выводимых слов:");
            int numlet = int.Parse(Console.ReadLine());
            Console.WriteLine("В тексте содержатся следующие слова, имеющющие длину не более " + numlet + " символов:");
            Message.WordsByNumOfLetters(text, numlet);
            Console.ReadLine();

            Console.WriteLine("Введите букву. Слова, оканчивающиеся на эту букву будут удалены из текста:");
            char ch = char.Parse(Console.ReadLine());

            Message.RemoveWordsByEndLetter(text, ch);

            Console.ReadLine();

            Console.WriteLine("Самое длинное слово в тексте:");
            Message.FindLongestWord (text);
            
            Console.ReadLine();

            Console.WriteLine("Строка из самых длинных слов в тексте:");
            Message.LongestWordsString(text);

            Console.ReadLine();

            /*Message.FindLongestWord lon = new Message.FindLongestWord()

        // complex01.re = 0;
        //complex01.im = 5;

        ComplexClass complex02 = new ComplexClass(3, -1);

        Console.WriteLine($"Первое комплексное число: {complex01}");
        Console.WriteLine($"Второе комплексное число: {complex02}");


        Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");*/

            Console.ReadLine();
        }
    }
}

