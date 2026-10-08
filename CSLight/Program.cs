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
            int healthPercent = 40;
            int fullHealth = 10;
            string nameHealthBar = "health";
            PrintBar(healthPercent, fullHealth, nameBar: nameHealthBar);

            int manaPercent = 60;
            int fullMana = 10;
            string nameManaBar = "mana";
            PrintBar(manaPercent, fullMana, ConsoleColor.Blue, coordinateY: 1, nameBar: nameManaBar);
        }

        private static void PrintBar(int fillPercentBar, int fullLenghtBar, ConsoleColor colorBar = ConsoleColor.Red, char symbolBar = ' ', int coordinateX = 0, int coordinateY = 0, string nameBar = "unknown")
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            int fillBar = fullLenghtBar * fillPercentBar / 100;

            Console.SetCursorPosition(coordinateX, coordinateY);
            Console.Write($"{nameBar} [");
            Console.BackgroundColor = colorBar;

            printBar(fillBar, symbolBar);
            
            Console.BackgroundColor = defaultColor;
            char emptySymbol = ' ';

            printBar(fullLenghtBar - fillBar, emptySymbol);
            
            Console.Write("]");
        }

        private static void printBar(int length, char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
