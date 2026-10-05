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

            int[] array = new int[0];
            bool isOpen = true;
            string inputUser;

            while (isOpen)
            {
                Console.WriteLine("\nВведены числа");

                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }

                Console.Write($"\nВведите число или одну из команд {ExitCommand}, {SumCommand}: ");
                inputUser = Console.ReadLine();

                if (inputUser.ToLower() == ExitCommand.ToLower())
                {
                    isOpen = false;
                    break;
                }
                else if (inputUser.ToLower() == SumCommand.ToLower())
                {
                    int sum = 0;

                    foreach (int element in array)
                    {
                        sum += element;
                    }

                    Console.WriteLine($"Сумма: {sum}");

                }
                else
                {
                    int newNumber = Convert.ToInt32(inputUser);
                    int[] tempArray = new int[array.Length + 1];

                    for (int i =0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }

                    tempArray[tempArray.Length - 1] = newNumber;
                    array = tempArray;
                }
            }
        }
    }
}
