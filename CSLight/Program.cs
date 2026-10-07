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
            int[] array = new int[10];
            Random random = new Random();
            int minValue = 0;
            int maxValue = 50;

            Console.WriteLine("Изначальный массив");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
                Console.Write(array[i] + " ");
            }

            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int currentElement = array[i];
                        array[i] = array[j];
                        array[j] = currentElement;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив");
            for (int i = 0; i < array.Length; i++)
            {                
                Console.Write(array[i] + " ");
            }
        }
    }
}
