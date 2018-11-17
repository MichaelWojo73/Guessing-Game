using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 1000");
            int count = 0;
            Console.WriteLine();

            Random rnd = new Random();
            int rnum = rnd.Next(1, 100);
            bool win = false;

            do
            {


                string input = Console.ReadLine();
                int guess = int.Parse(input);


                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Guess out of range.  Please try again");

                }

                else if (guess > rnum)
                {
                    count++;
                    Console.WriteLine($"Lower!   # of attempts: {count}");


                }
                else if (guess < rnum)
                {
                    count++;
                    Console.WriteLine($"Higher!   # of attempts: {count}");
                }

                else if (guess == rnum)
                {
                    count++;
                    win = true;
                }
                Console.WriteLine();
            }
            while (win == false);

            Console.WriteLine($"Congratulations!! {rnum} is correct!  Total # of attempts {count}");
            Console.WriteLine("");
        }
    }
}
