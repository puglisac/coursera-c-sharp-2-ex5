using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;

            while(answer != 4)
            {
                
                Console.WriteLine("Menu: \n1-New Game \n2-Load Game \n3-Options \n4-Quit");
                try
                {
                    answer = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    answer = 0;
                }
                if(answer < 1 || answer > 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input");
                    answer = 3;
                }
                if(answer == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Starting New Game");
                }
                if(answer == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Loading Game");
                }
                if(answer == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please select from the menu below");
                }
                Console.WriteLine();
            }
        }
    }
}
