using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        Random randomgenerator = new Random();
        int magicNumber = randomgenerator.Next(1, 100);

        while (magicNumber != guess)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess == magicNumber)
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Try guess a little higher!");
            }
            else
            {
                Console.WriteLine("Try guess a little lower!");
            }
        }

    }
}