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
            int[,] array = new int[10, 10];
            Random random = new Random();
            int minValue = 10;
            int maxValue = 99;
            int maxElement = int.MinValue;
            int newElement = 0;

            Console.WriteLine("Старый массив\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue + 1);
                    Console.Write(array[i, j] + " ");
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nНовый массив\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == maxElement)
                    {
                        array[i, j] = newElement;
                    }
                    Console.Write(array[i, j] + " ");                    
                }

                Console.WriteLine();
            }
        }
    }
}
