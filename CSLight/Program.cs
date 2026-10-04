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
            string symbol;
            string name;

            int lengthIncrement = 2;
            int rowCount = 3;
            int rowWithName = 1;
            int columnCount;

            Console.Write("Введите символ для рамки: ");
            symbol = Console.ReadLine();
            Console.Write("Введите выводимое имя: ");
            name = Console.ReadLine();

            columnCount = name.Length + lengthIncrement;

            for (int i = 0; i < rowCount; i++)
            {
                Console.WriteLine();
                if (i == rowWithName)
                {
                    Console.Write(symbol + name + symbol);
                }
                else
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        Console.Write(symbol);
                    }
                }
            }

        }
    }
}
