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
            string password = "qwert54321";
            string userInput;
            int countTries = 3;
            bool isFail = true;

            for (int i = 0; i < countTries; i++)
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Секреты!");
                    isFail = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль неверный!");                    
                }
            }

            if (isFail)
            {
                Console.WriteLine("Доступ заблокирован");
            }
        }
    }
}
