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
            Player player = new Player(5, 10, '@');
            Renderer renderer = new Renderer();
            renderer.Render(player);
        }
    }

    class Player
    {
        public int CoordinateX { get; private set; }

        public int CoordinateY { get; private set; }

        public char Symbol { get; private set; }


        public Player(int coordinateX, int coordinateY, char symbol)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            Symbol = symbol;
        }
    }

    class Renderer
    {
        public void Render(Player player)
        {
            Console.SetCursorPosition(player.CoordinateX, player.CoordinateY);
            Console.Write(player.Symbol);
        }
    }
}
