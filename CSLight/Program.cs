//#define BANK_VKLAD_1
//#define DRAKA_2
#define RANDOM_3
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
            Random random = new Random();
            int value;
            while (true)
            { 
                value = random.Next(0,10);
                Console.WriteLine(value);
                Console.ReadKey();
            }
#endif



        }
    }
}
