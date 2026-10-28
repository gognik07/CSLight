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
            Queue<int> purchases = new Queue<int>(new int[] { 1500, 2000, 4500, 200 });
            int moneyOnAccount = 0;

            while (purchases.Count > 0)
            {
                MakePurchase(purchases, ref moneyOnAccount);                
            }

            Console.WriteLine($"У вас на счету: {moneyOnAccount}");
        }

        private static void MakePurchase(Queue<int> purchases, ref int moneyOnAccount)
        {
            int currentPurchase = purchases.Dequeue();
            Console.WriteLine($"Текущая покупка стоит: {currentPurchase}");
            moneyOnAccount += currentPurchase;
            Console.WriteLine($"У вас на счету: {moneyOnAccount}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
