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
            char[,] worldMap = CreateWorldMap();
            int coordinateHeroX = 3;
            int coordinateHeroY = 1;
            char symbolHero = '@';
            bool isGameOver = false;
            ConsoleKeyInfo action;

            while (isGameOver == false)
            {
                Console.Clear();
                PrintMap(worldMap);
                PrintHero(coordinateHeroX, coordinateHeroY, symbolHero);

                action = GetAction();
                MoveHero(ref coordinateHeroX, ref coordinateHeroY, action, worldMap);

                if (action.Key == ConsoleKey.Escape)
                {
                    isGameOver = true;
                }
            }

            Console.SetCursorPosition(0, 12);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER!!!");

        }

        private static void MoveHero(ref int coordinateHeroX, ref int coordinateHeroY, ConsoleKeyInfo action, char[,] worldMap)
        {
            switch(action.Key)
            {
                case ConsoleKey.UpArrow:
                    if (worldMap[coordinateHeroY - 1, coordinateHeroX] != '#')
                    {
                        coordinateHeroY--;
                    }                    
                    break;
                case ConsoleKey.DownArrow:
                    if (worldMap[coordinateHeroY + 1, coordinateHeroX] != '#')
                    {
                        coordinateHeroY++;
                    }                    
                    break;
                case ConsoleKey.LeftArrow:
                    if (worldMap[coordinateHeroY, coordinateHeroX - 1] != '#')
                    {
                        coordinateHeroX--;
                    }                    
                    break;
                case ConsoleKey.RightArrow:
                    if (worldMap[coordinateHeroY, coordinateHeroX + 1] != '#')
                    {
                        coordinateHeroX++;
                    }
                    break;
            }
        }

        private static void PrintHero(int coordinateHeroX, int coordinateHeroY, char symbolHero)
        {
            Console.SetCursorPosition(coordinateHeroX, coordinateHeroY);
            Console.Write(symbolHero);
        }

        private static ConsoleKeyInfo GetAction()
        {
            ConsoleKeyInfo action = Console.ReadKey(intercept: true);
            bool isRightAction = false;

            while (isRightAction == false)
            {
                if (action.Key == ConsoleKey.RightArrow || action.Key == ConsoleKey.LeftArrow || action.Key == ConsoleKey.UpArrow || action.Key == ConsoleKey.DownArrow || action.Key == ConsoleKey.Escape)
                {
                    isRightAction = true;
                }
                else
                {
                    Console.SetCursorPosition(15, 0);
                    ConsoleColor defaultColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректная команда");
                    Console.ForegroundColor = defaultColor;
                    action = Console.ReadKey(intercept: true);
                }
            }

            return action;
        }

        private static char[,] CreateWorldMap()
        {
            return new char[10, 10]
            {
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#'},
                {'#', '#', '#', '#', ' ', ' ', ' ', '#', ' ', '#'},
                {'#', ' ', ' ', '#', ' ', ' ', ' ', '#', '#', '#'},
                {'#', ' ', '#', '#', ' ', ' ', ' ', '#', ' ', '#'},
                {'#', ' ', '#', '#', ' ', ' ', ' ', '#', ' ', '#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
            };
        }

        private static void PrintMap(char[,] worldMap)
        {
            for (int i = 0; i < worldMap.GetLength(0); i++)
            {
                for (int j = 0; j < worldMap.GetLength(1); j++)
                {
                    Console.Write(worldMap[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
