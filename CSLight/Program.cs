//#define HI
//#define INTERPOLATION
//#define ARIFMETIC
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
