
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

            bool isOpen = true;

            Table[] tables = { new Table(1, 4), new Table(2, 5), new Table(3, 5) };
            while (isOpen)
            {
                Console.WriteLine("Администрирование кафе\n");
                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();

                }
                Console.Write("\nВведите номер стора: ");
                int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("\nВведите количество мест для брони: ");
                int desiredPlaces = Convert.ToInt32(Console.ReadLine());
                
                bool isReservationCompleted = tables[wishTable].Reserve(desiredPlaces);
                if(isReservationCompleted)
                {
                    Console.WriteLine("бронь прошла успешно ");

                }
                else { Console.WriteLine("Бронь не прошла");}
                Console.ReadKey();
                Console.Clear();
            }


        }
        class Table
        {
            public int Number;
            public int MaxPlaces;
            public int FreePlaces;
            public Table(int number, int maxPlaces)
            {

                Number = number;
                MaxPlaces = maxPlaces;
                FreePlaces = maxPlaces;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"Стол: {Number}.Свободно мест: {FreePlaces} из {MaxPlaces}");
            }
            public bool Reserve(int places)
            {
                if (FreePlaces >= places)
                {

                    FreePlaces -= places;
                    return true;

                }
                else { return false; }

            }

        }
    }
}
