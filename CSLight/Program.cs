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
            const string AddDossierCommand = "1";
            const string DeleteDossierCommand = "2";
            const string ViewAllDossiersCommand = "3";
            const string ExitCommand = "4";

            Dictionary<string, List<string>> positions = new Dictionary<string, List<string>>();
            bool isOpen = true;
            string userInput;

            while (isOpen)
            {
                Console.WriteLine("Список команд:" +
                    $"\n{AddDossierCommand} - Добавление сотрудника" +
                    $"\n{DeleteDossierCommand} - Удаление сотрудника" +
                    $"\n{ViewAllDossiersCommand} - Показ полной информации" +
                    $"\n{ExitCommand} - Выход");
                Console.Write("Введите команду: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case AddDossierCommand:
                        positions = AddDossier(positions);
                        break;
                    case ViewAllDossiersCommand:
                        ViewAllDossiers(positions);
                        break;
                    case DeleteDossierCommand:
                        positions = DeleteDossier(positions);
                        break;
                    case ExitCommand:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }

                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
                Console.Clear();
            }

        }

        private static Dictionary<string, List<string>> DeleteDossier(Dictionary<string, List<string>> positions)
        {
            bool isDeleted = false;
            string deletedPosition = null;
            Console.Write("Введите имя удаляемого сотрудника: ");
            string deletedEmployee = Console.ReadLine();

            foreach (var position in positions)
            {
                if (position.Value.Contains(deletedEmployee))
                {
                    position.Value.Remove(deletedEmployee);

                    if (position.Value.Count == 0)
                    {
                        deletedPosition = position.Key;
                        Console.WriteLine($"Позиция {position.Key} будет удалена");
                    }

                    isDeleted = true;
                }
            }

            if (isDeleted == false)
            {
                Console.WriteLine("Сотрудник не найден");
            }

            if (deletedPosition != null)
            {
                positions.Remove(deletedPosition);
            }

            return positions;
        }

        private static void ViewAllDossiers(Dictionary<string, List<string>> positions)
        {
            foreach(var position in positions)
            {
                Console.WriteLine($"На должности {position.Key} работают: {string.Join(", ", position.Value)}");
            }
        }

        private static Dictionary<string, List<string>> AddDossier(Dictionary<string, List<string>> positions)
        {
            Console.Write("Введите имя нового сотрудника: ");
            string newDossier = Console.ReadLine();

            if (ContainsEmployee(positions, newDossier))
            {
                Console.WriteLine("Такой сотрудник уже работает на другой должности");
            }
            else
            {
                Console.Write("Введите должность нового сотрудника: ");
                string newPosition = Console.ReadLine();

                if (positions.ContainsKey(newPosition))
                {
                    positions[newPosition].Add(newDossier);
                }
                else
                {
                    positions.Add(newPosition, new List<string>() { newDossier });
                }
            }                       

            return positions;
        }

        private static bool ContainsEmployee(Dictionary<string, List<string>> positions, string employee)
        {
            foreach (var position in positions)
            {
                if (position.Value.Contains(employee))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
