using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int attempt = 1;
        bool playAgain = true;

        while (playAgain) {

            Console.Write("What is your guess? ");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess != magicNumber) {
                if (guess < 1 | guess > 100) {
                    Console.WriteLine("Invalid guess. Try again");
                    Console.Write("What is your guess? ");
                    guess = Convert.ToInt32(Console.ReadLine());
                } else if (guess > magicNumber) {
                    attempt += 1;
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    guess = Convert.ToInt32(Console.ReadLine());
                } else if (guess < magicNumber) {
                    attempt += 1;
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            };
            if (guess == magicNumber) {
                Console.WriteLine($"You guessed it in {attempt} turns!");
                Console.Write("Play again?");
                string response = Console.ReadLine();
                if (response == "yes" | response == "y" | response == "Yes") {
                    playAgain = true;
                } else {
                    playAgain = false;
                }
            }
        }
    }
}
