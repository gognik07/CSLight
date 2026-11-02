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
            Player player = new Player("hero", 100, 50);
            player.ShowCharacteristics();
        }
    }

    class Player
    {
        private string _name;

        private int _health;

        private int _mana;

        public Player(string name, int health, int mana)
        {
            _name = name;
            _health = health;
            _mana = mana;
        }

        public void ShowCharacteristics()
        {
            Console.WriteLine($"Имя игрока - {_name}");
            Console.WriteLine($"Здоровье игрока - {_health}");
            Console.WriteLine($"Мана игрока - {_mana}");
        }
    }
}
