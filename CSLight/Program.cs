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
            const string ExitCommand = "exit";
            const string SumCommand = "sum";

            List<int> array = new List<int>();
            bool isOpen = true;
            string inputUser;

            while (isOpen)
            {
                PrintArray(array);

                Console.Write($"\nВведите число или одну из команд {ExitCommand}, {SumCommand}: ");
                inputUser = Console.ReadLine();

                if (inputUser.ToLower() == ExitCommand.ToLower())
                {
                    isOpen = false;
                    break;
                }
                else if (inputUser.ToLower() == SumCommand.ToLower())
                {
                    CalculateSum(array);
                }          
                else
                {
                    array = AddElement(inputUser, array);                    
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        private static List<int> AddElement(string inputUser, List<int> array)
        {
            if (int.TryParse(inputUser, out int newNumber))
            {
                array.Add(newNumber);
            }
            else
            {
                Console.WriteLine("Введена некорректная команда/число");
            }

            return array;
        }

        private static void CalculateSum(List<int> array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                sum += element;
            }

            Console.WriteLine($"Сумма: {sum}");
        }

        private static void PrintArray(List<int> array)
        {
            Console.WriteLine("\nВведены числа");

            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
