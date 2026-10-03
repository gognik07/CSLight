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
            string userInput;
            int countOutputs;

            Console.Write("Введите строку для вывода: ");
            userInput = Console.ReadLine();
            Console.Write("Введите сколько раз нужно вывести строку");
            countOutputs = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countOutputs; i++)
            {
                Console.WriteLine(userInput);
            }
        }
    }
}
