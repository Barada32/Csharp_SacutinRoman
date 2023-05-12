
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

            float money;
            int years;
            int percent;
            Console.WriteLine("Введите количество денег, внесенных на вклад: ");
            money = Convert.ToSingle(Console.ReadLine());
            Console.Write("На сколько лет открыт вклад: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Под какой процент?");
            percent = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine("Через "+ (i+1) + "году у вас " + money);
                Console.ReadKey();
            }



        }
    }
}
