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
            string firstName = "Ivanov";
            string lastName = "Ivan";
            Console.WriteLine($"BEFORE: firstName = {firstName}, lastName = {lastName}");

            string buffer = firstName;
            firstName = lastName;
            lastName = buffer;
            Console.WriteLine($"AFTER: firstName = {firstName}, lastName = {lastName}");
        }
    }
}
