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
            int[] array = new int[30];
            Random random = new Random();
            int minValue = 0;
            int maxValue = 100;

            Console.WriteLine("Дан массив");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n\nЛокальные максимумы: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    if (array[i] > array[i + 1])
                    {
                        Console.Write(array[i] + " ");
                    }
                }
                else if (i == array.Length - 1)
                {
                    if (array[i] > array[i - 1])
                    {
                        Console.Write(array[i] + " ");
                    }
                }
                else
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        Console.Write(array[i] + " ");
                    }
                }
            }
        }
    }
}
