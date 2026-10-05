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

            int rowCount = 3;
            int columnCount;

            Console.Write("Введите символ для рамки: ");
            symbol = Console.ReadLine();
            Console.Write("Введите выводимое имя: ");
            name = Console.ReadLine();

            string printName = symbol + name + symbol;
            columnCount = printName.Length;

            for (int j = 0; j < columnCount; j++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine($"\n{printName}");

            for (int j = 0; j < columnCount; j++)
            {
                Console.Write(symbol);
            }
        }
    }
}
