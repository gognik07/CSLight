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
            int[] array = { 1, 2, 3, 4 };
            Console.WriteLine("Изначальный массив: ");

            foreach (int element in array)
            {
                Console.Write(element + " ");
            }

            int firstElement = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = firstElement;

            Console.WriteLine("\nСдвинутый массив: ");

            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
