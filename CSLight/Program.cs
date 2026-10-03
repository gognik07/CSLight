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

            Console.WriteLine($"Выбрано число {randomNumber}");

            for (int i = 0; i <= randomNumber; i++)
            {
                if (i > 0 && (i % 3 == 0 || i % 5 == 0))
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Сумма = {sum}");
        }
    }
}
