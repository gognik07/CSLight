using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {

        private const string ConvertRubToUsdCommand = "1";
        private const string ConvertRubToEuroCommand = "2";
        private const string ConvertUsdToRubCommand = "3";
        private const string ConvertUsdToEuroCommand = "4";
        private const string ConvertEuroToRubCommand = "5";
        private const string ConvertEuroToUsdCommand = "6";
        private const string ExitCommand = "7";

        static void Main(string[] args)
        {
            float rubToUsd = 85.1f;
            float rubToEuro = 97.2f;

            float usdToRub = 0.012f;
            float usdToEuro = 0.89f;

            float euroToRub = 0.011f;
            float euroToUsd = 1.13f;

            float balanceRub = 5000;
            float balanceUsd = 400;
            float balanceEuro = 0;

            string currentCommand;
            float countCurrency = 0;
            float moneyForPurchase;

            Console.WriteLine("Обмен валют!");
            
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine($"\nВаш баланс: {balanceRub} рублей, {balanceUsd} долларов, {balanceEuro} евро");
                Console.WriteLine("\nВыберите желаемое действие:" +
                    $"\n{ConvertRubToUsdCommand} - Покупка долларов за рубли" +
                    $"\n{ConvertRubToEuroCommand} - Покупка евро за рубли" +
                    $"\n{ConvertUsdToRubCommand} - Покупка рублей за доллары" +
                    $"\n{ConvertUsdToEuroCommand} - Покупка евро за доллары" +
                    $"\n{ConvertEuroToRubCommand} - Покупка рублей за евро" +
                    $"\n{ConvertEuroToUsdCommand} - Покупка долларов за евро" +
                    $"\n{ExitCommand} - Выход");
                Console.Write("Команда: ");
                currentCommand = Console.ReadLine();

                if (currentCommand == ConvertRubToUsdCommand 
                    || currentCommand == ConvertRubToEuroCommand
                    || currentCommand == ConvertUsdToRubCommand
                    || currentCommand == ConvertUsdToEuroCommand
                    || currentCommand == ConvertEuroToRubCommand
                    || currentCommand == ConvertEuroToUsdCommand
                    )
                {
                    Console.Write("Введите сколько валюты хотите купить: ");
                    countCurrency = Convert.ToSingle(Console.ReadLine());
                    if (countCurrency < 0)
                    {
                        Console.WriteLine("Нельзя купить отрицательную сумму");
                        continue;
                    }
                }

                switch (currentCommand)
                {
                    case ConvertRubToUsdCommand:                       
                        moneyForPurchase = countCurrency * rubToUsd;
                        if (moneyForPurchase > balanceRub)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} рублей");
                        }
                        else
                        {
                            balanceRub -= moneyForPurchase;
                            balanceUsd += countCurrency;
                        }
                        break;
                    case ConvertRubToEuroCommand:
                        moneyForPurchase = countCurrency * rubToEuro;
                        if (moneyForPurchase > balanceRub)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} рублей");
                        }
                        else
                        {
                            balanceRub -= moneyForPurchase;
                            balanceEuro += countCurrency;
                        }
                        break;
                    case ConvertUsdToRubCommand:
                        moneyForPurchase = countCurrency * usdToRub;
                        if (moneyForPurchase > balanceUsd)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} долларов");
                        }
                        else
                        {
                            balanceUsd -= moneyForPurchase;
                            balanceRub += countCurrency;
                        }
                        break;
                    case ConvertUsdToEuroCommand:
                        moneyForPurchase = countCurrency * usdToEuro;
                        if (moneyForPurchase > balanceUsd)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} долларов");
                        }
                        else
                        {
                            balanceUsd -= moneyForPurchase;
                            balanceEuro += countCurrency;
                        }
                        break;
                    case ConvertEuroToRubCommand:
                        moneyForPurchase = countCurrency * euroToRub;
                        if (moneyForPurchase > balanceEuro)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} евро");
                        }
                        else
                        {
                            balanceEuro -= moneyForPurchase;
                            balanceRub += countCurrency;
                        }
                        break;
                    case ConvertEuroToUsdCommand:
                        moneyForPurchase = countCurrency * euroToUsd;
                        if (moneyForPurchase > balanceEuro)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} евро");
                        }
                        else
                        {
                            balanceEuro -= moneyForPurchase;
                            balanceUsd += countCurrency;
                        }
                        break;
                    case ExitCommand:
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }
            }

            Console.WriteLine("Хорошего дня");
        }
    }
}
