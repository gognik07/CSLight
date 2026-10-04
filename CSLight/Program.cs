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

            while (countTries-- > 0)
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Секреты!");
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль неверный!");
                }
            }

            if (countTries < 0)
            {
                Console.WriteLine("Доступ заблокирован");
            }
        }
    }
}
