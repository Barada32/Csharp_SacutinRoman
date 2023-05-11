//#define VARIABLES_DESCRIPTION_1
//#define ARIFMETIC_2
//#define CONCATENATE_3
//#define INTERPOLATION_4
//#define COVERTING_STRING_TO_INT_5
//#define COVERTING_INT_TO_FLOAT_5
//#define COVERTING_INT_TO_BOOL_5_3
//#define RUSSIAN_LANGUAGE_6
//#define INCREMENT_DECREMENT
//#define INCREMENT_DECREMENT_7
//#define MINUS_BALANS_DISABLED_8
//#define IF_ELSE_OPERATORS_9
//#define LOGIC_I_ILI_10\
//#define SWITCH_11
#define SWITCH
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

#if VARIABLES_DESCRIPTION_1
            byte b;//0 до 255
            sbyte sb;//-128 до 127
            short s;//-32768 до 32768  Convert.ToInt16
            ushort us;//0 до 65535
            int i;//-2147483648 до 2147483648 Convert.ToInt32
            long l;//0 до 4294672295 Convert.ToInt64
            ulong ul = ulong.MaxValue;
            //Числа с плавающей точкой
            double d;
            float f = 5.7f;
            //Символьнйы тип 
            char c = ' ';
            //Строковый тип
            string str = "ПРивет мир!";
            //Логический тип
            bool bl;
            int age = 27;
            age = 30;
            //переменная отражает суть переменной
            //не использовать понятные только вам сокращения в коде
            //не использовать названия переменных написанные транслитом
            //составные имена сamelCase или waitingTime  
#endif

#if ARIFMETIC_2
            //+-*/%
            //int result = 5 + 10 * 3;
            //Console.WriteLine(result);
            //=!= > < <= >=
            int age = 17;
            bool accesIsAllowed = age >= 18;
            Console.WriteLine(accesIsAllowed); 
#endif

#if CONCATENATE_3
            string greeting = "Привет";
            string name = "Валентин";
            string message = greeting+" омлет " + name;
            Console.WriteLine(message+", рад тебя видеть!");   
#endif

#if INTERPOLATION_4
            int age = 27;
            string name = "Valentin";
            Console.WriteLine("Привет тебе исполнится " + (age + 1));
            Console.WriteLine("Ваше имя " + name + " вам " + age + " лет ");
            Console.WriteLine($"Ваше имя {name} вам {age} лет"); 
#endif

#if COVERTING_STRING_TO_INT_5_1
            int age;
            string input = "15";
            age = Convert.ToInt32(input);
            Console.WriteLine(age); 
#endif
#if COVERTING_INT_TO_FLOAT_5_2
            float result;
            int x = 5, y = 2;
            result = Convert.ToSingle(x) / y;
            Console.WriteLine(result);
#endif

#if COVERTING_INT_TO_BOOL_5_3
            int trigger = 1;
            bool triggerInBoolean = Convert.ToBoolean(trigger);
            Console.WriteLine(triggerInBoolean);
            int reconvert = Convert.ToInt32(triggerInBoolean);
            Console.WriteLine(reconvert); 
#endif

#if RUSSIAN_LANGUAGE_6
            //Console.WriteLine();//ввод с новой строки
            //Console.ReadKey();//ожидание нажатия клавиши
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string name;
            Console.Write( "Введите ваше имя:  ");//ввод сразу после сообщения
            name = Console.ReadLine();
            Console.WriteLine($"Ваше имя: {name}");
            Console.Write("Введите ваш возраст:  ");
            int age  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш возраст: {age} лет!");

#endif

#if INCREMENT_DECREMENT_7
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //int i = 0;
            //Console.WriteLine(i++ + ++i);// у инкремента и декремента  высший приоритет
            float health;
            int armor;
            int damage;
            int precentConverter = 100;
            Console.WriteLine("Введите количкество здоровья: ");
            health = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количкество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количкество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());
            health -= Convert.ToSingle(damage)/ precentConverter * armor ;
            Console.WriteLine($"Вам нанесли{damage} урона.У вас оста" +
                $"лось {health} здоровья.");


#endif

#if MINUS_BALANS_DISABLED_8

            int money;
            int food;
            int foodUnitPrice = 10;

            Console.WriteLine($"Добро пожаловать в пекарню!Сегодня еда по {foodUnitPrice} монет!");
            Console.Write("Сколько у вас золота?");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько еды вам нужно?");
            food = Convert.ToInt32(Console.ReadLine());

            bool isAbleToPay = money >= food * foodUnitPrice;
            food = Convert.ToInt32(isAbleToPay);
            money -= food * foodUnitPrice;
            Console.WriteLine($"У вас в сумке {food} едтниц еды и {money} монет");

#endif

#if IF_ELSE_OPERATORS_9
            int age;
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Добро пожаловать в наш бар!");
                Console.WriteLine("Что будете пить?");

            }
            else
            {
                Console.WriteLine("Вы слишком юны!");
                Console.WriteLine("Приходите к нам через " + (18 - age) + " лет!");
            }
            Console.WriteLine("Новый блок");

            string dayOfWeek;
            Console.Write("Введите день недели: ");
            dayOfWeek = Console.ReadLine();
            if (dayOfWeek == "понедельник") { Console.WriteLine("Проходим курсы!"); }
            else if (dayOfWeek == "вторник") { Console.WriteLine("Делаем домашнее задание.");}
          
#endif

#if LOGIC_I_ILI_10

            //логическое и && | логическое или ||
            // x | y            x | y 
            // 1 | 1 true       1 | 1 true
            // 1 | 0 false      1 | 0 true
            // 0 | 1 false      0 | 1 true
            // 0 | 0 false      0 | 0 false  
#endif

#if SWITCH_11
            string dayOfWeek = Console.ReadLine(); ;

            switch (dayOfWeek)
            {
                case "понедельник":
                case "суббота":
                    Console.WriteLine("идем в кино");
                    break;
                case "вторник":
                    Console.WriteLine("изучаем сыитч");
                    break;
                    default: Console.WriteLine("я такоого дня не знаю");
                    break;
            } 
#endif
            int tiersCount = 5;
            string password = "123456";
            string userInput;
            for (int i = 0; i < tiersCount; i++) 
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();
                if (userInput ==password)
                {
                    Console.WriteLine("Секретики");
                    break;
                }
                else { Console.WriteLine("Введен неверный пароль");
                Console.WriteLine("У вас осталось "+(tiersCount-i-1)+"попыток");}
            }

        }
    }
}
