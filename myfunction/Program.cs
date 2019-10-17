using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string color;
            
            Console.WriteLine("Please enter your name and fav color");

            name = Console.ReadLine();
            color = Console.ReadLine();

            KnowMe(name, color);

            Console.ReadLine();

        }

        public static void KnowMe(string name, string color)
        {
            Console.WriteLine($"Hello {name}. Your favourite color is {color}");

        }


    }
}
