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
            int minuteConsultation = 10;
            int minutesInHour = 60;

            Console.Write("Введите кол-во пациентов: ");
            int countPeople = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Вы должны отстоять в очереди {countPeople * minuteConsultation / minutesInHour} часа и {countPeople * minuteConsultation % minutesInHour} минут.");
        }
    }
}
