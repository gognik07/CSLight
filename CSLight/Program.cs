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
            int maxValue = 101;
            int randomNumber = random.Next(minValue, maxValue);
            int baseTwo = 2;
            int power = 0;
            int currentValue = 1;

            while (currentValue < randomNumber)
            {
                power++;
                currentValue *= baseTwo;
            }

            Console.WriteLine($"Для заданого числа {randomNumber} нужна степень двойки {power} = {currentValue}");
        }
    }
}
