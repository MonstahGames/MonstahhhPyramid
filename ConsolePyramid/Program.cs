using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            DoPyramid();
        }
        static void DoPyramid ()
        {
            Console.WriteLine("Welcome to Monstahhh's Pyramid maker.");
            Console.WriteLine("How big do you want your pyramid to be?\nEnter a number.");
            string inputString = Console.ReadLine();
            int input = Convert.ToInt32(inputString);

            if (input > 0)
            {
                for (int i = 0; i <= input; i++)
                {
                    for (int j = 1; j < input - i + 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                    Console.WriteLine();

                }
            } else
            {
                Console.WriteLine("no u");
            }

            TryAgain();
        }
        static void TryAgain ()
        {
            Console.WriteLine("Do you want to enter another number?\n(0 for no or 1 for yes).");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                default:
                    Console.WriteLine("Please enter a value between 0 and 1.");
                    Console.Clear();
                    TryAgain();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Press any key to close this program.");
                    Console.ReadKey();
                    break;
                case 1:
                    Console.Clear();
                    DoPyramid();
                    break;
            }
            Console.ReadKey();
        }
    }
}
