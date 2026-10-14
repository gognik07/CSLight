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
            const string ViewAllDossiersCommand = "2";
            const string DeleteDossierCommand = "3";
            const string FindByLastNameCommand = "4";
            const string ExitCommand = "5";

            string[] employees = new string[0];
            string[] positions = new string[0];
            bool isOpen = true;
            string userInput;

            while (isOpen)
            {
                Console.WriteLine("Список команд:" +
                    $"\n{AddDossierCommand} - Добавить досье" +
                    $"\n{ViewAllDossiersCommand} - Показать все досье" +
                    $"\n{DeleteDossierCommand} - Удалить досье" +
                    $"\n{FindByLastNameCommand} - Поиск по фамилии" +
                    $"\n{ExitCommand} - Выход");
                Console.Write("Введите команду: ");
                userInput = Console.ReadLine();

                switch(userInput)
                {
                    case AddDossierCommand:
                        AddDossier(ref employees, ref positions);
                        break;
                    case ViewAllDossiersCommand:
                        ViewAllDossiers(employees, positions);
                        break;
                    case DeleteDossierCommand:
                        DeleteDossier(ref employees, ref positions);
                        break;
                    case FindByLastNameCommand:
                        FindByLastName(employees, positions);
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

        private static void DeleteDossier(ref string[] employees, ref string[] positions)
        {
            const string DeleteByNumberCommand = "1";
            const string DeleteByFullNameCommand = "2";

            if (employees.Length <= 0)
            {
                Console.WriteLine("В базе нет досье для удаления");
                return;
            }

            string userInput;

            Console.WriteLine("\nУдаление по:" +
                    $"\n{DeleteByNumberCommand} - Порядковому номеру" +
                    $"\n{DeleteByFullNameCommand} - ФИО сотрудника");
            Console.Write("Введите команду: ");
            userInput = Console.ReadLine();

            switch (userInput) 
            {
                case DeleteByNumberCommand:
                    DeleteDossierByNumber(ref employees, ref positions);
                    break;
                case DeleteByFullNameCommand:
                    DeleteDossierByFullName(ref employees, ref positions);
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
        }

        private static void DeleteDossierByFullName(ref string[] employees, ref string[] positions)
        {
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();

            bool isDeleted = false;

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].ToLower() == fullName.ToLower())
                {
                    employees[i] = null;
                    positions[i] = null;
                    isDeleted = true;
                    break;
                }
            }

            if (isDeleted)
            {
                employees = NarrowArray(employees);
                positions = NarrowArray(positions);
            }
            else
            {
                Console.WriteLine("Досье не найдено");
            }
        }

        private static void DeleteDossierByNumber(ref string[] employees, ref string[] positions)
        {
            Console.Write("Введите номер досье: ");
            int deletedNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            if (deletedNumber > employees.Length)
            {
                Console.WriteLine($"В базе {employees.Length} досье");
                return;
            }

            if (deletedNumber < 0)
            {
                Console.WriteLine("Некорректный номер досье");
                return;
            }

            employees[deletedNumber] = null;
            positions[deletedNumber] = null;

            employees = NarrowArray(employees);
            positions = NarrowArray(positions);
        }

        private static string[] NarrowArray(string[] array)
        {
            string[] narrowedArray = new string[array.Length - 1];
            int currentElement = 0;

            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] != null)
                {
                    narrowedArray[currentElement++] = array[i];
                }
            }

            return narrowedArray;
        }

        private static void FindByLastName(string[] employees, string[] positions)
        {
            string foundLastName;

            Console.Write("Введите фамилию сотрудника: ");
            foundLastName = Console.ReadLine();

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Split()[0].ToLower() == foundLastName.ToLower())
                {
                    Console.WriteLine($"{employees[i]} ({positions[i]})");
                }
            }
        }

        private static void ViewAllDossiers(string[] employees, string[] positions)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {employees[i]} ({positions[i]})");
            }
        }

        private static void AddDossier(ref string[] employees, ref string[] positions)
        {
            const int CountWorldInFullName = 3;
            string newEmployee = "", newPosition;
            bool isRightEployee = false;

            while (isRightEployee == false)
            {
                Console.Write("Введите имя нового сотрудника: ");
                newEmployee = Console.ReadLine();

                if (newEmployee.Split().Length != CountWorldInFullName)
                {
                    Console.WriteLine($"ФИО сотрудника должно состоять из {CountWorldInFullName} слов");
                }
                else
                {
                    isRightEployee = true;
                }
            }

            Console.Write("Введите должность нового сотрудника: ");
            newPosition = Console.ReadLine();

            employees = ExtendArray(employees);
            positions = ExtendArray(positions);

            employees[employees.Length - 1] = newEmployee;
            positions[positions.Length - 1] = newPosition;
        }

        private static string[] ExtendArray(string[] array)
        {
            string[] extendArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                extendArray[i] = array[i];
            }

            return extendArray;
        }
    }
}
