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
            int readNumber = ReadInt();
            Console.WriteLine($"Введенное число = {readNumber}");
        }

        static int ReadInt()
        {
            int readNumber = 0;
            bool isNumber = false;

            while (isNumber == false)
            {
                Console.Write("Введите число: ");
                isNumber = int.TryParse(Console.ReadLine(), out readNumber);

                if (isNumber == false)
                {
                    Console.WriteLine("Это не число");
                }
            }

            return readNumber;
        }
    }
}
