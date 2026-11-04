using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string AddPlayerCommand = "add";
            const string BanPlayerCommand = "ban";
            const string UnbanPlayerCommand = "unban";
            const string DeletePlayerCommand = "delete";
            const string ExitCommand = "exit";

            DatabasePalyers databasePalyers = new DatabasePalyers();
            bool isOpen = true;
            string inputUser;

            while (isOpen)
            {
                databasePalyers.ShowInfo();
                Console.WriteLine();

                Console.WriteLine("Доступные команды:" +
                    $"\n{AddPlayerCommand} - Добавление игрока" +
                    $"\n{BanPlayerCommand} - Бан игрока" +
                    $"\n{UnbanPlayerCommand} - Разбан игрока" +
                    $"\n{DeletePlayerCommand} - Удаление игрока" +
                    $"\n{ExitCommand} - Выход");
                Console.Write("Введите команду: ");
                inputUser = Console.ReadLine();

                switch(inputUser)
                {
                    case AddPlayerCommand:
                        databasePalyers.AddPlayer(Player.CreatePlayer());
                        break;
                    case BanPlayerCommand:
                        databasePalyers.BanPlayerById(Player.GetPlayerId());
                        break;
                    case UnbanPlayerCommand:
                        databasePalyers.UnbanPlayerById(Player.GetPlayerId());
                        break;
                    case DeletePlayerCommand:
                        databasePalyers.DeletePlayerById(Player.GetPlayerId());
                        break;
                    case ExitCommand:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }        
    }

    class Player
    {
        private int _id;

        private string _nickName;

        private int _level;

        private bool _isBan;

        public Player(int id, string nickName, int level, bool isBan)
        {
            _id = id;
            _nickName = nickName;
            _level = level;
            _isBan = isBan;
        }

        public int Id
        {
            get { return _id; }
        }

        public void Ban()
        {
            _isBan = true;
        }

        public void Unban()
        {
            _isBan = false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Игрок {_id}: {_nickName}, уровня {_level}, статус = {GetBanString()}");
        }

        public static Player CreatePlayer()
        {
            int id = GetPlayerId();

            Console.Write("Введите имя никнейм: ");
            string nickName = Console.ReadLine();

            Console.Write("Введите Уровень: ");
            int level = 0;
            int.TryParse(Console.ReadLine(), out level);

            return new Player(id, nickName, level, false);
        }

        public static int GetPlayerId()
        {
            string inputUser;
            int playerId = -1;
            bool isInt = false;

            while (isInt == false)
            {
                Console.Write("Введите ID игрока: ");
                inputUser = Console.ReadLine();
                isInt = int.TryParse(inputUser, out playerId);
            }

            return playerId;
        }

        private string GetBanString()
        {
            if (_isBan)
            {
                return "Забанен";
            }
            else
            {
                return "Разбанен";
            }
        }
    }

    class DatabasePalyers
    {
        List<Player> _players;

        public DatabasePalyers()
        {
            _players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (ExistPlayer(player.Id) == false)
            {
                _players.Add(player);
            }
            else
            {
                Console.WriteLine($"Игрок с id = {player.Id} уже есть в БД");
            }
        }

        public void AddPlayer(int playerId, string playerNickName, int playerLevel)
        {
            if (ExistPlayer(playerId) == false)
            {
                _players.Add(new Player(playerId, playerNickName, playerLevel, false));
            }
            else
            {
                Console.WriteLine($"Игрок с id = {playerId} уже есть в БД");
            }
        }

        public void BanPlayerById(int playerId)
        {
            if (ExistPlayer(playerId) == false)
            {
                Console.WriteLine("Такого игрока нет в БД");
            }
            else
            {
                foreach (Player player in _players)
                {
                    if (player.Id == playerId)
                    {
                        player.Ban();
                    }
                }
            }
        }

        public void UnbanPlayerById(int playerId)
        {
            if (ExistPlayer(playerId) == false)
            {
                Console.WriteLine("Такого игрока нет в БД");
            }
            else
            {
                foreach (Player player in _players)
                {
                    if (player.Id == playerId)
                    {
                        player.Unban();
                    }
                }
            }
        }

        public void DeletePlayerById(int playerId)
        {
            if (ExistPlayer(playerId) == false)
            {
                Console.WriteLine("Такого игрока нет в БД");
            }
            else
            {
                _players.Remove(GetPlayerById(playerId));
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Текущая информация по БД");

            foreach (Player player in _players)
            {
                player.ShowInfo();
            }
        }

        private Player GetPlayerById(int playerId)
        {
            foreach (Player player in _players)
            {
                if (player.Id == playerId)
                {
                    return player;
                }
            }    

            return null;
        }

        private bool ExistPlayer(int playerId)
        {
            return GetPlayerById(playerId) != null;            
        }        
    }
}
