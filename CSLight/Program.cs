using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Дана строка с текстом используя метод строки String.Split() получить массив слов которые разделены пробелом в тексте и вывести массив каждое слово с новой строки";
            Console.WriteLine("Изначальный текст: " + text);

            string[] arrayWords = text.Split(' ');
            Console.WriteLine("\n\nТекст разделенный на слова:");

            foreach(string word in arrayWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
