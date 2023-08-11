//#define TABLE_RESERVED_1
//#define TACKER_1
//#define WARRIOR_1_NASLEDOVANIE
//#define INCAPSULATION
#define COLLECTION

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

#if WARRIOR_1_NASLEDOVANIE


			Knight warrior1 = new Knight(200,10,10);
            Barbarian warrior2 = new Barbarian(200,0,10,3);
            warrior1.TakeDamage(100);
            warrior2.TakeDamage(100);

            Console.Write("Рыцарь: ");
            warrior1.showInfo();
            Console.Write("Варвар: ");
            warrior2.showInfo();
            //651
        }
		class Warrior
		{
			protected int Health;
			protected int Armor;
			protected int Damage;
			public void TakeDamage(int damage) { Health -= damage - Armor; }
			public Warrior(int health, int armor, int damage)
			{
				Health = health;
				Armor = armor;
				Damage = damage;

			}
            public void showInfo()
            {
                Console.WriteLine(Health);
            }
		}

		class Knight : Warrior
		{
			public void Prey() { Armor += 2; }

			public Knight(int health, int armor, int damage) : base(health, armor, damage) { }


		}
		class Barbarian : Warrior
		{
            
			public Barbarian(int healt, int armor, int damage, int attackSpeed) : base(healt, armor, damage*attackSpeed) { }
			public void Shout()
			{
				Armor -= 2;
				Health += 10;
			}
		}

#endif

#if INCAPSULATION


			Render renderer = new Render();
			Player player = new Player(55, 10);
			renderer.Draw(player.X, player.Y);






		}
		class Render
		{


			public void Draw(int x, int y, char character = '@')
			{
				Console.CursorVisible = false;
				Console.SetCursorPosition(x, y);
				Console.Write(character);
				Console.ReadKey(true);
			}

		}
		class Player
		{
			private int _x;
			private int _y;
			public Player(int x, int y) { _x = x; _y = y; }
			public int X
			{
				get { return _x; }

				private set
				{ 
                    _x = value; 
                }
			}

            public int Y { get; private set; }
            



			public int getPositionY() { return _y; }
		}

#endif

#if COLLECTION




            Cart cart = new Cart();
            cart.ShowProducts();

		}
		class Cart
		{
			private List<Product> products = new List<Product>();

			public Cart()
			{
				products.Add(new Product("Яблоко"));
				products.Add(new Product("Банан"));
				products.Add(new Product("Апельсин"));
				products.Add(new Product("Груша"));
			}

			public void ShowProducts()
			{
                foreach (var product in products)
                {
                    Console.WriteLine(product.Name);

                }

			}

            //7_04

		}



		class Product
		{
			public string Name { get; private set; }
			public Product(string name)
			{
				Name = name;
			}

		}
#endif
	}
}
