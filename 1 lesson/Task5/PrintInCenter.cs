using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class OutputHelpers
    {
        public static void PrintInCenter(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}
