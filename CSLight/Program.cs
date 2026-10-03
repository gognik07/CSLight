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
            Random rand = new Random();
            int minNumber = 0;
            int maxNumber = 101;
            int randomNumber = rand.Next(minNumber, maxNumber);
            int sum = 0;
            int divThree = 3;
            int divFive = 5;

            Console.WriteLine($"Выбрано число {randomNumber}");

            for (int i = 0; i <= randomNumber; i++)
            {
                if (i > 0 && (i / divThree == 0 || i / divFive == 0))
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Сумма = {sum}");
        }
    }
}
