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
            string stopWord = "exit";
            string userInput = "";

            while (userInput != stopWord)
            {
                Console.Write("Введите строку: ");
                userInput = Console.ReadLine();
                Console.WriteLine($"Вы ввели {userInput}");
            }
        }
    }
}
