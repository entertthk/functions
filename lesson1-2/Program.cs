using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int counter = 0;

            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    counter++;
                }


            }

            Console.WriteLine($"Total {counter}");
            */

            int counter = 0;
            bool gameOver = false;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (!gameOver)
            {
                Console.WriteLine("Guess a number from 1 to 10");
                int userNumber = int.Parse(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("You won");
                    gameOver = true;
                }

                else
                {
                    Console.WriteLine("try again!");
                    counter++;
                }

                if (counter == 4)
                {
                    Console.WriteLine("You lost");
                }

            }



            Console.ReadLine();

        }
    }
}
