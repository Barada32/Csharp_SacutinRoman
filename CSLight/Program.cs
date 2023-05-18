﻿//#define BANK_VKLAD_1
//#define DRAKA_2
//#define RANDOM_3
//#define  FIGHT_4
//#define WORK_WITH_CONSOLE_5

//#define ARRAYS_6_1
//#define ARRAYS_6_2
//#define ARRAYS_MIN_MAX_7
//#define TIKET_PROGRAMM_8
#define D2_ARRAYS

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
#if WORK_WITH_CONSOLE_5
            Console.WindowHeight = 12;
            Console.WindowWidth = 35;
            Console.WriteLine("Привет анд");
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(5, 10);
            Console.ReadKey();
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor= ConsoleColor.Yellow;
            Console.Clear();
            Console.WindowHeight = 10;
            Console.WindowWidth = 35;
            Console.WriteLine("Привет FFFFFFFFFFFFFF");
#endif

#if ARRAYS_6_1
            int[] cucubers = new int[10];

            Random random = new Random();

            Console.WriteLine($"Длинна массива " + cucubers.Length);
            for (int i = 0; i < cucubers.Length; i++)
            {
                cucubers[i] = random.Next(0, 101);
                Console.Write(cucubers[i] + " ");

            } 
#endif //рандомное заполнение массива и вывод на экран

#if ARRAYS_6_2

            int[] cucubers = { 1,2,4,5};
            int sum=0;
          

            Console.WriteLine($"Длинна массива " + cucubers.Length);
            for (int i = 0; i < cucubers.Length; i++)
            {
               
                Console.WriteLine("Значение элемента на позиции "+i+" равно "+ cucubers[i] + " ");
                sum += cucubers[i];
               
            } 
            Console.Write("сумма массива равна " + sum);

#endif //ручное заполнение

#if ARRAYS_MIN_MAX_7
            int[] arr = { 1, 2, 4, 5 };
            int maxElement = int.MinValue;
            int minElement = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (maxElement < arr[i]  ) { maxElement = arr[i]; }
                if (arr[i] < minElement) { minElement = arr[i]; }
            }
            Console.WriteLine("Минимальный элемент = " + minElement);
            Console.WriteLine("Максимальный элемент = "+ maxElement);

#endif

#if TIKET_PROGRAMM_8


            int[] sectors = { 6, 28, 15, 15, 17 };
            bool isOpen = true;
            while (isOpen == true)
            {
                Console.SetCursorPosition(0, 15);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест");
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса.");
                Console.WriteLine("\n\n1- забронировать места\n \n2 - выход из программы\n");
                Console.Write("Введите номер команды.");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write("В каком секторе вы хотите лететь?");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sectors.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("Такого сектора не существует.");
                            break;
                        }

                        Console.Write("Сколько мест вы хотите забронировать?");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (userPlaceAmount < 0) { Console.WriteLine("Неверное количество мест"); break; }
                        if (sectors[userSector] < userPlaceAmount)
                        {

                            Console.WriteLine($"В секторе {userSector} недостаточно мест." +
                                $"Остаток {sectors[userSector]} ");
                            break;
                        }
                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("Бронирование успешно!");
                        break;
                    case 2:
                        isOpen = false;
                        break;


                }
                Console.ReadKey();
                Console.Clear();

            } 
#endif //бронирование мест по секторам в массиве 


            int[,] array = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < array.GetLength(0); i++)
            {for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.WriteLine($"Значение элемента{j} массива в строке {i}  равно " + array[i,j] );
                }
            
            }


        }
    }
}
