using System;
using System.Collections;
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
            const string ExitCommand = "exit";

            Dictionary<string, string> explanatoryDictionary = GenerateExplanatoryDictionary();
            bool isOpen = true;
            string userInput;

            while (isOpen)
            {
                Console.Write("Введите слово: ");
                userInput = Console.ReadLine();

                if (userInput == ExitCommand)
                {
                    isOpen = false;
                    continue;
                }

                Console.WriteLine(GetDictionaryValue(userInput, explanatoryDictionary));
            }
        }

        private static string GetDictionaryValue(string word, Dictionary<string, string> explanatoryDictionary)
        {
            const string MessageForUnknownWord = "Неизвесное слово";

            if (explanatoryDictionary.ContainsKey(word))
            {
                return explanatoryDictionary[word];
            }
            else
            {
                return MessageForUnknownWord;
            }
        }

        private static Dictionary<string, string> GenerateExplanatoryDictionary()
        {
            return new Dictionary<string, string>
            {
                { "Слово", "Набор букв" },
                { "C#", "Язык программирования" },
                { "Dictionary", "Набор пар ключ/значение" },
                { "Коллекция", "Структура данных для хранения набора значений" }
            };
        }
    }
}
