using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        const string helloCommand = "hello";
        const string fixCommand = "fix";
        const string randomCommand = "random";
        const string clearCommand = "clear";
        const string exitCommand = "exit";

        static void Main(string[] args)
        {
            bool isFinish = false;
            int minNumber = 0;
            int maxNumber = 101;
            Random random = new Random();
            string userInput;
                        
            Console.WriteLine("Добро пожаловать в консоль!");
            while (!isFinish)
            {
                Console.WriteLine("\nВведите команду:\n" +
                    $"{helloCommand}: Приветственное сообщение\n" +
                    $"{fixCommand}: Испрвавить ошибки\n" +
                    $"{randomCommand}: Вывести случайнрое число\n" +
                    $"{clearCommand}: очистить консоль\n" +
                    $"{exitCommand}: Выход");
                Console.Write("Команда: ");
                userInput = Console.ReadLine();

                switch(userInput)
                {
                    case helloCommand:
                        Console.WriteLine("Добро пожаловать к нам!");
                        break;
                    case fixCommand:
                        Console.WriteLine("Все ошибки исправлены!\nПриятного пользования");
                        break;
                    case randomCommand:
                        Console.WriteLine($"Ваше случайное число {random.Next(minNumber, maxNumber)}");
                        break;
                    case clearCommand:
                        Console.Clear();
                        break;
                    case exitCommand:
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
