using System;

class Program
{
    static void Main(string[] args)
    {
        string again = "yes";
        while (again == "yes")
        {
            int guess_count = 1;

            Random randomGenerator = new Random();
            int magic_numb = randomGenerator.Next(1, 100);


            int guess = -1;

            while (guess != magic_numb)
            {
                Console.WriteLine("Guess the magic number!");
                Console.Write("What is your guess (between 1-100)? ");
                string guess_set = Console.ReadLine();
                guess = int.Parse(guess_set);

                if (guess > magic_numb)
                {
                    Console.WriteLine("Lower");
                    guess_count = 1 + guess_count;
                }
                else if (guess < magic_numb)
                {
                    Console.WriteLine("Higher");
                    guess_count = 1 + guess_count;
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guess_count} trys!");

                    Console.Write("do you want to paly again? ");
                    again = Console.ReadLine();
                }
            }

        }

        Console.WriteLine("Thanks for playing!");
    }
}