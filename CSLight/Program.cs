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
            string name;
            Console.Write("Как вас зовут? ");
            name = Console.ReadLine();

            int age;
            Console.Write("Сколько вам лет? ");
            age = Convert.ToInt32(Console.ReadLine());

            String zodiacSign;
            Console.Write("Какой у вас знак зодиака? ");
            zodiacSign = Console.ReadLine();

            String placeWork;
            Console.Write("Где вы работаете? ");
            placeWork = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age} лет, вы {zodiacSign} и работаете на {placeWork}.");
        }
    }
}
