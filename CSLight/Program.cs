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
            int maxValue = 26;
            int start = 50;
            int end = 150;
            int n = random.Next(minValue, maxValue);
            int currentN = n;
            int countMultiples = 0;

            while (currentN <= end)
            {
                if (currentN >= start && currentN <= end)
                {
                    countMultiples++;
                }

                currentN += n;
            }

            Console.WriteLine($"Числу {n} есть {countMultiples} кратных чисел");
        }
    }
}
