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
            const string AttackCommand = "attack";
            const string FireBallCommand = "fireball";
            const string FireBlastCommand = "blast";
            const string CureCommand = "cure";
            const int FullHealth = 200;
            const int FullMana = 100;

            int heroHealth = FullHealth;
            int heroAttack = 35;
            int heroMana = FullMana;
            int fireBlast = 70;
            int fireBallMana = 40;
            bool isActivatedFireBall = false;
            int countCure = 2;
            int cureMana = 50;
            int cureHealth = 100;

            Random random = new Random();
            int minBossAttack = 40;
            int maxBossAttack = 100;
            int bossHealth = 150;

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
                    $"\n{AttackCommand} - атака" +
                    $"\n{FireBallCommand} - Огненный шар(требуется маны {fireBallMana})" +
                    $"\n{FireBlastCommand} - Взрыв" +
                    $"\n{CureCommand} - Лечение(Восстанваливает {cureHealth} здоровья, {cureMana} маны)");
                Console.Write("Введите действие: ");
                inputCommand = Console.ReadLine();

                switch (inputCommand)
                {
                    case AttackCommand:
                        bossHealth -= heroAttack;
                        break;
                    case FireBallCommand:
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
                    case FireBlastCommand:
                        if (isActivatedFireBall == false)
                        {
                            Console.WriteLine("У вас нет огненного шара для взрыва");
                        }
                        else
                        {
                            bossHealth -= fireBlast;
                            isActivatedFireBall = false;
                        }
                        break;
                    case CureCommand:
                        if (countCure > 0)
                        {
                            heroHealth += cureHealth;
                            if (heroHealth > FullHealth)
                            {
                                heroHealth = FullHealth;
                            }

                            heroMana += cureMana;
                            if (heroMana > FullMana)
                            {
                                heroMana = FullMana;
                            }

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
