//#define ZMEIKA_S_SUMKOI_1
//#define RANGE_BASED_FOR_2
//#define FUNCTIONS_3
//#define REF_OUT_4
//#define DYNAMIC_ARRAY_5
//#define RESIZE_ARRAY_OVERLOADING_6
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


#if DYNAMIC_ARRAY_5

            int[] array = new int[5];
            array = EditArray(array, 9, 5, 10);
            Console.WriteLine(array[9]);

        }
        static int[] EditArray(int[] array, int index, int value, int a)
        {

            array = new int[a];
            array[index] = value;
            return array;

        } 
#endif


#if RESIZE_ARRAY_OVERLOADING_6

            int[] array1 = new int[5];
            int[,] array2 = new int[5, 5];
            array1 = Resize(array1, 6);
            array2 = Resize(array2, 10, 11);
            Console.WriteLine(array1.Length);
            Console.WriteLine(array2.Length);
        }

        static int[] Resize(int[] array, int size)
        {
            int[] tempArray = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];

            }
            array = tempArray;
            return array;
        }
        static int[,] Resize(int[,] array, int x, int y)
        {
            int[,] tempArray = new int[x, y];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                { tempArray[i, j] = array[i, j]; }

            }
            array = tempArray;
            return array;
        }

#endif

            //4:48


    }
}
