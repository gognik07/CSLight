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
            Random random = new Random();
            int minValue = 0;
            int maxValue = 9;
            int[,] array = new int[3, 4];
            
            

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue + 1);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            int sum = 0;
            int rowForSum = 1;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[rowForSum, i];                
            }

            int multiplication = 1;
            int columnForMultiplication = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiplication *= array[i, columnForMultiplication];
            }

            Console.WriteLine($"\nСумма строки {rowForSum + 1} = {sum}, произведение столбца {columnForMultiplication + 1} = {multiplication}");
        }
    }
}
