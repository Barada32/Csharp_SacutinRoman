//#define BANK_VKLAD_1
//#define DRAKA_2
//#define RANDOM_3
#define  FIGHT_4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

#if BANK_VKLAD_1
            float money;
            int years;
            int percent;
            Console.WriteLine("Введите количество денег, внесенных на вклад: ");
            money = Convert.ToSingle(Console.ReadLine());
            Console.Write("На сколько лет открыт вклад: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Под какой процент?");
            percent = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine("Через " + (i + 1) + "году у вас " + money);
                Console.ReadKey();
            } 
#endif

#if DRAKA_2

            int playerHealth = 100 ;
            int playerDamage = 10;
            int enemyHealth = 100;
            int enemyDamage = 10;
            while (playerHealth>0&&enemyHealth>0)
            {
                playerHealth-=enemyDamage; 
                enemyHealth-=playerDamage ;
                Console.WriteLine(playerHealth+" игрок.");
                Console.WriteLine(enemyHealth+" враг.");
            }
            if (playerHealth<=0&&enemyHealth<=0) { Console.WriteLine("Ничья"); }

#endif
#if RANDOM_3
            int number;
            int lower, higher;
            int tiresCount = 5;
            int userInput;
            Random random = new Random();

            number = random.Next(0, 101);
            lower = random.Next(number - 10, number);
            higher = random.Next(number + 1, number + 10);
            Console.WriteLine($"Мы загадали число от 0 до 100 и оно больше чем {lower} " + $"но больше чем {higher}.");
            Console.WriteLine($"Что это за число?У Вас осталось {tiresCount} попыток");
            while (tiresCount-- > 0)
            {
                Console.WriteLine("Ваш ответ: ");
                userInput = Convert.ToInt32(Console.ReadLine()) ;
                if (userInput == number)
                {
                    Console.WriteLine("Вы правы, это было число " + number + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Не верно попробуйте еще раз.");
                }
            }
            if (tiresCount < 0) 
            { 
            Console.WriteLine("Вы проиграли,увы но повезет в следующий раз.Это было число" + number + ".");
            }





#endif
#if FIGHT_4
            Random rand = new Random();

            float health1 = rand.Next(30, 50);
            int damage1 = rand.Next(20, 25);
            int armor1 = rand.Next(25, 65);

            int armor2 = rand.Next(155, 250);
            int damage2 = rand.Next(21, 25);
            float health2 = rand.Next(133, 144);
            Console.WriteLine($"Гладиатор 1 ={health1} здоровья ,{damage1} наносимый урон, {armor1} броня");
            Console.WriteLine($"Гладиатор 2 ={health2} здоровья ,{damage2} наносимый урон, {armor2} броня");
            while (health1 > 0 && health2 > 0)
            {
                health1 -=Convert.ToSingle(rand.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;
                Console.WriteLine("Здоровье гладиатора 1: "+health1);
                Console.WriteLine("Здоровье гладиатора 2: "+health2);
                if (health1 <= 0 &&health2 <= 0) 
                { Console.WriteLine("Ничья.Оба погибли"); }
                else if (health1 <= 0) { Console.WriteLine("Гладиатор 1 пал"); }
                else if (health2 <= 0) { Console.WriteLine("Гладиатор 2 пал"); }
            }
#endif



        }
    }
}
