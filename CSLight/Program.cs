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
            int minValue = 10;
            int maxValue = 25;
            int start = 50;
            int end = 150;
            int selectedNumber = random.Next(minValue, maxValue + 1);
            int countMultiples = 0;

            for (int i = selectedNumber; i <= end; i += selectedNumber)
            {
                if (i >= start)
                {
                    countMultiples++;
                }
            }

            Console.WriteLine($"Числу {selectedNumber} есть {countMultiples} кратных чисел");

        }
    }
}
