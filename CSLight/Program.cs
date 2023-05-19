
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
            Console.CursorVisible = false;
            char[,] map =
            {
                { '#','#','#','#','#','#','#','#','#','#','#','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#','#','#','#',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#','#','#','#','#','#','#','#','#','#','#','#'}


            };
            int userX = 6; int userY = 6;


            while (true)
            {
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
                        if (map[userX-1,userY]!='#')
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
                        if (map[userX , userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;


                }


                
                Console.Clear();

            }


        }
    }
}
