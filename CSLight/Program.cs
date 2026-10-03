using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        const string HelloCommand = "hello";
        const string FixCommand = "fix";
        const string RandomCommand = "random";
        const string ClearCommand = "clear";
        const string ExitCommand = "exit";

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
                    $"{HelloCommand}: Приветственное сообщение\n" +
                    $"{FixCommand}: Испрвавить ошибки\n" +
                    $"{RandomCommand}: Вывести случайнрое число\n" +
                    $"{ClearCommand}: очистить консоль\n" +
                    $"{ExitCommand}: Выход");
                Console.Write("Команда: ");
                userInput = Console.ReadLine();

                switch(userInput)
                {
                    case HelloCommand:
                        Console.WriteLine("Добро пожаловать к нам!");
                        break;
                    case FixCommand:
                        Console.WriteLine("Все ошибки исправлены!\nПриятного пользования");
                        break;
                    case RandomCommand:
                        Console.WriteLine($"Ваше случайное число {random.Next(minNumber, maxNumber)}");
                        break;
                    case ClearCommand:
                        Console.Clear();
                        break;
                    case ExitCommand:
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
