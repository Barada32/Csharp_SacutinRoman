//#define TABLE_RESERVED_1
#define TACKER_1

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
#if TABLE_RESERVED_1
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
                if (isReservationCompleted)
                {
                    Console.WriteLine("бронь прошла успешно ");

                }
                else { Console.WriteLine("Бронь не прошла"); }
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

            } //6_35
#endif

#if TACKER_1



            Performer worker1 = new Performer("Веня");
            Performer worker2 = new Performer("Роман");

            Task[] tasks = { new Task(worker1, "Выкопать яму"), new Task(worker2, "Вывезти грунт") };
            Board shedule = new Board(tasks);
            shedule.ShowAllTasks();



        }

        class Performer 
        {
            public string Name;
            public Performer(string name) { Name = name; }
        }
        class Board
        {
            public Task[] Tasks;

            public Board(Task[] tasks)
            {
                Tasks = tasks;
            }

            public void ShowAllTasks()
            {
                for(int i = 0;i<Tasks.Length;i++)
                {
                    Tasks[i].ShowInfo();
                }

            }
        }
        class Task
        {
            public Performer Worker;
            public string Description;
            public Task(Performer worker, string description) 
            {
                Worker = worker; Description = description;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"Ответственный: {Worker.Name}\nОписание задачи: {Description}.\n ");
            }
        }

        //6_40

#endif
    }
}
