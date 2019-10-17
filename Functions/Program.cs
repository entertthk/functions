using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            //DRY- do not repeat yourself
            /*
            int a = 5;
            int b = 5;
            int c = a + b;
            Console.WriteLine($"results from main: {c}");
            Sum(a, b);
            Sum(10, 20);
            Hello();
            */

            GreetByName("Marko");

            
            Console.ReadLine();

        }

        public static void Sum(int x, int y)
        {
            Console.WriteLine($"Result: {x + y}");
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        public static void GreetByName(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

    }
}
