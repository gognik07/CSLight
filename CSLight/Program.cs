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
            int[] array = { 2, 2, 2, 4, 4, 4, 4, 5, 1, 1, 1, 1, 1 };
            int maxElement = array[0];
            int countMaxElement = 0;
            int currentElement = array[0];
            int countCurrentElement = 0;

            for (int i = 0;  i < array.Length; i++)
            {
                if (currentElement == array[i])
                {
                    countCurrentElement++;
                }
                else
                {
                    currentElement = array[i];
                    countCurrentElement = 1;
                }

                if (countMaxElement < countCurrentElement)
                {
                    maxElement = currentElement;
                    countMaxElement = countCurrentElement;
                }
            }

            Console.WriteLine($"Число {maxElement} повторяется {countMaxElement} раза подряд");
        }
    }
}
