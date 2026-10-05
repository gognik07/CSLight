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

            const string ConvertRubelToDollarCommand = "1";
            const string ConvertRubelToEuroCommand = "2";
            const string ConvertDollarToRubelCommand = "3";
            const string ConvertDollarToEuroCommand = "4";
            const string ConvertEuroToRubelCommand = "5";
            const string ConvertEuroToDollarCommand = "6";
            const string ExitCommand = "7";

            float rubelToDollar = 85.1f;
            float rubelToEuro = 97.2f;

            float dollarToRubel = 0.012f;
            float dollarToEuro = 0.89f;

            float euroToRubel = 0.011f;
            float euroToDollar = 1.13f;

            float balanceRubel = 5000;
            float balanceDollar = 400;
            float balanceEuro = 0;

            string currentCommand;
            float countCurrency = 0;
            float moneyForPurchase;

            Console.WriteLine("Обмен валют!");
            
            bool isExit = false;

            while (!isExit)
            {
                Console.WriteLine($"\nВаш баланс: {balanceRubel} рублей, {balanceDollar} долларов, {balanceEuro} евро");
                Console.WriteLine("\nВыберите желаемое действие:" +
                    $"\n{ConvertRubelToDollarCommand} - Покупка долларов за рубли" +
                    $"\n{ConvertRubelToEuroCommand} - Покупка евро за рубли" +
                    $"\n{ConvertDollarToRubelCommand} - Покупка рублей за доллары" +
                    $"\n{ConvertDollarToEuroCommand} - Покупка евро за доллары" +
                    $"\n{ConvertEuroToRubelCommand} - Покупка рублей за евро" +
                    $"\n{ConvertEuroToDollarCommand} - Покупка долларов за евро" +
                    $"\n{ExitCommand} - Выход");
                Console.Write("Команда: ");
                currentCommand = Console.ReadLine();

                switch (currentCommand)
                {
                    case ConvertRubelToDollarCommand:
                        Console.Write("Введите сколько валюты хотите купить: ");
                        countCurrency = Convert.ToSingle(Console.ReadLine());
                        if (countCurrency < 0)
                        {
                            Console.WriteLine("Нельзя купить отрицательную сумму");
                            continue;
                        }
                        moneyForPurchase = countCurrency * rubelToDollar;
                        if (moneyForPurchase > balanceRubel)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} рублей");
                        }
                        else
                        {
                            balanceRubel -= moneyForPurchase;
                            balanceDollar += countCurrency;
                        }
                        break;
                    case ConvertRubelToEuroCommand:
                        Console.Write("Введите сколько валюты хотите купить: ");
                        countCurrency = Convert.ToSingle(Console.ReadLine());
                        if (countCurrency < 0)
                        {
                            Console.WriteLine("Нельзя купить отрицательную сумму");
                            continue;
                        }
                        moneyForPurchase = countCurrency * rubelToEuro;
                        if (moneyForPurchase > balanceRubel)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} рублей");
                        }
                        else
                        {
                            balanceRubel -= moneyForPurchase;
                            balanceEuro += countCurrency;
                        }
                        break;
                    case ConvertDollarToRubelCommand:
                        Console.Write("Введите сколько валюты хотите купить: ");
                        countCurrency = Convert.ToSingle(Console.ReadLine());
                        if (countCurrency < 0)
                        {
                            Console.WriteLine("Нельзя купить отрицательную сумму");
                            continue;
                        }
                        moneyForPurchase = countCurrency * dollarToRubel;
                        if (moneyForPurchase > balanceDollar)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} долларов");
                        }
                        else
                        {
                            balanceDollar -= moneyForPurchase;
                            balanceRubel += countCurrency;
                        }
                        break;
                    case ConvertDollarToEuroCommand:
                        Console.Write("Введите сколько валюты хотите купить: ");
                        countCurrency = Convert.ToSingle(Console.ReadLine());
                        if (countCurrency < 0)
                        {
                            Console.WriteLine("Нельзя купить отрицательную сумму");
                            continue;
                        }
                        moneyForPurchase = countCurrency * dollarToEuro;
                        if (moneyForPurchase > balanceDollar)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} долларов");
                        }
                        else
                        {
                            balanceDollar -= moneyForPurchase;
                            balanceEuro += countCurrency;
                        }
                        break;
                    case ConvertEuroToRubelCommand:
                        Console.Write("Введите сколько валюты хотите купить: ");
                        countCurrency = Convert.ToSingle(Console.ReadLine());
                        if (countCurrency < 0)
                        {
                            Console.WriteLine("Нельзя купить отрицательную сумму");
                            continue;
                        }
                        moneyForPurchase = countCurrency * euroToRubel;
                        if (moneyForPurchase > balanceEuro)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} евро");
                        }
                        else
                        {
                            balanceEuro -= moneyForPurchase;
                            balanceRubel += countCurrency;
                        }
                        break;
                    case ConvertEuroToDollarCommand:
                        Console.Write("Введите сколько валюты хотите купить: ");
                        countCurrency = Convert.ToSingle(Console.ReadLine());
                        if (countCurrency < 0)
                        {
                            Console.WriteLine("Нельзя купить отрицательную сумму");
                            continue;
                        }
                        moneyForPurchase = countCurrency * euroToDollar;
                        if (moneyForPurchase > balanceEuro)
                        {
                            Console.WriteLine($"У вас недостаточно средств. Требуется {moneyForPurchase} евро");
                        }
                        else
                        {
                            balanceEuro -= moneyForPurchase;
                            balanceDollar += countCurrency;
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
