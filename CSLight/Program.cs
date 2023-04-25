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
            //+-*/%
            //int result = 5 + 10 * 3;
            //Console.WriteLine(result);
            //=!= > < <= >=
            int age = 17;
            bool accesIsAllowed = age >= 18;
            Console.WriteLine(accesIsAllowed);
        }
    }
}
