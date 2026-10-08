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
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Массив до перемешки");
            PrintArray(array);

            Shuffle(array);

            Console.WriteLine("\nМассив после перемешки");
            PrintArray(array);
        }

        private static void Shuffle(int[] array)
        {
            Random random = new Random();
            for (int i = array.Length - 1; i > 0; i--) 
            {
                int j = random.Next(0, i);
                ReplaceElement(array, i, j);
            }
        }

        private static void ReplaceElement(int[] array, int firstIndex, int secondIndex)
        {
            int firstElement = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = firstElement;
        }

        private static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
