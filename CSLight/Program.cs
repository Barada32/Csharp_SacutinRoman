//#define COLLECTION_LIST_1
//#define QUEUE_1
//#define STACK_1
//#define DICTIONARY_1
#define OOP_1


using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
#if COLLECTION_LIST_1
            List<int> numbers = new List<int>();
            numbers.Add(12);
            numbers.Add(11);
            numbers.Add(13);
            numbers.Add(14);
            numbers.AddRange(new int[] {3,4,5,6});
            numbers.RemoveAt(3);
            numbers.Remove(3);
            numbers.Insert(3, 4);
         
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            } 

            Console.WriteLine("Число 11 находится на позиции "+(1+ numbers.IndexOf(11)));
            numbers.Clear();
#endif

#if QUEUE_1

            Queue<string> patients = new Queue<string>();
            patients.Enqueue("Василий");
            patients.Enqueue("Саша");
            patients.Enqueue("Рома");
            patients.Enqueue("ОЛЕША");

            Console.WriteLine("Сейчас на прием идет " + patients.Dequeue());
            Console.WriteLine("Осталитсь в очереди");
            foreach (var item in patients)
            {
                Console.WriteLine(item);
            }


#endif
#if STACK_1
Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (var i in stack) { Console.WriteLine(stack); }
            

            while (stack.Count > 0) { Console.WriteLine("следующее число в стеке "+stack.Pop()); }
#endif
#if DICTIONARY_1
            //5_52
            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();
            countriesCapitals.Add("Австралия", "Канбера");
            countriesCapitals.Add("Турция", "Анкара");
            countriesCapitals.Add("Швейцария", "Берн");
            foreach(var country in countriesCapitals)
            {
                
                Console.Write($"Cтолица - {country.Value}, ");
                Console.WriteLine($"Страна - " + country.Key);
            }

#endif

#if OOP_1

            Car ford = new Car("Ford", -200, 7, 180);
            Car ferrari = new Car();

            ford.ShowTechPassport();

            ferrari.ShowTechPassport();



#endif

        }
        class Car
        {

            public string Name;
            public int Horsepower;
            public int Age;
            public float MaxSpeed;
            public int Years = 1;


            public Car(string name, int horsepower, int age, float maxSpeed)
            {
                if (horsepower < 0) { Horsepower = 1; }
                else { Horsepower = horsepower; }
                Name = name;
                Age = age;
                MaxSpeed = maxSpeed;

            }
            public Car()
            {
                Name = "Ferrari";
                Horsepower = 500;
                Age = 5;
                MaxSpeed = 300;
            }

            public void ShowTechPassport()
            {
                Console.WriteLine
                ($"Название авто: {Name}\nКоличество лошадиных сил: {Horsepower}" +
                 $"\nВозраст авто: {Age}\nМаксимальная скорость: {MaxSpeed}");


            }
            public void BecomeOlder(int years, int runAwayHorses)
            {
                Age += this.Years + years;
                Horsepower -= runAwayHorses;

            }

            //6_18
        }

    }
}