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
            int startNumber = 5;
            int endNumber = 103;
            int step = 7;
        
            // Цикл for, т.к. известно последнее число
            for(int i = startNumber; i <= endNumber; i += step)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
