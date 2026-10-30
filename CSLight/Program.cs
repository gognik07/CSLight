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
                        AddDossier(ref positions);
                        break;
                    case ViewAllDossiersCommand:
                        ViewAllDossiers(positions);
                        break;
                    case DeleteDossierCommand:
                        DeleteDossier(ref positions);
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

        private static void DeleteDossier(ref Dictionary<string, List<string>> positions)
        {
            Console.WriteLine("В компании есть следующие должности:");
            ShowNumericArray(positions.Keys.ToList());
            Console.Write("Введите должность: ");
            string deletedPosition = Console.ReadLine();

            if (positions.ContainsKey(deletedPosition) == false)
            {
                Console.WriteLine("Некорректное значение");
                return;
            }

            Console.WriteLine("Выберите сотрудника:");
            ShowNumericArray(positions[deletedPosition]);
            Console.Write("Введите номер сотрудника: ");
            int numberEmployee = Convert.ToInt32(Console.ReadLine()) - 1;

            if (numberEmployee < 0 || positions[deletedPosition].Count < numberEmployee)
            {
                Console.WriteLine("Некоректный номер");
                return;
            }

            positions[deletedPosition].RemoveAt(numberEmployee);

            if (positions[deletedPosition].Count <= 0)
            {
                positions.Remove(deletedPosition);
                Console.WriteLine($"Позиция {deletedPosition} удалена");
            }
        }

        private static void ViewAllDossiers(Dictionary<string, List<string>> positions)
        {
            foreach(var position in positions)
            {
                Console.WriteLine($"На должности {position.Key} работают:");
                ShowNumericArray(position.Value);
            }
        }

        private static void AddDossier(ref Dictionary<string, List<string>> positions)
        {           
            Console.Write("Введите имя нового сотрудника: ");
            string newDossier = Console.ReadLine();

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

        private static void ShowNumericArray(List<string> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {array[i]}");
            }
        }
    }
}
