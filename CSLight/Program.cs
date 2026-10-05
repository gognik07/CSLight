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
            //константы
            const string attackCommand = "attack";
            const string fireBallCommand = "fireball";
            const string fireBlastCommand = "blast";
            const string cureCommand = "cure";

            //статы для героя
            int heroHealth = 200;
            int heroAttack = 35;
            int heroMana = 100;
            int fireBlast = 70;
            int fireBallMana = 40;
            bool isActivatedFireBall = false;
            int countCure = 2;
            int cureMana = 50;
            int cureHealth = 100;

            //статы для босса
            Random random = new Random();
            int minBossAttack = 40;
            int maxBossAttack = 100;
            int bossHealth = 150;

            //переменные управления
            string inputCommand;

            while (heroHealth > 0 && bossHealth > 0)
            {
                Console.WriteLine("\nНачало хода" +
                    $"\nВаше здоровье - {heroHealth}, ваша мана - {heroMana}, здоровье босса - {bossHealth}" +
                    $"\nДоступное количичество лечений - {countCure}");

                if (isActivatedFireBall)
                {
                    Console.WriteLine("Огненый шар готов");
                }

                Console.WriteLine("\nДоступные ходы" +
                    $"\n{attackCommand} - атака" +
                    $"\n{fireBallCommand} - Огненный шар(требуется маны {fireBallMana})" +
                    $"\n{fireBlastCommand} - Взрыв" +
                    $"\n{cureCommand} - Лечение(Восстанваливает {cureHealth} здоровья, {cureMana} маны)");
                Console.Write("Введите действие: ");
                inputCommand = Console.ReadLine();

                switch (inputCommand)
                {
                    case attackCommand:
                        bossHealth -= heroAttack;
                        break;
                    case fireBallCommand:
                        if (heroMana >= fireBallMana)
                        {
                            isActivatedFireBall = true;
                            heroMana -= fireBallMana;
                            Console.WriteLine("Вы создали огненный шар");
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно маны для создания огненного шара");
                        }
                        break;
                    case fireBlastCommand:
                        if (!isActivatedFireBall)
                        {
                            Console.WriteLine("У вас нет огненного шара для взрыва");
                        }
                        else
                        {
                            bossHealth -= fireBlast;
                            isActivatedFireBall = false;
                        }
                        break;
                    case cureCommand:
                        if (countCure > 0)
                        {
                            heroHealth += cureHealth;
                            heroMana += cureMana;
                            countCure--;
                        }
                        else
                        {
                            Console.WriteLine("У вас не осталось лечения");
                        }
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда. Вы ничего не делаете");
                        break;
                }

                heroHealth -= random.Next(minBossAttack, maxBossAttack + 1);
            }

            if (heroHealth <= 0 && bossHealth <= 0)
            {
                Console.WriteLine("Пали оба");
            }
            else if (heroHealth <= 0)
            {
                Console.WriteLine("Поражение");
            }
            else if (bossHealth <= 0)
            {
                Console.WriteLine("Победа");
            }
        }
    }
}
