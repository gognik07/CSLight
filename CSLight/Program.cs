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
            bool isFinish = false;
            int minNumber = 0;
            int maxNumber = 101;
            Random rand = new Random();
            string userInput;

            Console.WriteLine("Добро пожаловать в консоль!");
            while (!isFinish)
            {
                Console.WriteLine("\nВведите команду:\n" +
                    "hello: Приветственное сообщение\n" +
                    "fix: Испрвавить ошибки\n" +
                    "random: Вывести случайнрое число\n" +
                    "clear: очистить консоль\n" +
                    "exit: Выход");
                Console.Write("Команда: ");
                userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "hello":
                        Console.WriteLine("Добро пожаловать к нам!");
                        break;
                    case "fix":
                        Console.WriteLine("Все ошибки исправлены!\nПриятного пользования");
                        break;
                    case "random":
                        Console.WriteLine($"Ваше случайное число {rand.Next(minNumber, maxNumber)}");
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        isFinish = true;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда!");
                        break;
                }                
            }

            Console.WriteLine("Хорошего вам дня!");
        }
    }
}
