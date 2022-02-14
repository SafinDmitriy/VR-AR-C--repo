/*
 Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, 
в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class Message
    {
        /*static public string text;*/

       /* static public void Message(string text)
        {
            *//*text = "Равным образом рамки и место обучения кадров влечет за собой процесс внедрения и модернизации систем массового участия. Значимость этих проблем настолько очевидна, что сложившаяся структура организации позволяет выполнять важные задания по разработке новых предложений. Разнообразный и богатый опыт сложившаяся структура организации способствует подготовки и реализации форм развития. Равным образом постоянный количественный рост и сфера нашей активности обеспечивает широкому кругу (специалистов) участие в формировании системы обучения кадров, соответствует насущным потребностям." +

              "Задача организации, в особенности же реализация намеченных плановых заданий требуют определения и уточнения позиций, занимаемых участниками в отношении поставленных задач. Таким образом постоянное информационно-пропагандистское обеспечение нашей деятельности играет важную роль в формировании модели развития.";*//*
        }*/

        /*Метод вывода слов из сообщения, содержащих не более n букв*/
        static public void WordsByNumOfLetters(string text, int num)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
 

            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= num)
                    Console.Write(word + ", ");
            }
            
        }


        /*Метод удаления из сообщения все слова, которые заканчиваются на заданный символ*/
        static public void RemoveWordsByEndLetter(string text, char ch)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });

            Console.WriteLine();
            Console.WriteLine("Найдены следующие слова, заканчивающиеся на букву " + ch + " :");
            
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == ch)
                {
                    Console.Write(word + " ");
                   text = text.Replace(word, "");
                }
            }
            Console.WriteLine();
            Console.WriteLine("После удаления слов получился следующий текст: \n" + text);

        }

        /*Метод нахождения самого длинного слова*/
        static public string FindLongestWord(string text)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            Console.WriteLine(maxWord);
            Console.ReadLine();
            return maxWord;
        }

        /*Метод формирования строки StringBuilder из самых длинных слов сообщения*/

        static public StringBuilder LongestWordsString(string text)
        {
            string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
            StringBuilder str = new StringBuilder();
            int max = Message.FindLongestWord(text).Length;
            foreach (string word in words)
            {
                if (word.Length >= max)
                {
                    str.Append(word.ToLower() + " ");
                }
            }
            Console.WriteLine("Полученная строка самых длинных слов: " + str);
            Console.ReadLine();
            return str;
        }

    
        
    }
}