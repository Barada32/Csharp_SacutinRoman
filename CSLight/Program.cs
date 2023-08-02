//#define ZMEIKA_S_SUMKOI_1
//#define RANGE_BASED_FOR_2
//#define FUNCTIONS_3
//#define REF_OUT_4
//#define DYNAMIC_ARRAY_5
//#define RESIZE_ARRAY_OVERLOADING_6
//#define HEALTH_MANA_BAR_7
//#define PAC_MAN_8_1
#define PAC_MAN_8_2
#define PAC_MAN_METHODS_8_2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Threading;
using System.Data;

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

#if HEALTH_MANA_BAR_7
            int health = 12, maxHealth = 18;
            int mana = 9, maxMana = 12;
            while (true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Green, 0, '|');
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1);

                Console.SetCursorPosition(0, 5);    
                Console.Write("Введите число на которое измениться жизни:");
                health += Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число на которое измениться маны:");
                mana += Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();
            }

        }
        static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = '_')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }
            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";
            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }
            Console.Write(bar + ']');
        }


#endif
#if PAC_MAN_8_1
            //считывание данных из файла txt
            char[,] map = null;
            string[] file = File.ReadAllLines("map.txt");//"C:\Users\barad\source\repos\Csharp_SacutinRoman\CSLight\obj\Debug\map.txt"
            Console.WriteLine(file[0]);

#endif
#if PAC_MAN_8_2
            Console.CursorVisible = false;
            char[,] map = ReadMap("map.txt");

            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

            int pacmanX = 1;
            int pacmanY = 1;
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                DrawMap(map);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(pacmanX, pacmanY);
                Console.Write("@");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(11, 1);
                Console.Write(pressedKey.KeyChar);
                pressedKey = Console.ReadKey();

                HandleInput(pressedKey, ref pacmanX, ref pacmanY,map);

            }

            //5_08

#endif


        }
#if PAC_MAN_METHODS_8_2
        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");
            char[,] map = new char[GetMaxLengthOfLine(file), file.Length];

            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                { map[x, y] = file[y][x]; }

            }
            return map;
        }

        private static int GetMaxLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;
            foreach (var line in lines)

                if (line.Length > maxLength)
                    maxLength = line.Length;


            return maxLength;
        }
        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.Write("\n");
            }
        }
        private static void HandleInput(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map)
        {
            int[] direction = GetDirection(pressedKey);
            int nextPacmanPositionX= pacmanX + direction[0];
            int nextPacmanPositionY=pacmanY+ direction[1];
            if (map[nextPacmanPositionX,nextPacmanPositionY]==' ')
            {
                pacmanX = nextPacmanPositionX;
                pacmanY = nextPacmanPositionY;
            }
        }
        private static int[] GetDirection(ConsoleKeyInfo pressedKey)
        {

            int[] direction = { 0, 0 };
            if (pressedKey.Key == ConsoleKey.UpArrow) { direction[1] = -1; }
            else if (pressedKey.Key == ConsoleKey.DownArrow) { direction[1] = 1; }
            else if (pressedKey.Key == ConsoleKey.LeftArrow) { direction[0] = -1; }
            else if (pressedKey.Key == ConsoleKey.RightArrow) { direction[0] = 1; }
            return direction;
        }
#endif
    }
}
