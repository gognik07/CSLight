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
            float priceDiamond = 5.5f;
            Console.WriteLine($"Добро пожаловать в магазин кристалов! 1 кристал = {priceDiamond} золота");

            Console.Write("Введите количество золота, что у вас есть: ");
            float gold = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите количество приобретаемых кристалов: ");
            int countDiamond = Convert.ToInt32(Console.ReadLine());

            gold -= countDiamond * priceDiamond;

            Console.WriteLine($"У вас осталось {gold} золота и {countDiamond} кристалов!");
        }
    }
}
