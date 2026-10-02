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
            int countImages = 52;
            int countImagesInRow = 3;
            int countFullRows = countImages / countImagesInRow;
            int countImagesWithoutFullRow = countImages % countImagesInRow;

            Console.WriteLine($"Количество полностью заполненных рядов = {countFullRows}\nКоличество лишних картинок = {countImagesWithoutFullRow}");
        }
    }
}
