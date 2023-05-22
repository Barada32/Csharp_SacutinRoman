//#define ZMEIKA_S_SUMKOI_1
//#define RANGE_BASED_FOR_2
//#define FUNCTIONS_3
//#define REF_OUT_4
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
#if ZMEIKA_S_SUMKOI_1
            Console.CursorVisible = false;
            char[,] map =
            {
                { '#','#','#','#','#','#','#','#','#','#','#','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#','#','#','#',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ','#',' ',' ','X',' ',' ',' ',' ','#'},
                { '#',' ',' ','#',' ',' ',' ',' ','X',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ','X',' ',' ','X',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ','X',' ','x',' ','x','x',' ','X',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#','#','#','#','#','#','#','#','#','#','#','#'}


            };
            int userX = 6; int userY = 6;
            char[] bag = new char[1];





            while (true)
            {
                Console.SetCursorPosition(0, 20); Console.Write("Сумка: ");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }



                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {

                        Console.Write(map[i, j]);

                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(userY, userX);
                Console.Write('@');
                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    case ConsoleKey.W:
                        if (map[userX - 1, userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.S:
                        if (map[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.D:
                        if (map[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;
                    case ConsoleKey.A:
                        if (map[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;


                }


                if (map[userX, userY] == 'X')
                {
                    map[userX, userY] = 'o';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = 'X';
                    bag = tempBag;

                }
                Console.Clear(); //4:11
            } 
#endif
#if RANGE_BASED_FOR_2
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numbers.Length; i++) { Console.Write(numbers[i] + "\t"); }
            Console.WriteLine("\n");

            foreach (int item in numbers)
            {
                Console.Write(item + "\t");
            } 
#endif
#if FUNCTIONS_3

            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь?");
            WriteError("Нет соединения с интернетом ", ConsoleColor.Green);
            Console.WriteLine("Странно.");
            WriteError("Инет не оплачен ", symbol: '@');

        }

        static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '!')
        {
            ConsoleColor defaltColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(symbol + "_" + text);
            Console.ForegroundColor = defaltColor;
        }
#endif//настройка функции обязательные и необязательные параметры( пример организация ошибок)

#if REF_OUT_4

            int sum, x = 1, y = 2;
            Add(out sum, x, y);
            Console.WriteLine(sum);


        }

        static void Add(out int sum, int x, int y) { sum = x + y; }
        //созданы для возврата более одного значения 

        //ref должно быть и в функции и в вызове и они должны быть инициализированы ОБЯЗАТЕЛЬНО
        //передает ссылку на область памяти где хранится переменная.



        //out можно не инициализировать создает сама люласть памяти и возвращает ссылку  
#endif



            int[] array = new int[10];
            EditArray(array, 3, 5);
            Console.WriteLine(array[2]);

        }
            static void EditArray(int[] array,int index,int value)
            {
                array[index] = value;

            }
            

    }
}
