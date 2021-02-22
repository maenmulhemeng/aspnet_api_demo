using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<string> NameList = new List<string>()
            {
                "Jimmy", "Jeffrey", "John"
            };
        static object TESTModule(object x)
        {
            switch (x)
            {
                case var expression when (x is int) && (int)x < 1:
                    throw new ArgumentException(String.Format("{0} is < 1", x), "x");
                case var expression when ((x is int) && (int)x >= 1 && (int)x <= 4):
                    return (int)x * 2;
                case var expression when ((x is int) && (int)x > 4):
                    return (int)x * 3;
                case var expression when (x is float) && ((float)x == 1.0f || (float)x == 2.0f):
                    return 3.0f;
               
                    
                case var expression when x is string:
                    return x.ToString().ToUpper();
                default:
                    return x;
            }
        }
        static void Main(string[] args)
        {
            int i = 0;

            while ( i < NameList.Count)
            {
                Console.WriteLine(NameList[i++]);
            }

            Console.WriteLine(TESTModule(1.0f));
            Console.WriteLine(TESTModule(2.0f));
            Console.WriteLine(TESTModule(6.0f));

            Console.WriteLine(TESTModule(1));
            Console.WriteLine(TESTModule(2));
            Console.WriteLine(TESTModule(3));
            Console.WriteLine(TESTModule(4));
            Console.WriteLine(TESTModule(8));
            Console.WriteLine(TESTModule("hi"));
            Console.WriteLine(TESTModule(false));
            Console.ReadKey();
        }
    }
}
