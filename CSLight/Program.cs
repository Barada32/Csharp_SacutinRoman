//#define HI
//#define INTERPOLATION
//#define ARIFMETIC
//#define VARIABLES_DESCRIPTION
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {

#if VARIABLES_DESCRIPTION
            byte b;//0 до 255
            sbyte sb;//-128 до 127
            short s;//-32768 до 32768
            ushort us;//0 до 65535
            int i;//-2147483648 до 2147483648
            long l;//0 до 4294672295
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

#if ARIFMETIC
            //+-*/%
            //int result = 5 + 10 * 3;
            //Console.WriteLine(result);
            //=!= > < <= >=
            int age = 17;
            bool accesIsAllowed = age >= 18;
            Console.WriteLine(accesIsAllowed); 
#endif

#if HI
            string greeting = "Привет";
            string name = "Валентин";
            string message = greeting+" омлет " + name;
            Console.WriteLine(message+", рад тебя видеть!");   
#endif


#if INTERPOLATION
            int age = 27;
            string name = "Valentin";
            Console.WriteLine("Привет тебе исполнится " + (age + 1));
            Console.WriteLine("Ваше имя " + name + " вам " + age + " лет ");
            Console.WriteLine($"Ваше имя {name} вам {age} лет"); 
#endif



        }
    }
}
