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
            string expression = "(()((())))";
            int openBrackets = 0;
            int maxBrackets = 0;
            bool isCorrect = true;

            foreach (char bracket in expression)
            {
                if (bracket == '(')
                {
                    openBrackets++;

                    if (openBrackets > maxBrackets)
                    {
                        maxBrackets = openBrackets;
                    }
                }
                else if ( bracket == ')')
                {
                    if (openBrackets == 0)
                    {
                        isCorrect = false;
                        break;
                    }

                    openBrackets--;
                }
            }

            isCorrect = isCorrect && openBrackets == 0;

            if (isCorrect)
            {
                Console.WriteLine($"Строка корректная и максимум глубины равняется {maxBrackets}");
            }
            else
            {
                Console.WriteLine("Некорректная строка");
            }

        }
    }
}
