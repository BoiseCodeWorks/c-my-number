using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int MIN = 1;
            const int MAX = 100;
            var guessing = true;
            var rand = new Random();
            int myRandNum = rand.Next(MIN, MAX);

            Console.WriteLine($"Can you guess my number???? It's somewhere between {MIN} - {MAX}");
            Console.WriteLine(myRandNum);
            while (guessing)
            {
                var guessInput = Console.ReadLine();

                int guess;
                int.TryParse(guessInput, out guess);

                if (guess == myRandNum)
                {
                    Console.WriteLine("I BOW TO YOU");
                    guessing = false;
                    return;
                }
                else if (guess < myRandNum)
                {
                    Console.WriteLine("A BIT TO LOW");
                }
                else if (guess > myRandNum)
                {
                    Console.WriteLine("TO HIGH");
                }
                Console.WriteLine("Nope Guess Again");
            }


        }
    }
}
